using System;
using System.Collections.Generic;
using System.IO;
using nMars.RedCode;

namespace nMars.Parser
{
    [Serializable]
    public class ExtendedWarrior : IExtendedWarrior, IWarrior
    {
        protected ExtendedWarrior()
        {
        }

        public ExtendedWarrior(Rules rules)
        {
            Instructions = new List<ExtendedInstruction>();
            StartOffset = 0;
            Rules = rules;
        }

        public string GetLabel(int instructionOffset)
        {
            return Instructions[instructionOffset].Label;
        }

        public string GetComment(int instructionOffset)
        {
            return Instructions[instructionOffset].Comment;
        }

        public string GetOriginalInstruction(int instructionOffset)
        {
            return Instructions[instructionOffset].OriginalInstruction;
        }

        public string GetOriginalLine(int instructionOffset)
        {
            return GetLabel(instructionOffset).PadRight(12) + " "
                   + Instructions[instructionOffset].ToString().PadRight(35) + " ;"
                   + GetOriginalInstruction(instructionOffset).PadRight(35) + " :"
                   + GetComment(instructionOffset);
        }

        void IWarrior.Dump(StreamWriter sw)
        {
            Dump(sw);
        }

        public void Dump(StreamWriter sw)
        {
            sw.Write("             ORG       ");
            sw.WriteLine(Instructions[StartOffset].Label);

            foreach (KeyValuePair<string, Expression> pair in Variables)
            {
                sw.Write(pair.Key.PadRight(12) + " EQU       ");
                sw.WriteLine(pair.Value.ToString());
            }

            for (int a = 0; a < Instructions.Count; a++)
            {
                sw.WriteLine(GetOriginalLine(a));
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
        
        [NonSerialized] 
        internal Dictionary<string, Expression> Variables = null;
        
        public List<ExtendedInstruction> Instructions;
        public int StartOffset;
        public string Name = "";
        public Rules Rules;
    }
}