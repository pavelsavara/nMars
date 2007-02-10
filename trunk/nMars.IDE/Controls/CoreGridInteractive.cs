// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.Windows.Forms;
using nMars.Graphics.Controls;

namespace nMars.IDE.Controls
{
    public partial class CoreGridInteractive : CoreGridInfo
    {
        public CoreGridInteractive()
        {
            InitializeComponent();
        }

        private void CoreGridInteractive_MouseClick(object sender, MouseEventArgs e)
        {
            int address = GetAddress(e.X, e.Y);
            if (address == -1)
                return;
            IDEApplication.Instance.ShowAddress(address);
        }

        private void CoreGridInteractive_DoubleClick(object sender, MouseEventArgs e)
        {
            int address = GetAddress(e.X, e.Y);
            if (address == -1)
                return;
            IDEApplication.Instance.EditCell(address);
        }
    }
}
