using System;
using nMars.RedCode;

namespace nMars.Parser
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