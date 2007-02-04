// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Collections.Generic;
using nMars.RedCode;

namespace nMars.Engine
{
    public class EngineStepBack : EngineHistory, IStepBackEngine, IDebuggerEngine
    {
        public StepResult PrevStep()
        {
            if (!CanStepBack)
                throw new InvalidOperationException("Cannot step back now");
            EngineEvent e = History.Pop();

            cycles = e.Cycles;
            cyclesLeft = e.CyclesLeft;
            int lastTask = e.Warrior.Tasks.Count;
            int liveLastRound = liveWarriors.Count;
            if (e.Died)
            {
                lastTask++;
                if (warriors.Count == 0)
                {
                    liveLastRound++;
                }
            }
            if (e.Split)
            {
                lastTask--;
            }

            // refill live warriors queue
            Queue<EngineWarrior> nlive = new Queue<EngineWarrior>();
            nlive.Enqueue(e.Warrior);
            for (int w = 0; w < liveLastRound - 1; w++)
            {
                nlive.Enqueue(liveWarriors.Dequeue());
            }
            liveWarriors = nlive;

            //refill tasks queue
            Queue<int> ntasks = new Queue<int>();
            ntasks.Enqueue(e.Ip);
            for (int t = 0; t < lastTask - 1; t++)
            {
                ntasks.Enqueue(e.Warrior.Tasks.Dequeue());
            }
            e.Warrior.Tasks = ntasks;

            //rollback core
            while (e.instructionsChanged.Count > 0)
            {
                EngineInstruction ei = e.instructionsChanged.Pop();
                core[ei.Address].Operation = ei.Operation;
                core[ei.Address].Modifier = ei.Modifier;
                core[ei.Address].ModeA = ei.ModeA;
                core[ei.Address].ModeB = ei.ModeB;
                core[ei.Address].ValueA = ei.ValueA;
                core[ei.Address].ValueB = ei.ValueB;
                core[ei.Address].OriginalOwner = ei.OriginalOwner;
                core[ei.Address].OriginalInstruction = ei.OriginalInstruction;
            }

            if (e.PSpaceAddress!=-1)
            {
                PSpaces[e.Warrior.WarriorIndex][e.PSpaceAddress] = e.PSpaceValue;
            }

            lastStepResult = e.PrevStepResult;
            return e.PrevStepResult;
        }

        public bool CanStepBack
        {
            get { return (lastStepResult == StepResult.Continue); }
        }
    }
}