// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.Collections.Generic;

namespace nMars.Parser
{
    public abstract class Expression
    {
        public abstract int Evaluate(Dictionary<string, Expression> variables, int currentAddress);

        public int Evaluate(Dictionary<string, Expression> variables, int currentAddress, int coreSize)
        {
            int raw = Evaluate(variables, currentAddress);
            int wrap = raw%coreSize;
            if (wrap <= (coreSize/-2))
                wrap += coreSize;
            if (wrap > (coreSize/2))
                wrap -= coreSize;
            return wrap;
        }
    }
}