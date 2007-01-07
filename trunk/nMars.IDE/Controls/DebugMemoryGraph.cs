// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Drawing;
using System.Windows.Forms;
using nMars.Graphics;
using nMars.RedCode;

namespace nMars.IDE.Controls
{
    public partial class DebugMemoryGraph : IDEFrame, IDebugWatch
    {
        #region Init

        public DebugMemoryGraph()
        {
            InitializeComponent();
        }

        public override void Attach(TabControl aFrame, string name)
        {
            base.Attach(aFrame, name);
            coreGrid.Attach(Application.ActiveEngine);
        }

        public override void Detach()
        {
            base.Detach();
            coreGrid.Detach();
        }

        #endregion

        #region IDebugWatch Members

        public void Resume()
        {
        }

        public void Pause()
        {
        }

        public void RepaintView()
        {
            coreGrid.RepaintView();
        }

        #endregion
    }
}