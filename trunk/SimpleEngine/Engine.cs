// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Collections.Generic;
using nMars.RedCode;

namespace nMars.SimpleEngine
{
    public class Engine : StepEngine, IEngine
    {
        public MatchResult Run(Rules aRules, IList<IWarrior> aWarriors, IPSpaces aPSpaces, Random aRandom,
                               IList<int> forcedAddresses)
        {
            BeginMatch(aRules, aWarriors, aPSpaces, aRandom, forcedAddresses);
            while (NextStep() != StepResult.Finished)
            {
            }
            return EndMatch();
        }

        public MatchResult Run(Rules aRules, IWarrior[] aWarriors, IPSpaces aPSpaces, Random aRandom,
                               int[] forcedAddresses)
        {
            return Run(aRules, aWarriors, aPSpaces, aRandom, forcedAddresses);
        }
    }
}