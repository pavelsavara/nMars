using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using nMars.RedCode;

namespace nMars.IDE.Controls
{
    public partial class DebugWarriorOverview : UserControl
    {
        public DebugWarriorOverview()
        {
            InitializeComponent();
        }

        public void Attach(TableLayoutPanel panel, int aWarriorIndex)
        {
            Dock = DockStyle.Fill;
            warriorIndex = aWarriorIndex;
            panel.Controls.Add(this, aWarriorIndex, 0);
            groupBox.Text = Application.ActiveEngine.Warriors[aWarriorIndex].Name;
        }

        public void WatchCore()
        {
            IRunningWarrior rw = Application.ActiveEngine.RunningWarriors[warriorIndex];
            textBoxTasks.Text = rw.TasksCount.ToString() + "/" + rw.DeadTasksCount.ToString();
            textBoxLastInstruction.Text = rw.PrevInstruction.ToString();
            int maxItems = int.MaxValue;
            if (!Application.ActiveEngine.IsPaused)
            {
                maxItems = listBoxNextInstructions.Height / listBoxNextInstructions.ItemHeight;                
            }
            listBoxNextInstructions.BeginUpdate();
            listBoxNextInstructions.Items.Clear();
            for (int t = 0; t < rw.Tasks.Count && t < maxItems; t++)
            {
                IRunningInstruction ri = Application.ActiveEngine[rw.Tasks[t]];
                listBoxNextInstructions.Items.Add(ri.ToString());
            }
            listBoxNextInstructions.EndUpdate();
        }

        private int warriorIndex;
    }
}
