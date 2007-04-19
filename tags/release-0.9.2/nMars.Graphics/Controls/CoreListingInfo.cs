// This file is part of nMars - Core War MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.Windows.Forms;

namespace nMars.Graphics.Controls
{
    public partial class CoreListingInfo : CoreListing
    {
        public CoreListingInfo()
        {
            InitializeComponent();
        }

        private void CoreListingInfo_MouseMove(object sender, MouseEventArgs e)
        {
            if (engine == null)
                return;

            int index = (e.Y / ItemHeight) + TopIndex;
            lock (engine)
            {
                if (index < 0 || index >= View.Count)
                {
                    toolTip.SetToolTip(this, "");
                }
                else
                {
                    int address = View[index];
                    toolTip.SetToolTip(this, MemoryPainter.GetMemoryTooltip(engine, address));
                }
            }
        }
    }
}
