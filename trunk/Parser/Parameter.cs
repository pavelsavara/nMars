using nMars.RedCode;

namespace nMars.Parser
{
    public class Parameter
    {
        public Parameter()
            : this(Mode.Direct, Parser.Value.Zero)
        {
        }

        public Parameter(Mode mode, Expression expression)
        {
            Mode = mode;
            Expression = expression;
        }

        public int Value
        {
            get { return Expression.Evaluate(); }
        }

        public Mode Mode;
        public Expression Expression;

        public override string ToString()
        {
            return ModeHelper.ToString(Mode) + Expression.ToString();
        }
    }
}