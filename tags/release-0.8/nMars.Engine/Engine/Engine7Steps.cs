// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using nMars.RedCode;

namespace nMars.Engine
{
    public class EngineSteps : EngineInstructions, IEngine, IStepEngine, IExtendedStepEngine
    {
        public MatchResult Run(IProject project)
        {
            BeginMatch(project);
            StepResult stepResult;
            do
            {
                stepResult = NextStep();
            } while (stepResult != StepResult.Finished);
            return EndMatch();
        }

        public void BeginMatch(IProject project)
        {
            InitializeMatch(project);
            InitializeRound();

            results = new MatchResult(project);
            lastStepResult = StepResult.Finished;
        }

        public StepResult NextStep()
        {
            if (round >= rules.Rounds)
            {
                return StepResult.Finished;
            }

            PerformInstruction();

            lastStepResult = StepResult.Continue;
            if (LiveWarriorsCount == 1 && WarriorsCount > 1)
            {
                liveWarriors.Peek().Result = RoundResult.Win;
                lastStepResult = StepResult.NextRound;
            }
            else if (LiveWarriorsCount == 0)
            {
                lastStepResult = StepResult.NextRound;
            }
            else if (cyclesLeft == 0)
            {
                lastStepResult = StepResult.NextRound;
            }
            if (lastStepResult == StepResult.NextRound)
            {
                for (int w = 0; w < rules.WarriorsCount; w++)
                {
                    EngineWarrior warrior = warriors[w];
                    results.results[w, round] = warrior.Result;
                    if (warrior.Result != RoundResult.Loss)
                    {
                        warrior.LastResult = LiveWarriorsCount;
                    }
                    else
                    {
                        warrior.LastResult = 0;
                    }
                }
                FinalizeRound();
                round++;
                if (round >= rules.Rounds)
                {
                    lastStepResult = StepResult.Finished;
                }
                else
                {
                    InitializeRound();
                }
            }
            return lastStepResult;
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
            lastStepWarrior = liveWarriors.Dequeue();
            int insructionPointer = lastStepWarrior.Tasks.Dequeue();

            PerformInstruction(lastStepWarrior, insructionPointer);

            if (lastStepWarrior.LiveTasks > 0)
            {
                liveWarriors.Enqueue(lastStepWarrior);
            }
            else
            {
                lastStepWarrior.Result = RoundResult.Loss;
                cyclesLeft = cyclesLeft - 1 - (cyclesLeft - 1) / (LiveWarriorsCount + 1);
            }
            cyclesLeft--;
            cycles++;
            FinalizeCycle();
        }

        #region Variables
        
        protected StepResult lastStepResult;
        protected EngineWarrior lastStepWarrior;

        #endregion
    }
}
