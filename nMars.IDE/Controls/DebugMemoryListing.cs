// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Collections;
using System.Windows.Forms;
using nMars.RedCode;

namespace nMars.IDE.Controls
{
    public partial class DebugMemoryListing : IDEFrame, IDebugWatch
    {
        public DebugMemoryListing()
        {
            InitializeComponent();
        }

        public override void Attach(TabControl aFrame, string name)
        {
            base.Attach(aFrame, name);
            CoreListView view = new CoreListView(Application.ActiveEngine);
            coreList.View = view;
            coreList.Attach(Application.ActiveEngine);
            coreList.TopIndex = Application.ActiveEngine.CoreSize / 2;
        }

        public override void Detach()
        {
            coreList.Detach();
            base.Detach();
        }

        public void RepaintView()
        {
            int nextAddress = Application.ActiveEngine.NextInstruction.Address;
            if (checkBoxAutoIP.Checked)
            {
                coreList.TopIndex = nextAddress + Application.ActiveEngine.CoreSize / 2 - 5;
            }
            coreList.RepaintView();
        }

        public void Resume()
        {
        }

        public void Pause()
        {
        }

        public void ShowAddress(int address)
        {
            checkBoxAutoIP.Checked = false;
            coreList.MarkedAddress = address;
            coreList.TopIndex = address + Application.ActiveEngine.CoreSize / 2 - 5;
        }

        private void ShowAddress()
        {
            int address;
            if (int.TryParse(maskedTextBoxAddress.Text, out address))
            {
                if (checkBoxRelative.Checked)
                {
                    //relative to current instruction
                    address += Application.ActiveEngine.NextInstruction.Address;
                }
                coreList.MarkedAddress = address;
                coreList.TopIndex = address + Application.ActiveEngine.CoreSize / 2 - 5;
            }
        }


        private void maskedTextBoxAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                ShowAddress();
            }
        }

        private void checkBoxRelative_CheckedChanged(object sender, EventArgs e)
        {
            ShowAddress();
        }
    }

    class CoreListView : ICoreBindingView
    {
        private int coreSize;
        private Random r = new Random();

        public CoreListView(IAsyncEngine aEngine)
        {
            coreSize = aEngine.CoreSize;
        }

        public int this[int index]
        {
            get
            {
                return (coreSize + index - (coreSize / 2)) % coreSize;
            }
        }

        public int Count
        {
            get { return coreSize * 2; }
        }

        public bool IsFixedSize
        {
            get { return true; }
        }
    }
}

