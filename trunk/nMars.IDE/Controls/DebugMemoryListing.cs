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
            coreList.BeginUpdate();
            coreList.DataSource = new CoreListHelper(Application.ActiveEngine);
            coreList.Attach(Application.ActiveEngine);
            coreList.EndUpdate();
        }

        public override void Detach()
        {
            coreList.Detach();
            base.Detach();
        }

        public void RepaintView()
        {
            coreList.BeginUpdate();
            int nextAddress = Application.ActiveEngine.NextInstruction.Address;
            if (checkBoxAutoIP.Checked)
            {
                coreList.FocusAddress(nextAddress);
            }
            coreList.RepaintView();
            coreList.EndUpdate();
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
            coreList.BeginUpdate();
            coreList.FocusAddress(address);
            coreList.EndUpdate();
        }

        private void ShowAddress()
        {
            int address;
            if (int.TryParse(maskedTextBoxAddress.Text, out address))
            {
                coreList.BeginUpdate();
                if (checkBoxRelative.Checked)
                {
                    //relative to current instruction
                    address += Application.ActiveEngine.NextInstruction.Address;
                }
                coreList.FocusAddress(address);
                coreList.EndUpdate();
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

    class CoreListHelper : CoreBindingList
    {
        public CoreListHelper(IAsyncEngine aEngine)
            : base(aEngine)
        {
        }

        public override object this[int index]
        {
            get { return cache[((CoreSize + index - (CoreSize / 2)) % CoreSize)]; }
            set { throw new NotImplementedException(); }
        }

        public override int Count
        {
            get { return CoreSize * 2; }
        }

        public override bool IsFixedSize
        {
            get { return true; }
        }

        public override IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

