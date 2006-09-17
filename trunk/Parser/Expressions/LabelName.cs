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

        public override int Evaluate(Dictionary<string, Expression> variables)
        {
            if (inEval)
            {
                throw new ParserException("Cyclic definition of variable : " + name);
            }
            try
            {
                return EvaluateInternal(variables);
            }
            finally
            {
                inEval = false;
            }
        }

        protected virtual int EvaluateInternal(Dictionary<string, Expression> variables)
        {
            string fullName = GetFullName(variables);
            if (variables.ContainsKey(fullName))
            {
                Expression ex = variables[fullName];
                if (ex == this)
                {
                    throw new ParserException("Label not yet resolved: " + fullName);
                }
                return variables[fullName].Evaluate(variables);
            }
            else
            {
                throw new ParserException("Label not defined: " + fullName);
            }
        }

        public override bool ContainsAddress(Dictionary<string, Expression> variables)
        {
            string fullName = GetFullName(variables);
            if (variables.ContainsKey(fullName))
            {
                Expression ex = variables[fullName];
                if (ex == this)
                {
                    throw new ParserException("Label not yet resolved: " + fullName);
                }
                return variables[fullName].ContainsAddress(variables);
            }
            else
            {
                throw new ParserException("Label not defined: " + fullName);
            }
        }

        public virtual string GetFullName(Dictionary<string, Expression> variables)
        {
            return name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}