using System.Windows.Forms;

namespace nMars.IDE.Controls
{
    partial class TextEditor
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
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.IDEFramePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // IDEFramePanel
            // 
            this.IDEFramePanel.Controls.Add(this.textBox);
            this.IDEFramePanel.Size = new System.Drawing.Size(249, 238);
            // 
            // textBox
            // 
            this.textBox.AcceptsTab = true;
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.DetectUrls = false;
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox.Location = new System.Drawing.Point(0, 0);
            this.textBox.Margin = new System.Windows.Forms.Padding(0);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(249, 238);
            this.textBox.TabIndex = 1;
            this.textBox.Text = "";
            this.textBox.WordWrap = false;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // TextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "TextEditor";
            this.Size = new System.Drawing.Size(249, 238);
            this.IDEFramePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox textBox;

    }
}
