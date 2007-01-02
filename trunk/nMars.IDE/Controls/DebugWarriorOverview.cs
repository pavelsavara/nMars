// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

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
            groupBox.Text = Application.ActiveEngine.Warriors[aWarriorIndex].Name + " by " +
                            Application.ActiveEngine.Warriors[aWarriorIndex].Author;
        }

        public void WatchCore()
        {
            IRunningWarrior rw = Application.ActiveEngine.RunningWarriors[warriorIndex];
            textBoxTasks.Text = rw.TasksCount.ToString() + "/" + rw.DeadTasksCount.ToString();
            if (rw.PrevInstruction != null)
                textBoxLastInstruction.Text = rw.PrevInstruction.ToString();
            else
                textBoxLastInstruction.Text = null;
            int maxItems = int.MaxValue;
            if (!Application.ActiveEngine.IsPaused)
            {
                maxItems = listBoxNextInstructions.Height / listBoxNextInstructions.ItemHeight;                
            }
            listBoxNextInstructions.BeginUpdate();
            listBoxNextInstructions.Items.Clear();
            IEnumerator<int> enumerator = rw.Tasks.GetEnumerator();
            for (int t = 0; t < maxItems; t++)
            {
                if (enumerator.MoveNext())
                {
                    IRunningInstruction ri = Application.ActiveEngine[enumerator.Current];
                    listBoxNextInstructions.Items.Add(ri.ToString());
                }
                else
                {
                    break;
                }
            }
            listBoxNextInstructions.EndUpdate();
        }

        private int warriorIndex;
    }
}
