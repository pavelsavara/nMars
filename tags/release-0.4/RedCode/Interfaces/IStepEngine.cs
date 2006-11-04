// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Runtime.InteropServices;

namespace nMars.RedCode
{
    [ComVisible(true)]
    public enum StepResult
    {
        Continue = 0,
        NextRound = 1,
        Finished = 2,
    }

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
        StepResult NextStep();

        /// <summary>
        /// returns results of the match
        /// </summary>
        MatchResult EndMatch();
    }

    [ComVisible(true)]
    public interface IExtendedStepEngine : IStepEngine, ICoreView, ITaskView, IWarriorsView, ITimeView
    {
    }
}