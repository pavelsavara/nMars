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

namespace nMars.Graphics.Controls
{
    public partial class CoreListing : ListBox, ICoreWatch, IMemoryPainter
    {
        public CoreListing()
        {
            InitializeComponent();
        }

        #region ICoreWatch Members

        public void Attach(IAsyncEngine aEngine)
        {
            engine = aEngine;
            TopIndex = engine.CoreSize / 2;
        }

        public void Detach()
        {
            engine = null;
            DataSource = null;
        }

        public void RepaintView()
        {
            nextAddress = (engine.NextInstruction.Address % engine.CoreSize) + (engine.CoreSize / 2);
            ((ICoreBindingList)DataSource).InvalidateEvents();
        }

        public void FocusAddress(int address)
        {
            markedIndex = (address % engine.CoreSize) + (engine.CoreSize / 2);
            ((ICoreBindingList)DataSource).Invalidate(nextAddress);
            ((ICoreBindingList)DataSource).Invalidate(markedIndex);
            TopIndex = markedIndex - 5;
        }

        #endregion

        #region IMemoryPainter Members

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

        #endregion

        #region Variables

        protected IAsyncEngine engine = null;

        protected System.Drawing.Graphics graphics;
        protected Rectangle bounds;

        protected const int offsetx = 2;
        protected const int offsety = 3;

        private int nextAddress = -1;
        private int markedIndex = -1;

        [Category("Appearance")]
        [DefaultValue(false)]
        public bool PaintNextAddress
        {
            get { return paintNextAddress; }
            set { paintNextAddress = value; }
        }
        private bool paintNextAddress = false;

        [Category("Appearance")]
        [DefaultValue(false)]
        public bool PaintMarkedIndex
        {
            get { return paintMarkedIndex; }
            set { paintMarkedIndex = value; }
        }
        private bool paintMarkedIndex = false;

        #endregion

        #region Drawing

        private void CoreListing_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index != -1)
            {
                Brush myBrush;

                if (PaintNextAddress && e.Index == nextAddress)
                {
                    e.Graphics.FillRectangle(Brushes.DarkRed, e.Bounds);
                    myBrush = Brushes.White;
                }
                else if (PaintMarkedIndex && e.Index == markedIndex)
                {
                    myBrush = Brushes.Blue;
                }
                else
                {
                    e.Graphics.FillRectangle(Brushes.Black, e.Bounds);
                    myBrush = Brushes.White;
                }
                //e.DrawFocusRectangle();

                if (DataSource!=null && engine!=null)
                {
                    CoreCellHelper cell = (CoreCellHelper)((ListBox)sender).Items[e.Index];
                    graphics = e.Graphics;
                    bounds = e.Bounds;
                    MemoryPainter.PaintCell(this, cell.Event, cell.Instruction, true);
                    Rectangle r = new Rectangle(e.Bounds.X + 10, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height);

                    graphics.DrawString(cell.Instruction.ToString(), e.Font, myBrush, r, StringFormat.GenericDefault);
                }
            }
        }

        #endregion
    }
}
