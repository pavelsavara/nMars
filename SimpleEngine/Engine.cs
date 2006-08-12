using System;
using System.Collections.Generic;
using nMars.RedCode;

namespace nMars.SimpleEngine
{
    public class Engine : StepEngine, IStepEngine
    {
        public IList<FightResult> Run(IList<IWarrior> aWarriors, Rules aRules, Random aRandom)
        {
            BeginMatch(aWarriors, aRules, aRandom);
            while (NextStep())
            {
            }
            return EndMatch();
        }
    }
}