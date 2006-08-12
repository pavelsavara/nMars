using nMars.RedCode;

namespace nMars.SimpleEngine
{
    public struct EngineInstruction
    {
        public EngineInstruction(Instruction src, int address)
        {
            Operation = src.Operation;
            Modifier = src.Modifier;
            ModeA = src.ModeA;
            ValueA = src.ValueA;
            ModeB = src.ModeB;
            ValueB = src.ValueB;
            Source = src;
            Address = address;
        }

        public bool IsEmpty
        {
            get
            {
                return Operation == Operation.DAT
                       && Modifier == Modifier.F
                       && ModeA == Mode.Direct
                       && ModeB == Mode.Direct
                       && ValueA == 0
                       && ValueB == 0;
            }
        }

        public Operation Operation;
        public Modifier Modifier;
        public Mode ModeA;
        public int ValueA;
        public Mode ModeB;
        public int ValueB;
        public Instruction Source;
        public int Address;

        public override string ToString()
        {
            return Operation.ToString() + "." + Modifier.ToString().PadRight(5) +
                   ModeHelper.ToString(ModeA) + ValueA.ToString().PadLeft(6) + ", " +
                   ModeHelper.ToString(ModeB) + ValueB.ToString().PadLeft(6);
        }
    }
}