// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Text;
using nMars.RedCode;

namespace nMars.Parser.Warrior
{
    [Serializable]
    public class ExtendedInstruction : Instruction, IExtendedInstruction
    {
        public ExtendedInstruction()
        {
        }

        public ExtendedInstruction(Operation operation, Modifier modifier, Mode modeA, int valueA, Mode modeB,
                                   int valueB)
            : base(operation, modifier, modeA, valueA, modeB, valueB)
        {
        }


        public ExtendedInstruction(Instruction src)
            : base(src)
        {
        }

        public override string GetLine(DumpOptions options, bool start)
        {
            StringBuilder sb = new StringBuilder();
            if (options.Offset)
            {
                sb.Append(Address.ToString("00 "));
            }

            if (options.Labels)
            {
                sb.Append(Label.PadRight(12));
                sb.Append(" ");
            }
            else
            {
                if (start)
                {
                    sb.Append("START  ");
                }
                else
                {
                    sb.Append("       ");
                }
            }

            sb.Append(ToString());
            if (options.Comments)
            {
                if (Comment.Length > 0)
                {
                    sb.Append("  ;");
                    sb.Append(Comment);
                }
            }
            return sb.ToString();
        }

        string IExtendedInstruction.Label
        {
            get { return Label; }
        }

        string IExtendedInstruction.Comment
        {
            get { return Comment; }
        }

        public int Address;
        public string Label;
        public string Comment;
        public string OriginalInstruction;
    }
}