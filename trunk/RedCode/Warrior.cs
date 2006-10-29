// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Collections.Generic;
using System.IO;

namespace nMars.RedCode
{
    [Serializable]
    public class Warrior : IWarrior
    {
        protected Warrior()
        {
        }

        public Warrior(Rules rules)
        {
            Instructions = new List<Instruction>();
            StartOffset = 0;
            Rules = rules;
        }

        public List<Instruction> Instructions;
        public int StartOffset;
        public string Name = "";
        public string Author = "Anonymous";
        public string Date = "";
        public string Version = "";
        public string FileName = null;
        public Rules Rules;
        public int Pin = UnsharedPin;
        public const int UnsharedPin = -1;

        public void Dump(TextWriter tw)
        {
            Dump(tw, DumpOptions.Default);
        }

        public virtual void Dump(TextWriter tw, DumpOptions options)
        {
            tw.WriteLine("Program \"" + Name + "\" (length " + Length.ToString() + ") by \"" + Author + "\"");
            tw.WriteLine();
            tw.WriteLine("       ORG      START");
            for (int a = 0; a < Instructions.Count; a++)
            {
                Instruction instruction = Instructions[a];
                if (options.Offset)
                    tw.Write("   ");
                if (a == StartOffset)
                {
                    tw.Write("START  ");
                }
                else
                {
                    tw.Write("       ");
                }
                if (options.Labels)
                    tw.Write("      ");
                tw.WriteLine(instruction.ToString());
            }
            tw.WriteLine();
        }

        public virtual void Dump(string fileName, DumpOptions options)
        {
            StreamWriter sw = new StreamWriter(fileName);
            Dump(sw, options);
            sw.Close();
        }

        int IWarrior.StartOffset
        {
            get { return StartOffset; }
        }

        string IWarrior.Name
        {
            get { return Name; }
        }

        string IWarrior.Author
        {
            get { return Author; }
        }

        string IWarrior.Date
        {
            get { return Date; }
        }

        string IWarrior.Version
        {
            get { return Version; }
        }

        string IWarrior.FileName
        {
            get { return FileName; }
        }

        int IWarrior.Pin
        {
            get { return Pin; }
        }

        Rules IWarrior.Rules
        {
            get { return Rules; }
        }

        public Instruction this[int offset]
        {
            get { return Instructions[offset]; }
        }

        public int Length
        {
            get { return Instructions.Count; }
        }

        public override string ToString()
        {
            return Name;
        }

        public static bool Equals(IWarrior a, IWarrior b)
        {
            if (a.Length != b.Length) return false;
            if (a.StartOffset != b.StartOffset) return false;
            //if (a.Pin != b.Pin) return false;
            //if (a.Name != b.Name) return false;
            //if (a.Author != b.Author) return false;
            for (int adr = 0; adr < b.Length; adr++)
            {
                if (a[adr] != b[adr]) return false;
            }
            return true;
        }
    }
}