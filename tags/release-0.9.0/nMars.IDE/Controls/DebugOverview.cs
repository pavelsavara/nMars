// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.Collections.Generic;
using System.Windows.Forms;
using nMars.IDE.Controls;

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
            warriorsCount = IDEApplication.Instance.Engine.WarriorsCount;
            tableLayoutPanel.ColumnCount = warriorsCount;
            tableLayoutPanel.ColumnStyles.Clear();
            for (int w = 0; w < warriorsCount;w++ )
            {
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F / warriorsCount));
                DebugWarriorOverview dwo = new DebugWarriorOverview();
                dwo.Attach(tableLayoutPanel, w);
                dwoList.Add(dwo);
            }
            base.Attach(aFrame, name);
            tableLayoutPanel.ResumeLayout();
        }

        public void RepaintView()
        {
            textBoxCycle.Text = IDEApplication.Instance.Engine.Cycle + "/" +
                                IDEApplication.Instance.Engine.CyclesLeft;
            textBoxRound.Text = IDEApplication.Instance.Engine.Round + "/" +
                                IDEApplication.Instance.Engine.Project.Rules.Rounds;
            textBoxLive.Text = IDEApplication.Instance.Engine.LiveWarriorsCount + "/" +
                               IDEApplication.Instance.Engine.TasksCount;

            for (int w = 0; w < warriorsCount; w++)
            {
                dwoList[w].RepaintView();
            }
        }

        public void Resume()
        {
        }

        public void Pause()
        {
            for (int w = 0; w < warriorsCount; w++)
            {
                dwoList[w].RepaintView();
            }
        }

        private int warriorsCount;
        private List<DebugWarriorOverview> dwoList = new List<DebugWarriorOverview>();
    }
}

