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
    public partial class DebugMemoryGraph : nMars.IDE.Controls.IDEFrame
    {
        public DebugMemoryGraph()
        {
            InitializeComponent();
        }

        public void WatchCore()
        {
            Invalidate();
        }

        public override void Attach(TabControl aFrame, string name)
        {
            base.Attach(aFrame, name);
            coresize = Application.ActiveEngine.CoreSize;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //empty
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaint(e);

            int left = e.ClipRectangle.Left / cellxsize;
            int right = (e.ClipRectangle.Right / cellxsize) + 1;
            int top = e.ClipRectangle.Top / cellysize;
            int bottom = (e.ClipRectangle.Bottom / cellysize) + 1;
            if (right > columns)
                right = columns;
            if (bottom > rows)
                bottom = rows;

            for (int c = left; c < right; c++)
            {
                for (int r = top; r < bottom; r++)
                {
                    int address = c * columns + r;

                    IRunningInstruction ri = Application.ActiveEngine[address];
                    Pen pen;
                    switch (ri.Operation)
                    {
                        case Operation.MOV:
                            pen = Pens.White;
                            break;
                        case Operation.DAT:
                            pen = Pens.Black;
                            break;
                        default:
                            pen = Pens.Red;
                            break;
                    }
                    e.Graphics.DrawRectangle(pen, c * cellxsize, r * cellysize, 2, 2);
                }
            }
        }

        const int columns = 100;
        const int rows = 80;
        const int cellxsize = 4;
        const int cellysize = 4;
        private int coresize;
    }
}

