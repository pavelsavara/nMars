// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using nMars.RedCode;

namespace nMars.Engine
{
    public abstract class EngineStatus : EngineTasks, IStatusView
    {
        #region Events
        
        protected override void InitializeMatch(IProject project, Random aRandom)
        {
            base.InitializeMatch(project, aRandom);
            round = 0;
        }

        protected override void InitializeRound()
        {
            base.InitializeRound();
            cycles = 0;
            cyclesLeft = rules.MaxCycles * rules.WarriorsCount;
        }

        #endregion

        #region Interfaces

        public int Round
        {
            get { return round; }
        }

        public int Cycles
        {
            get { return cycles; }
        }

        public int CyclesLeft
        {
            get { return cyclesLeft; }
        }

        #endregion

        #region Variables

        protected int cycles;
        protected int cyclesLeft;
        protected int round;

        #endregion
    }
}
