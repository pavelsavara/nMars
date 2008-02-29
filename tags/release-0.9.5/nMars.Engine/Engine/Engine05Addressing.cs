// This file is part of nMars - Core War MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using nMars.RedCode;

namespace nMars.Engine
{
    public abstract class EngineAddressing : EngineChanges
    {
        /// <summary>
        /// (primary)-field effective address calculation
        /// </summary>
        protected void GetEffectiveAddress(Mode mode, out int indirect, ref int AX_Value, ref int IR_X, int primary)
        {
            int direct = mod(primary + reg.ip);
            switch (mode)
            {
                case Mode.PreDecIndirectA:
                    indirect = mod(direct + dec(direct, Column.A));
                    AX_Value = this[indirect, Column.A];
                    IR_X = this[indirect, Column.B];
                    return;
                case Mode.PreDecIndirectB:
                    indirect = mod(direct + dec(direct, Column.B));
                    AX_Value = this[indirect, Column.A];
                    IR_X = this[indirect, Column.B];
                    return;
                case Mode.IndirectA:
                    indirect = mod(direct + this[direct, Column.A]);
                    AX_Value = this[indirect, Column.A];
                    IR_X = this[indirect, Column.B];
                    return;
                case Mode.IndirectB:
                    indirect = mod(direct + this[direct, Column.B]);
                    AX_Value = this[indirect, Column.A];
                    IR_X = this[indirect, Column.B];
                    return;
                case Mode.PostIncIndirectA:
                    indirect = mod(direct + this[direct, Column.A]);
                    AX_Value = this[indirect, Column.A];
                    IR_X = this[indirect, Column.B];
                    inc(direct, Column.A);
                    return;
                case Mode.PostIncIndirectB:
                    indirect = mod(direct + this[direct, Column.B]);
                    AX_Value = this[indirect, Column.A];
                    IR_X = this[indirect, Column.B];
                    inc(direct, Column.B);
                    return;
                case Mode.Direct:
                    AX_Value = this[direct, Column.A];
                    IR_X = this[direct, Column.B];
                    indirect = direct;
                    return;
                case Mode.Immediate:
                    indirect = reg.ip;
                    IR_X = reg.IR.ValueB;
                    return;
                default:
                    throw new InvalidOperationException("Unknown Mode");
            }
        }

        protected Registers reg;

        protected struct Registers
        {
            public int ip;
            public EngineInstruction IR; //Instruction copy
            public int AdrA;
            public int AdrB;
            public int AA_Value;
            public int AB_Value;
        }
    }
}