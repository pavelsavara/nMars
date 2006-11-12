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
        #region Connstruction

        protected Warrior()
        {
        }

        public Warrior(Rules rules)
        {
            Instructions = new List<IInstruction>();
            StartOffset = 0;
            Rules = rules;
        }

        #endregion

        #region Dumping

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
                tw.WriteLine(Instructions[a].GetLine(options, a == StartOffset));
            }
            tw.WriteLine();
        }

        public virtual void Dump(string fileName, DumpOptions options)
        {
            StreamWriter sw = new StreamWriter(fileName);
            Dump(sw, options);
            sw.Close();
        }

        #endregion

        #region Interface

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

        IInstruction IWarrior.this[int offset]
        {
            get { return Instructions[offset]; }
        }

        public int Length
        {
            get { return Instructions.Count; }
        }

        #endregion

        #region Extensions

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
                if (!a[adr].Equals(b[adr])) return false;
            }
            return true;
        }

        #endregion

        #region Variables

        public List<IInstruction> Instructions;
        public int StartOffset;
        public string Name = "";
        public string Author = "Anonymous";
        public string Date = "";
        public string Version = "";
        public string FileName = null;
        public Rules Rules;
        public int Pin = PSpace.UNSHARED;

        #endregion
    }
}