// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Drawing;
using System.Windows.Forms;
using nMars.IDE.Debugger.Properties;
using nMars.IDE.Forms;

namespace nMars.IDE.Debugger.Forms
{
    public class DebuggerMainForm
    {
        public DebuggerMainForm(MainForm aMainForm, IDEDebuggerApplication aIDEDebuggerApplication)
        {
            mainForm = aMainForm;
            IDEDebuggerApplication = aIDEDebuggerApplication;
            InitializeComponent();
        }

        private MainForm mainForm;
        private IDEDebuggerApplication IDEDebuggerApplication;

        private void InitializeComponent()
        {
            debugToolStripMenuItem = new ToolStripMenuItem();
            runFastToolStripMenuItem = new ToolStripMenuItem();
            runNormalToolStripMenuItem = new ToolStripMenuItem();
            runSlowToolStripMenuItem = new ToolStripMenuItem();
            runToolStripMenuItem = new ToolStripMenuItem();
            stepAnyToolStripMenuItem = new ToolStripMenuItem();
            stepWarriorToolStripMenuItem = new ToolStripMenuItem();
            stepThreadToolStripMenuItem = new ToolStripMenuItem();
            pauseToolStripMenuItem = new ToolStripMenuItem();
            stopToolStripMenuItem = new ToolStripMenuItem();
            executeToolStripButton = new ToolStripButton();
            runFastToolStripButton = new ToolStripButton();
            runNormalToolStripButton = new ToolStripButton();
            runSlowToolStripButton = new ToolStripButton();
            stepRoundToolStripButton = new ToolStripButton();
            stepThreadToolStripButton = new ToolStripButton();
            stepAnyToolStripButton = new ToolStripButton();
            pauseToolStripButton = new ToolStripButton();
            stepBackToolStripButton = new ToolStripButton();
            stopToolStripButton = new ToolStripButton();
            timerDebugWatch = new Timer(mainForm.components);
            mainForm.mainMenu.SuspendLayout();
            mainForm.toolbar.SuspendLayout();

            mainForm.mainMenu.Items.Add(debugToolStripMenuItem);

            // 
            // debugToolStripMenuItem
            // 
            debugToolStripMenuItem.DropDownItems.AddRange(
                new ToolStripItem[]
                    {
                        runFastToolStripMenuItem, runNormalToolStripMenuItem, runSlowToolStripMenuItem,
                        runToolStripMenuItem, stepAnyToolStripMenuItem, stepWarriorToolStripMenuItem,
                        stepThreadToolStripMenuItem, pauseToolStripMenuItem, stopToolStripMenuItem
                    });
            debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            debugToolStripMenuItem.Size = new Size(50, 20);
            debugToolStripMenuItem.Text = "Debug";
            // 
            // runFastToolStripMenuItem
            // 
            runFastToolStripMenuItem.Name = "runFastToolStripMenuItem";
            runFastToolStripMenuItem.Size = new Size(175, 22);
            runFastToolStripMenuItem.Text = "Run Fast";
            runFastToolStripMenuItem.Click += new EventHandler(runFastToolStripMenuItem_Click);
            // 
            // runNormalToolStripMenuItem
            // 
            runNormalToolStripMenuItem.Name = "runNormalToolStripMenuItem";
            runNormalToolStripMenuItem.Size = new Size(175, 22);
            runNormalToolStripMenuItem.Text = "Run Normal";
            runNormalToolStripMenuItem.Click += new EventHandler(runNormalToolStripMenuItem_Click);
            // 
            // runSlowToolStripMenuItem
            // 
            runSlowToolStripMenuItem.Name = "runSlowToolStripMenuItem";
            runSlowToolStripMenuItem.Size = new Size(175, 22);
            runSlowToolStripMenuItem.Text = "Run Slow";
            runSlowToolStripMenuItem.Click += new EventHandler(runSlowToolStripMenuItem_Click);
            // 
            // runToolStripMenuItem
            // 
            runToolStripMenuItem.Name = "runToolStripMenuItem";
            runToolStripMenuItem.ShortcutKeys = Keys.F5;
            runToolStripMenuItem.Size = new Size(175, 22);
            runToolStripMenuItem.Text = "Run";
            runToolStripMenuItem.Click += new EventHandler(runToolStripMenuItem_Click);
            // 
            // stepAnyToolStripMenuItem
            // 
            stepAnyToolStripMenuItem.Name = "stepAnyToolStripMenuItem";
            stepAnyToolStripMenuItem.ShortcutKeys = Keys.F12;
            stepAnyToolStripMenuItem.Size = new Size(175, 22);
            stepAnyToolStripMenuItem.Text = "Step Any";
            stepAnyToolStripMenuItem.Click += new EventHandler(stepAnyToolStripMenuItem_Click);
            // 
            // stepWarriorToolStripMenuItem
            // 
            stepWarriorToolStripMenuItem.Name = "stepWarriorToolStripMenuItem";
            stepWarriorToolStripMenuItem.ShortcutKeys = Keys.F11;
            stepWarriorToolStripMenuItem.Size = new Size(175, 22);
            stepWarriorToolStripMenuItem.Text = "Step Warrior";
            stepWarriorToolStripMenuItem.Click += new EventHandler(stepWarriorToolStripMenuItem_Click);
            // 
            // stepThreadToolStripMenuItem
            // 
            stepThreadToolStripMenuItem.Name = "stepThreadToolStripMenuItem";
            stepThreadToolStripMenuItem.ShortcutKeys = Keys.F10;
            stepThreadToolStripMenuItem.Size = new Size(175, 22);
            stepThreadToolStripMenuItem.Text = "Step Thread";
            stepThreadToolStripMenuItem.Click += new EventHandler(stepThreadToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            pauseToolStripMenuItem.ShortcutKeys = (Keys.Control | Keys.Space);
            pauseToolStripMenuItem.Size = new Size(175, 22);
            pauseToolStripMenuItem.Text = "Pause";
            pauseToolStripMenuItem.Click += new EventHandler(pauseToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            stopToolStripMenuItem.ShortcutKeys = (Keys.Shift | Keys.F5);
            stopToolStripMenuItem.Size = new Size(175, 22);
            stopToolStripMenuItem.Text = "Stop";
            stopToolStripMenuItem.Click += new EventHandler(stopToolStripMenuItem_Click);

            mainForm.toolbar.Items.AddRange(
                new ToolStripItem[]
                    {
                        executeToolStripButton, runFastToolStripButton, runNormalToolStripButton,
                        runSlowToolStripButton, stepRoundToolStripButton, stepThreadToolStripButton,
                        stepAnyToolStripButton, pauseToolStripButton, stepBackToolStripButton,
                        stopToolStripButton
                    });

            // 
            // executeToolStripButton
            // 
            executeToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            executeToolStripButton.Image = Resources.Execute;
            executeToolStripButton.ImageTransparentColor = Color.Magenta;
            executeToolStripButton.Name = "executeToolStripButton";
            executeToolStripButton.Size = new Size(23, 22);
            executeToolStripButton.Text = "Execute without Debuger";
            executeToolStripButton.Click += new EventHandler(executeToolStripButton_Click);
            // 
            // runFastToolStripButton
            // 
            runFastToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            runFastToolStripButton.Image = Resources.RunFF;
            runFastToolStripButton.ImageTransparentColor = Color.Magenta;
            runFastToolStripButton.Name = "runFastToolStripButton";
            runFastToolStripButton.Size = new Size(23, 22);
            runFastToolStripButton.Text = "Run Fast";
            runFastToolStripButton.Click += new EventHandler(runFastToolStripButton_Click);
            // 
            // runNormalToolStripButton
            // 
            runNormalToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            runNormalToolStripButton.Image = Resources.RunF;
            runNormalToolStripButton.ImageTransparentColor = Color.Magenta;
            runNormalToolStripButton.Name = "runNormalToolStripButton";
            runNormalToolStripButton.Size = new Size(23, 22);
            runNormalToolStripButton.Text = "Run";
            runNormalToolStripButton.Click += new EventHandler(runNormalToolStripButton_Click);
            // 
            // runSlowToolStripButton
            // 
            runSlowToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            runSlowToolStripButton.Image = Resources.Run;
            runSlowToolStripButton.ImageTransparentColor = Color.Magenta;
            runSlowToolStripButton.Name = "runSlowToolStripButton";
            runSlowToolStripButton.Size = new Size(23, 22);
            runSlowToolStripButton.Text = "Run Slow";
            runSlowToolStripButton.Click += new EventHandler(runSlowToolStripButton_Click);
            // 
            // stepRoundToolStripButton
            // 
            stepRoundToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            stepRoundToolStripButton.Image = Resources.StepRound;
            stepRoundToolStripButton.ImageTransparentColor = Color.Magenta;
            stepRoundToolStripButton.Name = "stepRoundToolStripButton";
            stepRoundToolStripButton.Size = new Size(23, 22);
            stepRoundToolStripButton.Text = "Step Round";
            stepRoundToolStripButton.Click += new EventHandler(stepRoundToolStripButton_Click);
            // 
            // stepThreadToolStripButton
            // 
            stepThreadToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            stepThreadToolStripButton.Image = Resources.StepThread;
            stepThreadToolStripButton.ImageTransparentColor = Color.Magenta;
            stepThreadToolStripButton.Name = "stepThreadToolStripButton";
            stepThreadToolStripButton.Size = new Size(23, 22);
            stepThreadToolStripButton.Text = "Step Thread";
            // 
            // stepAnyToolStripButton
            // 
            stepAnyToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            stepAnyToolStripButton.Image = Resources.Step;
            stepAnyToolStripButton.ImageTransparentColor = Color.Magenta;
            stepAnyToolStripButton.Name = "stepAnyToolStripButton";
            stepAnyToolStripButton.Size = new Size(23, 22);
            stepAnyToolStripButton.Text = "Step";
            stepAnyToolStripButton.Click += new EventHandler(stepAnyToolStripButton_Click);
            // 
            // pauseToolStripButton
            // 
            pauseToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            pauseToolStripButton.Image = Resources.Pause;
            pauseToolStripButton.ImageTransparentColor = Color.Magenta;
            pauseToolStripButton.Name = "pauseToolStripButton";
            pauseToolStripButton.Size = new Size(23, 22);
            pauseToolStripButton.Text = "Pause";
            pauseToolStripButton.Click += new EventHandler(pauseToolStripButton_Click);
            // 
            // stepBackToolStripButton
            // 
            stepBackToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            stepBackToolStripButton.Image = Resources.Back;
            stepBackToolStripButton.ImageTransparentColor = Color.Magenta;
            stepBackToolStripButton.Name = "stepBackToolStripButton";
            stepBackToolStripButton.Size = new Size(23, 22);
            stepBackToolStripButton.Text = "Step Back";
            stepBackToolStripButton.Click += new EventHandler(stepBackToolStripButton_Click);
            // 
            // stopToolStripButton
            // 
            stopToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            stopToolStripButton.Image = Resources.Stop;
            stopToolStripButton.ImageTransparentColor = Color.Magenta;
            stopToolStripButton.Name = "stopToolStripButton";
            stopToolStripButton.Size = new Size(23, 22);
            stopToolStripButton.Text = "Stop";
            stopToolStripButton.Click += new EventHandler(stopToolStripButton_Click);
            // 
            // timerDebugWatch
            // 
            timerDebugWatch.Interval = 150;
            timerDebugWatch.Tick += new EventHandler(timerDebugWatch_Tick);

            mainForm.mainMenu.ResumeLayout();
            mainForm.toolbar.ResumeLayout();
        }

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

        #region 

        private void runSlowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDEDebuggerApplication.Run(IDEDebuggerApplication.slowRunBrake);
        }

        private void runSlowToolStripButton_Click(object sender, EventArgs e)
        {
            IDEDebuggerApplication.Run(IDEDebuggerApplication.slowRunBrake);
        }

        private void runFastToolStripButton_Click(object sender, EventArgs e)
        {
            IDEDebuggerApplication.Run(IDEDebuggerApplication.fastRunBrake);
        }

        private void runFastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDEDebuggerApplication.Run(IDEDebuggerApplication.fastRunBrake);
        }

