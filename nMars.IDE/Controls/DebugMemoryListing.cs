// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using nMars.RedCode;

namespace nMars.IDE.Controls
{
    public partial class DebugMemoryListing : nMars.IDE.Controls.IDEFrame
    {
        public DebugMemoryListing()
        {
            InitializeComponent();
        }

        public override void Attach(TabControl aFrame, string name)
        {
            base.Attach(aFrame, name);
            coresize = Application.ActiveEngine.CoreSize;
            listBoxMemory.DataSource = data;
        }

        public void WatchCore()
        {
            nextAddress = Application.ActiveEngine.NextInstruction.Address;
            int maxItems = listBoxMemory.Height / listBoxMemory.ItemHeight;
            if (maxItems > coresize || Application.ActiveEngine.IsPaused)
            {
                maxItems = coresize;
            }
            if (!Application.ActiveEngine.IsPaused)
            {
                markedIndex = -1;
            }
            maskedTextBoxAddress.Enabled = Application.ActiveEngine.IsPaused;
            listBoxMemory.BeginUpdate();
            data = new string[maxItems];
            //listBoxMemory.Items.Clear();
            for (int a = 0; a < maxItems; a++)
            {
                int adr = (a - offset + nextAddress + coresize) % coresize;
                IRunningInstruction ri = Application.ActiveEngine[adr];
                data[a] = ri.ToString();
                //listBoxMemory.Items.Add(ri.ToString());
            }
            listBoxMemory.DataSource = data;
            listBoxMemory.EndUpdate();
        }

        private const int offset = 5;
        private int nextAddress;
        private int coresize;
        private int markedIndex=-1;
        private string[] data=new string[0];

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

        private void ShowAddress()
        {
            int addr;
            if (int.TryParse(maskedTextBoxAddress.Text, out addr))
            {
                listBoxMemory.BeginUpdate();
                int index = (addr + offset + coresize);
                if (!checkBoxRelative.Checked)
                {
                    index -= nextAddress;
                }
                markedIndex = (index % coresize);
                index = markedIndex - offset;
                if (index < 0) //because of offset
                    index = 0;
                listBoxMemory.TopIndex = index;
                listBoxMemory.EndUpdate();
            }
        }

        private void listBoxMemory_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index != -1)
            {
                e.DrawBackground();
                Brush myBrush = Brushes.Black;

                if (e.Index == offset)
                {
                    myBrush = Brushes.Red;
                }
                if (e.Index == markedIndex)
                {
                    myBrush = Brushes.Blue;
                }

                e.Graphics.DrawString(((ListBox)sender).Items[e.Index].ToString(), e.Font, myBrush, e.Bounds,
                                      StringFormat.GenericDefault);
                e.DrawFocusRectangle();
            }
        }
    }
}

