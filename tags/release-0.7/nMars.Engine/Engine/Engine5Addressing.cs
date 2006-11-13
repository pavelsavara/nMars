// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using nMars.RedCode;

namespace nMars.Engine
{
    public abstract class EngineAddressing : EngineStatus
    {
        /// <summary>
        /// (primary)-field effective address calculation
        /// </summary>
        protected void GetEffectiveAddress(int ip, Mode mode, out int indirect, ref int AX_Value, ref int IR_X, int IR_B,
                                         int primary)
        {
            int direct;
            switch (mode)
            {
                case Mode.PreDecIndirectA:
                    direct = mod(primary + ip);
                    indirect = mod(direct + dec(ref core[direct].ValueA));
                    AX_Value = core[indirect].ValueA;
                    IR_X = core[indirect].ValueB;
                    return;
                case Mode.PreDecIndirectB:
                    direct = mod(primary + ip);
                    indirect = mod(direct + dec(ref core[direct].ValueB));
                    AX_Value = core[indirect].ValueA;
                    IR_X = core[indirect].ValueB;
                    return;
                case Mode.IndirectA:
                    direct = mod(ip + primary);
                    indirect = mod(direct + core[direct].ValueA);
                    AX_Value = core[indirect].ValueA;
                    IR_X = core[indirect].ValueB;
                    return;
                case Mode.IndirectB:
                    direct = mod(ip + primary);
                    indirect = mod(direct + core[direct].ValueB);
                    AX_Value = core[indirect].ValueA;
                    IR_X = core[indirect].ValueB;
                    return;
                case Mode.PostIncIndirectA:
                    direct = mod(ip + primary);
                    indirect = mod(direct + core[direct].ValueA);
                    AX_Value = core[indirect].ValueA;
                    IR_X = core[indirect].ValueB;
                    inc(ref core[direct].ValueA);
                    return;
                case Mode.PostIncIndirectB:
                    direct = mod(ip + primary);
                    indirect = mod(direct + core[direct].ValueB);
                    AX_Value = core[indirect].ValueA;
                    IR_X = core[indirect].ValueB;
                    inc(ref core[direct].ValueB);
                    return;
                case Mode.Direct:
                    direct = mod(ip + primary);
                    indirect = direct;
                    AX_Value = core[indirect].ValueA;
                    IR_X = core[indirect].ValueB;
                    return;
                case Mode.Immediate:
                    indirect = ip;
                    IR_X = IR_B;
                    return;
                default:
                    throw new InvalidOperationException("Unknown Mode");
            }
        }

    }
}
