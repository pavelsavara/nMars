using System.Collections.Generic;

namespace nMars.Parser
{
    public abstract class Expression
    {
        public abstract int Evaluate(Dictionary<string, Expression> variables);

        public virtual bool ContainsAddress(Dictionary<string, Expression> variables)
        {
            return false;
        }

        public int Evaluate(Dictionary<string, Expression> variables, int coreSize, int currentAddress)
        {
            return (ContainsAddress(variables) ? (currentAddress - Evaluate(variables)) : Evaluate(variables))%coreSize;
        }
    }
}