// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Text;
using nMars.RedCode;

namespace nMars.Engine
{
    public struct EngineInstruction : IRunningInstruction, IExtendedInstruction
    {
        public EngineInstruction(int address, IRunningWarrior owner)
        {
            Operation = Operation.DAT;
            Modifier = Modifier.F;
            ModeA = Mode.Direct;
            ValueA = 0;
            ModeB = Mode.Direct;
            ValueB = 0;
            Source = null;
            Address = address;
            OriginalOwner = owner;
        }

        public EngineInstruction(IInstruction src, int address, IRunningWarrior owner)
        {
            Operation = src.Operation;
            Modifier = src.Modifier;
            ModeA = src.ModeA;
            ValueA = src.ValueA;
            ModeB = src.ModeB;
            ValueB = src.ValueB;
            Address = address;
            OriginalOwner = owner;
            if (src is EngineInstruction)
            {
                EngineInstruction ei = (EngineInstruction)src;
                Source = ei.Source;
            }
            else
            {
                Source = src;
            }
        }

        public EngineInstruction(IInstruction src, int address)
        {
            Operation = src.Operation;
            Modifier = src.Modifier;
            ModeA = src.ModeA;
            ValueA = src.ValueA;
            ModeB = src.ModeB;
            ValueB = src.ValueB;
            Address = address;
            if (src is EngineInstruction)
            {
                EngineInstruction ei = (EngineInstruction)src;
                Source = ei.Source;
                OriginalOwner = ei.OriginalOwner;
            }
            else
            {
                Source = src;
                OriginalOwner = null;
            }
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

        #region Extensions
        
        string IRunningInstruction.ToString()
        {
            return Address.ToString().PadRight(5) + 
                   Operation.ToString() + "." + Modifier.ToString().PadRight(3) +
                   ModeHelper.ToString(ModeA) + ValueA.ToString().PadLeft(6) + ", " +
                   ModeHelper.ToString(ModeB) + ValueB.ToString().PadLeft(6) + "     ";
        }

        public override string ToString()
        {
            return Operation.ToString() + "." + Modifier.ToString().PadRight(3) +
                   ModeHelper.ToString(ModeA) + ValueA.ToString().PadLeft(6) + ", " +
                   ModeHelper.ToString(ModeB) + ValueB.ToString().PadLeft(6) + "     ";
        }

        public override bool Equals(object obj)
        {
            IInstruction o = obj as IInstruction;
            return Instruction.Equals(this, o, Rules.DefaultRules.CoreSize);
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

        public static bool operator !=(EngineInstruction a, EngineInstruction b)
        {
            return !a.Equals(b);
        }

        public static bool operator ==(EngineInstruction a, EngineInstruction b)
        {
            return a.Equals(b);
        }

        public static bool operator ==(EngineInstruction a, IInstruction b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(EngineInstruction a, IInstruction b)
        {
            return !a.Equals(b);
        }

        public static bool operator ==(IInstruction a, EngineInstruction b)
        {
            return b.Equals(a);
        }

        public static bool operator !=(IInstruction a, EngineInstruction b)
        {
            return !b.Equals(a);
        }

        #endregion

        #region IInstruction

        public string GetLine(ParserOptions options, bool start)
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

        int IRunningInstruction.Address
        {
            get { return Address; }
        }

        public string Label
        {
            get { throw new NotImplementedException(); }
        }

        public string Comment
        {
            get { throw new NotImplementedException(); }
        }

        IRunningWarrior IRunningInstruction.OriginalOwner
        {
            get
            {
                return OriginalOwner;
            }
        }

        #endregion

        public Operation Operation;
        public Modifier Modifier;
        public Mode ModeA;
        public int ValueA;
        public Mode ModeB;
        public int ValueB;
        public IInstruction Source;
        public IRunningWarrior OriginalOwner;
        public int Address;
    }
}