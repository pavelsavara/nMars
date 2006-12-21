namespace nMars.IDE.Controls
{
    partial class Console
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbIn = new System.Windows.Forms.ComboBox();
            this.tbOut = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IDEFramePanel
            // 
            this.Controls.Add(this.tbOut);
            this.Controls.Add(this.panel1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbIn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 347);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 23);
            this.panel1.TabIndex = 0;
            // 
            // cbIn
            // 
            this.cbIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbIn.FormattingEnabled = true;
            this.cbIn.Location = new System.Drawing.Point(0, 0);
            this.cbIn.Name = "cbIn";
            this.cbIn.Size = new System.Drawing.Size(806, 21);
            this.cbIn.TabIndex = 0;
            // 
            // tbOut
            // 
            this.tbOut.BackColor = System.Drawing.SystemColors.Window;
            this.tbOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbOut.Location = new System.Drawing.Point(0, 0);
            this.tbOut.Multiline = true;
            this.tbOut.Name = "tbOut";
            this.tbOut.ReadOnly = true;
            this.tbOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbOut.Size = new System.Drawing.Size(806, 347);
            this.tbOut.TabIndex = 1;
            // 
            // Console
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Console";
            this.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ComboBox cbIn;
        public System.Windows.Forms.TextBox tbOut;

    }
}
