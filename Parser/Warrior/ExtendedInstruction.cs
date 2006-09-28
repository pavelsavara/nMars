// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using nMars.RedCode;

namespace nMars.Parser.Warrior
{
    [Serializable]
    public class ExtendedInstruction : Instruction
    {
        public ExtendedInstruction()
        {
        }

        public ExtendedInstruction(
            Operation operation,
            Modifier modifier,
            Mode modeA,
            int valueA,
            Mode modeB,
            int valueB)
            : base(operation, modifier, modeA, valueA, modeB, valueB)
        {
        }


        public ExtendedInstruction(Instruction src)
            : base(src)
        {
        }

        public int Address;
        public string Label;
        public string Comment;
        public string OriginalInstruction;
    }
}