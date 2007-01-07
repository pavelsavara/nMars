namespace nMars.Graphics.Controls
{
    partial class CoreListing
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
            // CoreListing
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ForeColor = System.Drawing.Color.White;
            this.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.CoreListing_DrawItem);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
