// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using nMars.RedCode;

namespace nMars.Parser.Expressions
{
    public abstract class Expression
    {
        public abstract int Evaluate(WarriorParser parser, int currentAddress);
        public abstract Mode GetMode(WarriorParser parser, int currentAddress);

        public int Evaluate(WarriorParser parser, int currentAddress, int coreSize)
        {
            int raw = Evaluate(parser, currentAddress);
            return Instruction.Wrap(raw, coreSize);
        }

    }
}