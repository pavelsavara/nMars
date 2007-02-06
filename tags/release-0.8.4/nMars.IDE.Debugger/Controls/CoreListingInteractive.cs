// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.ComponentModel;
using nMars.Graphics.Controls;

namespace nMars.IDE.Debugger.Controls
{
    public partial class CoreListingInteractive : CoreListingInfo
    {
        public CoreListingInteractive()
        {
            InitializeComponent();
        }

        public CoreListingInteractive(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void CoreListingInteractive_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (engine==null)
                return;

            int index = (e.Y / ItemHeight) + TopIndex;
            int address = View[index];
            IDEDebuggerApplication.Instance.EditCell(address);
        }

        private void CoreListingInteractive_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (engine == null)
                return;

            int index = (e.Y / ItemHeight) + TopIndex;
            int address = View[index];
            IDEDebuggerApplication.Instance.ShowAddress(address);
        }
    }
}
