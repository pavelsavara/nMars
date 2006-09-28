// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Collections.Generic;

namespace nMars.RedCode
{
    public interface IStepEngine
    {
        /// <summary>
        /// Initialize the engine
        /// </summary>
        void BeginMatch(IList<IWarrior> wariors, IPSpaces pSpaces, Random random,
                        IList<int> forcedAddresses);

        /// <summary>
        /// make step
        /// </summary>
        /// <returns>true when there is next step to process</returns>
        bool NextStep();

        /// <summary>
        /// returns results of the match
        /// </summary>
        IList<FightResult> EndMatch();
    }
}