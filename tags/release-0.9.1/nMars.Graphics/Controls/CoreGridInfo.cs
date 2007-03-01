// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.Windows.Forms;

namespace nMars.Graphics.Controls
{
    public partial class CoreGridInfo : CoreGrid
    {
        public CoreGridInfo()
        {
            InitializeComponent();
        }

        private void CoreGridInfo_MouseMove(object sender, MouseEventArgs e)
        {
            int address = GetAddress(e.X, e.Y);
            if (address == -1 || engine == null)
            {
                toolTip.SetToolTip(this, "");
                return;
            }

            lock (engine)
            {
                toolTip.SetToolTip(this, MemoryPainter.GetMemoryTooltip(engine, address));
            }
        }
    }
}
