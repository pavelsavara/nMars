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
    public partial class DebugMemoryGraph : IDEFrame, IDebugWatch
    {
        #region Init

        public DebugMemoryGraph()
        {
            InitializeComponent();
        }

        public override void Attach(TabControl aFrame, string name)
        {
            base.Attach(aFrame, name);
            coreSize = Application.ActiveSolution.ActiveProject.Rules.CoreSize;
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

            lock (Application.ActiveEngine)
            {
                for (int c = left; c < right; c++)
                {
                    for (int r = top; r < bottom; r++)
                    {
                        int address = c + (r * columns);
                        IRunningInstruction ri = Application.ActiveEngine[address];
                        PaintCell(e.Graphics, c, r, events[address], ri, true);
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
            Graphics g = CreateGraphics();
            for (int c = 0; c < columns; c++)
            {
                for (int r = 0; r < rows; r++)
                {
                    int address = c + (r * columns);
                    IRunningInstruction ri = Application.ActiveEngine[address];
                    PaintCell(g, c, r, events[address], ri, false);
                }
            }
            g.Dispose();
        }

        #endregion

        #region Painting Cell

        private static void PaintCell(Graphics g, int column, int row, CoreEventRecord evnt, IRunningInstruction ri, bool paintAll)
        {
            switch (evnt.Level)
            {
                case CoreEventsLevel.Flash:
                    PaintFlash(g, column, row, evnt);
                    break;
                case CoreEventsLevel.Fade:
                    PaintFade(g, column, row, ri, evnt);
                    break;
                case CoreEventsLevel.Clean:
                    PaintNormal(g, column, row, ri);
                    break;
                case CoreEventsLevel.None:
                    if (paintAll)
                    {
                        PaintNormal(g, column, row, ri);
                    }
                    break;
            }
        }

        private static void PaintFlash(Graphics g, int column, int row, CoreEventRecord evt)
        {
            Color evnt;
            Color touched;
            ColorManager.GetFlash(evt, out evnt, out touched);

            DrawSmall(g, evnt, column, row);
            DrawBig(g, touched, column, row);
            DrawData(g, evnt, column, row);
        }


        private static void PaintFade(Graphics g, int column, int row, IRunningInstruction ri, CoreEventRecord evt)
        {
            Color evnt;
            Color owner;
            ColorManager.GetFade(ri, evt, out evnt, out owner);

            DrawSmall(g, evnt, column, row);
            DrawBig(g, owner, column, row);
            DrawData(g, evnt, column, row);
        }

        private static void PaintNormal(Graphics g, int column, int row, IRunningInstruction ri)
        {
            Color data;
            Color instruction;
            Color owner;
            ColorManager.GetNormal(ri, out data, out instruction, out owner);

            DrawBig(g, owner, column, row);
            DrawSmall(g, instruction, column, row);
            DrawData(g, data, column, row);
        }


        #endregion

        #region Drawing

        private static void DrawData(Graphics g, Color color, int column, int row)
        {
            g.FillRectangle(new SolidBrush(color), offsetx + (column * gridx) + 2, offsety + (row * gridy) + 2, 1, 1);
        }

        private static void DrawGrid(Graphics g, int column, int row)
        {
            if (column % 10 == 0 || row % 10 == 0)
            {
                g.FillRectangle(Brushes.Brown, offsetx + (column * gridx), offsety + (row * gridy), 1, 1);
            }
            else if (column % 5 == 0 || row % 5 == 0)
            {
                g.FillRectangle(Brushes.DarkGoldenrod, offsetx + (column * gridx), offsety + (row * gridy), 1, 1);
            }
        }

        private static void DrawSmall(Graphics g, Color color, int column, int row)
        {
            g.DrawRectangle(new Pen(color), offsetx + (column * gridx) + 1, offsety + (row * gridy) + 1, 2, 2);
        }

        private static void DrawBig(Graphics g, Color color, int column, int row)
        {
            g.DrawRectangle(new Pen(color), offsetx + (column * gridx), offsety + (row * gridy), 4, 4);
            if (color == Color.Black)
            {
                DrawGrid(g, column, row);
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
            int column = (e.X-offsetx) / gridx;
            int row = (e.Y-offsety) / gridy;
            if (column < 0 || column>=columns || row<0 || row>=rows)
                return;
            int address = column + row * columns;
            lock (Application.ActiveEngine)
            {
                IRunningInstruction instruction = Application.ActiveEngine[address];
                IRunningWarrior warrior = instruction.OriginalOwner;
                CoreEventRecord evnt = Application.ActiveEngine.CoreEvents[address];
                tooltipText.Length = 0;
                tooltipText.Append(instruction.ToString());
                if (warrior!=null)
                {
                    tooltipText.Append("\r\nfrom ");
                    tooltipText.Append(warrior.Name);
                }
                if (evnt.Event != 0)
                {
                    tooltipText.Append("\r\n");
                    if ((evnt.Event & InstructionEvent.Died) != 0)
                    {
                        tooltipText.Append("Died, ");
                    }
                    if ((evnt.Event & InstructionEvent.Execute) != 0)
                    {
                        tooltipText.Append("Executed, ");
                    }
                    if ((evnt.Event & InstructionEvent.Write) != 0)
                    {
                        tooltipText.Append("Write, ");
                    }
                    if ((evnt.Event & InstructionEvent.Read) != 0)
                    {
                        tooltipText.Append("Read ");
                    }
                    tooltipText.Append("by ");
                    tooltipText.Append(evnt.Touched.Name);
                }
                if (evnt.Executed != null)
                {
                    tooltipText.Append("\r\n last executed by ");
                    tooltipText.Append(evnt.Executed.Name);
                }
                toolTip.SetToolTip(this, tooltipText.ToString());
            }
        }

        private StringBuilder tooltipText=new StringBuilder(200);

        /// <summary>
        /// Click to show memory
        /// </summary>
        private void DebugMemoryGraph_MouseClick(object sender, MouseEventArgs e)
        {
            int column = (e.X-offsetx) / gridx;
            int row = (e.Y-offsety) / gridy;
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
            int column = (e.X-offsetx) / gridx;
            int row = (e.Y-offsety) / gridy;
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