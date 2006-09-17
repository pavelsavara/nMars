using System;
using System.Collections.Generic;
using nMars.RedCode;

namespace nMars.SimpleEngine
{
    public class Engine : StepEngine, IEngine
    {
        public IList<FightResult> Run(IList<IWarrior> aWarriors, Rules aRules, IPSpaces pSpaces, Random aRandom,
                                      IList<int> forcedAddresses)
        {
            BeginMatch(aWarriors, aRules, pSpaces, aRandom, forcedAddresses);
            while (NextStep())
            {
            }
            return EndMatch();
        }
    }
}