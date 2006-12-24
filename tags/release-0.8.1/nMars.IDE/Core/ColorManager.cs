// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Drawing;
using nMars.RedCode;

namespace nMars.IDE
{
    public class ColorManager
    {
        static ColorManager()
        {
            InitColors();
        }

        public static void GetFlash(CoreEventRecord evt, out Color evnt, out Color touched)
        {
            evnt = GetEventColor(evt.Event);
            touched = GetWarriorColor(evt.Touched);
        }

        public static void GetFade(IRunningInstruction ri, CoreEventRecord evt, out Color evnt, out Color owner)
        {
            evnt = GetEventColor(evt.Event);
            owner = GetWarriorColor(ri.OriginalOwner);
        }

        public static void GetNormal(IRunningInstruction ri, out Color data, out Color instruction, out Color owner)
        {
            instruction = GetInstructionColor(ri);
            data = GetDataColor(ri);
            owner = GetWarriorColor(ri.OriginalOwner);
        }

        public static Color GetDataColor(IRunningInstruction ri)
        {
            if (ri.Operation == Operation.DAT && (ri.ValueA != 0 || ri.ValueB != 0))
            {
                return Color.White;
            }
            else
            {
                return GetInstructionColor(ri);
            }
        }

        public static Color GetInstructionColor(IRunningInstruction ri)
        {
            return operationColors[(int)ri.Operation];
        }


        public static Color GetWarriorColor(IRunningWarrior warrior)
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

        public static Color GetEventColor(InstructionEvent evnt)
        {
            if ((evnt & InstructionEvent.Write) != 0)
            {
                return flashWriteColor;
            }
            else if ((evnt & InstructionEvent.Died) != 0)
            {
                return flashDiedColor;
            }
            else if ((evnt & InstructionEvent.Execute) != 0)
            {
                return flashExecuteColor;
            }
            else if ((evnt & InstructionEvent.Read) != 0)
            {
                return flashReadColor;
            }
            else
            {
                throw new ApplicationException("Invalid call");
            }
        }

        private static void InitColors()
        {
            operationColors = new Color[OperationHelper.OperationCount];
            operationColors[(int)Operation.MOV] = Color.Gray;
            operationColors[(int)Operation.NOP] = Color.DarkGray;
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
            warriorColors[1] = Color.LightGreen;
            warriorColors[2] = Color.LightBlue;
            warriorColors[3] = Color.LightYellow;

            flashReadColor = Color.Aquamarine;
            flashWriteColor = Color.Orange;
            flashExecuteColor = Color.DarkSeaGreen;
            flashDiedColor = Color.Cyan;
        }

        private static int warriorColorsCount = 4;
        private static Color[] warriorColors;
        private static Color[] operationColors;
        private static Color flashReadColor;
        private static Color flashWriteColor;
        private static Color flashExecuteColor;
        private static Color flashDiedColor;
    }
}
