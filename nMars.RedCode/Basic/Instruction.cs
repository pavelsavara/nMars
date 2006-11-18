// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Runtime.InteropServices;
using System.Text;

namespace nMars.RedCode
{
    [Serializable]
    [ComVisible(true)]
    public class Instruction : IInstruction
    {
        #region Constructors

        public Instruction(Operation operation, Modifier modifier, Mode modeA, int valueA, Mode modeB, int valueB)
        {
            Operation = operation;
            Modifier = modifier;
            ModeA = modeA;
            ModeB = modeB;
            ValueA = valueA;
            ValueB = valueB;
        }

        public Instruction(IInstruction src)
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

        #endregion

        #region Public methods

        public static int Mod(int raw, int coreSize)
        {
            int res = raw % coreSize;
            if (res < 0) res += coreSize;
            return res;
        }

        public static int Wrap(int raw, int coreSize)
        {
            int wrap = raw % coreSize;
            if (wrap <= (coreSize / -2))
                wrap += coreSize;
            if (wrap > (coreSize / 2))
                wrap -= coreSize;
            return wrap;
        }

        public static bool Equals(IInstruction a, IInstruction b, int coreSize)
        {
            if (a.Operation != b.Operation) return false;
            if (a.Modifier != b.Modifier) return false;
            if (a.ModeA != b.ModeA) return false;
            if (a.ModeB != b.ModeB) return false;
            if (Mod(a.ValueA, coreSize) != Mod(b.ValueA, coreSize)) return false;
            if (Mod(a.ValueB, coreSize) != Mod(b.ValueB, coreSize)) return false;
            return true;
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
                case Operation.CMP:
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

        #endregion

        #region Extensions

        public override string ToString()
        {
            return Operation.ToString() + "." + Modifier.ToString().PadRight(3) +
                   ModeHelper.ToString(ModeA) + ValueA.ToString().PadLeft(6) + ", " +
                   ModeHelper.ToString(ModeB) + ValueB.ToString().PadLeft(6) + "     ";
        }

        public override bool Equals(object obj)
        {
            IInstruction o = obj as IInstruction;
            return Equals(this, o, Rules.DefaultRules.CoreSize);
        }

        public override int GetHashCode()
        {
            return
                Operation.GetHashCode() ^ Modifier.GetHashCode() ^
                ModeA.GetHashCode() ^ ModeB.GetHashCode() ^
                ValueA.GetHashCode() ^ ValueB.GetHashCode();
        }

        public int CompareTo(object obj)
        {
            return Equals(obj) ? 0 : 1;
        }

        public static bool operator !=(Instruction a, Instruction b)
        {
            return !a.Equals(b);
        }

        public static bool operator ==(Instruction a, Instruction b)
        {
            return a.Equals(b);
        }

        public static bool operator ==(Instruction a, IInstruction b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(Instruction a, IInstruction b)
        {
            return !a.Equals(b);
        }

        public static bool operator ==(IInstruction a, Instruction b)
        {
            return b.Equals(a);
        }

        public static bool operator !=(IInstruction a, Instruction b)
        {
            return !b.Equals(a);
        }

        #endregion

        #region Interface

        public virtual string GetLine(ParserOptions options, bool start)
        {
            StringBuilder sb = new StringBuilder();

            if (options.Offset)
                sb.Append("   ");
            if (start)
            {
                sb.Append("START  ");
            }
            else
            {
                sb.Append("       ");
            }
            if (options.Labels)
                sb.Append("      ");
            sb.Append(ToString());
            return sb.ToString();
        }

        Operation IInstruction.Operation
        {
            get { return Operation; }
        }

        Modifier IInstruction.Modifier
        {
            get { return Modifier; }
        }

        Mode IInstruction.ModeA
        {
            get { return ModeA; }
        }

        int IInstruction.ValueA
        {
            get { return ValueA; }
        }

        Mode IInstruction.ModeB
        {
            get { return ModeB; }
        }

        int IInstruction.ValueB
        {
            get { return ValueB; }
        }

        #endregion

        #region Variables
        
        public Operation Operation;
        public Modifier Modifier;
        public Mode ModeA;
        public int ValueA;
        public Mode ModeB;
        public int ValueB;

        #endregion
    }
}