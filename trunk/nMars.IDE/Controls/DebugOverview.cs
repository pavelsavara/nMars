using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace nMars.IDE.Controls
{
    public partial class DebugOverview : nMars.IDE.Controls.IDEFrame
    {
        public DebugOverview()
        {
            InitializeComponent();
        }

        public void WatchCore()
        {
            textBoxCycle.Text = Application.ActiveEngine.Cycles.ToString() + "/" +
                                Application.ActiveEngine.CyclesLeft.ToString();
            textBoxRound.Text = Application.ActiveEngine.Round.ToString() + "/" +
                                Application.ActiveSolution.ActiveProject.Rules.Rounds;
        }
    }
}

