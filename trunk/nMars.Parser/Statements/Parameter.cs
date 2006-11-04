// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

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

        public int GetValue(nMarsParser parser, int currentAddress)
        {
            return Expression.Evaluate(parser, currentAddress);
        }

        public Mode Mode;
        public Expression Expression;

        public override string ToString()
        {
            return ModeHelper.ToString(Mode) + Expression.ToString();
        }
    }
}