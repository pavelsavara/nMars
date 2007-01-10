namespace nMars.IDE.Controls
{
    partial class SolutionExplorer
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tree = new System.Windows.Forms.TreeView();
            this.contextMenuSolution = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addExisingProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSolutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuProject = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewWarriorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addExistingWarriorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setAsActiveProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuWarrior = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.compileWarriorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeWarriorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteWarriorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activateWarriorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deactivateWarriorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuSolution.SuspendLayout();
            this.contextMenuProject.SuspendLayout();
            this.contextMenuWarrior.SuspendLayout();
            this.SuspendLayout();
            // 
            // tree
            // 
            this.tree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tree.Location = new System.Drawing.Point(0, 0);
            this.tree.Name = "tree";
            this.tree.Size = new System.Drawing.Size(252, 600);
            this.tree.TabIndex = 0;
            this.tree.DoubleClick += new System.EventHandler(this.tree_DoubleClick);
            this.tree.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tree_MouseUp);
            // 
            // contextMenuSolution
            // 
            this.contextMenuSolution.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewProjectToolStripMenuItem,
            this.addExisingProjectToolStripMenuItem,
            this.saveSolutionToolStripMenuItem});
            this.contextMenuSolution.Name = "contextMenuSolution";
            this.contextMenuSolution.Size = new System.Drawing.Size(178, 70);
            // 
            // addNewProjectToolStripMenuItem
            // 
            this.addNewProjectToolStripMenuItem.Name = "addNewProjectToolStripMenuItem";
            this.addNewProjectToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.addNewProjectToolStripMenuItem.Text = "Add new Project";
            this.addNewProjectToolStripMenuItem.Click += new System.EventHandler(this.addNewProjectToolStripMenuItem_Click);
            // 
            // addExisingProjectToolStripMenuItem
            // 
            this.addExisingProjectToolStripMenuItem.Name = "addExisingProjectToolStripMenuItem";
            this.addExisingProjectToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.addExisingProjectToolStripMenuItem.Text = "Add exising Project";
            this.addExisingProjectToolStripMenuItem.Click += new System.EventHandler(this.addExisingProjectToolStripMenuItem_Click);
            // 
            // saveSolutionToolStripMenuItem
            // 
            this.saveSolutionToolStripMenuItem.Name = "saveSolutionToolStripMenuItem";
            this.saveSolutionToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.saveSolutionToolStripMenuItem.Text = "Save Solution";
            this.saveSolutionToolStripMenuItem.Click += new System.EventHandler(this.saveSolutionToolStripMenuItem_Click);
            // 
            // contextMenuProject
            // 
            this.contextMenuProject.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewWarriorToolStripMenuItem,
            this.addExistingWarriorToolStripMenuItem,
            this.removeProjectToolStripMenuItem,
            this.deleteProjectToolStripMenuItem,
            this.saveProjectToolStripMenuItem,
            this.setAsActiveProjectToolStripMenuItem,
            this.editProjectToolStripMenuItem});
            this.contextMenuProject.Name = "contextMenuProject";
            this.contextMenuProject.Size = new System.Drawing.Size(186, 180);
            // 
            // addNewWarriorToolStripMenuItem
            // 
            this.addNewWarriorToolStripMenuItem.Name = "addNewWarriorToolStripMenuItem";
            this.addNewWarriorToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.addNewWarriorToolStripMenuItem.Text = "Add new Warrior";
            this.addNewWarriorToolStripMenuItem.Click += new System.EventHandler(this.addNewWarriorToolStripMenuItem_Click);
            // 
            // addExistingWarriorToolStripMenuItem
            // 
            this.addExistingWarriorToolStripMenuItem.Name = "addExistingWarriorToolStripMenuItem";
            this.addExistingWarriorToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.addExistingWarriorToolStripMenuItem.Text = "Add existing Warrior";
            this.addExistingWarriorToolStripMenuItem.Click += new System.EventHandler(this.addExistingWarriorToolStripMenuItem_Click);
            // 
            // removeProjectToolStripMenuItem
            // 
            this.removeProjectToolStripMenuItem.Name = "removeProjectToolStripMenuItem";
            this.removeProjectToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.removeProjectToolStripMenuItem.Text = "Remove Project";
            this.removeProjectToolStripMenuItem.Click += new System.EventHandler(this.removeProjectToolStripMenuItem_Click);
            // 
            // deleteProjectToolStripMenuItem
            // 
            this.deleteProjectToolStripMenuItem.Name = "deleteProjectToolStripMenuItem";
            this.deleteProjectToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.deleteProjectToolStripMenuItem.Text = "Delete Project";
            this.deleteProjectToolStripMenuItem.Click += new System.EventHandler(this.deleteProjectToolStripMenuItem_Click);
            // 
            // saveProjectToolStripMenuItem
            // 
            this.saveProjectToolStripMenuItem.Name = "saveProjectToolStripMenuItem";
            this.saveProjectToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.saveProjectToolStripMenuItem.Text = "Save Project";
            this.saveProjectToolStripMenuItem.Click += new System.EventHandler(this.saveProjectToolStripMenuItem_Click);
            // 
            // setAsActiveProjectToolStripMenuItem
            // 
            this.setAsActiveProjectToolStripMenuItem.Name = "setAsActiveProjectToolStripMenuItem";
            this.setAsActiveProjectToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.setAsActiveProjectToolStripMenuItem.Text = "Set as Active project";
            this.setAsActiveProjectToolStripMenuItem.Click += new System.EventHandler(this.setAsActiveProjectToolStripMenuItem_Click);
            // 
            // contextMenuWarrior
            // 
            this.contextMenuWarrior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compileWarriorToolStripMenuItem,
            this.removeWarriorToolStripMenuItem,
            this.deleteWarriorToolStripMenuItem,
            this.activateWarriorToolStripMenuItem,
            this.deactivateWarriorToolStripMenuItem});
            this.contextMenuWarrior.Name = "contextMenuWarrior";
            this.contextMenuWarrior.Size = new System.Drawing.Size(177, 114);
            // 
            // compileWarriorToolStripMenuItem
            // 
            this.compileWarriorToolStripMenuItem.Name = "compileWarriorToolStripMenuItem";
            this.compileWarriorToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.compileWarriorToolStripMenuItem.Text = "Compile Warrior";
            this.compileWarriorToolStripMenuItem.Click += new System.EventHandler(this.compileWarriorToolStripMenuItem_Click);
            // 
            // removeWarriorToolStripMenuItem
            // 
            this.removeWarriorToolStripMenuItem.Name = "removeWarriorToolStripMenuItem";
            this.removeWarriorToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.removeWarriorToolStripMenuItem.Text = "Remove Warrior";
            this.removeWarriorToolStripMenuItem.Click += new System.EventHandler(this.removeWarriorToolStripMenuItem_Click);
            // 
            // deleteWarriorToolStripMenuItem
            // 
            this.deleteWarriorToolStripMenuItem.Name = "deleteWarriorToolStripMenuItem";
            this.deleteWarriorToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.deleteWarriorToolStripMenuItem.Text = "Delete Warrior";
            this.deleteWarriorToolStripMenuItem.Click += new System.EventHandler(this.deleteWarriorToolStripMenuItem_Click);
            // 
            // activateWarriorToolStripMenuItem
            // 
            this.activateWarriorToolStripMenuItem.Name = "activateWarriorToolStripMenuItem";
            this.activateWarriorToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.activateWarriorToolStripMenuItem.Text = "Activate Warrior";
            this.activateWarriorToolStripMenuItem.Click += new System.EventHandler(this.activateWarriorToolStripMenuItem_Click);
            // 
            // deactivateWarriorToolStripMenuItem
            // 
            this.deactivateWarriorToolStripMenuItem.Name = "deactivateWarriorToolStripMenuItem";
            this.deactivateWarriorToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.deactivateWarriorToolStripMenuItem.Text = "Deactivate Warrior";
            this.deactivateWarriorToolStripMenuItem.Click += new System.EventHandler(this.deactivateWarriorToolStripMenuItem_Click);
            // 
            // editProjectToolStripMenuItem
            // 
            this.editProjectToolStripMenuItem.Name = "editProjectToolStripMenuItem";
            this.editProjectToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.editProjectToolStripMenuItem.Text = "Edit Project";
            this.editProjectToolStripMenuItem.Click += new System.EventHandler(this.editProjectToolStripMenuItem_Click);
            // 
            // SolutionExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.tree);
            this.Name = "SolutionExplorer";
            this.Size = new System.Drawing.Size(252, 600);
            this.contextMenuSolution.ResumeLayout(false);
            this.contextMenuProject.ResumeLayout(false);
            this.contextMenuWarrior.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tree;
        private System.Windows.Forms.ContextMenuStrip contextMenuSolution;
        private System.Windows.Forms.ContextMenuStrip contextMenuProject;
        private System.Windows.Forms.ContextMenuStrip contextMenuWarrior;
        private System.Windows.Forms.ToolStripMenuItem addNewProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewWarriorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addExistingWarriorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compileWarriorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeWarriorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteWarriorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addExisingProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSolutionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setAsActiveProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activateWarriorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deactivateWarriorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editProjectToolStripMenuItem;


    }
}
