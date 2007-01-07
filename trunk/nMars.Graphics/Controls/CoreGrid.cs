// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Drawing;
using System.Windows.Forms;
using nMars.RedCode;

namespace nMars.Graphics.Controls
{
    public partial class CoreGrid : UserControl, ICoreWatch, IMemoryPainter
    {
        public CoreGrid()
        {
            InitializeComponent();
        }

        public int GetAddress(int x, int y)
        {
            column = (x - offsetx) / gridx;
            row = (y - offsety) / gridy;
            int address;
            if (column < 0 || column >= columns || row < 0 || row >= rows)
            {
                address = -1;
            }
            else
            {
                address = column + row * columns;
            }
            return address;
        }

        #region Painting

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //empty
        }

        /// <summary>
        /// Paint region
        /// </summary>
        protected override void OnPaint(PaintEventArgs e)
        {
            graphics = e.Graphics;

            int left = (e.ClipRectangle.Left - offsetx) / gridx;
            int right = ((e.ClipRectangle.Right - offsetx) / gridx) + 1;
            int top = (e.ClipRectangle.Top - offsety) / gridy;
            int bottom = ((e.ClipRectangle.Bottom - offsety) / gridy) + 1;
            if (left < 0)
                left = 0;
            if (top < 0)
                top = 0;
            if (right > columns)
                right = columns;
            if (bottom > rows)
                bottom = rows;

            if (engine != null)
            {
                lock (engine)
                {
                    CoreEventRecord[] events = engine.CoreEvents;
                    for (column = left; column < right; column++)
                    {
                        for (row = top; row < bottom; row++)
                        {
                            int address = column + (row * columns);
                            IRunningInstruction ri = engine[address];
                            MemoryPainter.PaintCell(this, events[address], ri, true);
                        }
                    }
                }
            }
            else
            {
                for (column = left; column < right; column++)
                {
                    for (row = top; row < bottom; row++)
                    {
                        ((IMemoryPainter)this).DrawGrid();
                    }
                }
            }
        }

        /// <summary>
        /// Paint changes only
        /// </summary>
        private void PaintChanges()
        {
            CoreEventRecord[] events = engine.CoreEvents;
            graphics = CreateGraphics();
            for (column = 0; column < columns; column++)
            {
                for (row = 0; row < rows; row++)
                {
                    int address = column + (row * columns);
                    IRunningInstruction ri = engine[address];
                    MemoryPainter.PaintCell(this, events[address], ri, false);
                }
            }
            graphics.Dispose();
        }

        #endregion

        #region ICoreWatch Members

        public void Attach(IAsyncEngine aEngine)
        {
            engine = aEngine;
            coreSize = engine.Project.Rules.CoreSize;
        }

        public void Detach()
        {
            engine = null;
        }

        public void RepaintView()
        {
            PaintChanges();
        }

        #endregion

        #region IMemoryPainter Members

        void IMemoryPainter.DrawData(Color color)
        {
            graphics.FillRectangle(new SolidBrush(color), offsetx + (column * gridx) + 2, offsety + (row * gridy) + 2, 1,
                                   1);
        }

        void IMemoryPainter.DrawGrid()
        {
            if (column % 10 == 0 || row % 10 == 0)
            {
                graphics.FillRectangle(Brushes.Brown, offsetx + (column * gridx), offsety + (row * gridy), 1, 1);
            }
            else if (column % 5 == 0 || row % 5 == 0)
            {
                graphics.FillRectangle(Brushes.DarkGoldenrod, offsetx + (column * gridx), offsety + (row * gridy), 1, 1);
            }
        }

        void IMemoryPainter.DrawSmall(Color color)
        {
            graphics.DrawRectangle(new Pen(color), offsetx + (column * gridx) + 1, offsety + (row * gridy) + 1, 2, 2);
        }

        void IMemoryPainter.DrawBig(Color color)
        {
            graphics.DrawRectangle(new Pen(color), offsetx + (column * gridx), offsety + (row * gridy), 4, 4);
            if (color == Color.Black)
            {
                ((IMemoryPainter)this).DrawGrid();
            }
        }

        #endregion

        #region Events

        private void CoreGrid_ClientSizeChanged(object sender, EventArgs e)
        {
            columns = (Width / (gridx * 10)) * 10;
            if (columns < 50)
                columns = 50;
            if (columns > 150)
                columns = 150;
            rows = coreSize / columns;
        }

        #endregion

        #region Variables

        protected IAsyncEngine engine = null;
        private System.Drawing.Graphics graphics;
        protected int column;
        protected int row;

        protected int columns = 100;
        protected int rows = 80;
        protected int coreSize = 8000;
        protected const int gridx = 6;
        protected const int gridy = 6;

        protected const int offsetx = 10;
        protected const int offsety = 10;

        #endregion
    }
}
