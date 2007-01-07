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

        private void DebugCoreGrid_MouseClick(object sender, MouseEventArgs e)
        {

            int address = GetAddress(e.X, e.Y);
            if (address == -1)
                return;
            Application.ShowAddress(address);

        }

        private void DebugCoreGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int address = GetAddress(e.X, e.Y);
            if (address == -1)
                return;
            Application.EditCell(address);

        }
    }
}
