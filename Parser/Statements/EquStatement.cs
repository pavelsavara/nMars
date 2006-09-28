// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.Collections.Generic;
using nMars.Parser.Expressions;
using nMars.Parser.Warrior;

namespace nMars.Parser.Statements
{
    public class EquStatement : Statement
    {
        public EquStatement(Expression expression)
        {
            this.expression = expression;
        }

        public override void ExpandStatements(ExtendedWarrior warrior, Dictionary<string, Expression> variables,
                                              ref int currentAddress, int coreSize, bool evaluate)
        {
            //set labels, except last which is EQU expression
            for (int l = 0; l < Labels.Count; l++)
            {
                LabelName label = Labels[l];
                if (l == Labels.Count - 1)
                {
                    variables[label.GetFullName(variables, currentAddress)] = expression;
                }
                else
                {
                    variables[label.GetFullName(variables, currentAddress)] = new Address(currentAddress);
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