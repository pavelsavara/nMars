// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Collections.Generic;
using nMars.RedCode;

namespace nMars.SimpleEngine
{
    public class Core : ICoreView
    {
        protected Core()
        {
        }

        protected void Init(IList<IWarrior> aWarriors, IPSpaces aPSpaces, Random aRandom,
                            IList<int> forcedAddresses)
        {
            random = aRandom;
            pSpaces = aPSpaces;
            CleanCore();
            if (forcedAddresses != null)
            {
                PlaceWarriors(aWarriors, forcedAddresses);
            }
            else
            {
                RandomlyPlaceWarriors(aWarriors);
            }
            Cycles = 0;
        }

        protected void CleanCore()
        {
            core = new EngineInstruction[rules.coreSize];
            liveWarriors = new Queue<EngineWarrior>();
            warriors = new List<EngineWarrior>();
        }

        private void PlaceWarriors(IList<IWarrior> aWarriors, IList<int> forcedAddresses)
        {
            for (int i = 0; i < aWarriors.Count; i++)
            {
                IWarrior warrior = aWarriors[i];
                int loadAddress = forcedAddresses[i];
                //add warrior
                EngineWarrior engineWarrior = new EngineWarrior(warrior, this, warriors.Count, loadAddress);
                liveWarriors.Enqueue(engineWarrior);
                warriors.Add(engineWarrior);
            }
        }

        private void RandomlyPlaceWarriors(IList<IWarrior> aWarriors)
        {
            foreach (IWarrior warrior in aWarriors)
            {
                int loadAddress;
                bool conflict;

                //search for free space
                do
                {
                    conflict = false;
                    loadAddress = random.Next(CoreSize);
                    for (int a = loadAddress; a < loadAddress + warrior.Length; a++)
                    {
                        if (!core[mod(a)].IsEmpty)
                        {
                            conflict = true;
                            break;
                        }
                    }
                } while (conflict);


                //add warrior
                EngineWarrior engineWarrior = new EngineWarrior(warrior, this, warriors.Count, loadAddress);
                liveWarriors.Enqueue(engineWarrior);
                warriors.Add(engineWarrior);
            }
        }

        public int mod(int address)
        {
            int res = (address%CoreSize);
            if (res >= 0) return res;
            return res + CoreSize;
        }

        protected int predec(ref int address)
        {
            address = mod(address - 1);
            return address;
        }

        protected int postinc(ref int address)
        {
            int cpy = address;
            address = mod(address + 1);
            return cpy;
        }

        protected bool decz(ref int address)
        {
            address = mod(address - 1);
            return address == 0;
        }

        /// <returns>T- should die</returns>
        protected bool oper(ref int res, int a, int b, Operation op)
        {
            switch (op)
            {
                case Operation.ADD:
                    res = a + b;
                    break;
                case Operation.SUB:
                    res = a - b;
                    break;
                case Operation.MUL:
                    res = a*b;
                    break;
                case Operation.MOD:
                    if (b == 0) return true;
                    res = a%b;
                    break;
                case Operation.DIV:
                    if (b == 0) return true;
                    res = a/b;
                    break;
                default:
                    throw new InvalidOperationException("Unknown instruction");
            }
            res = mod(res);
            return false;
        }

        public int CoreSize
        {
            get { return rules.coreSize; }
        }

        Instruction ICoreView.this[int address]
        {
            get { return core[mod(address)].Source; }
        }

        public int LiveWarriorsCount
        {
            get { return liveWarriors.Count; }
        }

        public int WarriorsCount
        {
            get { return warriors.Count; }
        }

        internal Rules Rules
        {
            get { return rules; }
        }

        internal IPSpaces PSpaces
        {
            get { return pSpaces; }
        }

        internal EngineInstruction[] core;
        private Random random;

        protected IList<EngineWarrior> warriors;
        protected Queue<EngineWarrior> liveWarriors;
        protected Rules rules;
        protected IPSpaces pSpaces;
        protected int Cycles;
    }
}