namespace nMars.IDE.Debugger.Controls
{
    partial class DebugMemoryGraph
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
            this.coreGrid = new nMars.IDE.Debugger.Controls.CoreGridInteractive();
            this.SuspendLayout();
            // 
            // coreGrid
            // 
            this.coreGrid.BackColor = System.Drawing.Color.Black;
            this.coreGrid.Cursor = System.Windows.Forms.Cursors.Cross;
            this.coreGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.coreGrid.ForeColor = System.Drawing.Color.White;
            this.coreGrid.Location = new System.Drawing.Point(0, 0);
            this.coreGrid.Name = "coreGrid";
            this.coreGrid.Size = new System.Drawing.Size(870, 370);
            this.coreGrid.TabIndex = 0;
            // 
            // DebugMemoryGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.coreGrid);
            this.Name = "DebugMemoryGraph";
            this.Size = new System.Drawing.Size(870, 370);
            this.ResumeLayout(false);

        }

        #endregion

        private CoreGridInteractive coreGrid;

    }
}
