namespace nMars.IDE.Forms
{
    partial class CellDetailDialog
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageInfo = new System.Windows.Forms.TabPage();
            this.tabPageBreakpoint = new System.Windows.Forms.TabPage();
            this.checkBoxExecute = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tabPageInfo.SuspendLayout();
            this.tabPageBreakpoint.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageInfo);
            this.tabControl.Controls.Add(this.tabPageBreakpoint);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(589, 348);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageInfo
            // 
            this.tabPageInfo.Controls.Add(this.textBox2);
            this.tabPageInfo.Controls.Add(this.textBox1);
            this.tabPageInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPageInfo.Name = "tabPageInfo";
            this.tabPageInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInfo.Size = new System.Drawing.Size(581, 322);
            this.tabPageInfo.TabIndex = 0;
            this.tabPageInfo.Text = "Info";
            this.tabPageInfo.UseVisualStyleBackColor = true;
            // 
            // tabPageBreakpoint
            // 
            this.tabPageBreakpoint.Controls.Add(this.checkBoxExecute);
            this.tabPageBreakpoint.Location = new System.Drawing.Point(4, 22);
            this.tabPageBreakpoint.Name = "tabPageBreakpoint";
            this.tabPageBreakpoint.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBreakpoint.Size = new System.Drawing.Size(581, 322);
            this.tabPageBreakpoint.TabIndex = 1;
            this.tabPageBreakpoint.Text = "Breakpoint";
            this.tabPageBreakpoint.UseVisualStyleBackColor = true;
            // 
            // checkBoxExecute
            // 
            this.checkBoxExecute.AutoSize = true;
            this.checkBoxExecute.Location = new System.Drawing.Point(6, 6);
            this.checkBoxExecute.Name = "checkBoxExecute";
            this.checkBoxExecute.Size = new System.Drawing.Size(125, 17);
            this.checkBoxExecute.TabIndex = 0;
            this.checkBoxExecute.Text = "Break after executed";
            this.checkBoxExecute.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(3, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(47, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "00000";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(59, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(175, 20);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "MOV.I    #1234, $4321";
            // 
            // CellDetailDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 348);
            this.Controls.Add(this.tabControl);
            this.Name = "CellDetailDialog";
            this.Text = "CellDetailDialog";
            this.tabControl.ResumeLayout(false);
            this.tabPageInfo.ResumeLayout(false);
            this.tabPageInfo.PerformLayout();
            this.tabPageBreakpoint.ResumeLayout(false);
            this.tabPageBreakpoint.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageInfo;
        private System.Windows.Forms.TabPage tabPageBreakpoint;
        private System.Windows.Forms.CheckBox checkBoxExecute;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}