using System;
using System.Collections.Generic;
using System.IO;
using nMars.RedCode;

namespace nMars.pMarsDll
{
    public class pMarsDllEngine : IEngine, IStepEngine, IObservedEngine
    {
        public IList<FightResult> Run(Rules aRules, IList<IWarrior> aWarriors, IPSpaces aPSpaces, Random aRandom,
                                      IList<int> forcedAddresses)
        {
            BeginMatch(aRules, aWarriors, aPSpaces, aRandom, forcedAddresses);
            while (NextStep())
            {
            }
            return EndMatch();
        }

        public FightResult[] Run(Rules aRules, IWarrior[] aWarriors, IPSpaces aPSpaces, Random aRandom,
                                      int[] forcedAddresses)
        {
            return Run(aRules, aWarriors, aPSpaces, aRandom, forcedAddresses);
        }

        public void BeginMatch(Rules aRules, IWarrior[] aWariors, IPSpaces aPSpaces, Random aRandom,
                               int[] forcedAddresses)
        {
            BeginMatch(aRules, (IList<IWarrior>)aWariors, aPSpaces, aRandom, forcedAddresses);
        }

        public void BeginMatch(Rules aRules, IList<IWarrior> aWariors, IPSpaces aPSpaces, Random aRandom,
                               IList<int> forcedAddresses)
        {
            rules = aRules;
            string[] names=new string[aWariors.Count];
            for(int w=0;w<aWariors.Count;w++)
            {
                names[w] = aWariors[w].FileName;
            }
            List<string> r = pMarsDll.BuildParams(rules, false, names);

            string errFile = Path.GetTempFileName();
            int res = pMarsDll.pMarsBeginMatch(r.Count, r.ToArray(), errFile);
            if (res != 0)
            {
                string errors = File.ReadAllText(errFile);
                File.Delete(errFile);
                throw new ParserException(errors);
            }
        }

        public bool NextStep()
        {
            int res = pMarsDll.pMarsStepMatch();
            if (res != 2)
            {
                coreCopy=new List<Instruction>(rules.coreSize);
                IntPtr core;
                int size;
                pMarsDll.pMarsGetCore(out core, out size);
                pMarsDll.FillInstructions(coreCopy, core, size, rules.coreSize);
                return true;
            }
            return false;
        }

        public FightResult[] EndMatch()
        {
            pMarsDll.pMarsEndMatch();
            return null;
        }

        public Instruction this[int offset]
        {
            get { return coreCopy[offset]; }
        }

        private List<Instruction> coreCopy = null;
        private Rules rules;
    }
}
