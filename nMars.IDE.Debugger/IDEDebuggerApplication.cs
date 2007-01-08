// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using nMars.IDE.Debugger.Controls;
using nMars.IDE.Debugger.Forms;
using nMars.IDE.Forms;
using nMars.RedCode;
using nMars.RedCode.Modules;

namespace nMars.IDE.Debugger
{
    public class IDEDebuggerApplication : nMars.Debugger.Debugger, IIDEPlugin
    {
        public IDEDebuggerApplication()
            : base(IDEApplication.Console.GetAsyncWrapper())
        {
            Instance = this;
        }

        public void Load()
        {
            MainForm = IDEApplication.MainForm;
            DebuggerMainForm = new DebuggerMainForm(MainForm, this);
        }

        public void Unload()
        {
            if (ActiveEngine !=null && ActiveEngine.IsLive)
            {
                ActiveEngine.Kill();
            }
        }

        #region UI

        public void RefreshControls()
        {
            bool live = ActiveEngine != null && ActiveEngine.IsLive;
            bool canRun = !live || ActiveEngine.IsPaused;
            DebuggerMainForm.runSlowToolStripMenuItem.Enabled = canRun || Brake != slowRunBrake;
            DebuggerMainForm.runSlowToolStripButton.Enabled = canRun || Brake != slowRunBrake;
            DebuggerMainForm.runNormalToolStripButton.Enabled = canRun || Brake != normalRunBrake;
            DebuggerMainForm.runFastToolStripButton.Enabled = canRun || Brake != fastRunBrake;

            DebuggerMainForm.stopToolStripMenuItem.Enabled = live;
            DebuggerMainForm.stopToolStripButton.Enabled = live;

            bool step = live && ActiveEngine.IsPaused;
            DebuggerMainForm.stepAnyToolStripMenuItem.Enabled = step;
            DebuggerMainForm.stepAnyToolStripButton.Enabled = step;
            DebuggerMainForm.stepThreadToolStripMenuItem.Enabled = step;
            DebuggerMainForm.stepThreadToolStripButton.Enabled = step;
            DebuggerMainForm.stepRoundToolStripButton.Enabled = step;
            DebuggerMainForm.stepBackToolStripButton.Enabled = step;

            bool pause = live && !ActiveEngine.IsPaused;
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

        #region Overrides

        public void Run(int brake)
        {
            IDEApplication.ActiveProject.Project.EngineOptions.Brake = brake;
            Run();
        }

        public void Run()
        {
            Run(IDEApplication.ActiveProject.Project, IDEApplication.ActiveSolution.Components, EngineStopped);
            IDEApplication.RefreshControls();
        }

        public override bool Run(Project project, ComponentLoader components, EngineStoppedCallback engineStopped)
        {
            if (IDEApplication.ActiveSolution.ActiveProject.Documents.Count == 0)
                return false;

            return  base.Run(project, components, engineStopped);
        }

        protected override void RunContinueImpl(bool start)
        {
            if (start)
            {
                BeginWatch();
            }
            else
            {
                ResumeWatch();
            }
            ActiveEngine.Continue();
        }

        protected override bool engineStopped(bool finished)
        {
            bool res = base.Continue();
            if (res)
            {
                if (finished)
                {
                    EndWatch();
                    IDEApplication.ActiveSolution.ActiveProject.Project.EngineOptions.Brake = executeBrake;
                }
                else
                {
                    PauseWatch();
                }
                IDEApplication.RefreshControls();
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


        public override bool Step()
        {
            bool res = base.Step();
            if (res)
            {
                WatchTick();
            }
            return res;
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

        private delegate bool boolDelegate(bool logical);

        public void EngineStopped(bool finished)
        {
            MainForm.Invoke(new boolDelegate(engineStopped), finished);
        }


        #endregion

        #region Watch Core

        private void BeginWatch()
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
            DebuggerMainForm.timerDebugWatch.Enabled = true;
        }

        public void PauseWatch()
        {
            DebuggerMainForm.timerDebugWatch.Enabled = false;
            DebugOverview.Pause();
            DebugMemoryListing.Pause();
            DebugMemoryGraph.Pause();
            //WatchTick();
        }

        public void ResumeWatch()
        {
            DebugOverview.Resume();
            DebugMemoryListing.Resume();
            DebugMemoryGraph.Resume();
            DebuggerMainForm.timerDebugWatch.Enabled = true;
        }

        public void WatchTick()
        {
            if (ActiveEngine == null)
                return;

            lock (ActiveEngine)
            {
                DebugOverview.RepaintView();
                DebugMemoryListing.RepaintView();
                DebugMemoryGraph.RepaintView();
                ActiveEngine.UiTickDone();
            }
        }

        private void EndWatch()
        {
            DebuggerMainForm.timerDebugWatch.Enabled = false;
            DebugOverview.Detach();
            DebugMemoryListing.Detach();
            DebugMemoryGraph.Detach();
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

        public  DebugOverview DebugOverview;
        public  DebugMemoryListing DebugMemoryListing;
        public  DebugMemoryGraph DebugMemoryGraph;
        public  DebuggerMainForm DebuggerMainForm;
        public  MainForm MainForm;

        public static IDEDebuggerApplication Instance;
    }
}
