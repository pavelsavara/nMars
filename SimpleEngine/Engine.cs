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
        
        public IList<FightResult> Run(IList<IWarrior> aWarriors, IPSpaces pSpaces, Random aRandom,
                                      IList<int> forcedAddresses)
        {
            BeginMatch(aWarriors, pSpaces, aRandom, forcedAddresses);
            while (NextStep())
            {
            }
            return EndMatch();
        }
    }
}