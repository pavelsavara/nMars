// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using nMars.RedCode;

namespace nMars.Graphics.Controls
{
    public partial class CoreListing : UserControl, ICoreWatch, IMemoryPainter
    {
        public CoreListing()
        {
            InitializeComponent();
        }

        #region ICoreWatch Members

        public void Attach(IAsyncEngine aEngine)
        {
            engine = aEngine;
            scrollBar.Maximum = View.Count;
            font = new Font("Courier New", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
        }

        public void Detach()
        {
            engine = null;
            font.Dispose();
        }

        public void RepaintView()
        {
            if (engine==null)
                return;
            if (engine.NextInstruction!=null)
            {
                nextAddress = engine.NextInstruction.Address;
            }
            else
            {
                nextAddress = -1;
            }
            scrollBar.Maximum = View.Count;
            PaintAll();
        }

        public ICoreBindingView View;
        protected IAsyncEngine engine = null;
        private long maxVersion;

        private int nextAddress = -1;
        public int MarkedAddress = -1;
        public  int TopIndex
        {
            get
            {
                return topIndex;
            }
            set
            {
                if (value<0)
                    value = 0;
                if (value >= View.Count - +maxItems)
                    value = View.Count - +maxItems;

                scrollBar.Value = value;
                topIndex = value;
                PaintAll();
            }
        }

        private int topIndex = 0;
        private int maxItems = 0;

        #endregion

        #region Public Properties

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

        #region Painting

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            //empty
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (View==null)
            {
                e.Graphics.FillRectangle(Brushes.Black, new Rectangle(0, 0, Width, Height));
                return;
            }

            int top = Math.Max((
                e.ClipRectangle.Top - offsety) / ItemHeight, 
                0)
                +topIndex;
            int bottom = Math.Min(Math.Min(
                ((e.ClipRectangle.Bottom - offsety) / ItemHeight) + 1 + topIndex,
                maxItems + topIndex), 
                View.Count);
            graphics = e.Graphics;
            for (int index = top; index < bottom; index++)
            {
                int address = View[index];
                DrawItem(index, address);
            }
            int fill = Height - ((bottom-topIndex) * ItemHeight);
            if (fill > 0)
            {
                graphics.FillRectangle(Brushes.White,
                                       new Rectangle(0, View.Count * ItemHeight, Width - scrollBar.Width, fill));
            }
        }

        /// <summary>
        /// Paint changes only
        /// </summary>
        private void PaintAll()
        {
            graphics = CreateGraphics();

            int bottom = Math.Min(
                maxItems + topIndex,
                View.Count);

            for (int index = topIndex; index < bottom; index++)
            {
                int address = View[index];
                DrawItem(index, address);
            }
            int fill = Height - ((bottom - topIndex) * ItemHeight);
            if (fill > 0)
            {
                graphics.FillRectangle(Brushes.White,
                                       new Rectangle(0, View.Count * ItemHeight, Width - scrollBar.Width, fill));
            }
            graphics.Dispose();
        }

        private void DrawItem(int index, int address)
        {
            bounds = new Rectangle(0, (index - TopIndex) * ItemHeight, Width - scrollBar.Width, ItemHeight);
            Brush myBrush;

            if (PaintNextAddress && address == nextAddress)
            {
                graphics.FillRectangle(Brushes.DarkRed, bounds);
                myBrush = Brushes.White;
            }
            else if (PaintMarkedIndex && address == MarkedAddress)
            {
                graphics.FillRectangle(Brushes.Black, bounds);
                myBrush = Brushes.Blue;
            }
            else
            {
                graphics.FillRectangle(Brushes.Black, bounds);
                myBrush = Brushes.White;
            }

            if (engine != null)
            {
                IRunningInstruction instruction = engine[address];
                CoreEventRecord record = engine.CoreEvents[address];
                MemoryPainter.PaintCell(this, record, instruction, true);
                Rectangle r = new Rectangle(bounds.X + 10, bounds.Y, bounds.Width, bounds.Height);

                graphics.DrawString(instruction.ToString(), font, myBrush, r, StringFormat.GenericDefault);
            }
        }

        private void CoreListing_ClientSizeChanged(object sender, EventArgs e)
        {
            maxItems = Height / ItemHeight;
        }

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

        protected System.Drawing.Graphics graphics;
        protected Rectangle bounds;
        protected Font font;

        protected const int offsetx = 2;
        protected const int offsety = 3;
        public int ItemHeight = 14;

        #endregion

        private void CoreListing_MouseWheel(object sender, MouseEventArgs e)
        {
            TopIndex -= e.Delta / ItemHeight;
        }

        private void scrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            TopIndex = e.NewValue;
        }

        private void CoreListing_MouseEnter(object sender, EventArgs e)
        {
            this.Select();
        }
    }
}
