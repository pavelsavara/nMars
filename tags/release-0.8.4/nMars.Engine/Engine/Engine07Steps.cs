// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using nMars.RedCode;

namespace nMars.Engine
{
    public class EngineSteps : EngineInstructions, IEngine, IStepEngine, IExtendedStepEngine
    {
        public MatchResult Run(IProject project, ISimpleOutput console)
        {
            BeginMatch(project);
            StepResult stepResult;
            do
            {
                stepResult = NextStep();
            } while (stepResult != StepResult.Finished);
            return EndMatch(console);
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

            StepResult stepResult = StepResult.Continue;
            if (LiveWarriorsCount == 1 && WarriorsCount > 1)
            {
                liveWarriors.Peek().Result = RoundResult.Win;
                stepResult = StepResult.NextRound;
            }
            else if (LiveWarriorsCount == 0)
            {
                stepResult = StepResult.NextRound;
            }
            else if (cyclesLeft == 0)
            {
                stepResult = StepResult.NextRound;
            }
            if (stepResult == StepResult.NextRound)
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
                    stepResult = StepResult.Finished;
                }
                else
                {
                    InitializeRound();
                }
            }
            lastStepResult = stepResult;
            return stepResult;
        }

        public MatchResult EndMatch(ISimpleOutput console)
        {
            FinalizeMatch();
            results.ComputePoints();
            if (console!=null)
            {
                if (Project.EngineOptions.DumpResults)
                {
                    results.Dump(console, Project);
                }
                if (Project.EngineOptions.StatusLine)
                {
                    console.WriteLine("========== Finished fight of " + Project.Warriors.Count + " warriors ==========");
                }
            }
            return results;
        }

        public StepResult LastStepResult
        {
            get { return lastStepResult; }
        }

        protected void PerformInstruction()
        {
            EngineWarrior warrior = liveWarriors.Dequeue();
            activeWarrior = warrior;
            int insructionPointer = warrior.Tasks.Dequeue();
            InitializeCycle(insructionPointer);

            PerformInstruction(insructionPointer);

            if (warrior.LiveTasks > 0)
            {
                liveWarriors.Enqueue(activeWarrior);
            }
            else
            {
                warrior.Result = RoundResult.Loss;
                cyclesLeft = cyclesLeft - 1 - (cyclesLeft - 1) / (LiveWarriorsCount + 1);
            }
            cyclesLeft--;
            cycles++;
            FinalizeCycle();
        }

        #region Variables

        protected StepResult lastStepResult;

        #endregion
    }
}