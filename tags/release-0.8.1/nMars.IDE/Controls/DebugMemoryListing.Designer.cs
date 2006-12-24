namespace nMars.IDE.Controls
{
    partial class DebugMemoryListing
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxAutoIP = new System.Windows.Forms.CheckBox();
            this.checkBoxRelative = new System.Windows.Forms.CheckBox();
            this.maskedTextBoxAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.listBoxMemory = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxAutoIP);
            this.panel1.Controls.Add(this.checkBoxRelative);
            this.panel1.Controls.Add(this.maskedTextBoxAddress);
            this.panel1.Controls.Add(this.labelAddress);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 38);
            this.panel1.TabIndex = 0;
            // 
            // checkBoxAutoIP
            // 
            this.checkBoxAutoIP.AutoSize = true;
            this.checkBoxAutoIP.Location = new System.Drawing.Point(121, 18);
            this.checkBoxAutoIP.Name = "checkBoxAutoIP";
            this.checkBoxAutoIP.Size = new System.Drawing.Size(74, 17);
            this.checkBoxAutoIP.TabIndex = 3;
            this.checkBoxAutoIP.Text = "Autofocus";
            this.checkBoxAutoIP.UseVisualStyleBackColor = true;
            // 
            // checkBoxRelative
            // 
            this.checkBoxRelative.AutoSize = true;
            this.checkBoxRelative.Location = new System.Drawing.Point(121, 3);
            this.checkBoxRelative.Name = "checkBoxRelative";
            this.checkBoxRelative.Size = new System.Drawing.Size(65, 17);
            this.checkBoxRelative.TabIndex = 2;
            this.checkBoxRelative.Text = "Relative";
            this.checkBoxRelative.UseVisualStyleBackColor = true;
            this.checkBoxRelative.CheckedChanged += new System.EventHandler(this.checkBoxRelative_CheckedChanged);
            // 
            // maskedTextBoxAddress
            // 
            this.maskedTextBoxAddress.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maskedTextBoxAddress.Location = new System.Drawing.Point(51, 10);
            this.maskedTextBoxAddress.Name = "maskedTextBoxAddress";
            this.maskedTextBoxAddress.Size = new System.Drawing.Size(54, 20);
            this.maskedTextBoxAddress.TabIndex = 1;
            this.maskedTextBoxAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTextBoxAddress_KeyDown);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(10, 13);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(35, 13);
            this.labelAddress.TabIndex = 0;
            this.labelAddress.Text = "Addr :";
            // 
            // listBoxMemory
            // 
            this.listBoxMemory.BackColor = System.Drawing.Color.Black;
            this.listBoxMemory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxMemory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxMemory.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxMemory.ForeColor = System.Drawing.Color.White;
            this.listBoxMemory.FormattingEnabled = true;
            this.listBoxMemory.ItemHeight = 14;
            this.listBoxMemory.Location = new System.Drawing.Point(0, 38);
            this.listBoxMemory.Name = "listBoxMemory";
            this.listBoxMemory.Size = new System.Drawing.Size(199, 494);
            this.listBoxMemory.TabIndex = 3;
            this.listBoxMemory.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxMemory_DrawItem);
            // 
            // DebugMemoryListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.listBoxMemory);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "DebugMemoryListing";
            this.Size = new System.Drawing.Size(199, 540);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox maskedTextBoxAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.CheckBox checkBoxRelative;
        private System.Windows.Forms.ListBox listBoxMemory;
        private System.Windows.Forms.CheckBox checkBoxAutoIP;
    }
}
