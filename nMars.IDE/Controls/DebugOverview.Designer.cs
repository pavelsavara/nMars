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
            this.textBoxLive = new System.Windows.Forms.TextBox();
            this.labelLive = new System.Windows.Forms.Label();
            this.textBoxCycle = new System.Windows.Forms.TextBox();
            this.labelCycle = new System.Windows.Forms.Label();
            this.textBoxRound = new System.Windows.Forms.TextBox();
            this.labelRound = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.overviewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // IDEFramePanel
            // 
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.overviewPanel);
            // 
            // overviewPanel
            // 
            this.overviewPanel.Controls.Add(this.textBoxLive);
            this.overviewPanel.Controls.Add(this.labelLive);
            this.overviewPanel.Controls.Add(this.textBoxCycle);
            this.overviewPanel.Controls.Add(this.labelCycle);
            this.overviewPanel.Controls.Add(this.textBoxRound);
            this.overviewPanel.Controls.Add(this.labelRound);
            this.overviewPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.overviewPanel.Location = new System.Drawing.Point(0, 0);
            this.overviewPanel.Name = "overviewPanel";
            this.overviewPanel.Size = new System.Drawing.Size(806, 26);
            this.overviewPanel.TabIndex = 1;
            // 
            // textBoxLive
            // 
            this.textBoxLive.Location = new System.Drawing.Point(390, 3);
            this.textBoxLive.Name = "textBoxLive";
            this.textBoxLive.ReadOnly = true;
            this.textBoxLive.Size = new System.Drawing.Size(100, 20);
            this.textBoxLive.TabIndex = 5;
            // 
            // labelLive
            // 
            this.labelLive.AutoSize = true;
            this.labelLive.Location = new System.Drawing.Point(337, 6);
            this.labelLive.Name = "labelLive";
            this.labelLive.Size = new System.Drawing.Size(55, 13);
            this.labelLive.TabIndex = 4;
            this.labelLive.Text = "Live w/t : ";
            // 
            // textBoxCycle
            // 
            this.textBoxCycle.Location = new System.Drawing.Point(227, 3);
            this.textBoxCycle.Name = "textBoxCycle";
            this.textBoxCycle.ReadOnly = true;
            this.textBoxCycle.Size = new System.Drawing.Size(100, 20);
            this.textBoxCycle.TabIndex = 3;
            // 
            // labelCycle
            // 
            this.labelCycle.AutoSize = true;
            this.labelCycle.Location = new System.Drawing.Point(174, 6);
            this.labelCycle.Name = "labelCycle";
            this.labelCycle.Size = new System.Drawing.Size(42, 13);
            this.labelCycle.TabIndex = 2;
            this.labelCycle.Text = "Cycle : ";
            // 
            // textBoxRound
            // 
            this.textBoxRound.Location = new System.Drawing.Point(65, 3);
            this.textBoxRound.Name = "textBoxRound";
            this.textBoxRound.ReadOnly = true;
            this.textBoxRound.Size = new System.Drawing.Size(100, 20);
            this.textBoxRound.TabIndex = 1;
            // 
            // labelRound
            // 
            this.labelRound.AutoSize = true;
            this.labelRound.Location = new System.Drawing.Point(12, 6);
            this.labelRound.Name = "labelRound";
            this.labelRound.Size = new System.Drawing.Size(48, 13);
            this.labelRound.TabIndex = 0;
            this.labelRound.Text = "Round : ";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 26);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(806, 344);
            this.tableLayoutPanel.TabIndex = 2;
            // 
            // DebugOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "DebugOverview";
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
        private System.Windows.Forms.TextBox textBoxLive;
        private System.Windows.Forms.Label labelLive;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
    }
}
