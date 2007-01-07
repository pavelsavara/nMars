// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.Drawing;
using System.Text;
using System.Windows.Forms;
using nMars.RedCode;

namespace nMars.IDE.Controls
{
    public partial class DebugMemoryGraph : IDEFrame, IDebugWatch, IMemoryPainter
    {
        #region Init

        public DebugMemoryGraph()
        {
            InitializeComponent();
        }

        public override void Attach(TabControl aFrame, string name)
        {
            base.Attach(aFrame, name);
            coreSize = Application.ActiveEngine.Project.Rules.CoreSize;
            columns = (Width / (gridx * 10)) * 10;
            rows = coreSize / columns;
        }

        #endregion

        #region Events

        public void Resume()
        {
        }

        public void Pause()
        {
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //empty
        }

        /// <summary>
        /// Paint region
        /// </summary>
        protected override void OnPaint(PaintEventArgs e)
        {
            CoreEventRecord[] events = Application.ActiveEngine.CoreEvents;
            int left = (e.ClipRectangle.Left-offsetx) / gridx;
            int right = ((e.ClipRectangle.Right-offsetx) / gridx) + 1;
            int top = (e.ClipRectangle.Top-offsety) / gridy;
            int bottom = ((e.ClipRectangle.Bottom-offsety) / gridy) + 1;
            if (left < 0)
                left = 0;
            if (top < 0)
                top = 0;
            if (right > columns)
                right = columns;
            if (bottom > rows)
                bottom = rows;
            graphics = e.Graphics;

            lock (Application.ActiveEngine)
            {
                for (column = left; column < right; column++)
                {
                    for (row = top; row < bottom; row++)
                    {
                        int address = column + (row * columns);
                        IRunningInstruction ri = Application.ActiveEngine[address];
                        MemoryPainter.PaintCell(this, events[address], ri, true);
                    }
                }
            }
        }

        /// <summary>
        /// Paint changes only
        /// </summary>
        public void WatchCore()
        {
            CoreEventRecord[] events = Application.ActiveEngine.CoreEvents;
            graphics = CreateGraphics();
            for (column = 0; column < columns; column++)
            {
                for (row = 0; row < rows; row++)
                {
                    int address = column + (row * columns);
                    IRunningInstruction ri = Application.ActiveEngine[address];
                    MemoryPainter.PaintCell(this,events[address], ri, false);
                }
            }
            graphics.Dispose();
        }

        #endregion

        #region Drawing

        private Graphics graphics;
        private int column;
        private int row;

        void IMemoryPainter.DrawData(Color color)
        {
            graphics.FillRectangle(new SolidBrush(color), offsetx + (column * gridx) + 2, offsety + (row * gridy) + 2, 1, 1);
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

        private const int offsetx = 10;
        private const int offsety = 10;

        #endregion

        #region Mouse

        /// <summary>
        /// Tooltip
        /// </summary>
        private void DebugMemoryGraph_MouseMove(object sender, MouseEventArgs e)
        {
            column = (e.X-offsetx) / gridx;
            row = (e.Y-offsety) / gridy;
            if (column < 0 || column>=columns || row<0 || row>=rows)
                return;
            int address = column + row * columns;
            lock (Application.ActiveEngine)
            {
                toolTip.SetToolTip(this, MemoryPainter.GetTooltip(Application.ActiveEngine, address));
            }
        }



        /// <summary>
        /// Click to show memory
        /// </summary>
        private void DebugMemoryGraph_MouseClick(object sender, MouseEventArgs e)
        {
            column = (e.X-offsetx) / gridx;
            row = (e.Y-offsety) / gridy;
            if (column < 0 || column>=columns || row<0 || row>=rows)
                return;
            int address = column + row * columns;
            Application.ShowAddress(address);
        }

        /// <summary>
        /// Double click to add breakpoint
        /// </summary>
        private void DebugMemoryGraph_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            column = (e.X-offsetx) / gridx;
            row = (e.Y-offsety) / gridy;
            if (column < 0 || column>=columns || row<0 || row>=rows)
                return;
            int address = column + row * columns;
            Application.AddBreakpoint(address);
        }

        #endregion

        #region Variables

        private int columns = 100;
        private int rows = 80;
        private int coreSize = 8000;
        private const int gridx = 6;
        private const int gridy = 6;

        #endregion
    }
}