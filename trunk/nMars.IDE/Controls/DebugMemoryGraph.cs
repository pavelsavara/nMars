// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Drawing;
using System.Windows.Forms;
using nMars.RedCode;

namespace nMars.IDE.Controls
{
    public partial class DebugMemoryGraph : IDEFrame
    {
        public DebugMemoryGraph()
        {
            InitializeComponent();
            InitColors();
        }

        #region Events

        public void WatchCore()
        {
            PaintChanges();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //empty
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            CoreEventsLevel[] levels = Application.ActiveEngine.EventLevels;
            InstructionEvent[] events = Application.ActiveEngine.Events;
            IRunningWarrior[] eventWarriors = Application.ActiveEngine.EventWarriors;
            int left = e.ClipRectangle.Left / gridx;
            int right = (e.ClipRectangle.Right / gridx) + 1;
            int top = e.ClipRectangle.Top / gridy;
            int bottom = (e.ClipRectangle.Bottom / gridy) + 1;
            if (right > columns)
                right = columns;
            if (bottom > rows)
                bottom = rows;

            for (int c = left; c < right; c++)
            {
                for (int r = top; r < bottom; r++)
                {
                    PaintCell(e.Graphics, c, r, events, levels, eventWarriors, true);
                }
            }
        }

        private void PaintChanges()
        {
            CoreEventsLevel[] levels = Application.ActiveEngine.EventLevels;
            InstructionEvent[] events = Application.ActiveEngine.Events;
            IRunningWarrior[] eventWarriors = Application.ActiveEngine.EventWarriors;
            Graphics g = CreateGraphics();
            for (int c = 0; c < columns; c++)
            {
                for (int r = 0; r < rows; r++)
                {
                    PaintCell(g, c, r, events, levels, eventWarriors, false);
                }
            }
            g.Dispose();
        }

        #endregion

        private void PaintCell(Graphics g, int column, int row, InstructionEvent[] events, CoreEventsLevel[] levels,IRunningWarrior[] eventWarriors,
                               bool paintNone)
        {
            int address = column + row * columns;
            CoreEventsLevel level = levels[address];
            switch (level)
            {
                case CoreEventsLevel.Flash:
                    PaintFlash(g, column, row, address, events, eventWarriors);
                    levels[address]--;
                    break;
                case CoreEventsLevel.Fade:
                    PaintFade(g, column, row, address, events);
                    levels[address]--;
                    events[address] = InstructionEvent.None;
                    break;
                case CoreEventsLevel.Clean:
                    PaintNormal(g, column, row, address);
                    levels[address]--;
                    break;
                case CoreEventsLevel.None:
                    if (paintNone)
                    {
                        PaintNormal(g, column, row, address);
                    }
                    break;
            }
        }

        private const int columns = 100;
        private const int rows = 80;
        private const int gridx = 6;
        private const int gridy = 6;
        private const int offsetx = 10;
        private const int offsety = 10;

        private void PaintFlash(Graphics g, int column, int row, int address, InstructionEvent[] events, IRunningWarrior[] eventWarriors)
        {
            InstructionEvent evnt = events[address];
            Color ecolor = GetEventColor(evnt);
            DrawSmall(g, new Pen(ecolor), column, row);
            DrawData(g, ecolor, column, row);

            IRunningWarrior warrior = eventWarriors[address];
            DrawBig(g, new Pen(GetWarriorColor(warrior)), column, row);
        }

        private void PaintFade(Graphics g, int column, int row, int address, InstructionEvent[] events)
        {
            InstructionEvent evnt = events[address];
            Color ecolor = GetEventColor(evnt);
            DrawSmall(g, new Pen(ecolor), column, row);
            DrawData(g, ecolor, column, row);
            
            IRunningInstruction ri = Application.ActiveEngine[address];
            IRunningWarrior warrior = ri.OriginalOwner;
            DrawBig(g, new Pen(GetWarriorColor(warrior)), column, row);
        }

