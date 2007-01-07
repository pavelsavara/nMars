using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using nMars.RedCode;

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
                ICoreBindingList list = (ICoreBindingList)DataSource;
                if (index < 0 || index >= list.Count)
                {
                    toolTip.SetToolTip(this, "");
                }
                else
                {
                    CoreCellHelper item = (CoreCellHelper)list[index];
                    toolTip.SetToolTip(this, MemoryPainter.GetTooltip(engine, item.Instruction.Address));
                }
            }
        }
    }
}
