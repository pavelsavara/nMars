// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using nMars.IDE.Core;

namespace nMars.IDE.Controls
{
    public partial class SolutionExplorer : IDEFrame
    {
        public SolutionExplorer()
        {
            InitializeComponent();
        }

        public void ReloadSolution()
        {
            tree.BeginUpdate();
            tree.Nodes.Clear();
            TreeNode root = new TreeNode(Application.ActiveSolution.Name);
            root.Tag = Application.ActiveSolution;
            foreach (KeyValuePair<string, RedCodeProject> project in Application.ActiveSolution.Projects)
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
                    if (project.Value == Application.ActiveSolution.ActiveProject)
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
                        war.ToolTipText = document.Key;
                    }
                }
                proj.ToolTipText = project.Key;
                root.Nodes.Add(proj);
            }
            tree.Nodes.Add(root);
            tree.ExpandAll();
            tree.EndUpdate();
        }

        #region Project events

        private void addNewProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.AddNewProject();
        }

        private void addExisingProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.AddExistingProject();
        }

        private void deleteProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.RemoveProject(clickedNode.Tag as RedCodeProject, true);
        }

        private void removeProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.RemoveProject(clickedNode.Tag as RedCodeProject, false);
        }

        private void saveProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.SaveProject(clickedNode.Tag as RedCodeProject);
        }

        private void setAsActiveProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.SetProjectActive(clickedNode.Tag as RedCodeProject);
        }

        #endregion

        #region Warrior events

        private void addExistingWarriorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.AddExistingWarrior(clickedNode.Tag as RedCodeProject);
        }

        private void addNewWarriorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.AddNewWarrior(clickedNode.Tag as RedCodeProject);
        }

        private void removeWarriorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WarriorDocument warrior = clickedNode.Tag as WarriorDocument;
            Application.RemoveWarrior(warrior, false);
        }

        private void deleteWarriorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WarriorDocument warrior = clickedNode.Tag as WarriorDocument;
            Application.RemoveWarrior(warrior, true);
        }

        private void compileWarriorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO
        }

        #endregion

        #region Solution events

        private void saveSolutionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.SaveSolution();
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
                    Application.ActivateDocument(clickedNode.Tag as ProjectDocument);
                }
            }
        }

        private TreeNode clickedNode;

        #endregion
    }
}