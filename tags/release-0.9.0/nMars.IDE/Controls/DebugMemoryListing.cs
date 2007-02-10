// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Windows.Forms;
using nMars.IDE.Controls;
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
            CoreListView view = new CoreListView(IDEApplication.Instance.Engine);
            coreList.View = view;
            coreList.Attach(IDEApplication.Instance.Engine);
            CoreSize = IDEApplication.Instance.Engine.CoreSize;
            ShowAddress(0);
        }

        private int CoreSize;

        public override void Detach()
        {
            coreList.Detach();
            base.Detach();
        }

        public void RepaintView()
        {
            IRunningInstruction instruction = IDEApplication.Instance.Engine.NextInstruction;
            int nextAddress;
            if (instruction == null)
            {
                nextAddress = -1;
            }
            else
            {
                nextAddress = instruction.Address;
            }
            if (checkBoxAutoIP.Checked)
            {
                coreList.TopIndex = nextAddress + CoreSize / 2 - 5;
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
            coreList.TopIndex = address + CoreSize / 2 - 5;
        }

        private void ShowAddress()
        {
            int address;
            if (int.TryParse(maskedTextBoxAddress.Text, out address))
            {
                if (checkBoxRelative.Checked)
                {
                    //relative to current instruction
                    address += IDEApplication.Instance.Engine.NextInstruction.Address;
                }
                coreList.MarkedAddress = address;
                coreList.TopIndex = address + CoreSize / 2 - 5;
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

