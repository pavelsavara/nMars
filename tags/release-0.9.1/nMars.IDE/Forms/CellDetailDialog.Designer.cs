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
            this.textBoxCell = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.checkBoxBreakExec = new System.Windows.Forms.CheckBox();
            this.checkBoxBreakDeath = new System.Windows.Forms.CheckBox();
            this.checkBoxBreakWriteData = new System.Windows.Forms.CheckBox();
            this.checkBoxBreakRead = new System.Windows.Forms.CheckBox();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.panelBtn = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.checkBoxBreakWriteInstruction = new System.Windows.Forms.CheckBox();
            this.panelInfo.SuspendLayout();
            this.panelBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxCell
            // 
            this.textBoxCell.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxCell.Location = new System.Drawing.Point(69, 12);
            this.textBoxCell.Name = "textBoxCell";
            this.textBoxCell.ReadOnly = true;
            this.textBoxCell.Size = new System.Drawing.Size(189, 20);
            this.textBoxCell.TabIndex = 14;
            this.textBoxCell.Text = "MOV.I    #1234, $4321";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxAddress.Location = new System.Drawing.Point(11, 12);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.ReadOnly = true;
            this.textBoxAddress.Size = new System.Drawing.Size(52, 20);
            this.textBoxAddress.TabIndex = 13;
            this.textBoxAddress.Text = "000000";
            // 
            // checkBoxBreakExec
            // 
            this.checkBoxBreakExec.AutoSize = true;
            this.checkBoxBreakExec.Location = new System.Drawing.Point(11, 38);
            this.checkBoxBreakExec.Name = "checkBoxBreakExec";
            this.checkBoxBreakExec.Size = new System.Drawing.Size(110, 17);
            this.checkBoxBreakExec.TabIndex = 15;
            this.checkBoxBreakExec.Text = "Break on execute";
            this.checkBoxBreakExec.UseVisualStyleBackColor = true;
            // 
            // checkBoxBreakDeath
            // 
            this.checkBoxBreakDeath.AutoSize = true;
            this.checkBoxBreakDeath.Location = new System.Drawing.Point(12, 61);
            this.checkBoxBreakDeath.Name = "checkBoxBreakDeath";
            this.checkBoxBreakDeath.Size = new System.Drawing.Size(99, 17);
            this.checkBoxBreakDeath.TabIndex = 16;
            this.checkBoxBreakDeath.Text = "Break on death";
            this.checkBoxBreakDeath.UseVisualStyleBackColor = true;
            // 
            // checkBoxBreakWriteData
            // 
            this.checkBoxBreakWriteData.AutoSize = true;
            this.checkBoxBreakWriteData.Location = new System.Drawing.Point(12, 84);
            this.checkBoxBreakWriteData.Name = "checkBoxBreakWriteData";
            this.checkBoxBreakWriteData.Size = new System.Drawing.Size(118, 17);
            this.checkBoxBreakWriteData.TabIndex = 17;
            this.checkBoxBreakWriteData.Text = "Break on write data";
            this.checkBoxBreakWriteData.UseVisualStyleBackColor = true;
            // 
            // checkBoxBreakRead
            // 
            this.checkBoxBreakRead.AutoSize = true;
            this.checkBoxBreakRead.Location = new System.Drawing.Point(12, 130);
            this.checkBoxBreakRead.Name = "checkBoxBreakRead";
            this.checkBoxBreakRead.Size = new System.Drawing.Size(93, 17);
            this.checkBoxBreakRead.TabIndex = 18;
            this.checkBoxBreakRead.Text = "Break on read";
            this.checkBoxBreakRead.UseVisualStyleBackColor = true;
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInfo.Location = new System.Drawing.Point(0, 0);
            this.textBoxInfo.Multiline = true;
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.ReadOnly = true;
            this.textBoxInfo.Size = new System.Drawing.Size(263, 96);
            this.textBoxInfo.TabIndex = 0;
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.textBoxInfo);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInfo.Location = new System.Drawing.Point(0, 166);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(263, 96);
            this.panelInfo.TabIndex = 19;
            // 
            // panelBtn
            // 
            this.panelBtn.Controls.Add(this.buttonCancel);
            this.panelBtn.Controls.Add(this.buttonOK);
            this.panelBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBtn.Location = new System.Drawing.Point(0, 262);
            this.panelBtn.Name = "panelBtn";
            this.panelBtn.Size = new System.Drawing.Size(263, 44);
            this.panelBtn.TabIndex = 20;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(59, 9);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(140, 9);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // checkBoxBreakWriteInstruction
            // 
            this.checkBoxBreakWriteInstruction.AutoSize = true;
            this.checkBoxBreakWriteInstruction.Location = new System.Drawing.Point(12, 107);
            this.checkBoxBreakWriteInstruction.Name = "checkBoxBreakWriteInstruction";
            this.checkBoxBreakWriteInstruction.Size = new System.Drawing.Size(133, 17);
            this.checkBoxBreakWriteInstruction.TabIndex = 21;
            this.checkBoxBreakWriteInstruction.Text = "Break on write opcode";
            this.checkBoxBreakWriteInstruction.UseVisualStyleBackColor = true;
            // 
            // CellDetailDialog
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(263, 306);
            this.Controls.Add(this.checkBoxBreakWriteInstruction);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelBtn);
            this.Controls.Add(this.checkBoxBreakRead);
            this.Controls.Add(this.checkBoxBreakWriteData);
            this.Controls.Add(this.checkBoxBreakDeath);
            this.Controls.Add(this.checkBoxBreakExec);
            this.Controls.Add(this.textBoxCell);
            this.Controls.Add(this.textBoxAddress);
            this.Name = "CellDetailDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cell Details";
            this.Load += new System.EventHandler(this.CellDetailDialog_Load);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelBtn.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCell;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.CheckBox checkBoxBreakExec;
        private System.Windows.Forms.CheckBox checkBoxBreakDeath;
        private System.Windows.Forms.CheckBox checkBoxBreakWriteData;
        private System.Windows.Forms.CheckBox checkBoxBreakRead;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Panel panelBtn;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.CheckBox checkBoxBreakWriteInstruction;

    }
}