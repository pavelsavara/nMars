// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using nMars.RedCode;

namespace nMars.Parser
{
    public abstract class Expression
    {
        public abstract int Evaluate(nMarsParser parser, int currentAddress);

        public int Evaluate(nMarsParser parser, int currentAddress, int coreSize)
        {
            int raw = Evaluate(parser, currentAddress);
            return Instruction.Wrap(raw, coreSize);
        }
    }
}