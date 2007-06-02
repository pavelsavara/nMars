// This file is part of nMars - Core War MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using nMars.IDE.Core;
using nMars.RedCode.Utils;

namespace nMars.IDE.Controls
{
    public partial class SolutionExplorer : IDEFrame
    {
        public SolutionExplorer()
        {
            InitializeComponent();
            IDEApplication = IDEApplication.Instance;
        }

        private IDEApplication IDEApplication;

        public void ReloadSolution()
        {
            tree.BeginUpdate();
            tree.Nodes.Clear();
            TreeNode root = new TreeNode(IDEApplication.ActiveSolution.Name);
            root.Tag = IDEApplication.ActiveSolution;
            foreach (KeyValuePair<string, RedCodeProject> project in IDEApplication.ActiveSolution.Projects)
            {
                TreeNode proj;
                if (project.Value == null)
                {
                    proj = new TreeNode(project.Key);
                }
                else
                {
                    proj = new TreeNode(project.Value.Name);
                    proj.Tag = project.Value;
                    if (project.Value == IDEApplication.ActiveProject)
                    {
                        proj.NodeFont = new Font(tree.Font, FontStyle.Bold);
                    }
                    foreach (KeyValuePair<string, ProjectDocument> document in project.Value.Documents)
                    {
                        TreeNode war;
                        if (document.Value == null)
                        {
                            war = new TreeNode(document.Key);
                        }
                        else
                        {
                            war = new TreeNode(document.Value.Name);
                            war.Tag = document.Value;
                        }
                        proj.Nodes.Add(war);
                        if (!MonoCheck.IsMonoRuntime)
                        {
                            InitializeNonMono(war, document.Key);
                        }
                    }
                }
                if (!MonoCheck.IsMonoRuntime)
                {
                    InitializeNonMono(proj, project.Key);
                }
                root.Nodes.Add(proj);
            }
            tree.Nodes.Add(root);
            tree.ExpandAll();
            tree.EndUpdate();
        }

        private static void InitializeNonMono(TreeNode node, string text)
        {
#if !MONO
            node.ToolTipText = text;
#endif
        }

        #region Project events

        private void addNewProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDEApplication.AddNewProject();
        }

        private void addExisingProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDEApplication.AddExistingProject();
        }

        private void deleteProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDEApplication.RemoveProject(clickedNode.Tag as RedCodeProject, true);
        }

        private void removeProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDEApplication.RemoveProject(clickedNode.Tag as RedCodeProject, false);
        }

        private void saveProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDEApplication.SaveProject(clickedNode.Tag as RedCodeProject);
        }

        private void setAsActiveProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDEApplication.SetProjectActive(clickedNode.Tag as RedCodeProject);
        }

        private void editProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDEApplication.ActivateDocument(clickedNode.Tag as RedCodeProject);
        }

        #endregion

        #region Warrior events

        private void addExistingWarriorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDEApplication.AddExistingWarrior(clickedNode.Tag as RedCodeProject);
        }

        private void addNewWarriorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDEApplication.AddNewWarrior(clickedNode.Tag as RedCodeProject);
        }

        private void removeWarriorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WarriorDocument warrior = clickedNode.Tag as WarriorDocument;
            IDEApplication.RemoveWarrior(warrior, false);
        }

        private void deleteWarriorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WarriorDocument warrior = clickedNode.Tag as WarriorDocument;
            IDEApplication.RemoveWarrior(warrior, true);
        }

        private void activateWarriorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WarriorDocument warrior = clickedNode.Tag as WarriorDocument;
            warrior.Project.Activate(warrior);
        }

        private void deactivateWarriorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WarriorDocument warrior = clickedNode.Tag as WarriorDocument;
            warrior.Project.Deactivate(warrior);
        }

        private void compileWarriorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WarriorDocument warrior = clickedNode.Tag as WarriorDocument;
            IDEApplication.Compile(warrior);
        }

        #endregion

        #region Solution events

        private void saveSolutionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDEApplication.SaveSolution();
        }

        #endregion

        #region Events

        private void tree_MouseUp(object sender, MouseEventArgs e)
        {
            // Point where the mouse is clicked.
            Point p = new Point(e.X, e.Y);

            // Get the node that the user has clicked.
            clickedNode = tree.GetNodeAt(p);
            if (clickedNode != null)
            {
                if (e.Button == MouseButtons.Right)
                {
                    // Find the appropriate ContextMenu depending on the selected node.
                    if (clickedNode.Tag is RedCodeSolution)
                    {
                        contextMenuSolution.Show(tree, p);
                    }
                    if (clickedNode.Tag is RedCodeProject)
                    {
                        contextMenuProject.Show(tree, p);
                    }
                    if (clickedNode.Tag is WarriorDocument)
                    {
                        contextMenuWarrior.Show(tree, p);
                    }
                }
            }
        }

        private void tree_DoubleClick(object sender, EventArgs e)
        {
            if (clickedNode != null)
            {
                if (clickedNode.Tag is ProjectDocument)
                {
                    IDEApplication.ActivateDocument(clickedNode.Tag as ProjectDocument);
                }
                if (clickedNode.Tag is RedCodeProject)
                {
                    IDEApplication.ActivateDocument(clickedNode.Tag as RedCodeProject);
                }
            }
        }

        private TreeNode clickedNode;

        #endregion


    }
}