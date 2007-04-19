// This file is part of nMars - Core War MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using nMars.IDE.Controls;
using nMars.IDE.Forms;
using nMars.RedCode;

namespace nMars.IDE
{
    public partial class IDEApplication : nMars.Debugger.Debugger
    {
        #region Construction

        public void LoadDebugger()
        {
            ConsoleControl.CommandEntered += new ConsoleCommandEntered(ConsoleCommandEntered);
        }

        public void UnloadDebugger()
        {
            if (Engine != null && Engine.IsLive)
            {
                Engine.Kill();
            }
            ConsoleControl.CommandEntered -= new ConsoleCommandEntered(ConsoleCommandEntered);
        }

        #endregion

        #region UI

        public void RefreshControlsDebugger()
        {
            bool warrior = ActiveProject!=null && ActiveProject.Project.WarriorFiles.Count > 0;
            bool live = Engine != null && Engine.IsLive;
            bool canRun = (!live || Engine.IsPaused) && warrior;
            MainForm.runSlowToolStripMenuItem.Enabled = canRun || (live && Brake != slowRunBrake);
            MainForm.runSlowToolStripButton.Enabled = canRun || (live && Brake != slowRunBrake);
            MainForm.runNormalToolStripButton.Enabled = canRun || (live && Brake != normalRunBrake);
            MainForm.runFastToolStripButton.Enabled = canRun || (live && Brake != fastRunBrake);
            MainForm.executeToolStripButton.Enabled = warrior;

            MainForm.stopToolStripMenuItem.Enabled = live;
            MainForm.stopToolStripButton.Enabled = live;

            bool step = live && Engine.IsPaused && warrior;
            bool stepOrStart = step || ((Engine == null || !Engine.IsLive) && warrior);
            MainForm.stepAnyToolStripMenuItem.Enabled = stepOrStart;
            MainForm.stepAnyToolStripButton.Enabled = stepOrStart;
            MainForm.stepThreadToolStripMenuItem.Enabled = step;
            MainForm.stepThreadToolStripButton.Enabled = step;
            MainForm.stepRoundToolStripButton.Enabled = step;
            MainForm.stepBackToolStripButton.Enabled = step;

            bool pause = live && !Engine.IsPaused;
            MainForm.pauseToolStripButton.Enabled = pause;
            MainForm.pauseToolStripMenuItem.Enabled = live;
            if (live)
            {
                if (pause)
                {
                    MainForm.pauseToolStripMenuItem.Text = "Pause";
                }
                else
                {
                    MainForm.pauseToolStripMenuItem.Text = "Resume";
                }
            }
        }

        #endregion

        #region Operating


        /// <summary>
        /// Redirection thru MainForm
        /// </summary>
        protected override void onEngineStoppedAsync(bool finished, BreakPoint breakPoint, string reason)
        {
            MainForm.Invoke(new EngineStoppedCallback(OnEngineStopped), finished, breakPoint, reason);
        }

        protected override void OnEngineStopped(bool finished, BreakPoint breakpoint, string reason)
        {
            if (finished)
            {
                EndWatch();
                ActiveProject.Project.EngineOptions.Brake = executeBrake;
            }
            else
            {
                PauseWatch();
            }
            base.OnEngineStopped(finished, breakpoint, reason);
            RefreshControls();
        }

        protected override void OnAfterStartEngine(bool justContinue, bool onlyInit)
        {
            if (justContinue)
            {
                ResumeWatch();
            }
            else
            {
                BeginWatch();
                if (onlyInit)
                    PauseWatch();
            }
            base.OnAfterStartEngine(justContinue, onlyInit);
        }

        public void Run(int brake)
        {
            ActiveProject.Project.EngineOptions.Brake = brake;
            Run();
        }

        public void Run()
        {
            if (ActiveProject.Documents.Count == 0)
                return;

            Project = ActiveProject.Project;
            Components = ActiveSolution.Components;
            SaveAll();
            Start(false);
            RefreshControls();
        }

        public override bool Step()
        {
            if (Engine == null || !Engine.IsLive)
            {
                ActiveProject.Project.EngineOptions.Brake = slowRunBrake;
                Project = ActiveProject.Project;
                Components = ActiveSolution.Components;
                SaveAll();
                Start(true);
                RefreshControls();
                return true;
            }
            else
            {
                bool res = base.Step();
                if (res)
                {
                    WatchTick();
                }
                return res;
            }
        }

        public override bool Back()
        {
            bool res = base.Back();
            if (res)
            {
                WatchTick();
            }
            return res;
        }


        public override bool Pause()
        {
            bool res = base.Pause();
            if (res)
            {
                RefreshControls();
            }
            return res;
        }

        public override bool Continue()
        {
            bool res = base.Continue();
            if (res)
            {
                ResumeWatch();
                RefreshControls();
            }
            return res;
        }

        #endregion

        #region Watch Core

        private void BeginWatch()
        {
            lock (Engine)
            {
                DebugOverview = new DebugOverview();
                DebugOverview.Attach(MainForm.tabBottom, "Debug Overview");
                DebugMemoryListing = new DebugMemoryListing();
                DebugMemoryListing.Attach(MainForm.tabExplorers, "Memory Listing");
                DebugMemoryGraph = new DebugMemoryGraph();
                DebugMemoryGraph.Attach(MainForm.tabDocuments, "Memory Graph");

                DebugOverview.ActivateControl();
                DebugMemoryListing.ActivateControl();
                DebugMemoryGraph.ActivateControl();
            }
            MainForm.timerDebugWatch.Enabled = true;
        }

        public void PauseWatch()
        {
            MainForm.timerDebugWatch.Enabled = false;
            lock (Engine)
            {
                DebugOverview.Pause();
                DebugMemoryListing.Pause();
                DebugMemoryGraph.Pause();
            }
        }

        public void ResumeWatch()
        {
            lock (Engine)
            {
                DebugOverview.Resume();
                DebugMemoryListing.Resume();
                DebugMemoryGraph.Resume();
            }
            MainForm.timerDebugWatch.Enabled = true;
        }

        public void WatchTick()
        {
            if (Engine == null)
                return;

            lock (Engine)
            {
                DebugOverview.RepaintView();
                DebugMemoryListing.RepaintView();
                DebugMemoryGraph.RepaintView();
                Engine.UiTickDone();
            }
        }

        private void EndWatch()
        {
            MainForm.timerDebugWatch.Enabled = false;
            lock (Engine)
            {
                DebugOverview.Detach();
                DebugMemoryListing.Detach();
                DebugMemoryGraph.Detach();
            }
        }


        public void ShowAddress(int address)
        {
            DebugMemoryListing.ShowAddress(address);
        }

        public void EditCell(int address)
        {
            bool wasRunning = !Engine.IsPaused;
            if (wasRunning)
            {
                Pause();
            }
            CellDetailDialog editor=new CellDetailDialog();
            editor.Address = address;
            editor.Engine = Engine;
            editor.Project = Project;
            editor.ShowDialog();
            if (wasRunning)
            {
                Continue();
            }
        }

        #endregion

        #region Variables 

        public DebugOverview DebugOverview;
        public DebugMemoryListing DebugMemoryListing;
        public DebugMemoryGraph DebugMemoryGraph;


        #endregion
    }
}
