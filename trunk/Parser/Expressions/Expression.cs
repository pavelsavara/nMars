// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

namespace nMars.Parser
{
    public abstract class Expression
    {
        public abstract int Evaluate(nMarsParser parser, int currentAddress);

        public int Evaluate(nMarsParser parser, int currentAddress, int coreSize)
        {
            int raw = Evaluate(parser, currentAddress);
            int wrap = raw%coreSize;
            if (wrap <= (coreSize/-2))
                wrap += coreSize;
            if (wrap > (coreSize/2))
                wrap -= coreSize;
            return wrap;
        }
    }
}