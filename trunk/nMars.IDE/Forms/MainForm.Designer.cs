// This file is part of nMars - Core War MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.Windows.Forms;

namespace nMars.IDE.Forms
{
    partial class MainForm
    {

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openExistingWarriorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openExistingSolutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewWarriorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addExistingWarriorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addWarriorIntoProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeWarriorFromProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveWarriorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeWarriorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeSolutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recentProjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compileWarriorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compileProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runFastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runNormalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runSlowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stepAnyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stepWarriorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stepThreadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusbar = new System.Windows.Forms.StatusStrip();
            this.toolbar = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.executeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.runFastToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.runNormalToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.runSlowToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.stepRoundToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.stepThreadToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.stepAnyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pauseToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.stepBackToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.stopToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            this.fileToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.splitContainerOuter = new System.Windows.Forms.SplitContainer();
            this.splitContainerInner = new System.Windows.Forms.SplitContainer();
            this.lbDocClose = new System.Windows.Forms.Label();
            this.tabDocuments = new nMars.IDE.Controls.IDEPanel();
            this.tabBottom = new nMars.IDE.Controls.IDEPanel();
            this.tabExplorers = new nMars.IDE.Controls.IDEPanel();
            this.timerDebugWatch = new System.Windows.Forms.Timer(this.components);
            this.saveAllToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.mainMenu.SuspendLayout();
            this.toolbar.SuspendLayout();
            this.splitContainerOuter.Panel1.SuspendLayout();
            this.splitContainerOuter.Panel2.SuspendLayout();
            this.splitContainerOuter.SuspendLayout();
            this.splitContainerInner.Panel1.SuspendLayout();
            this.splitContainerInner.Panel2.SuspendLayout();
            this.splitContainerInner.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.compileToolStripMenuItem,
            this.debugToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mainMenu.Size = new System.Drawing.Size(807, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.addToolStripMenuItem,
            this.addWarriorIntoProjectToolStripMenuItem,
            this.removeWarriorFromProjectToolStripMenuItem,
            this.saveWarriorToolStripMenuItem,
            this.closeWarriorToolStripMenuItem,
            this.saveAllToolStripMenuItem,
            this.closeSolutionToolStripMenuItem,
            this.recentProjectsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openExistingWarriorToolStripMenuItem,
            this.openExistingSolutionToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // openExistingWarriorToolStripMenuItem
            // 
            this.openExistingWarriorToolStripMenuItem.Name = "openExistingWarriorToolStripMenuItem";
            this.openExistingWarriorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openExistingWarriorToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.openExistingWarriorToolStripMenuItem.Text = "Open existing Warrior";
            this.openExistingWarriorToolStripMenuItem.Click += new System.EventHandler(this.openExistingWarriorToolStripMenuItem_Click);
            // 
            // openExistingSolutionToolStripMenuItem
            // 
            this.openExistingSolutionToolStripMenuItem.Name = "openExistingSolutionToolStripMenuItem";
            this.openExistingSolutionToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.openExistingSolutionToolStripMenuItem.Text = "Open existing Solution";
            this.openExistingSolutionToolStripMenuItem.Click += new System.EventHandler(this.openExistingSolutionToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewProjectToolStripMenuItem,
            this.addNewWarriorToolStripMenuItem,
            this.addExistingWarriorToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // addNewProjectToolStripMenuItem
            // 
            this.addNewProjectToolStripMenuItem.Name = "addNewProjectToolStripMenuItem";
            this.addNewProjectToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.addNewProjectToolStripMenuItem.Text = "Add new Project";
            this.addNewProjectToolStripMenuItem.Click += new System.EventHandler(this.addNewProjectToolStripMenuItem_Click);
            // 
            // addNewWarriorToolStripMenuItem
            // 
            this.addNewWarriorToolStripMenuItem.Name = "addNewWarriorToolStripMenuItem";
            this.addNewWarriorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.addNewWarriorToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.addNewWarriorToolStripMenuItem.Text = "Add new Warrior";
            this.addNewWarriorToolStripMenuItem.Click += new System.EventHandler(this.addNewWarriorToolStripMenuItem_Click);
            // 
            // addExistingWarriorToolStripMenuItem
            // 
            this.addExistingWarriorToolStripMenuItem.Name = "addExistingWarriorToolStripMenuItem";
            this.addExistingWarriorToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.addExistingWarriorToolStripMenuItem.Text = "Add existing Warrior";
            this.addExistingWarriorToolStripMenuItem.Click += new System.EventHandler(this.addExistingWarriorToolStripMenuItem_Click);
            // 
            // addWarriorIntoProjectToolStripMenuItem
            // 
            this.addWarriorIntoProjectToolStripMenuItem.Name = "addWarriorIntoProjectToolStripMenuItem";
            this.addWarriorIntoProjectToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.addWarriorIntoProjectToolStripMenuItem.Text = "Add file into Project";
            this.addWarriorIntoProjectToolStripMenuItem.Click += new System.EventHandler(this.addWarriorIntoProjectToolStripMenuItem_Click);
            // 
            // removeWarriorFromProjectToolStripMenuItem
            // 
            this.removeWarriorFromProjectToolStripMenuItem.Name = "removeWarriorFromProjectToolStripMenuItem";
            this.removeWarriorFromProjectToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.removeWarriorFromProjectToolStripMenuItem.Text = "Remove file from Project";
            this.removeWarriorFromProjectToolStripMenuItem.Click += new System.EventHandler(this.removeWarriorFromProjectToolStripMenuItem_Click);
            // 
            // saveWarriorToolStripMenuItem
            // 
            this.saveWarriorToolStripMenuItem.Name = "saveWarriorToolStripMenuItem";
            this.saveWarriorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveWarriorToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.saveWarriorToolStripMenuItem.Text = "Save file";
            this.saveWarriorToolStripMenuItem.Click += new System.EventHandler(this.saveWarriorToolStripMenuItem_Click);
            // 
            // closeWarriorToolStripMenuItem
            // 
            this.closeWarriorToolStripMenuItem.Name = "closeWarriorToolStripMenuItem";
            this.closeWarriorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.closeWarriorToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.closeWarriorToolStripMenuItem.Text = "Close file";
            this.closeWarriorToolStripMenuItem.Click += new System.EventHandler(this.closeWarriorToolStripMenuItem_Click);
            // 
            // saveAllToolStripMenuItem
            // 
            this.saveAllToolStripMenuItem.Name = "saveAllToolStripMenuItem";
            this.saveAllToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.saveAllToolStripMenuItem.Text = "Save All";
            this.saveAllToolStripMenuItem.Click += new System.EventHandler(this.saveAllToolStripMenuItem_Click);
            // 
            // closeSolutionToolStripMenuItem
            // 
            this.closeSolutionToolStripMenuItem.Name = "closeSolutionToolStripMenuItem";
            this.closeSolutionToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.closeSolutionToolStripMenuItem.Text = "Close Solution";
            this.closeSolutionToolStripMenuItem.Click += new System.EventHandler(this.closeSolutionToolStripMenuItem_Click);
            // 
            // recentProjectsToolStripMenuItem
            // 
            this.recentProjectsToolStripMenuItem.Name = "recentProjectsToolStripMenuItem";
            this.recentProjectsToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.recentProjectsToolStripMenuItem.Text = "Recent Solutions";
            // 
            // compileToolStripMenuItem
            // 
            this.compileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compileWarriorToolStripMenuItem,
            this.compileProjectToolStripMenuItem});
            this.compileToolStripMenuItem.Name = "compileToolStripMenuItem";
            this.compileToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.compileToolStripMenuItem.Text = "Compile";
            // 
            // compileWarriorToolStripMenuItem
            // 
            this.compileWarriorToolStripMenuItem.Name = "compileWarriorToolStripMenuItem";
            this.compileWarriorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F7)));
            this.compileWarriorToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.compileWarriorToolStripMenuItem.Text = "Compile Warrior";
            this.compileWarriorToolStripMenuItem.Click += new System.EventHandler(this.compileWarriorToolStripMenuItem_Click);
            // 
            // compileProjectToolStripMenuItem
            // 
            this.compileProjectToolStripMenuItem.Name = "compileProjectToolStripMenuItem";
            this.compileProjectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.B)));
            this.compileProjectToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.compileProjectToolStripMenuItem.Text = "Compile Project";
            this.compileProjectToolStripMenuItem.Click += new System.EventHandler(this.compileProjectToolStripMenuItem_Click);
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runFastToolStripMenuItem,
            this.runNormalToolStripMenuItem,
            this.runSlowToolStripMenuItem,
            this.runToolStripMenuItem,
            this.stepAnyToolStripMenuItem,
            this.stepWarriorToolStripMenuItem,
            this.stepThreadToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // runFastToolStripMenuItem
            // 
            this.runFastToolStripMenuItem.Name = "runFastToolStripMenuItem";
            this.runFastToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.runFastToolStripMenuItem.Text = "Run Fast";
            this.runFastToolStripMenuItem.Click += new System.EventHandler(this.runFastToolStripMenuItem_Click);
            // 
            // runNormalToolStripMenuItem
            // 
            this.runNormalToolStripMenuItem.Name = "runNormalToolStripMenuItem";
            this.runNormalToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.runNormalToolStripMenuItem.Text = "Run Normal";
            this.runNormalToolStripMenuItem.Click += new System.EventHandler(this.runNormalToolStripMenuItem_Click);
            // 
            // runSlowToolStripMenuItem
            // 
            this.runSlowToolStripMenuItem.Name = "runSlowToolStripMenuItem";
            this.runSlowToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.runSlowToolStripMenuItem.Text = "Run Slow";
            this.runSlowToolStripMenuItem.Click += new System.EventHandler(this.runSlowToolStripMenuItem_Click);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.runToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.runToolStripMenuItem.Text = "Run";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // stepAnyToolStripMenuItem
            // 
            this.stepAnyToolStripMenuItem.Name = "stepAnyToolStripMenuItem";
            this.stepAnyToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.stepAnyToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.stepAnyToolStripMenuItem.Text = "Step Any";
            this.stepAnyToolStripMenuItem.Click += new System.EventHandler(this.stepAnyToolStripMenuItem_Click);
            // 
            // stepWarriorToolStripMenuItem
            // 
            this.stepWarriorToolStripMenuItem.Name = "stepWarriorToolStripMenuItem";
            this.stepWarriorToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.stepWarriorToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.stepWarriorToolStripMenuItem.Text = "Step Warrior";
            this.stepWarriorToolStripMenuItem.Click += new System.EventHandler(this.stepWarriorToolStripMenuItem_Click);
            // 
            // stepThreadToolStripMenuItem
            // 
            this.stepThreadToolStripMenuItem.Name = "stepThreadToolStripMenuItem";
            this.stepThreadToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.stepThreadToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.stepThreadToolStripMenuItem.Text = "Step Thread";
            this.stepThreadToolStripMenuItem.Click += new System.EventHandler(this.stepThreadToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Space)));
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F5)));
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.checkForUpdateToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // checkForUpdateToolStripMenuItem
            // 
            this.checkForUpdateToolStripMenuItem.Name = "checkForUpdateToolStripMenuItem";
            this.checkForUpdateToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.checkForUpdateToolStripMenuItem.Text = "Check for Update";
            this.checkForUpdateToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdateToolStripMenuItem_Click);
            // 
            // statusbar
            // 
            this.statusbar.Location = new System.Drawing.Point(0, 406);
            this.statusbar.Name = "statusbar";
            this.statusbar.Size = new System.Drawing.Size(807, 22);
            this.statusbar.TabIndex = 2;
            this.statusbar.Text = "statusStrip1";
            // 
            // toolbar
            // 
            this.toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAllToolStripButton,
            this.saveToolStripButton,
            this.executeToolStripButton,
            this.runFastToolStripButton,
            this.runNormalToolStripButton,
            this.runSlowToolStripButton,
            this.stepRoundToolStripButton,
            this.stepThreadToolStripButton,
            this.stepAnyToolStripButton,
            this.pauseToolStripButton,
            this.stepBackToolStripButton,
            this.stopToolStripButton});
            this.toolbar.Location = new System.Drawing.Point(0, 24);
            this.toolbar.Name = "toolbar";
            this.toolbar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolbar.Size = new System.Drawing.Size(807, 25);
            this.toolbar.TabIndex = 3;
            this.toolbar.Text = "toolStrip1";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = global::nMars.IDE.Properties.Resources.Save;
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // executeToolStripButton
            // 
            this.executeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.executeToolStripButton.Image = global::nMars.IDE.Properties.Resources.Execute;
            this.executeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.executeToolStripButton.Name = "executeToolStripButton";
            this.executeToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.executeToolStripButton.Text = "Execute without Debuger";
            this.executeToolStripButton.Click += new System.EventHandler(this.executeToolStripButton_Click);
            // 
            // runFastToolStripButton
            // 
            this.runFastToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.runFastToolStripButton.Image = global::nMars.IDE.Properties.Resources.RunFF;
            this.runFastToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.runFastToolStripButton.Name = "runFastToolStripButton";
            this.runFastToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.runFastToolStripButton.Text = "Run Fast";
            this.runFastToolStripButton.Click += new System.EventHandler(this.runFastToolStripButton_Click);
            // 
            // runNormalToolStripButton
            // 
            this.runNormalToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.runNormalToolStripButton.Image = global::nMars.IDE.Properties.Resources.RunF;
            this.runNormalToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.runNormalToolStripButton.Name = "runNormalToolStripButton";
            this.runNormalToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.runNormalToolStripButton.Text = "Run";
            this.runNormalToolStripButton.Click += new System.EventHandler(this.runNormalToolStripButton_Click);
            // 
            // runSlowToolStripButton
            // 
            this.runSlowToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.runSlowToolStripButton.Image = global::nMars.IDE.Properties.Resources.Run;
            this.runSlowToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.runSlowToolStripButton.Name = "runSlowToolStripButton";
            this.runSlowToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.runSlowToolStripButton.Text = "Run Slow";
            this.runSlowToolStripButton.Click += new System.EventHandler(this.runSlowToolStripButton_Click);
            // 
            // stepRoundToolStripButton
            // 
            this.stepRoundToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stepRoundToolStripButton.Image = global::nMars.IDE.Properties.Resources.StepRound;
            this.stepRoundToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stepRoundToolStripButton.Name = "stepRoundToolStripButton";
            this.stepRoundToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.stepRoundToolStripButton.Text = "Step Round";
            this.stepRoundToolStripButton.Visible = false;
            this.stepRoundToolStripButton.Click += new System.EventHandler(this.stepRoundToolStripButton_Click);
            // 
            // stepThreadToolStripButton
            // 
            this.stepThreadToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stepThreadToolStripButton.Image = global::nMars.IDE.Properties.Resources.StepThread;
            this.stepThreadToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stepThreadToolStripButton.Name = "stepThreadToolStripButton";
            this.stepThreadToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.stepThreadToolStripButton.Text = "Step Thread";
            this.stepThreadToolStripButton.Visible = false;
            // 
            // stepAnyToolStripButton
            // 
            this.stepAnyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stepAnyToolStripButton.Image = global::nMars.IDE.Properties.Resources.Step;
            this.stepAnyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stepAnyToolStripButton.Name = "stepAnyToolStripButton";
            this.stepAnyToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.stepAnyToolStripButton.Text = "Step";
            this.stepAnyToolStripButton.Click += new System.EventHandler(this.stepAnyToolStripButton_Click);
            // 
            // pauseToolStripButton
            // 
            this.pauseToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pauseToolStripButton.Image = global::nMars.IDE.Properties.Resources.Pause;
            this.pauseToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pauseToolStripButton.Name = "pauseToolStripButton";
            this.pauseToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.pauseToolStripButton.Text = "Pause";
            this.pauseToolStripButton.Click += new System.EventHandler(this.pauseToolStripButton_Click);
            // 
            // stepBackToolStripButton
            // 
            this.stepBackToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stepBackToolStripButton.Image = global::nMars.IDE.Properties.Resources.Back;
            this.stepBackToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stepBackToolStripButton.Name = "stepBackToolStripButton";
            this.stepBackToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.stepBackToolStripButton.Text = "Step Back";
            this.stepBackToolStripButton.Click += new System.EventHandler(this.stepBackToolStripButton_Click);
            // 
            // stopToolStripButton
            // 
            this.stopToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stopToolStripButton.Image = global::nMars.IDE.Properties.Resources.Stop;
            this.stopToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stopToolStripButton.Name = "stopToolStripButton";
            this.stopToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.stopToolStripButton.Text = "Stop";
            this.stopToolStripButton.Click += new System.EventHandler(this.stopToolStripButton_Click);
            // 
            // splitContainerOuter
            // 
            this.splitContainerOuter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerOuter.Location = new System.Drawing.Point(0, 49);
            this.splitContainerOuter.Name = "splitContainerOuter";
            // 
            // splitContainerOuter.Panel1
            // 
            this.splitContainerOuter.Panel1.Controls.Add(this.splitContainerInner);
            // 
            // splitContainerOuter.Panel2
            // 
            this.splitContainerOuter.Panel2.Controls.Add(this.tabExplorers);
            this.splitContainerOuter.Size = new System.Drawing.Size(807, 357);
            this.splitContainerOuter.SplitterDistance = 622;
            this.splitContainerOuter.TabIndex = 7;
            // 
            // splitContainerInner
            // 
            this.splitContainerInner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerInner.Location = new System.Drawing.Point(0, 0);
            this.splitContainerInner.Name = "splitContainerInner";
            this.splitContainerInner.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerInner.Panel1
            // 
            this.splitContainerInner.Panel1.Controls.Add(this.lbDocClose);
            this.splitContainerInner.Panel1.Controls.Add(this.tabDocuments);
            // 
            // splitContainerInner.Panel2
            // 
            this.splitContainerInner.Panel2.Controls.Add(this.tabBottom);
            this.splitContainerInner.Size = new System.Drawing.Size(622, 357);
            this.splitContainerInner.SplitterDistance = 269;
            this.splitContainerInner.TabIndex = 0;
            // 
            // lbDocClose
            // 
            this.lbDocClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDocClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbDocClose.Location = new System.Drawing.Point(604, 4);
            this.lbDocClose.Name = "lbDocClose";
            this.lbDocClose.Size = new System.Drawing.Size(15, 13);
            this.lbDocClose.TabIndex = 1;
            this.lbDocClose.Text = "X";
            this.lbDocClose.Click += new System.EventHandler(this.lbDocClose_Click);
            // 
            // tabDocuments
            // 
            this.tabDocuments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDocuments.Location = new System.Drawing.Point(0, 0);
            this.tabDocuments.Name = "tabDocuments";
            this.tabDocuments.SelectedIndex = 0;
            this.tabDocuments.Size = new System.Drawing.Size(622, 269);
            this.tabDocuments.TabIndex = 0;
            // 
            // tabBottom
            // 
            this.tabBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabBottom.Location = new System.Drawing.Point(0, 0);
            this.tabBottom.Name = "tabBottom";
            this.tabBottom.SelectedIndex = 0;
            this.tabBottom.Size = new System.Drawing.Size(622, 84);
            this.tabBottom.TabIndex = 0;
            // 
            // tabExplorers
            // 
            this.tabExplorers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabExplorers.Location = new System.Drawing.Point(0, 0);
            this.tabExplorers.Name = "tabExplorers";
            this.tabExplorers.SelectedIndex = 0;
            this.tabExplorers.Size = new System.Drawing.Size(181, 357);
            this.tabExplorers.TabIndex = 0;
            // 
            // timerDebugWatch
            // 
            this.timerDebugWatch.Interval = 150;
            this.timerDebugWatch.Tick += new System.EventHandler(this.timerDebugWatch_Tick);
            // 
            // saveAllToolStripButton
            // 
            this.saveAllToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveAllToolStripButton.Image = global::nMars.IDE.Properties.Resources.SaveAll;
            this.saveAllToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveAllToolStripButton.Name = "saveAllToolStripButton";
            this.saveAllToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveAllToolStripButton.Text = "Save All";
            this.saveAllToolStripButton.Click += new System.EventHandler(this.saveAllToolStripButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 428);
            this.Controls.Add(this.splitContainerOuter);
            this.Controls.Add(this.toolbar);
            this.Controls.Add(this.statusbar);
            this.Controls.Add(this.mainMenu);
            this.Name = "MainForm";
            this.Text = "nMars - Core War MARS for .NET ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.toolbar.ResumeLayout(false);
            this.toolbar.PerformLayout();
            this.splitContainerOuter.Panel1.ResumeLayout(false);
            this.splitContainerOuter.Panel2.ResumeLayout(false);
            this.splitContainerOuter.ResumeLayout(false);
            this.splitContainerInner.Panel1.ResumeLayout(false);
            this.splitContainerInner.Panel2.ResumeLayout(false);
            this.splitContainerInner.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.SaveFileDialog saveDialog;
        public System.Windows.Forms.OpenFileDialog openDialog;
        public IDE.Controls.IDEPanel tabExplorers;
        public IDE.Controls.IDEPanel tabDocuments;
        public IDE.Controls.IDEPanel tabBottom;
        public System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        public System.Windows.Forms.StatusStrip statusbar;
        public System.Windows.Forms.ToolStrip toolbar;
        public System.Windows.Forms.ToolStripMenuItem saveWarriorToolStripMenuItem;
        public System.Windows.Forms.ToolTip fileToolTip;
        public System.Windows.Forms.SplitContainer splitContainerOuter;
        public System.Windows.Forms.SplitContainer splitContainerInner;
        public System.Windows.Forms.ToolStripMenuItem closeWarriorToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem addNewProjectToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem addNewWarriorToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem openExistingWarriorToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem saveAllToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem compileToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem compileWarriorToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem openExistingSolutionToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem addExistingWarriorToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem closeSolutionToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem addWarriorIntoProjectToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem removeWarriorFromProjectToolStripMenuItem;
        public System.Windows.Forms.MenuStrip mainMenu;
        public System.Windows.Forms.ToolStripMenuItem compileProjectToolStripMenuItem;
        public System.Windows.Forms.Label lbDocClose;
        public System.Windows.Forms.ToolStripMenuItem recentProjectsToolStripMenuItem;
        private System.ComponentModel.IContainer components;


        public ToolStripMenuItem debugToolStripMenuItem;
        public ToolStripMenuItem runSlowToolStripMenuItem;
        public ToolStripMenuItem stepAnyToolStripMenuItem;
        public ToolStripMenuItem stepThreadToolStripMenuItem;
        public ToolStripButton runSlowToolStripButton;
        public ToolStripButton stopToolStripButton;
        public ToolStripMenuItem stopToolStripMenuItem;
        public ToolStripButton pauseToolStripButton;
        public ToolStripMenuItem pauseToolStripMenuItem;
        public ToolStripButton runFastToolStripButton;
        public ToolStripButton runNormalToolStripButton;
        public ToolStripButton stepAnyToolStripButton;
        public ToolStripButton stepBackToolStripButton;
        public ToolStripMenuItem runFastToolStripMenuItem;
        public Timer timerDebugWatch;
        public ToolStripButton stepThreadToolStripButton;
        public ToolStripButton stepRoundToolStripButton;
        public ToolStripButton executeToolStripButton;
        public ToolStripMenuItem runNormalToolStripMenuItem;
        public ToolStripMenuItem stepWarriorToolStripMenuItem;
        public ToolStripMenuItem runToolStripMenuItem;
        public ToolStripMenuItem checkForUpdateToolStripMenuItem;
        public ToolStripButton saveToolStripButton;
        public ToolStripButton saveAllToolStripButton;
    
    }
}

