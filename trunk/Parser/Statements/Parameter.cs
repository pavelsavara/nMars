using System.Collections.Generic;
using nMars.RedCode;

namespace nMars.Parser.Statements
{
    public class Parameter
    {
        public Parameter()
            : this(Mode.Direct, Value.Zero)
        {
        }

        public Parameter(Mode mode, Expression expression)
        {
            Mode = mode;
            Expression = expression;
        }

        public int GetValue(Dictionary<string, Expression> variables)
        {
            return Expression.Evaluate(variables);
        }

        public Mode Mode;
        public Expression Expression;

        public override string ToString()
        {
            return ModeHelper.ToString(Mode) + Expression.ToString();
        }
    }
}