        private void runNormalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDEDebuggerApplication.Run(IDEDebuggerApplication.normalRunBrake);
        }

        private void runNormalToolStripButton_Click(object sender, EventArgs e)
        {
            IDEDebuggerApplication.Run(IDEDebuggerApplication.normalRunBrake);
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDEDebuggerApplication.Run();
        }

        private void executeToolStripButton_Click(object sender, EventArgs e)
        {
            IDEDebuggerApplication.Run(IDEDebuggerApplication.executeBrake);
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDEDebuggerApplication.Stop();
        }

        private void stopToolStripButton_Click(object sender, EventArgs e)
        {
            IDEDebuggerApplication.Stop();
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IDEDebuggerApplication.ActiveEngine.IsPaused)
            {
                IDEDebuggerApplication.Pause();
            }
            else
            {
                IDEDebuggerApplication.Continue();
            }
        }

        private void pauseToolStripButton_Click(object sender, EventArgs e)
        {
            IDEDebuggerApplication.Pause();
        }

        private void stepRoundToolStripButton_Click(object sender, EventArgs e)
        {
            IDEDebuggerApplication.StepThread();
        }

        private void stepThreadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDEDebuggerApplication.StepThread();
        }

        private void stepWarriorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDEDebuggerApplication.StepWarrior();
        }

        private void stepAnyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDEDebuggerApplication.Step();
        }

        private void stepAnyToolStripButton_Click(object sender, EventArgs e)
        {
            IDEDebuggerApplication.Step();
        }

        private void stepBackToolStripButton_Click(object sender, EventArgs e)
        {
            IDEDebuggerApplication.Back();
        }

        private void timerDebugWatch_Tick(object sender, EventArgs e)
        {
            IDEDebuggerApplication.WatchTick();
        }

        #endregion
    }
}
