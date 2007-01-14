// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using nMars.IDE.Debugger.Controls;
using nMars.IDE.Debugger.Forms;
using nMars.IDE.Forms;
using nMars.RedCode;

namespace nMars.IDE.Debugger
{
    public class IDEDebuggerApplication : nMars.Debugger.Debugger, IIDEPlugin
    {
        #region Construction

        public IDEDebuggerApplication()
        {
            Instance = this;
        }

        public void Load()
        {
            MainForm = IDEApplication.MainForm;
            DebuggerMainForm = new DebuggerMainForm(MainForm, this);
            IDEApplication.Console.CommandEntered += new ConsoleCommandEntered(ConsoleCommandEntered);
        }

        public void Unload()
        {
            if (Engine != null && Engine.IsLive)
            {
                Engine.Kill();
            }
            IDEApplication.Console.CommandEntered -= new ConsoleCommandEntered(ConsoleCommandEntered);
        }

        #endregion

        #region UI

        public void RefreshControls()
        {
            bool warrior = IDEApplication.ActiveProject!=null && IDEApplication.ActiveProject.WarriorsCount > 0;
            bool live = Engine != null && Engine.IsLive;
            bool canRun = (!live || Engine.IsPaused) && warrior;
            DebuggerMainForm.runSlowToolStripMenuItem.Enabled = canRun || (live && Brake != slowRunBrake);
            DebuggerMainForm.runSlowToolStripButton.Enabled = canRun || (live && Brake != slowRunBrake);
            DebuggerMainForm.runNormalToolStripButton.Enabled = canRun || (live && Brake != normalRunBrake);
            DebuggerMainForm.runFastToolStripButton.Enabled = canRun || (live && Brake != fastRunBrake);
            DebuggerMainForm.executeToolStripButton.Enabled = warrior;

            DebuggerMainForm.stopToolStripMenuItem.Enabled = live;
            DebuggerMainForm.stopToolStripButton.Enabled = live;

            bool step = live && Engine.IsPaused && warrior;
            bool stepOrStart = step || ((Engine == null || !Engine.IsLive) && warrior);
            DebuggerMainForm.stepAnyToolStripMenuItem.Enabled = stepOrStart;
            DebuggerMainForm.stepAnyToolStripButton.Enabled = stepOrStart;
            DebuggerMainForm.stepThreadToolStripMenuItem.Enabled = step;
            DebuggerMainForm.stepThreadToolStripButton.Enabled = step;
            DebuggerMainForm.stepRoundToolStripButton.Enabled = step;
            DebuggerMainForm.stepBackToolStripButton.Enabled = step;

            bool pause = live && !Engine.IsPaused;
            DebuggerMainForm.pauseToolStripButton.Enabled = pause;
            DebuggerMainForm.pauseToolStripMenuItem.Enabled = live;
            if (live)
            {
                if (pause)
                {
                    DebuggerMainForm.pauseToolStripMenuItem.Text = "Pause";
                }
                else
                {
                    DebuggerMainForm.pauseToolStripMenuItem.Text = "Resume";
                }
            }
        }

        #endregion

        #region Operating


        /// <summary>
        /// Redirection thru MainForm
        /// </summary>
        delegate void boolDelegate(bool logical);
        protected override void onEngineStoppedAsync(bool finished)
        {
            MainForm.Invoke(new boolDelegate(OnEngineStopped), finished);
        }

        protected override void OnEngineStopped(bool finished)
        {
            if (finished)
            {
                EndWatch();
                IDEApplication.ActiveProject.Project.EngineOptions.Brake = executeBrake;
            }
            else
            {
                PauseWatch();
            }
            base.OnEngineStopped(finished);
            IDEApplication.RefreshControls();
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
            IDEApplication.ActiveProject.Project.EngineOptions.Brake = brake;
            Run();
        }

        public void Run()
        {
            if (IDEApplication.ActiveProject.Documents.Count == 0)
                return;

            Project = IDEApplication.ActiveProject.Project;
            Components = IDEApplication.ActiveSolution.Components;
            Start(false);
            IDEApplication.RefreshControls();
        }

        public override bool Step()
        {
            if (Engine == null || !Engine.IsLive)
            {
                IDEApplication.ActiveProject.Project.EngineOptions.Brake = slowRunBrake;
                Project = IDEApplication.ActiveProject.Project;
                Components = IDEApplication.ActiveSolution.Components;
                Start(true);
                IDEApplication.RefreshControls();
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
                IDEApplication.RefreshControls();
            }
            return res;
        }

        public override bool Continue()
        {
            bool res = base.Continue();
            if (res)
            {
                ResumeWatch();
                IDEApplication.RefreshControls();
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
            DebuggerMainForm.timerDebugWatch.Enabled = true;
        }

        public void PauseWatch()
        {
            DebuggerMainForm.timerDebugWatch.Enabled = false;
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
            DebuggerMainForm.timerDebugWatch.Enabled = true;
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
            DebuggerMainForm.timerDebugWatch.Enabled = false;
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
            //TODO breakpoints + cell values, 
            // dialog and tabs ?
        }

        #endregion

        #region Variables 

        public DebugOverview DebugOverview;
        public DebugMemoryListing DebugMemoryListing;
        public DebugMemoryGraph DebugMemoryGraph;
        public DebuggerMainForm DebuggerMainForm;
        public MainForm MainForm;

        public static IDEDebuggerApplication Instance;

        #endregion
    }
}
