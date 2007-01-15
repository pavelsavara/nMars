// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using com.calitha.goldparser;
using nMars.Parser.Expressions;
using nMars.Parser.Warrior;

namespace nMars.Parser.Statements
{
    class AssertStatement : Statement
    {
        public AssertStatement(Expression expression, Location location)
            : base(location)
        {
            this.expression = expression;
        }

        public override void ExpandStatements(ExtendedWarrior warrior, Parser parser, ref int currentAddress,
                                              int coreSize, bool evaluate)
        {
            if (!evaluate)
                return;
            if (expression.Evaluate(parser, currentAddress) == 0)
            {
                parser.WriteWarning("Assert failed : " + this + " at : " + Location, Location);
            }
        }

        private Expression expression;

        public override string ToString()
        {
            return expression.ToString();
        }
    }
}
