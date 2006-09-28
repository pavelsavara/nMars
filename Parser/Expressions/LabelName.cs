// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.Collections.Generic;

namespace nMars.Parser.Expressions
{
    public class LabelName : Expression
    {
        public LabelName(string name)
        {
            this.name = name;
        }

        private bool inEval = false;
        protected string name;

        public virtual string Name
        {
            get { return name; }
        }

        public override int Evaluate(Dictionary<string, Expression> variables, int currentAddress)
        {
            if (inEval)
            {
                throw new ParserException("Cyclic definition of variable : " + name);
            }
            try
            {
                return EvaluateInternal(variables, currentAddress);
            }
            finally
            {
                inEval = false;
            }
        }

        protected virtual int EvaluateInternal(Dictionary<string, Expression> variables, int currentAddress)
        {
            string fullName = GetFullName(variables, currentAddress);
            if (variables.ContainsKey(fullName))
            {
                Expression ex = variables[fullName];
                if (ex == this)
                {
                    throw new ParserException("Label not yet resolved: " + fullName);
                }
                return ex.Evaluate(variables, currentAddress);
            }
            else
            {
                throw new ParserException("Label not defined: " + fullName);
            }
        }

        public virtual string GetFullName(Dictionary<string, Expression> variables, int currentAddress)
        {
            return name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}