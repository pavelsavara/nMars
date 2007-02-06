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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectEditor));
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
            this.tabPageBreakPoints = new System.Windows.Forms.TabPage();
            this.listBoxBreakPoints = new System.Windows.Forms.ListBox();
            this.breakPointsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.bindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.redCodeProjectBindingSource)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPageRules.SuspendLayout();
            this.tabPageBreakPoints.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.breakPointsBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).BeginInit();
            this.bindingNavigator.SuspendLayout();
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
            this.tabControl.Controls.Add(this.tabPageBreakPoints);
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
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cycles";
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
            // tabPageBreakPoints
            // 
            this.tabPageBreakPoints.Controls.Add(this.listBoxBreakPoints);
            this.tabPageBreakPoints.Controls.Add(this.panel2);
            this.tabPageBreakPoints.Location = new System.Drawing.Point(4, 22);
            this.tabPageBreakPoints.Name = "tabPageBreakPoints";
            this.tabPageBreakPoints.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBreakPoints.Size = new System.Drawing.Size(802, 469);
            this.tabPageBreakPoints.TabIndex = 1;
            this.tabPageBreakPoints.Text = "BreakPoints";
            this.tabPageBreakPoints.UseVisualStyleBackColor = true;
            // 
            // listBoxBreakPoints
            // 
            this.listBoxBreakPoints.DataSource = this.breakPointsBindingSource;
            this.listBoxBreakPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxBreakPoints.FormattingEnabled = true;
            this.listBoxBreakPoints.Location = new System.Drawing.Point(3, 3);
            this.listBoxBreakPoints.Name = "listBoxBreakPoints";
            this.listBoxBreakPoints.Size = new System.Drawing.Size(796, 420);
            this.listBoxBreakPoints.TabIndex = 1;
            // 
            // breakPointsBindingSource
            // 
            this.breakPointsBindingSource.AllowNew = true;
            this.breakPointsBindingSource.DataSource = typeof(nMars.RedCode.BreakPoints);
            this.breakPointsBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.breakPointsBindingSource_AddingNew);
            this.breakPointsBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.breakPointsBindingSource_ListChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bindingNavigator);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 433);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(796, 33);
            this.panel2.TabIndex = 0;
            // 
            // bindingNavigator
            // 
            this.bindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator.BindingSource = this.breakPointsBindingSource;
            this.bindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator.Name = "bindingNavigator";
            this.bindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator.Size = new System.Drawing.Size(796, 25);
            this.bindingNavigator.TabIndex = 0;
            this.bindingNavigator.Text = "bindingNavigator";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            this.tabPageBreakPoints.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.breakPointsBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).EndInit();
            this.bindingNavigator.ResumeLayout(false);
            this.bindingNavigator.PerformLayout();
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
        private TabPage tabPageBreakPoints;
        private ListBox listBoxBreakPoints;
        private Panel panel2;
        private BindingSource breakPointsBindingSource;
        private BindingNavigator bindingNavigator;
        private ToolStripButton bindingNavigatorAddNewItem;
        private ToolStripLabel bindingNavigatorCountItem;
        private ToolStripButton bindingNavigatorDeleteItem;
        private ToolStripButton bindingNavigatorMoveFirstItem;
        private ToolStripButton bindingNavigatorMovePreviousItem;
        private ToolStripSeparator bindingNavigatorSeparator;
        private ToolStripTextBox bindingNavigatorPositionItem;
        private ToolStripSeparator bindingNavigatorSeparator1;
        private ToolStripButton bindingNavigatorMoveNextItem;
        private ToolStripButton bindingNavigatorMoveLastItem;
        private ToolStripSeparator bindingNavigatorSeparator2;
    }
}
