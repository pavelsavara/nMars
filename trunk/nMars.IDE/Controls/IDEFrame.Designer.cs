namespace nMars.IDE.Controls
{
    partial class IDEFrame
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
            this.IDEFramePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // IDEFramePanel
            // 
            this.IDEFramePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IDEFramePanel.Location = new System.Drawing.Point(0, 0);
            this.IDEFramePanel.Name = "IDEFramePanel";
            this.IDEFramePanel.Size = new System.Drawing.Size(806, 370);
            this.IDEFramePanel.TabIndex = 0;
            // 
            // IDEFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.IDEFramePanel);
            this.Name = "IDEFrame";
            this.Size = new System.Drawing.Size(806, 370);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel IDEFramePanel;

    }
}
