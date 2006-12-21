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

        public override void Attach(TabControl aFrame, string name)
        {
            base.Attach(aFrame, name);
            coresize = Application.ActiveEngine.CoreSize;
        }

        private int coresize;

        public void WatchCore()
        {
            //IDEFramePanel.Invalidate();
        }

        private const int cellSize = 4;

        private void IDEFramePanel_Paint(object sender, PaintEventArgs e)
        {
            int columns = e.ClipRectangle.Width / cellSize;
            int rows = e.ClipRectangle.Height / cellSize;
            for (int c = 0; c < columns; c++)
            {
                for (int r = 0; r < rows; r++)
                {
                    int address = c * columns + r;
                    if (address == coresize)
                        return;
                    IRunningInstruction ri = Application.ActiveEngine[address];
                    Pen p;
                    switch(ri.Operation)
                    {
                        case Operation.MOV:
                            p = Pens.White;
                            break;
                        case Operation.DAT:
                            p = Pens.Black;
                            break;
                        default:
                            p = Pens.Red;
                            break;
                    }
                    e.Graphics.DrawRectangle(p, c * cellSize, r * cellSize, cellSize - 2, cellSize - 2);
                }
            }
        }
    }
}

