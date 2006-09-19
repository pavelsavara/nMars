using System;
using System.Collections.Generic;
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

        public string GetLabel(int instructionOffset)
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

        public string GetOriginalLine(int instructionOffset)
        {
            return GetLabel(instructionOffset).PadRight(12) + " "
                   + Instructions[instructionOffset].ToString().PadRight(35) + " ;"
                   + GetOriginalInstruction(instructionOffset).PadRight(35) + " :"
                   + GetComment(instructionOffset);
        }

        [NonSerialized] internal Dictionary<string, Expression> Variables = null;

    }
}