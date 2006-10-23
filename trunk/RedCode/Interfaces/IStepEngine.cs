// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Runtime.InteropServices;

namespace nMars.RedCode
{
    [ComVisible(true)]
    public interface IStepEngine
    {
        /// <summary>
        /// Initialize the engine
        /// </summary>
        void BeginMatch(Rules aRules, IWarrior[] wariors, IPSpaces aPSpaces, Random random,
                        int[] forcedAddresses);

        /// <summary>
        /// make step
        /// </summary>
        /// <returns>true when there is next step to process</returns>
        bool NextStep();

        /// <summary>
        /// returns results of the match
        /// </summary>
        FightResult[] EndMatch();
    }
}