// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using nMars.RedCode;

namespace nMars.IDE.Controls
{
    public partial class DebugMemoryListing : IDEFrame, IDebugWatch, IMemoryPainter
    {
        public DebugMemoryListing()
        {
            InitializeComponent();
        }

        public override void Attach(TabControl aFrame, string name)
        {
            base.Attach(aFrame, name);
            listBoxMemory.BeginUpdate();
            helper = new CoreListHelper();
            listBoxMemory.DataSource = helper;
            listBoxMemory.TopIndex = helper.half;
            listBoxMemory.EndUpdate();
        }

        public override void Detach()
        {
            listBoxMemory.DataSource = null;
            base.Detach();
        }

        public void WatchCore()
        {
            listBoxMemory.BeginUpdate();
            nextAddress = (Application.ActiveEngine.NextInstruction.Address % helper.coreSize) + helper.half;
            if (checkBoxAutoIP.Checked)
            {
                Show(Application.ActiveEngine.NextInstruction.Address, false);
            }
            helper.WatchCore();
            listBoxMemory.EndUpdate();
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
            Show(address, true);
        }

        private void Show(int address, bool external)
        {
            listBoxMemory.BeginUpdate();
            markedIndex = address;
            if (!external && checkBoxRelative.Checked)
            {
                markedIndex += Application.ActiveEngine.NextInstruction.Address;
            }
            markedIndex = (markedIndex % helper.coreSize) + helper.half;
            helper.Invalidate(nextAddress);
            helper.Invalidate(markedIndex);
            listBoxMemory.TopIndex = markedIndex - 5;
            listBoxMemory.EndUpdate();
        }

        private void ShowAddress()
        {
            int addr;
            if (int.TryParse(maskedTextBoxAddress.Text, out addr))
            {
                Show(addr, false);
            }
        }

        private CoreListHelper helper;
        private int nextAddress = 0;
        private int markedIndex = -1;

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


