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
        public Engine(Rules rules)
        {
            this.rules = rules;
        }

        public IList<FightResult> Run(IList<IWarrior> aWarriors, IPSpaces aPSpaces, Random aRandom,
                                      IList<int> forcedAddresses)
        {
            BeginMatch(aWarriors, pSpaces, aRandom, forcedAddresses);
            while (NextStep())
            {
            }
            return EndMatch();
        }

        public FightResult[] Run(IWarrior[] aWarriors, IPSpaces aPSpaces, Random aRandom,
                                      int[] forcedAddresses)
        {
            return Run(aWarriors, pSpaces, aRandom, forcedAddresses);
        }
    }
}