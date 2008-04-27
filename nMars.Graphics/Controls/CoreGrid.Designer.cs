namespace nMars.Graphics.Controls
{
    partial class CoreGrid
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
            this.SuspendLayout();
            // 
            // CoreGrid
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "CoreGrid";
            this.Size = new System.Drawing.Size(383, 280);
            this.DoubleBuffered = true;
            this.ClientSizeChanged += new System.EventHandler(this.CoreGrid_ClientSizeChanged);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
