using System;

namespace nMars.RedCode
{
    [Serializable]
    public class Instruction
    {
        public Instruction(
            Operation operation,
            Modifier modifier,
            Mode modeA,
            int valueA,
            Mode modeB,
            int valueB)
        {
            Operation = operation;
            Modifier = modifier;
            ModeA = modeA;
            ModeB = modeB;
            ValueA = valueA;
            ValueB = valueB;
        }

        public Instruction(Instruction src)
        {
            Operation = src.Operation;
            Modifier = src.Modifier;
            ModeA = src.ModeA;
            ValueA = src.ValueA;
            ModeB = src.ModeB;
            ValueB = src.ValueB;
        }

        public Instruction()
        {
            Operation = Operation.DAT;
            Modifier = Modifier.F;
            ModeA = Mode.Direct;
            ValueA = 0;
            ModeB = Mode.Direct;
            ValueB = 0;
        }

        public Operation Operation;
        public Modifier Modifier;
        public Mode ModeA;
        public int ValueA;
        public Mode ModeB;
        public int ValueB;

        public override string ToString()
        {
            return Operation.ToString() + "." + Modifier.ToString().PadRight(5) +
                   ModeHelper.ToString(ModeA) + ValueA.ToString().PadLeft(6) + ", " +
                   ModeHelper.ToString(ModeB) + ValueB.ToString().PadLeft(6);
        }

        public static Modifier DefaultModifier(Operation op, Mode modeA, Mode modeB)
        {
            switch (op)
            {
                case Operation.NOP:
                case Operation.DAT:
                    return Modifier.F;
                case Operation.MOV:
                case Operation.SNE:
                case Operation.SEQ:
                    if (modeA == Mode.Immediate)
                    {
                        return Modifier.AB;
                    }
                    else if (modeB == Mode.Immediate)
                    {
                        return Modifier.B;
                    }
                    else
                    {
                        return Modifier.I;
                    }
                case Operation.ADD:
                case Operation.SUB:
                case Operation.MUL:
                case Operation.DIV:
                case Operation.MOD:
                    if (modeA == Mode.Immediate)
                    {
                        return Modifier.AB;
                    }
                    else if (modeB == Mode.Immediate)
                    {
                        return Modifier.B;
                    }
                    else
                    {
                        return Modifier.F;
                    }
                case Operation.SLT:
                case Operation.LDP:
                case Operation.STP:
                    if (modeA == Mode.Immediate)
                    {
                        return Modifier.AB;
                    }
                    else
                    {
                        return Modifier.B;
                    }
                default:
                    return Modifier.B;
            }
        }

        public override bool Equals(object obj)
        {
            Instruction o = obj as Instruction;
            //TODO if (o == null) return false;

            if (o.Operation != Operation) return false;
            if (o.Modifier != Modifier) return false;
            if (o.ModeA != ModeA) return false;
            if (o.ValueA != ValueA) return false;
            if (o.ModeB != ModeB) return false;
            if (o.ValueB != ValueB) return false;
            return true;
        }

        public override int GetHashCode()
        {
            return
                Operation.GetHashCode() ^ Modifier.GetHashCode() ^ 
                ModeA.GetHashCode() ^ ModeB.GetHashCode() ^
                ValueA.GetHashCode() ^ ValueB.GetHashCode();
        }
        
        public static bool operator !=(Instruction a, Instruction b)
        {
            return !a.Equals(b);
        }
        
        public static bool operator ==(Instruction a, Instruction b)
        {
            return a.Equals(b);
        }
    }
}