using System.Collections.Generic;

namespace nMars.Parser
{
    internal class Variable : Expression
    {
        public Variable(string name, Dictionary<string, Expression> variables,
                        Dictionary<string, InstructionStatement> labels)
        {
            this.name = name;
            this.variables = variables;
            this.labels = labels;
        }

        private string name;
        private Dictionary<string, Expression> variables;
        private Dictionary<string, InstructionStatement> labels;
        private bool inEval = false;

        public bool IsLabel
        {
            get { return labels.ContainsKey(name); }
        }

        public override int Evaluate()
        {
            if (inEval)
            {
                throw new ParserException("Cyclic definition of variable : " + name);
            }
            try
            {
                inEval = true;
                if (labels.ContainsKey(name))
                {
                    return labels[name].Address;
                }
                if (variables.ContainsKey(name))
                {
                    return variables[name].Evaluate();
                }
                throw new ParserException("Missing variable/label : " + name);
            }
            finally
            {
                inEval = false;
            }
        }

        public override string ToString()
        {
            return name;
        }
    }
}