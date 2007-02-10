using nMars.Graphics.Controls;

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
            this.components = new System.ComponentModel.Container();
            this.panel = new System.Windows.Forms.Panel();
            this.checkBoxAutoIP = new System.Windows.Forms.CheckBox();
            this.checkBoxRelative = new System.Windows.Forms.CheckBox();
            this.maskedTextBoxAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.coreList = new nMars.IDE.Controls.CoreListingInteractive(this.components);
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.checkBoxAutoIP);
            this.panel.Controls.Add(this.checkBoxRelative);
            this.panel.Controls.Add(this.maskedTextBoxAddress);
            this.panel.Controls.Add(this.labelAddress);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(199, 38);
            this.panel.TabIndex = 0;
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
            // coreList
            // 
            this.coreList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.coreList.Location = new System.Drawing.Point(0, 38);
            this.coreList.Name = "coreList";
            this.coreList.PaintMarkedIndex = true;
            this.coreList.PaintNextAddress = true;
            this.coreList.Size = new System.Drawing.Size(199, 494);
            this.coreList.TabIndex = 3;
            // 
            // DebugMemoryListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.coreList);
            this.Controls.Add(this.panel);
            this.Name = "DebugMemoryListing";
            this.Size = new System.Drawing.Size(199, 540);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox maskedTextBoxAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.CheckBox checkBoxRelative;
        private CoreListingInteractive coreList;
        private System.Windows.Forms.CheckBox checkBoxAutoIP;
    }
}
