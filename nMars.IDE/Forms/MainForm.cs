using System;
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
            saveWarriorToolStripMenuItem.Enabled = Application.ActiveEditor != null &&
                                                   Application.ActiveEditor.Document is WarriorDocument;
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

        private void addExistingWarriorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.AddExistingWarrior(Application.ActiveSolution.ActiveProject);
        }

        private void closeSolutionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.CloseSolution();
        }

        private void newWarriorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.OpenNewWarrior();
        }

        private void loadWarriorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.OpenExistingWarrior();
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
            Application.Compile(Application.ActiveEditor.Document as WarriorDocument);
        }

        private void compileProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Compile(Application.ActiveSolution.ActiveProject);
        }

        #endregion
    }
}