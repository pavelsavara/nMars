// This file is part of nMars - Core War MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using nMars.RedCode;

namespace nMars.Engine
{
    public abstract class EngineCore : EngineGround, ICoreEdit
    {
        #region Events

        protected override void InitializeMatch(IProject project)
        {
            base.InitializeMatch(project);
            pSpaces = new PSpace[rules.WarriorsCount];
        }

        protected virtual void InitializeRound()
        {
            core = new EngineInstruction[coreSize];
            for (int a = 0; a < coreSize; a++)
            {
                core[a] = new EngineInstruction(a, null);
            }
        }

        protected virtual void FinalizeRound()
        {
        }

        #endregion

        #region Interfaces

        public int CoreSize
        {
            get { return coreSize; }
        }

        public virtual IRunningInstruction this[int address]
        {
            get { return core[mod(address)]; }
            set { core[mod(address)] = new EngineInstruction(value, address); }
        }

        public virtual int this[int address, Column column]
        {
            get
            {
                switch (column)
                {
                    case Column.A:
                        return core[mod(address)].ValueA;
                    case Column.B:
                        return core[mod(address)].ValueB;
                    default:
                        throw new ApplicationException("Unknown register");
                }
            }
            set
            {
                switch (column)
                {
                    case Column.A:
                        core[mod(address)].ValueA = value;
                        break;
                    case Column.B:
                        core[mod(address)].ValueB = value;
                        break;
                    default:
                        throw new ApplicationException("Unknown register");
                }
            }
        }

        #endregion

        #region Variables

        protected EngineInstruction[] core;
        protected PSpace[] pSpaces;
        protected EngineWarrior activeWarrior;

        #endregion
    }
}