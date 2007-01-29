// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using com.calitha.goldparser;
using nMars.Parser.Expressions;
using nMars.Parser.Warrior;
using nMars.RedCode;

namespace nMars.Parser.Statements
{
    public class EquStatement : Statement
    {
        public EquStatement(Expression expression, Location location)
            : base(location)
        {
            this.expression = expression;
        }

        public override void ExpandStatements(ExtendedWarrior warrior, WarriorParser parser, ref int currentAddress,
                                              int coreSize, bool evaluate)
        {
            //set labels, except last which is EQU expression
            for (int l = 0; l < Labels.Count; l++)
            {
                LabelName label = Labels[l];
                if (l == Labels.Count - 1)
                {//equ
                    parser.variables[label.GetFullName(parser, currentAddress)] = expression;
                }
                else
                {//labels
                    parser.variables[label.GetFullName(parser, currentAddress)] = new Address(currentAddress);
                }
            }
            return;
        }

        private Expression expression;

        public override string ToString()
        {
            return expression.ToString();
        }
    }
}