// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.ComponentModel;
using nMars.Graphics.Controls;
using nMars.RedCode;

namespace nMars.IDE.Controls
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
            CoreCellHelper item = (CoreCellHelper)((ICoreBindingList)DataSource)[index];
            Application.EditCell(item.Instruction.Address);
        }

        private void CoreListingInteractive_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (engine == null)
                return;

            int index = (e.Y / ItemHeight) + TopIndex;
            CoreCellHelper item = (CoreCellHelper)((ICoreBindingList)DataSource)[index];
            Application.ShowAddress(item.Instruction.Address);
        }
    }
}
