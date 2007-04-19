// This file is part of nMars - Core War MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using nMars.RedCode;

namespace nMars.Engine
{
    public class EngineSteps : EngineInstructions, IEngine, IStepEngine, IExtendedStepEngine
    {
        public MatchResult Run(IProject project, ISimpleOutput console)
        {
            StepResult stepResult;
            BeginMatch(project);
            do
            {
                stepResult = NextStep();
            } while (stepResult != StepResult.Finished);
            return EndMatch(console);
        }

        public void BeginMatch(IProject project)
        {
            if (project.EngineOptions.EngineMode != EngineMode.Match)
                throw new InvalidOperationException("This engine mode is supported only by method run");

            InitializeMatch(project);
            InitializeRound();

            results = new MatchResult(project);
            lastStepResult = StepResult.Start;
            initBefore = Project.EngineOptions.InitRoundBefore;
            rounds = rules.Rounds;
        }

        public StepResult NextStep()
        {
            
            if (initBefore && lastStepResult == StepResult.NextRound)
            {
                InitRound();
            }
            if (round >= rounds)
            {
                return StepResult.Finished;
            }

            PerformInstruction();

            lastStepResult = StepResult.Continue;
            if (LiveWarriorsCount == 1 && WarriorsCount > 1)
            {
                liveWarriors.Peek().Result = RoundResult.Win;
                lastStepResult = StepResult.NextRound;
                NextRound();
            }
            else if (LiveWarriorsCount == 0 || cyclesLeft == 0)
            {
                lastStepResult = StepResult.NextRound;
                NextRound();
            }
            return lastStepResult;
        }

        protected void InitRound()
        {
            round++;
            if (round >= rounds)
            {
                lastStepResult = StepResult.Finished;
            }
            else
            {
                InitializeRound();
            }
        }

        protected void NextRound()
        {
            for (int w = 0; w < rules.WarriorsCount; w++)
            {
                EngineWarrior warrior = warriors[w];
                results.results[w, round] = warrior.Result;
                if (warrior.Result != RoundResult.Loss)
                {
                    warrior.PSpace[0] = LiveWarriorsCount;
                }
                else
                {
                    warrior.PSpace[0] = 0;
                }
            }
            FinalizeRound();
            if (!Project.EngineOptions.InitRoundBefore)
            {
                InitRound();
            }
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

        protected virtual void PerformInstruction()
        {
            EngineWarrior warrior = liveWarriors.Dequeue();
            int insructionPointer = warrior.Tasks.Dequeue();

            activeWarrior = warrior;
            InitializeCycle(insructionPointer);

            PerformInstruction(insructionPointer);

            if (warrior.LiveTasks > 0)
            {
                liveWarriors.Enqueue(warrior);
            }
            else
            {
                warrior.Result = RoundResult.Loss;
                cyclesLeft = cyclesLeft - 1 - (cyclesLeft - 1) / (LiveWarriorsCount + 1);
            }
            FinalizeCycle();
            cyclesLeft--;
            cycle++;
        }

        #region Variables

        protected StepResult lastStepResult;
        private bool initBefore;
        private int rounds;
        #endregion
    }
}