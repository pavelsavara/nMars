// This file is part of nMars - Core War MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using nMars.RedCode;
using nMars.RedCode.Modules;

namespace nMars.Engine
{
    public abstract class EngineGround : BaseComponent
    {
        #region Events

        protected virtual void InitializeMatch(IProject project)
        {
            rules = project.Rules;
            coreSize = rules.CoreSize;
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

        public int wrap(int value)
        {
            return Instruction.Wrap(value, coreSize);
        }

        internal protected int mod(int value)
        {
            return Instruction.Mod(value, coreSize);
        }

        /// <returns>T- should die</returns>
        protected bool oper(ref int res, int a, int b, Operation op)
        {
            switch (op)
            {
                case Operation.ADD:
                    res = a + b;
                    if (res >= coreSize) res -= coreSize;
                    break;
                case Operation.SUB:
                    res = a - b;
                    if (res < 0) res += coreSize;
                    break;
                case Operation.MUL:
                    res = a * b;
                    res %= coreSize;
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

        protected internal Rules rules;
        protected internal int coreSize;

        #endregion
    }
}