        private void listBoxMemory_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index != -1)
            {
                Brush myBrush;

                if (e.Index == nextAddress)
                {
                    e.Graphics.FillRectangle(Brushes.DarkRed, e.Bounds);
                    myBrush = Brushes.White;
                }
                else if (e.Index == markedIndex)
                {
                    myBrush = Brushes.Blue;
                }
                else
                {
                    e.DrawBackground();
                    myBrush = Brushes.White;
                }
                CoreCellHelper cell = (CoreCellHelper)((ListBox)sender).Items[e.Index];
                graphics = e.Graphics;
                bounds = e.Bounds;
                MemoryPainter.PaintCell(this, cell.Event, cell.Instruction, true);
                Rectangle r = new Rectangle(e.Bounds.X + 10, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height);

                e.Graphics.DrawString(cell.Instruction.ToString(), e.Font, myBrush, r, StringFormat.GenericDefault);
                e.DrawFocusRectangle();
            }
        }

        #region Drawing

        private Graphics graphics;
        private Rectangle bounds;

        void IMemoryPainter.DrawData(Color color)
        {
            graphics.FillRectangle(new SolidBrush(color), bounds.X + offsetx + 3, bounds.Y + offsety + 3, 3, 3);
        }

        void IMemoryPainter.DrawSmall(Color color)
        {
            graphics.DrawRectangle(new Pen(color, 2), bounds.X + offsetx + 2, bounds.Y + offsety + 2, 5, 5);
        }

        void IMemoryPainter.DrawBig(Color color)
        {
            graphics.DrawRectangle(new Pen(color, 2), bounds.X + offsetx, bounds.Y + offsety, 9, 9);
        }

        void IMemoryPainter.DrawGrid()
        {
        }

        private const int offsetx = 2;
        private const int offsety = 4;

        #endregion

        private void listBoxMemory_MouseMove(object sender, MouseEventArgs e)
        {
            int index = (e.Y / listBoxMemory.ItemHeight) + listBoxMemory.TopIndex;
            CoreCellHelper item = (CoreCellHelper)helper[index];
            lock (Application.ActiveEngine)
            {
                toolTip.SetToolTip(listBoxMemory, MemoryPainter.GetTooltip(Application.ActiveEngine, item.Instruction.Address));
            }
        }
    }

    internal class CoreCellHelper
    {
        public IRunningInstruction Instruction;
        public CoreEventRecord Event;
    }

    internal class CoreListHelper : IBindingList
    {
        private CoreCellHelper[] cache;

        public CoreListHelper()
        {
            coreSize = Application.ActiveSolution.ActiveProject.Rules.CoreSize;
            half = coreSize / 2;
            cache = new CoreCellHelper[coreSize * 2];
            CoreEventRecord[] records = Application.ActiveEngine.CoreEvents;
            for (int i = 0; i < coreSize * 2; i++)
            {
                cache[i] = new CoreCellHelper();
                cache[i].Event = records[(i + half) % coreSize];
                cache[i].Instruction = Application.ActiveEngine[i + half];
            }
        }

        public void Invalidate(int index)
        {
            change.Invoke(this, new ListChangedEventArgs(ListChangedType.ItemChanged, index));
        }

        public void WatchCore()
        {
            long lmax = maxVersion;
            CoreEventRecord[] records = Application.ActiveEngine.CoreEvents;
            for (int i = 0; i < coreSize * 2; i++)
            {
                CoreEventRecord evn = records[(i + half) % coreSize];
                long ver = evn.Version;
                if (ver > maxVersion)
                {
                    if (ver > lmax)
                    {
                        lmax = ver;
                    }
                    cache[i].Event = evn;
                    cache[i].Instruction = Application.ActiveEngine[i + half];
                    change.Invoke(this, new ListChangedEventArgs(ListChangedType.ItemChanged, i));
                }
            }
            maxVersion = lmax;
        }

        public int coreSize;
        public int half;
        private long maxVersion;
        private ListChangedEventHandler change;

        #region IBindingList

        public event ListChangedEventHandler ListChanged
        {
            add { change += value; }
            remove { change -= value; }
        }

        public bool SupportsChangeNotification
        {
            get { return true; }
        }

        public object this[int index]
        {
            get { return cache[index]; }
            set { throw new NotImplementedException(); }
        }

        public int Count
        {
            get { return coreSize * 2; }
        }

        public bool IsReadOnly
        {
            get { return true; }
        }

        public bool IsFixedSize
        {
            get { return true; }
        }

        public object SyncRoot
        {
            get { return Application.ActiveEngine; }
        }

        public bool IsSynchronized
        {
            get { throw new NotImplementedException(); }
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        #region Not Implemented

        public object AddNew()
        {
            throw new NotImplementedException();
        }

        public void AddIndex(PropertyDescriptor property)
        {
            throw new NotImplementedException();
        }

        public void ApplySort(PropertyDescriptor property, ListSortDirection direction)
        {
            throw new NotImplementedException();
        }

        public int Find(PropertyDescriptor property, object key)
        {
            throw new NotImplementedException();
        }

        public void RemoveIndex(PropertyDescriptor property)
        {
            throw new NotImplementedException();
        }

        public void RemoveSort()
        {
            throw new NotImplementedException();
        }

        public bool AllowNew
        {
            get { return false; }
        }

        public bool AllowEdit
        {
            get { return false; }
        }

        public bool AllowRemove
        {
            get { return false; }
        }

        public bool SupportsSearching
        {
            get { return false; }
        }

        public bool SupportsSorting
        {
            get { return false; }
        }

        public bool IsSorted
        {
            get { throw new NotImplementedException(); }
        }

        public PropertyDescriptor SortProperty
        {
            get { throw new NotImplementedException(); }
        }

        public ListSortDirection SortDirection
        {
            get { throw new NotImplementedException(); }
        }

        public int Add(object value)
        {
            throw new NotImplementedException();
        }

        public bool Contains(object value)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(object value)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, object value)
        {
            throw new NotImplementedException();
        }

        public void Remove(object value)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        #endregion

        #endregion
    }
}

