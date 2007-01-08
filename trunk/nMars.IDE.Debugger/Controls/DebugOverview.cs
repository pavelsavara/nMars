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
            warriorsCount = IDEDebuggerApplication.Instance.ActiveEngine.WarriorsCount;
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
            textBoxCycle.Text = IDEDebuggerApplication.Instance.ActiveEngine.Cycles + "/" +
                                IDEDebuggerApplication.Instance.ActiveEngine.CyclesLeft;
            textBoxRound.Text = IDEDebuggerApplication.Instance.ActiveEngine.Round + "/" +
                                IDEDebuggerApplication.Instance.ActiveEngine.Project.Rules.Rounds;
            textBoxLive.Text = IDEDebuggerApplication.Instance.ActiveEngine.LiveWarriorsCount + "/" +
                               IDEDebuggerApplication.Instance.ActiveEngine.TasksCount;

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

