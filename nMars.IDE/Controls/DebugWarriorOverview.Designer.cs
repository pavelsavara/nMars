
namespace nMars.IDE.Controls
{
    partial class DebugWarriorOverview
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
            this.components = new System.ComponentModel.Container();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.coreList = new nMars.IDE.Controls.CoreListingInteractive(this.components);
            this.panelTop = new System.Windows.Forms.Panel();
            this.textBoxTasks = new System.Windows.Forms.TextBox();
            this.textBoxLastInstruction = new System.Windows.Forms.TextBox();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.labelTaks = new System.Windows.Forms.Label();
            this.labelLastInstruction = new System.Windows.Forms.Label();
            this.labelNext = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.panelRight);
            this.groupBox.Controls.Add(this.panelLeft);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(642, 535);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "WarriorName";
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.coreList);
            this.panelRight.Controls.Add(this.panelTop);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(73, 16);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(566, 516);
            this.panelRight.TabIndex = 12;
            // 
            // listBoxNextInstructions
            // 
            this.coreList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.coreList.Location = new System.Drawing.Point(0, 58);
            this.coreList.Name = "coreList";
            this.coreList.Size = new System.Drawing.Size(566, 452);
            this.coreList.TabIndex = 11;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.textBoxTasks);
            this.panelTop.Controls.Add(this.textBoxLastInstruction);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(566, 58);
            this.panelTop.TabIndex = 12;
            // 
            // textBoxTasks
            // 
            this.textBoxTasks.Location = new System.Drawing.Point(0, 4);
            this.textBoxTasks.Name = "textBoxTasks";
            this.textBoxTasks.ReadOnly = true;
            this.textBoxTasks.Size = new System.Drawing.Size(230, 20);
            this.textBoxTasks.TabIndex = 7;
            // 
            // textBoxLastInstruction
            // 
            this.textBoxLastInstruction.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLastInstruction.Location = new System.Drawing.Point(0, 30);
            this.textBoxLastInstruction.Name = "textBoxLastInstruction";
            this.textBoxLastInstruction.ReadOnly = true;
            this.textBoxLastInstruction.Size = new System.Drawing.Size(230, 20);
            this.textBoxLastInstruction.TabIndex = 9;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.labelTaks);
            this.panelLeft.Controls.Add(this.labelLastInstruction);
            this.panelLeft.Controls.Add(this.labelNext);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(3, 16);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(70, 516);
            this.panelLeft.TabIndex = 13;
            // 
            // labelTaks
            // 
            this.labelTaks.AutoSize = true;
            this.labelTaks.Location = new System.Drawing.Point(3, 7);
            this.labelTaks.Name = "labelTaks";
            this.labelTaks.Size = new System.Drawing.Size(58, 13);
            this.labelTaks.TabIndex = 6;
            this.labelTaks.Text = "Tasks l/d :";
            // 
            // labelLastInstruction
            // 
            this.labelLastInstruction.AutoSize = true;
            this.labelLastInstruction.Location = new System.Drawing.Point(3, 33);
            this.labelLastInstruction.Name = "labelLastInstruction";
            this.labelLastInstruction.Size = new System.Drawing.Size(33, 13);
            this.labelLastInstruction.TabIndex = 8;
            this.labelLastInstruction.Text = "Last :";
            // 
            // labelNext
            // 
            this.labelNext.AutoSize = true;
            this.labelNext.Location = new System.Drawing.Point(3, 63);
            this.labelNext.Name = "labelNext";
            this.labelNext.Size = new System.Drawing.Size(35, 13);
            this.labelNext.TabIndex = 10;
            this.labelNext.Text = "Next :";
            // 
            // DebugWarriorOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "DebugWarriorOverview";
            this.Size = new System.Drawing.Size(642, 535);
            this.groupBox.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox textBoxLastInstruction;
        private System.Windows.Forms.Label labelLastInstruction;
        private System.Windows.Forms.TextBox textBoxTasks;
        private System.Windows.Forms.Label labelTaks;
        private System.Windows.Forms.Panel panelRight;
        private CoreListingInteractive coreList;
        private System.Windows.Forms.Label labelNext;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelTop;
    }
}
