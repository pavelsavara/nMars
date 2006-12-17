namespace nMars.IDE.Controls
{
    partial class DebugOverview
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.overviewPanel = new System.Windows.Forms.Panel();
            this.labelRound = new System.Windows.Forms.Label();
            this.textBoxRound = new System.Windows.Forms.TextBox();
            this.textBoxCycle = new System.Windows.Forms.TextBox();
            this.labelCycle = new System.Windows.Forms.Label();
            this.IDEFramePanel.SuspendLayout();
            this.overviewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // IDEFramePanel
            // 
            this.IDEFramePanel.Controls.Add(this.overviewPanel);
            // 
            // overviewPanel
            // 
            this.overviewPanel.Controls.Add(this.textBoxCycle);
            this.overviewPanel.Controls.Add(this.labelCycle);
            this.overviewPanel.Controls.Add(this.textBoxRound);
            this.overviewPanel.Controls.Add(this.labelRound);
            this.overviewPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.overviewPanel.Location = new System.Drawing.Point(0, 0);
            this.overviewPanel.Name = "overviewPanel";
            this.overviewPanel.Size = new System.Drawing.Size(806, 96);
            this.overviewPanel.TabIndex = 1;
            // 
            // labelRound
            // 
            this.labelRound.AutoSize = true;
            this.labelRound.Location = new System.Drawing.Point(12, 11);
            this.labelRound.Name = "labelRound";
            this.labelRound.Size = new System.Drawing.Size(48, 13);
            this.labelRound.TabIndex = 0;
            this.labelRound.Text = "Round : ";
            // 
            // textBoxRound
            // 
            this.textBoxRound.Location = new System.Drawing.Point(57, 8);
            this.textBoxRound.Name = "textBoxRound";
            this.textBoxRound.ReadOnly = true;
            this.textBoxRound.Size = new System.Drawing.Size(100, 20);
            this.textBoxRound.TabIndex = 1;
            // 
            // textBoxCycle
            // 
            this.textBoxCycle.Location = new System.Drawing.Point(57, 34);
            this.textBoxCycle.Name = "textBoxCycle";
            this.textBoxCycle.ReadOnly = true;
            this.textBoxCycle.Size = new System.Drawing.Size(100, 20);
            this.textBoxCycle.TabIndex = 3;
            // 
            // labelCycle
            // 
            this.labelCycle.AutoSize = true;
            this.labelCycle.Location = new System.Drawing.Point(12, 37);
            this.labelCycle.Name = "labelCycle";
            this.labelCycle.Size = new System.Drawing.Size(42, 13);
            this.labelCycle.TabIndex = 2;
            this.labelCycle.Text = "Cycle : ";
            // 
            // DebugOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "DebugOverview";
            this.IDEFramePanel.ResumeLayout(false);
            this.overviewPanel.ResumeLayout(false);
            this.overviewPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel overviewPanel;
        private System.Windows.Forms.Label labelRound;
        private System.Windows.Forms.TextBox textBoxCycle;
        private System.Windows.Forms.Label labelCycle;
        private System.Windows.Forms.TextBox textBoxRound;
    }
}
