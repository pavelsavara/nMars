// This file is part of nMars - Core War MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.Collections.Generic;
using nMars.Engine;
using nMars.RedCode;

namespace nMars.Fngine
{
    public delegate void Fn(int address, EngineWarrior warrior);
    
    class FnHolder
    {
        public int Code
        {
            get
            {
                return Instruction.GetCode(Operation, Modifier, ModeA, ModeB);
            }
        }

        public string Name
        {
            get
            {
                return Instruction.GetName(Operation, Modifier, ModeA, ModeB);
            }
        }

        public Operation Operation;
        public Modifier Modifier;
        public Mode ModeA;
        public Mode ModeB;
        public Fn Fn;
    }

}
