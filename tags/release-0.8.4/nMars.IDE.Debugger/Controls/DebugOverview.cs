// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.Collections.Generic;
using System.Windows.Forms;
using nMars.IDE.Controls;

namespace nMars.IDE.Debugger.Controls
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
            warriorsCount = IDEDebuggerApplication.Instance.Engine.WarriorsCount;
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
            textBoxCycle.Text = IDEDebuggerApplication.Instance.Engine.Cycles + "/" +
                                IDEDebuggerApplication.Instance.Engine.CyclesLeft;
            textBoxRound.Text = IDEDebuggerApplication.Instance.Engine.Round + "/" +
                                IDEDebuggerApplication.Instance.Engine.Project.Rules.Rounds;
            textBoxLive.Text = IDEDebuggerApplication.Instance.Engine.LiveWarriorsCount + "/" +
                               IDEDebuggerApplication.Instance.Engine.TasksCount;

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

