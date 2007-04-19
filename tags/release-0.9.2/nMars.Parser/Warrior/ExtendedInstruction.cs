// This file is part of nMars - Core War MARS for .NET 
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


        public ExtendedInstruction(ExtendedInstruction src)
            : base(src)
        {
            Address = src.Address;
            Label = src.Label;
            Comment = src.Comment;
            ExpressionA = src.ExpressionA;
            ExpressionB = src.ExpressionB;
            OriginalInstruction = src.OriginalInstruction;
        }

        public ExtendedInstruction(IInstruction src)
            : base(src)
        {
        }

        public override string GetLine(ParserOptions options, bool start)
        {
            StringBuilder sb = new StringBuilder();
            if (options.Offset)
            {
                sb.Append(Address.ToString("00 "));
            }

            if (options.Labels)
            {
                if (Label != null)
                {
                    sb.Append(Label.PadRight(13));
                }
                else
                {
                    sb.Append("             ");
                }
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

            //operation and modifier
            sb.Append(Operation);
            sb.Append(".");
            sb.Append(Modifier.ToString().PadRight(3));

            //A
            sb.Append(ModeHelper.ToString(ModeA));
            if (options.Expressions)
            {
                if (ExpressionA != null)
                {
                    sb.Append(ExpressionA.PadLeft(12));
                }
                else
                {
                    sb.Append(ValueA.ToString().PadLeft(12));
                }
            }
            else
            {
                sb.Append(ValueA.ToString().PadLeft(6));
            }
            
            //B
            sb.Append(", ");
            sb.Append(ModeHelper.ToString(ModeB));
            if (options.Expressions)
            {
                if (ExpressionB != null)
                {
                    sb.Append(ExpressionB.PadLeft(12));
                }
                else
                {
                    sb.Append(ValueB.ToString().PadLeft(12));
                }
            }
            else
            {
                sb.Append(ValueB.ToString().PadLeft(6));
            }

            //comment
            if (options.Comments && Comment !=null && Comment.Length > 0)
            {
                int c = 35;
                if (options.Labels)
                    c += 6;
                if (options.Expressions)
                    c += 19;
                if (sb.Length < c)
                    sb.Append(' ', c);
                sb.Append(";");
                sb.Append(Comment);
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
        public string ExpressionA;
        public string ExpressionB;
        public string OriginalInstruction;
    }
}