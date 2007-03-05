using System;
using System.Collections.Generic;
using System.Text;
using nMars.Engine;
using nMars.RedCode;
using nMars.RedCode.Modules;

namespace nMars.Fngine.Fngine
{
    public sealed partial class Fngine : EngineSteps
    {
        protected override void PerformInstruction()
        {
            EngineWarrior warrior = liveWarriors.Dequeue();
            int insructionPointer = warrior.Tasks.Dequeue();

            Operations[insructionPointer](insructionPointer, warrior);

            if (warrior.LiveTasks > 0)
            {
                liveWarriors.Enqueue(warrior);
            }
            else
            {
                warrior.Result = RoundResult.Loss;
                cyclesLeft = cyclesLeft - 1 - (cyclesLeft - 1) / (LiveWarriorsCount + 1);
            }
            cyclesLeft--;
            cycle++;
        }

    }
}
