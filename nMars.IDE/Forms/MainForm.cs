using System;
using System.IO;
using System.Windows.Forms;
using nMars.IDE.Core;

namespace nMars.IDE.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Icon = nMars.IDE.Properties.Resources.IDEsmall;
        }

        public void RefreshUI()
        {
            //TODO
            bool openEditor = Application.ActiveEditor != null;
            bool openWarrior = openEditor && Application.ActiveEditor.Document is WarriorDocument;
            saveWarriorToolStripMenuItem.Enabled = openWarrior;
            compileWarriorToolStripMenuItem.Enabled = openWarrior;
            closeWarriorToolStripMenuItem.Enabled = openWarrior;
            lbDocClose.Visible = openEditor;
            
            bool pending = Application.ActiveEditor != null;
            compileWarriorToolStripMenuItem.Enabled = !pending;

            bool live = Application.ActiveEngine != null && Application.ActiveEngine.IsLive;
            bool canRun = !live || Application.ActiveEngine.IsPaused;
            runSlowToolStripMenuItem.Enabled = canRun || Application.ActiveBrake != Application.slowRunBrake;
            runSlowToolStripButton.Enabled = canRun || Application.ActiveBrake != Application.slowRunBrake;
            runNormalToolStripButton.Enabled = canRun || Application.ActiveBrake != Application.normalRunBrake;
            runFastToolStripButton.Enabled = canRun || Application.ActiveBrake != Application.fastRunBrake;

            stopToolStripMenuItem.Enabled = live;
            stopToolStripButton.Enabled = live;

            bool step = live && Application.ActiveEngine.IsPaused;
            stepAnyToolStripMenuItem.Enabled = step;
            stepAnyToolStripButton.Enabled = step;
            stepThreadToolStripMenuItem.Enabled = step;
            stepThreadToolStripButton.Enabled = step;
            stepThreadToolStripButton.Enabled = step;
            stepBackToolStripButton.Enabled = step;

            bool pause = live && !Application.ActiveEngine.IsPaused;
            pauseToolStripMenuItem.Enabled = pause;
            pauseToolStripButton.Enabled = pause;
        }

        public void RefreshRecent()
        {
            recentProjectsToolStripMenuItem.DropDownItems.Clear();
            foreach (string project in Application.Settings.RecentProjects)
            {
                ToolStripMenuItem it=new ToolStripMenuItem(Path.GetFileNameWithoutExtension(project));
                it.Tag = project;
                it.ToolTipText = project;
                it.Click += new EventHandler(it_Click);
                recentProjectsToolStripMenuItem.DropDownItems.Add(it);
            }
        }


        #region Cycle documents

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            const int WM_KEYDOWN = 0x100;
            const int WM_SYSKEYDOWN = 0x104;
            //const int WM_KEYUP = 0x101;
            //const int WM_SYSKEYUP = 0x105;
            if ((msg.Msg == WM_KEYDOWN) || (msg.Msg == WM_SYSKEYDOWN))
            {
                if (keyData == (Keys.Tab | Keys.Control))
                {
                    CycleDocuments(false);
                    cycleDocuments = true;
                    return true;
                }
            }
            if (cycleDocuments)
            {
                CycleDocuments(true);
                cycleDocuments = false;
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        //TODO not yet perfect
        public void CycleDocuments(bool finish)
        {
            if (!finish)
            {
                if (Application.Editors.Count == 0)
                {
                    return;
                }
                lastCycledEditor++;
                if (lastCycledEditor >= Application.Editors.Count)
                    lastCycledEditor = 0;
                Application.ActiveEditor = Application.Editors[lastCycledEditor];
                Application.ActiveEditor.ActivateControl();
            }
            else
            {
                if (lastCycledEditor != -1)
                {
                    Application.Editors.Remove(Application.ActiveEditor);
                    Application.Editors.Insert(0, Application.ActiveEditor);
                    lastCycledEditor = 0;
                }
            }
        }

        private bool cycleDocuments = false;
        private static int lastCycledEditor = 0;

        #endregion

        #region Events

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutDialog about = new AboutDialog();
            about.ShowDialog();
        }

        private void addNewProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.AddNewProject();
        }

        private void addNewWarriorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.AddNewWarrior(Application.ActiveSolution.ActiveProject);
        }

        private void saveAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.SaveAll();
        }

        private void openExistingWarriorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.OpenExistingWarrior();
        }

        private void openExistingSolutionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.OpenSolution();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Application.ClosingApplication())
            {
                e.Cancel = true;
            }
        }

        void it_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem it = sender as ToolStripMenuItem;
            Application.OpenSolution(it.Tag as string);
        }

        private void addExistingWarriorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.AddExistingWarrior(Application.ActiveSolution.ActiveProject);
        }

        private void closeSolutionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.CloseSolution();
        }

        private void saveWarriorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.SaveDocument(Application.ActiveEditor.Document);
        }

        private void closeWarriorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.CloseDocument(Application.ActiveEditor.Document);
        }

        private void addWarriorIntoProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.AddIntoProject(Application.ActiveEditor.Document as ProjectDocument);
        }

        private void removeWarriorFromProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.RemoveFromProject(Application.ActiveEditor.Document as ProjectDocument);
        }

        private void compileWarriorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.ActiveEditor != null)
            {
                Application.Compile(Application.ActiveEditor.Document as WarriorDocument);
            }
        }

        private void compileProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Compile(Application.ActiveSolution.ActiveProject);
        }

        private void lbDocClose_Click(object sender, EventArgs e)
        {
            Application.CloseDocument(Application.ActiveEditor.Document);
        }

        private void runSlowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Run(Application.ActiveSolution.ActiveProject, Application.slowRunBrake);
        }

        private void runSlowToolStripButton_Click(object sender, EventArgs e)
        {
            Application.Run(Application.ActiveSolution.ActiveProject, Application.slowRunBrake);
        }

        private void runFastToolStripButton_Click(object sender, EventArgs e)
        {
            Application.Run(Application.ActiveSolution.ActiveProject, Application.fastRunBrake);
        }

        private void runFastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Run(Application.ActiveSolution.ActiveProject, Application.fastRunBrake);
        }

        private void runNormalToolStripButton_Click(object sender, EventArgs e)
        {
            Application.Run(Application.ActiveSolution.ActiveProject, Application.normalRunBrake);
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Stop();
        }

        private void stopToolStripButton_Click(object sender, EventArgs e)
        {
            Application.Stop();
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Pause();
        }

        private void pauseToolStripButton_Click(object sender, EventArgs e)
        {
            Application.Pause();
        }

        private void stepAnyToolStripButton_Click(object sender, EventArgs e)
        {
            Application.Step();
        }

        private void stepBackToolStripButton_Click(object sender, EventArgs e)
        {
            Application.Back();
        }

        #endregion

        private void timerDebugWatch_Tick(object sender, EventArgs e)
        {
            Application.WatchTick();
        }
    }
}