// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using nMars.RedCode;

namespace nMars.Engine
{
    public abstract class EngineGround
    {
        #region Events
        
        protected virtual void InitializeMatch(IProject project, IPSpaces pspaces, Random aRandom)
        {
            rules = project.Rules;
        }

        protected virtual void FinalizeMatch()
        {
        }

        #endregion

        #region Modular operations

        protected void incWarrior(ref int warriorIndex)
        {
            warriorIndex++;
            if (warriorIndex >= rules.WarriorsCount)
                warriorIndex = 0;
        }

        protected int dec(ref int address)
        {
            address = mod(address - 1);
            return address;
        }

        protected void inc(ref int address)
        {
            address = mod(address + 1);
        }

        public int wrap(int value)
        {
            return Instruction.Wrap(value, rules.CoreSize);
        }

        internal int mod(int value)
        {
            return Instruction.Mod(value, rules.CoreSize);
        }

        /// <returns>T- should die</returns>
        protected bool binoper(EngineInstruction instruction, ref int indirectAvalA, ref int indirectAvalB,
                                     ref int indirectBvalA, ref int indirectBvalB)
        {
            bool die = false;
            switch (instruction.Modifier)
            {
                case Modifier.I:
                case Modifier.F:
                    die |= oper(ref indirectBvalB, indirectBvalB, indirectAvalB, instruction.Operation);
                    die |= oper(ref indirectBvalA, indirectBvalA, indirectAvalA, instruction.Operation);
                    break;
                case Modifier.A:
                    die = oper(ref indirectBvalA, indirectBvalA, indirectAvalA, instruction.Operation);
                    break;
                case Modifier.B:
                    die = oper(ref indirectBvalB, indirectBvalB, indirectAvalB, instruction.Operation);
                    break;
                case Modifier.X:
                    die |= oper(ref indirectBvalA, indirectBvalA, indirectAvalB, instruction.Operation);
                    die |= oper(ref indirectBvalB, indirectBvalB, indirectAvalA, instruction.Operation);
                    break;
                case Modifier.AB:
                    die = oper(ref indirectBvalB, indirectBvalB, indirectAvalA, instruction.Operation);
                    break;
                case Modifier.BA:
                    die = oper(ref indirectBvalA, indirectBvalA, indirectAvalB, instruction.Operation);
                    break;
            }
            return die;
        }

        /// <returns>T- should die</returns>
        private bool oper(ref int res, int a, int b, Operation op)
        {
            switch (op)
            {
                case Operation.ADD:
                    res = a + b;
                    if (res >= rules.CoreSize) res -= rules.CoreSize;
                    break;
                case Operation.SUB:
                    res = a - b;
                    if (res < 0) res += rules.CoreSize;
                    break;
                case Operation.MUL:
                    res = a * b;
                    res %= rules.CoreSize;
                    break;
                case Operation.MOD:
                    if (b == 0) return true;
                    res = a % b;
                    break;
                case Operation.DIV:
                    if (b == 0) return true;
                    res = a / b;
                    break;
                default:
                    throw new InvalidOperationException("Unknown instruction");
            }
            return false;
        }

        #endregion

        #region Variables
        
        internal Rules rules;
        
        #endregion
    }
}
