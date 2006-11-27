using System;
using System.Collections.Generic;
using nMars.RedCode;

namespace nMars.Engine
{
    class EngineStepBack : EngineObserver, IStepBackEngine
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
                if (warriors.Count==0)
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
            for(int w=0;w<liveLastRound-1;w++)
            {
                nlive.Enqueue(liveWarriors.Dequeue());
            }
            liveWarriors = nlive;
            
            //refill tasks queue
            Queue<int> ntasks=new Queue<int>();
            ntasks.Enqueue(e.Ip);
            for (int t = 0; t < lastTask - 1; t++)
            {
                ntasks.Enqueue(e.Warrior.Tasks.Dequeue());
            }
            e.Warrior.Tasks = ntasks;
            
            //rollback core
            while(e.instructionsChanged.Count>0)
            {
                EngineInstruction ei = e.instructionsChanged.Pop();
                core[ei.Address] = ei;
            }

            lastStepResult = e.PrevStepResult;
            return e.PrevStepResult;
        }

        public bool CanStepBack
        {
            get
            {
                return (lastStepResult == StepResult.Continue);
            }
        }
    }
}