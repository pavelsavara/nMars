// This file is part of nMars - Core War MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Collections.Generic;
using nMars.Parser.Expressions;
using nMars.RedCode;

namespace nMars.Parser.Warrior
{
    [Serializable]
    public class ExtendedWarrior : RedCode.Warrior
    {
        protected ExtendedWarrior()
        {
        }

        public ExtendedWarrior(Rules rules)
            : base(rules)
        {
        }

        public ExtendedInstruction this[int offset]
        {
            get { return (ExtendedInstruction)Instructions[offset]; }
        }

        public void Add(ExtendedInstruction instruction)
        {
            instruction.Address = Instructions.Count;
            Instructions.Add(instruction);
        }

        public override void Dump(ISimpleOutput tw, ParserOptions options)
        {
            if (options.XmlFormat)
            {
                base.Dump(tw, options);
                return;
            }

            if (options.Header)
            {
                tw.WriteLine("Program \"" + Name + "\" (length " + Length.ToString() + ") by \"" + Author + "\"");
                tw.WriteLine("");
            }
            if (options.Metainfo)
            {
                tw.WriteLine(";redcode");
                if (Name != null)
                    tw.WriteLine(";name " + Name);
                if (Author != null)
                    tw.WriteLine(";author " + Author);
                if (Date != null)
                    tw.WriteLine(";date " + Date);
                tw.WriteLine("");
            }
            if (options.Instructions)
            {
                if (options.Offset)
                {
                    tw.Write("   ");
                }
                if (options.Labels && Length > 0)
                {
                    tw.WriteLine("             ORG      " + this[StartOffset].Label);
                }
                else
                {
                    tw.WriteLine("       ORG      START");
                }
                for (int a = 0; a < Instructions.Count; a++)
                {
                    tw.WriteLine(this[a].GetLine(options, a == StartOffset));
                }
                tw.WriteLine("");
            }
        }

        [NonSerialized]
        internal Variables Variables = null;
    }
}