// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Collections.Generic;
using nMars.RedCode;

namespace nMars.Engine
{
    public abstract class EnginePlacement : EngineCore, ICoreEdit, IPSpacesView
    {
        #region Events

        protected override void InitializeMatch(IProject aProject)
        {
            project = aProject;
            base.InitializeMatch(project);
            if (project.Warriors.Count != rules.WarriorsCount)
                throw new EngineException("Count of warriors differ from rules");

            random = project.EngineOptions.Random;
            if (random == null)
            {
                random = new Random();
            }
            forcedAddresses = project.EngineOptions.ForcedAddresses;
            sourceWarriors = project.Warriors;

            warriors = new List<EngineWarrior>(rules.WarriorsCount);
            runningWarriors = new List<IRunningWarrior>(rules.WarriorsCount);
            iWarriors = new List<IWarrior>(rules.WarriorsCount);

            for (int w = 0; w < rules.WarriorsCount; w++)
            {
                IWarrior sourceWarrior = sourceWarriors[w];
                if (!sourceWarrior.Rules.Equals(rules))
                    throw new EngineException("Warrior was compiled under different rules");
                EngineWarrior engineWarrior = new EngineWarrior(sourceWarrior, this, w);

                warriors.Add(engineWarrior);
                runningWarriors.Add(engineWarrior);
                iWarriors.Add(engineWarrior);
            }
            InitPSpaces();
            permutate = project.EngineOptions.Permutate;
            if (forcedAddresses != null && forcedAddresses.Count>0)
            {
                seed = forcedAddresses[1] - rules.MinDistance;
            }
            else
            {
                seed = random.Next();
            }
        }

        protected override void InitializeRound()
        {
            base.InitializeRound();

            if (rules.WarriorsCount > 1)
            {
                if (rules.WarriorsCount == 2)
                {
                    if (permutate)
                    {
                        throw new NotImplementedException("Permutations are not implemented");
                    }
                    else
                    {
                        int positions = coreSize + 1 - (rules.MinDistance << 1);
                        warriors[1].LoadAddress = rules.MinDistance + seed % positions;
                        seed = Rng(seed);
                    }
                }
                else
                {
                    if (Posit())
                        Npos();
                }
            }

            //Load warriors
            for (int w = 0; w < rules.WarriorsCount; w++)
            {
                EngineWarrior engineWarrior = warriors[w];
                Load(engineWarrior, engineWarrior.LoadAddress);
            }
        }

        #endregion

        #region Helpers

        public void Load(EngineWarrior warrior, int loadAddress)
        {
            warrior.LoadAddress = loadAddress;

            //copy warrior to core
            for (int a = 0; a < warrior.Length; a++)
            {
                IInstruction instruction = warrior[a];
                if (instruction.ValueA >= coreSize || instruction.ValueA < 0 ||
                    instruction.ValueB >= coreSize || instruction.ValueB < 0 )
                {
                    throw new RulesException("operand value out of core size");
                }
                if (instruction.Operation == Operation.LDP || instruction.Operation == Operation.STP)
                {
                    if (!rules.EnablePSpace)
                    {
                        throw new RulesException("Current rules don't support p-space operations");
                    }
                }
                int addr = mod(loadAddress + a);
                core[addr] = new EngineInstruction(instruction, addr, warrior);
            }
        }

        private void InitPSpaces()
        {
            int pspP = 0;
            for (int w = 0; w < rules.WarriorsCount; ++w)
            {
                if (warriors[w].PSpaceIndex == PSpace.UNSHARED)
                {
                    warriors[w].PSpaceIndex = pspP;
                    pspP++;
                }
                else if (warriors[w].PSpaceIndex == PSpace.PIN_APPEARED)
                {
                    warriors[w].PSpaceIndex = pspP;
                    for (int v = w + 1; v < rules.WarriorsCount; ++v)
                    {
                        if (warriors[w].Pin == warriors[v].Pin)
                        {
                            warriors[v].PSpaceIndex = pspP;
                        }
                    }
                    pspP++;
                }
                if (pSpaces[warriors[w].PSpaceIndex] == null)
                    pSpaces[warriors[w].PSpaceIndex] = new PSpace(rules.PSpaceSize);
                warriors[w].PSpace = pSpaces[warriors[w].PSpaceIndex];
                warriors[w].PSpace.Memory[0] = coreSize - 1;
            }
        }

