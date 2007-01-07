// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.Drawing;
using System.Text;
using nMars.RedCode;

namespace nMars.Graphics
{
    public interface IMemoryPainter
    {
        void DrawData(Color color);
        void DrawGrid();
        void DrawSmall(Color color);
        void DrawBig(Color color);
    }

    public class MemoryPainter
    {
        public static string GetTooltip(IAsyncEngine engine, int address)
        {
            IRunningInstruction instruction = engine[address]; 
            CoreEventRecord evnt = engine.CoreEvents[address];

            StringBuilder tooltipText = new StringBuilder(200);
            IRunningWarrior owner = instruction.OriginalOwner;
            IInstruction source = instruction.OriginalInstruction;
            tooltipText.Append(instruction.ToString());
            if (source != null)
            {
                tooltipText.Append("\nCopy from: ");
                if (owner != null)
                {
                    tooltipText.Append(owner.Name);
                    tooltipText.Append("\n");
                }
                tooltipText.Append(source.GetLine(ParserOptions.Full, false).Trim());
            }

            //dead
            if ((evnt.Event & InstructionEvent.Died) != 0)
            {
                if (evnt.Died!=null)
                {
                    tooltipText.Append("\n");
                    tooltipText.Append("Died: ");
                    tooltipText.Append(evnt.Died.Name);
                }
                else
                {
                    tooltipText.Append("\nDied");
                }
            }
            else if (evnt.Died!=null)
            {
                tooltipText.Append("\nLast death: ");
                tooltipText.Append(evnt.Died.Name);
            }

            //exec
            if ((evnt.Event & InstructionEvent.Executed) != 0)
            {
                if (evnt.Executed != null)
                {
                    tooltipText.Append("\nExecuted by: ");
                    tooltipText.Append(evnt.Executed.Name);
                }
                else
                {
                    tooltipText.Append("\nExecuted");
                }
            }
            else if (evnt.Executed != null)
            {
                tooltipText.Append("\nLast execution by: ");
                tooltipText.Append(evnt.Executed.Name);
            }

            //write instruction
            if ((evnt.Event & InstructionEvent.WrittenInstruction) != 0)
            {
                tooltipText.Append("\nInstruction written by: ");
                tooltipText.Append(evnt.WrittenInstruction.Name);
            }
            else if (evnt.WrittenInstruction != null)
            {
                tooltipText.Append("\nInstruction last written by: ");
                tooltipText.Append(evnt.WrittenInstruction.Name);
            }

            //write data
            if ((evnt.Event & InstructionEvent.WrittenData) != 0)
            {
                tooltipText.Append("\nData written by: ");
                tooltipText.Append(evnt.WrittenData.Name);
            }
            else if (evnt.WrittenData != null)
            {
                tooltipText.Append("\nData last written by: ");
                tooltipText.Append(evnt.WrittenData.Name);
            }

            //read
            if ((evnt.Event & InstructionEvent.Read) != 0)
            {
                tooltipText.Append("\nRead by: ");
                tooltipText.Append(evnt.Read.Name);
            }
            else if (evnt.Read != null)
            {
                tooltipText.Append("\nLast read by: ");
                tooltipText.Append(evnt.Read.Name);
            }

            //tasks
            foreach (IRunningWarrior warrior in engine.LiveWarriors)
            {
                bool found = false;
                int index = 0;
                int count = 0;
                foreach (int task in warrior.Tasks)
                {
                    if (task == address)
                    {
                        if (!found)
                        {
                            found = true;
                            tooltipText.Append("\nIn task queue of: ");
                            tooltipText.Append(warrior.Name);
                            tooltipText.Append(" at");
                        }
                        tooltipText.Append(" ");
                        tooltipText.Append(index.ToString());
                        count++;
                    }
                    index++;
                    if (count > 10)
                    {
                        tooltipText.Append(" ...");
                        break;
                    }
                }
            }

            return tooltipText.ToString();
        }

        public static void PaintCell(IMemoryPainter painter, CoreEventRecord evnt, IRunningInstruction ri, bool paintAll)
        {
            switch (evnt.Level)
            {
                case CoreEventsLevel.Flash:
                    PaintFlash(painter,evnt);
                    break;
                case CoreEventsLevel.Fade:
                    PaintFade(painter, ri, evnt);
                    break;
                case CoreEventsLevel.Clean:
                    PaintNormal(painter, ri);
                    break;
                case CoreEventsLevel.None:
                    if (paintAll)
                    {
                        PaintNormal(painter, ri);
                    }
                    break;
            }
        }

        private static void PaintFlash(IMemoryPainter painter, CoreEventRecord evt)
        {
            Color evnt;
            Color touched;
            ColorManager.GetFlash(evt, out evnt, out touched);

            painter.DrawSmall(evnt);
            painter.DrawBig(touched);
            painter.DrawData(evnt);
        }


        private static void PaintFade(IMemoryPainter painter, IRunningInstruction ri, CoreEventRecord evt)
        {
            Color evnt;
            Color owner;
            ColorManager.GetFade(ri, evt, out evnt, out owner);

            painter.DrawSmall(evnt);
            painter.DrawBig(owner);
            painter.DrawData(evnt);
        }

        private static void PaintNormal(IMemoryPainter painter, IRunningInstruction ri)
        {
            Color data;
            Color instruction;
            Color owner;
            ColorManager.GetNormal(ri, out data, out instruction, out owner);

            painter.DrawBig(owner);
            painter.DrawSmall(instruction);
            painter.DrawData(data);
        }
    }
}
