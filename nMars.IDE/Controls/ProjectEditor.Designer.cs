using System.ComponentModel;
using System.Windows.Forms;
using nMars.IDE.Core;

namespace nMars.IDE.Controls
{
    partial class ProjectEditor
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
            this.redCodeProjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageRules = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCoreSize = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPSpaceSize = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCycles = new System.Windows.Forms.TextBox();
            this.labelRounds = new System.Windows.Forms.Label();
            this.textBoxRounds = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.redCodeProjectBindingSource)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPageRules.SuspendLayout();
            this.SuspendLayout();
            // 
            // redCodeProjectBindingSource
            // 
            this.redCodeProjectBindingSource.AllowNew = false;
            this.redCodeProjectBindingSource.DataSource = typeof(nMars.IDE.Core.RedCodeProject);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 10);
            this.panel1.TabIndex = 1;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageRules);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 10);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(810, 495);
            this.tabControl.TabIndex = 2;
            // 
            // tabPageRules
            // 
            this.tabPageRules.Controls.Add(this.label7);
            this.tabPageRules.Controls.Add(this.textBoxCoreSize);
            this.tabPageRules.Controls.Add(this.label6);
            this.tabPageRules.Controls.Add(this.textBoxPSpaceSize);
            this.tabPageRules.Controls.Add(this.label5);
            this.tabPageRules.Controls.Add(this.textBox1);
            this.tabPageRules.Controls.Add(this.label4);
            this.tabPageRules.Controls.Add(this.textBox4);
            this.tabPageRules.Controls.Add(this.label3);
            this.tabPageRules.Controls.Add(this.textBox3);
            this.tabPageRules.Controls.Add(this.label2);
            this.tabPageRules.Controls.Add(this.textBox2);
            this.tabPageRules.Controls.Add(this.label1);
            this.tabPageRules.Controls.Add(this.textBoxCycles);
            this.tabPageRules.Controls.Add(this.labelRounds);
            this.tabPageRules.Controls.Add(this.textBoxRounds);
            this.tabPageRules.Location = new System.Drawing.Point(4, 22);
            this.tabPageRules.Name = "tabPageRules";
            this.tabPageRules.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRules.Size = new System.Drawing.Size(802, 469);
            this.tabPageRules.TabIndex = 0;
            this.tabPageRules.Text = "Rules";
            this.tabPageRules.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Core Size";
            // 
            // textBoxCoreSize
            // 
            this.textBoxCoreSize.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.redCodeProjectBindingSource, "CoreSize", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.textBoxCoreSize.Location = new System.Drawing.Point(81, 83);
            this.textBoxCoreSize.Name = "textBoxCoreSize";
            this.textBoxCoreSize.Size = new System.Drawing.Size(100, 20);
            this.textBoxCoreSize.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "PSpace Size";
            // 
            // textBoxPSpaceSize
            // 
            this.textBoxPSpaceSize.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.redCodeProjectBindingSource, "PSpaceSize", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.textBoxPSpaceSize.Location = new System.Drawing.Point(81, 109);
            this.textBoxPSpaceSize.Name = "textBoxPSpaceSize";
            this.textBoxPSpaceSize.Size = new System.Drawing.Size(100, 20);
            this.textBoxPSpaceSize.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Warriors";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.redCodeProjectBindingSource, "WarriorsCount", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.textBox1.Location = new System.Drawing.Point(81, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Min Distance";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.redCodeProjectBindingSource, "MinDistance", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.textBox4.Location = new System.Drawing.Point(81, 187);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Max Length";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.redCodeProjectBindingSource, "MaxLength", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.textBox3.Location = new System.Drawing.Point(81, 161);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Processes";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.redCodeProjectBindingSource, "MaxProcesses", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.textBox2.Location = new System.Drawing.Point(81, 135);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cycle";
            // 
            // textBoxCycles
            // 
            this.textBoxCycles.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.redCodeProjectBindingSource, "MaxCycles", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.textBoxCycles.Location = new System.Drawing.Point(81, 57);
            this.textBoxCycles.Name = "textBoxCycles";
            this.textBoxCycles.Size = new System.Drawing.Size(100, 20);
            this.textBoxCycles.TabIndex = 2;
            // 
            // labelRounds
            // 
            this.labelRounds.AutoSize = true;
            this.labelRounds.Location = new System.Drawing.Point(9, 34);
            this.labelRounds.Name = "labelRounds";
            this.labelRounds.Size = new System.Drawing.Size(44, 13);
            this.labelRounds.TabIndex = 1;
            this.labelRounds.Text = "Rounds";
            // 
            // textBoxRounds
            // 
            this.textBoxRounds.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.redCodeProjectBindingSource, "Rounds", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.textBoxRounds.Location = new System.Drawing.Point(81, 31);
            this.textBoxRounds.Name = "textBoxRounds";
            this.textBoxRounds.Size = new System.Drawing.Size(100, 20);
            this.textBoxRounds.TabIndex = 0;
            // 
            // ProjectEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel1);
            this.Name = "ProjectEditor";
            this.Size = new System.Drawing.Size(810, 505);
            ((System.ComponentModel.ISupportInitialize)(this.redCodeProjectBindingSource)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPageRules.ResumeLayout(false);
            this.tabPageRules.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BindingSource redCodeProjectBindingSource;
        private Panel panel1;
        private TabControl tabControl;
        private TabPage tabPageRules;
        private Label labelRounds;
        private TextBox textBoxRounds;
        private Label label4;
        private TextBox textBox4;
        private Label label3;
        private TextBox textBox3;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBoxCycles;
        private Label label5;
        private TextBox textBox1;
        private Label label6;
        private TextBox textBoxPSpaceSize;
        private Label label7;
        private TextBox textBoxCoreSize;
    }
}
