// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace nMars.IDE.Controls
{
    public partial class DebugOverview : IDEFrame, IDebugWatch
    {
        public DebugOverview()
        {
            InitializeComponent();
        }

        public override void Attach(TabControl aFrame, string name)
        {
            tableLayoutPanel.SuspendLayout();
            warriorsCount = Application.ActiveEngine.WarriorsCount;
            tableLayoutPanel.ColumnCount = warriorsCount;
            tableLayoutPanel.ColumnStyles.Clear();
            for (int w = 0; w < warriorsCount;w++ )
            {
                tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F / warriorsCount));
                DebugWarriorOverview dwo = new DebugWarriorOverview();
                dwo.Attach(tableLayoutPanel, w);
                dwoList.Add(dwo);
            }
            base.Attach(aFrame, name);
            tableLayoutPanel.ResumeLayout();
        }

        public void WatchCore()
        {
            textBoxCycle.Text = Application.ActiveEngine.Cycles.ToString() + "/" +
                                Application.ActiveEngine.CyclesLeft.ToString();
            textBoxRound.Text = Application.ActiveEngine.Round.ToString() + "/" +
                                Application.ActiveEngine.Project.Rules.Rounds;
            textBoxLive.Text = Application.ActiveEngine.LiveWarriorsCount + "/" +
                               Application.ActiveEngine.TasksCount;

            for (int w = 0; w < warriorsCount; w++)
            {
                dwoList[w].WatchCore();
            }
        }

        public void Resume()
        {
        }

        public void Pause()
        {
        }

        private int warriorsCount;
        private List<DebugWarriorOverview> dwoList = new List<DebugWarriorOverview>();
    }
}

