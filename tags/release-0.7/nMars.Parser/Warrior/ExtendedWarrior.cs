// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Collections.Generic;
using System.IO;
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

        public new ExtendedInstruction this[int offset]
        {
            get { return (ExtendedInstruction)Instructions[offset]; }
        }

        public override void Dump(TextWriter tw, DumpOptions options)
        {
            if (options.XmlFormat)
            {
                base.Dump(tw, options);
                return;
            }
            
            tw.WriteLine("Program \"" + Name + "\" (length " + Length.ToString() + ") by \"" + Author + "\"");
            tw.WriteLine();
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
            tw.WriteLine();
        }

        [NonSerialized]
        internal Dictionary<string, Expression> Variables = null;
    }
}