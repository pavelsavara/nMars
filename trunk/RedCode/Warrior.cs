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
        public Rules Rules;
        public int Pin = -1;

        public void Dump(StreamWriter sw)
        {
            sw.WriteLine("           ORG       start");
            for (int a = 0; a < Instructions.Count; a++)
            {
                Instruction instruction = Instructions[a];
                if (a == StartOffset)
                {
                    sw.Write("start      ");
                }
                else
                {
                    sw.Write("           ");
                }
                sw.WriteLine(instruction.ToString());
            }
        }

        int IWarrior.StartOffset
        {
            get { return StartOffset; }
        }

        string IWarrior.Name
        {
            get { return Name; }
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
    }
}