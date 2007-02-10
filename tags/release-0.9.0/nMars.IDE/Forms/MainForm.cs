// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.IO;
using System.Windows.Forms;
using nMars.IDE.Core;
using nMars.IDE.Properties;

namespace nMars.IDE.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Icon = Resources.IDEsmall;
            IDEApplication = IDEApplication.Instance;
        }

        private IDEApplication IDEApplication;

        public void RefreshRecent()
        {
            recentProjectsToolStripMenuItem.DropDownItems.Clear();
            foreach (string project in IDEApplication.Settings.RecentProjects)
            {
                ToolStripMenuItem it = new ToolStripMenuItem(Path.GetFileNameWithoutExtension(project));
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
                if (IDEApplication.Editors.Count == 0)
                {
                    return;
                }
                lastCycledEditor++;
                if (lastCycledEditor >= IDEApplication.Editors.Count)
                    lastCycledEditor = 0;
                IDEApplication.ActiveEditor = IDEApplication.Editors[lastCycledEditor];
                IDEApplication.ActiveEditor.ActivateControl();
            }
            else
            {
                if (lastCycledEditor != -1)
                {
                    IDEApplication.Editors.Remove(IDEApplication.ActiveEditor);
                    IDEApplication.Editors.Insert(0, IDEApplication.ActiveEditor);
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
            IDEApplication.AddNewProject();
        }

        private void addNewWarriorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDEApplication.AddNewWarrior(IDEApplication.ActiveProject);
        }

        private void saveAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDEApplication.SaveAll();
        }

        private void openExistingWarriorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDEApplication.OpenExistingWarrior();
        }

        private void openExistingSolutionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDEApplication.OpenSolution();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!IDEApplication.ClosingApplication())
            {
                e.Cancel = true;
            }
        }

        private void it_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem it = sender as ToolStripMenuItem;
            IDEApplication.OpenSolution(it.Tag as string);
        }

        private void addExistingWarriorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDEApplication.AddExistingWarrior(IDEApplication.ActiveProject);
        }

        private void closeSolutionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDEApplication.CloseSolution();
        }

        private void saveWarriorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDEApplication.SaveDocument(IDEApplication.ActiveEditor.Document);
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            IDEApplication.SaveDocument(IDEApplication.ActiveEditor.Document);
        }

        private void closeWarriorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDEApplication.CloseDocument(IDEApplication.ActiveEditor.Document);
        }

        private void addWarriorIntoProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDEApplication.AddIntoProject(IDEApplication.ActiveEditor.Document as ProjectDocument);
        }

        private void removeWarriorFromProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDEApplication.RemoveFromProject(IDEApplication.ActiveEditor.Document as ProjectDocument);
        }

        private void compileWarriorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IDEApplication.ActiveEditor != null)
            {
                IDEApplication.Compile(IDEApplication.ActiveEditor.Document as WarriorDocument);
            }
        }

        private void compileProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDEApplication.Compile(IDEApplication.ActiveProject);
        }

        private void lbDocClose_Click(object sender, EventArgs e)
        {
            IDEApplication.CloseDocument(IDEApplication.ActiveEditor.Document);
        }

        private void checkForUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDEApplication.CheckNewVersion(false);
        }

        #endregion

        #region Debugger Events

        private void runSlowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDEApplication.Run(IDEApplication.slowRunBrake);
        }

        private void runSlowToolStripButton_Click(object sender, EventArgs e)
        {
            IDEApplication.Run(IDEApplication.slowRunBrake);
        }

        private void runFastToolStripButton_Click(object sender, EventArgs e)
        {
            IDEApplication.Run(IDEApplication.fastRunBrake);
        }

        private void runFastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDEApplication.Run(IDEApplication.fastRunBrake);
        }

        private void runNormalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDEApplication.Run(IDEApplication.normalRunBrake);
        }

        private void runNormalToolStripButton_Click(object sender, EventArgs e)
        {
            IDEApplication.Run(IDEApplication.normalRunBrake);
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDEApplication.Run();
        }

        private void executeToolStripButton_Click(object sender, EventArgs e)
        {
            IDEApplication.Run(IDEApplication.executeBrake);
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDEApplication.Stop();
        }

        private void stopToolStripButton_Click(object sender, EventArgs e)
        {
            IDEApplication.Stop();
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IDEApplication.Engine.IsPaused)
            {
                IDEApplication.Pause();
            }
            else
            {
                IDEApplication.Continue();
            }
        }

        private void pauseToolStripButton_Click(object sender, EventArgs e)
        {
            IDEApplication.Pause();
        }

        private void stepRoundToolStripButton_Click(object sender, EventArgs e)
        {
            IDEApplication.StepThread();
        }

        private void stepThreadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDEApplication.StepThread();
        }

        private void stepWarriorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDEApplication.StepWarrior();
        }

        private void stepAnyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDEApplication.Step();
        }

        private void stepAnyToolStripButton_Click(object sender, EventArgs e)
        {
            IDEApplication.Step();
        }

        private void stepBackToolStripButton_Click(object sender, EventArgs e)
        {
            IDEApplication.Back();
        }

        private void timerDebugWatch_Tick(object sender, EventArgs e)
        {
            IDEApplication.WatchTick();
        }

        #endregion

    }
}