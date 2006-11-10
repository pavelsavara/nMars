// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using nMars.RedCode;

namespace nMars.Engine
{
    public class EngineSteps : EngineInstructions, IEngine, IStepEngine, IExtendedStepEngine
    {
        public MatchResult Run(IProject project, IPSpaces pspaces, Random aRandom)
        {
            BeginMatch(project, pspaces, aRandom);
            while (NextStep() != StepResult.Finished)
            {
            }
            return EndMatch();
        }

        public void BeginMatch(IProject project, IPSpaces pspaces, Random aRandom)
        {
            InitializeMatch(project, pspaces, aRandom);
            InitializeRound();

            results = new MatchResult(rules);
        }

        public StepResult NextStep()
        {
            if (round >= rules.Rounds)
            {
                return StepResult.Finished;
            }

            PerformInstruction();

            StepResult res = StepResult.Continue;
            if (LiveWarriorsCount == 1 && WarriorsCount > 1)
            {
                liveWarriors.Peek().Result = FightResult.Win;
                res = StepResult.NextRound;
            }
            else if (LiveWarriorsCount == 0)
            {
                res = StepResult.NextRound;
            }
            else if (cyclesLeft == 0)
            {
                res = StepResult.NextRound;
            }
            if (res == StepResult.NextRound)
            {
                FinalizeRound();
                for (int w = 0; w < rules.WarriorsCount; w++)
                {
                    EngineWarrior warrior = warriors[w];
                    results.results[w, round] = warrior.Result;
                }
                round++;
                if (round >= rules.Rounds)
                {
                    res = StepResult.Finished;
                }
                else
                {
                    InitializeRound();
                }
            }
            return res;
        }

        public MatchResult EndMatch()
        {
            FinalizeMatch();
            results.ComputePoints();
            return results;
        }

        protected void PerformInstruction()
        {
            InitializeCycle();
            EngineWarrior warrior = liveWarriors.Dequeue();
            int insructionPointer = warrior.Tasks.Dequeue();

            PerformInstruction(warrior, insructionPointer);

            if (warrior.LiveTasks > 0)
            {
                liveWarriors.Enqueue(warrior);
            }
            else
            {
                warrior.Result = FightResult.Loose;
                cyclesLeft = cyclesLeft - 1 - (cyclesLeft - 1) / (LiveWarriorsCount + 1);
            }
            cyclesLeft--;
            cycles++;
            FinalizeCycle();
        }

        private MatchResult results;
    }
}
