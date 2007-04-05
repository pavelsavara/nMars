// This file is part of nMars - Core War MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using nMars.Parser.Warrior;
using nMars.RedCode;

namespace nMars.Generator
{
    public delegate bool ProcessInstruction(ExtendedInstruction instruction);

    class Generator
    {
        public static void Generate(ProcessInstruction processor)
        {
            foreach (Operation operation in Enum.GetValues(typeof(Operation)))
            {
                /*if (operation==Operation.NOP ||
                    operation==Operation.DAT ||
                    operation==Operation.LDP ||
                    operation==Operation.STP )
                    continue;*/
                foreach (Modifier modifier in Enum.GetValues(typeof(Modifier)))
                {
                    if (modifier == Modifier.NULL)
                        continue;
                    foreach (Mode modeA in Enum.GetValues(typeof(Mode)))
                    {
                        if (modeA == Mode.NULL)
                            continue;
                        foreach (Mode modeB in Enum.GetValues(typeof(Mode)))
                        {
                            if (modeB == Mode.NULL)
                                continue;
                            ExtendedInstruction instruction = new ExtendedInstruction(operation, modifier, modeA, 0, modeB, 0);
                            if (processor.Invoke(instruction))
                              return;
                        }
                    }
                }
            }
            
        }
    }
}
