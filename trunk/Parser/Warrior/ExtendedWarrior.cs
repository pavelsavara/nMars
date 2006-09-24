using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using nMars.RedCode;

namespace nMars.Parser.Warrior
{
    [Serializable]
    public class ExtendedWarrior : RedCode.Warrior, IExtendedWarrior
    {
        protected ExtendedWarrior()
        {
        }

        public ExtendedWarrior(Rules rules)
            : base(rules)
        {
        }

        public string GetLabels(int instructionOffset)
        {
            return ((ExtendedInstruction)Instructions[instructionOffset]).Label;
        }

        public string GetComment(int instructionOffset)
        {
            return ((ExtendedInstruction)Instructions[instructionOffset]).Comment;
        }

        public string GetOriginalInstruction(int instructionOffset)
        {
            return ((ExtendedInstruction)Instructions[instructionOffset]).OriginalInstruction;
        }

        public string GetExtendedLine(int instructionOffset, DumpOptions options)
        {
            StringBuilder sb = new StringBuilder();
            if (options.Offset)
            {
                sb.Append(instructionOffset.ToString("00 "));
            }
            
            if (options.Labels)
            {
                sb.Append(GetLabels(instructionOffset).PadRight(12));
                sb.Append(" ");
            }
            else 
            {
                if (instructionOffset == StartOffset)
                {
                    sb.Append("START  ");
                }
                else
                {
                    sb.Append("       ");
                }
            }

            sb.Append(Instructions[instructionOffset].ToString());
            if (options.Comments)
            {
                string comment = GetComment(instructionOffset);
                if (comment.Length>0)
                {
                    sb.Append("  ;");
                    sb.Append(comment);
                }
            }
            return sb.ToString();
        }

        public override void Dump(TextWriter tw, DumpOptions options)
        {
            tw.WriteLine("Program \"" + Name + "\" (length " + Length.ToString() + ") by \"" + Author + "\"");
            tw.WriteLine();
            if (options.Offset)
            {
                tw.Write("   ");
            }
            if (options.Labels)
            {
                tw.WriteLine("             ORG      " + GetLabels(StartOffset));
            }
            else
            {
                tw.WriteLine("       ORG      START");
            }
            for (int a = 0; a < Instructions.Count; a++)
            {
                tw.WriteLine(GetExtendedLine(a, options));
            }
            tw.WriteLine();
        }

        [NonSerialized]
        internal Dictionary<string, Expression> Variables = null;

    }
}