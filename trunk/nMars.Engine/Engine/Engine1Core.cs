// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using nMars.RedCode;

namespace nMars.Engine
{
    public abstract class EngineCore : EngineGround, ICoreView
    {
        #region Events

        protected override void InitializeMatch(IProject project, IPSpaces pspaces, Random aRandom)
        {
            base.InitializeMatch(project, pspaces, aRandom);
            pSpaces = pspaces;
        }

        protected virtual void InitializeRound()
        {
            core = new EngineInstruction[rules.CoreSize];
            for (int a = 0; a < rules.CoreSize; a++)
            {
                core[a] = EngineInstruction.DefaultInstruction;
                core[a].Address = a;
            }
        }

        protected virtual void FinalizeRound()
        {
        }

        #endregion

        #region Interfaces

        public IInstruction this[int address]
        {
            get { return core[mod(address)]; }
        }

        public int CoreSize
        {
            get { return rules.CoreSize; }
        }

        #endregion

        #region Variables

        protected IPSpaces pSpaces;
        internal EngineInstruction[] core;

        #endregion
    }
}