        public int Rng(int lseed)
        {
            int temp = lseed;
            unchecked
            {
                temp = 16807 * (temp % 127773) - 2836 * (temp / 127773);
                if (temp < 0)
                    temp += 2147483647;
            }
            return temp;
        }


        bool Posit()
        {
            const int RETRIES1 = 20;
            const int RETRIES2 = 4;

            int pos = 1, i, retries1 = RETRIES1, retries2 = RETRIES2;
            int diff;

            do
            {
                /* generate */
                warriors[pos].LoadAddress = ((seed = Rng(seed)) % (coreSize - 2 * rules.MinDistance + 1)) +
                                            rules.MinDistance;
                /* test for overlap */
                for (i = 1; i < pos; ++i)
                {
                    /* calculate positive difference */
                    diff = warriors[pos].LoadAddress - warriors[i].LoadAddress;
                    if (diff < 0)
                        diff = -diff;
                    if (diff < rules.MinDistance)
                        break; /* overlap! */
                }
                if (i == pos) /* no overlap, generate next number */
                    ++pos;
                else
                {
                    /* overlap */
                    if (retries2 != 0)
                        return true; /* exceeded attempts, fail */
                    if (retries1 != 0)
                    {
                        /* backtrack: generate new sequence starting
                                 * at an */
                        pos = i; /* arbitrary position (last conflict) */
                        --retries2;
                        retries1 = RETRIES1;
                    }
                    else /* generate new current number (pos not
                                 * incremented) */
                        --retries1;
                }
            } while (pos < rules.WarriorsCount);
            return false;
        }

        void Npos()
        {
            int i, j;
            int temp;
            int room = coreSize - rules.MinDistance * rules.WarriorsCount + 1;
            for (i = 1; i < rules.WarriorsCount; i++)
            {
                temp = (seed = Rng(seed)) % room;
                for (j = i - 1; j > 0; j--)
                {
                    if (temp > warriors[j].LoadAddress)
                        break;
                    warriors[j + 1].LoadAddress = warriors[j].LoadAddress;
                }
                warriors[j + 1].LoadAddress = temp;
            }
            temp = rules.MinDistance;
            for (i = 1; i < rules.WarriorsCount; i++)
            {
                warriors[i].LoadAddress += temp;
                temp += rules.MinDistance;
            }
            for (i = 1; i < rules.WarriorsCount; i++)
            {
                j = (seed = Rng(seed)) % (rules.WarriorsCount - i) + i;
                temp = warriors[j].LoadAddress;
                warriors[j].LoadAddress = warriors[i].LoadAddress;
                warriors[i].LoadAddress = temp;
            }
        }

        private int seed;

        #endregion

        #region Interfaces

        public IList<IRunningWarrior> RunningWarriors
        {
            get { return runningWarriors; }
        }

        public IList<IWarrior> Warriors
        {
            get { return iWarriors; }
        }

        public IList<IPSpace> PSpaces
        {
            get
            {
                List<IPSpace> res = new List<IPSpace>();
                foreach (IRunningWarrior warrior in runningWarriors)
                {
                    res.Add(warrior.PSpace);
                }
                return res;
            }
        }

        public IList<int> LastResults
        {
            get
            {
                List<int> res = new List<int>();
                foreach (IRunningWarrior warrior in runningWarriors)
                {
                    res.Add(warrior.LastResult);
                }
                return res;
            }
        }

        public IList<int> PSPaceIndexes
        {
            get
            {
                List<int> res = new List<int>();
                foreach (IRunningWarrior warrior in runningWarriors)
                {
                    res.Add(warrior.PSpaceIndex);
                }
                return res;
            }
        }

        public IProject Project
        {
            get { return project; }
        }

        #endregion

        #region Variables

        //various views
        protected List<EngineWarrior> warriors;
        private List<IRunningWarrior> runningWarriors;
        private List<IWarrior> iWarriors;

        //input
        private IProject project;
        private IList<IWarrior> sourceWarriors;
        private IList<int> forcedAddresses;
        private Random random;
        private bool permutate;

        #endregion
    }
}