        private void PaintNormal(Graphics g, int column, int row, int address)
        {
            IRunningInstruction ri = Application.ActiveEngine[address];
            IRunningWarrior warrior = ri.OriginalOwner;
            DrawBig(g, new Pen(GetWarriorColor(warrior)), column, row);

            Color instColor = GetInstructionColor(ri);
            DrawSmall(g, new Pen(instColor), column, row);
            if (ri.Operation == Operation.DAT 
                && (ri.ValueA != 0 || ri.ValueB != 0))
            {
                DrawData(g, Color.White, column, row);
            }
            else
            {
                DrawData(g, instColor, column, row);
            }
        }

        private Color GetInstructionColor(IRunningInstruction ri)
        {
            return operationColors[(int)ri.Operation];
        }


        private Color GetWarriorColor(IRunningWarrior warrior)
        {
            if (warrior != null)
            {
                return warriorColors[warrior.WarriorIndex % warriorColorsCount];
            }
            else
            {
                return Color.Black;
            }
        }

        private Color GetEventColor(InstructionEvent evnt)
        {
            if ((evnt & InstructionEvent.Read) != 0)
            {
                return flashReadColor;
            }
            else if ((evnt & InstructionEvent.Write) != 0)
            {
                return flashWriteColor;
            }
            else if ((evnt & InstructionEvent.Execute) != 0)
            {
                return flashExecuteColor;
            }
            else if ((evnt & InstructionEvent.Died) != 0)
            {
                return flashDiedColor;
            }
            else
            {
                throw new ApplicationException("Invalid call");
            }
        }

        #region Colors & Helpers

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

        private static void DrawSmall(Graphics g, Pen pen, int column, int row)
        {
            g.DrawRectangle(pen, offsetx + (column * gridx) + 1, offsety + (row * gridy) + 1, 2, 2);
        }

        private static void DrawBig(Graphics g, Pen pen, int column, int row)
        {
            g.DrawRectangle(pen, offsetx + (column * gridx), offsety + (row * gridy), 4, 4);
            if (pen.Color == Color.Black)
            {
                DrawGrid(g, column, row);
            }
        }


        private void InitColors()
        {
            operationColors = new Color[OperationHelper.OperationCount];
            operationColors[(int)Operation.MOV] = Color.WhiteSmoke;
            operationColors[(int)Operation.NOP] = Color.Gray;
            operationColors[(int)Operation.DAT] = Color.Black;
            operationColors[(int)Operation.SPL] = Color.Blue;

            operationColors[(int)Operation.LDP] = Color.DarkSalmon;
            operationColors[(int)Operation.STP] = Color.DarkSalmon;

            operationColors[(int)Operation.ADD] = Color.Violet;
            operationColors[(int)Operation.SUB] = Color.Violet;
            operationColors[(int)Operation.MOD] = Color.Violet;
            operationColors[(int)Operation.DIV] = Color.Violet;
            operationColors[(int)Operation.MUL] = Color.Violet;

            operationColors[(int)Operation.JMP] = Color.DarkGreen;
            operationColors[(int)Operation.JMZ] = Color.DarkGreen;
            operationColors[(int)Operation.JMN] = Color.DarkGreen;
            operationColors[(int)Operation.DJN] = Color.DarkGreen;
            operationColors[(int)Operation.CMP] = Color.DarkGreen;
            operationColors[(int)Operation.SNE] = Color.DarkGreen;
            operationColors[(int)Operation.SLT] = Color.DarkGreen;

            warriorColors = new Color[warriorColorsCount];
            warriorColors[0] = Color.Red;
            warriorColors[1] = Color.Green;
            warriorColors[2] = Color.Blue;
            warriorColors[3] = Color.Yellow;

            flashReadColor = Color.Aquamarine;
            flashWriteColor = Color.Orange;
            flashExecuteColor = Color.DarkSeaGreen;
            flashDiedColor = Color.Cyan;
        }

        private int warriorColorsCount = 4;
        private Color[] warriorColors;
        private Color[] operationColors;
        private Color flashReadColor;
        private Color flashWriteColor;
        private Color flashExecuteColor;
        private Color flashDiedColor;

        #endregion

        private void toolTip_Popup(object sender, PopupEventArgs e)
        {
        }
    }
}