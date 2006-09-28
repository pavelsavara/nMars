// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Collections.Generic;

namespace nMars.Parser
{
    public class UnaryExpression : Expression
    {
        public enum UnaryOperation
        {
            Negate,
            Brackets,
        }

        public UnaryExpression(Expression sub, UnaryOperation operation)
        {
            this.sub = sub;
            this.operation = operation;
        }

        private UnaryOperation operation;
        private Expression sub;

        public override int Evaluate(Dictionary<string, Expression> variables, int currentAddress)
        {
            switch (operation)
            {
                case UnaryOperation.Negate:
                    return 0 - sub.Evaluate(variables, currentAddress);
                case UnaryOperation.Brackets:
                    return sub.Evaluate(variables, currentAddress);
                default:
                    throw new InvalidOperationException();
            }
        }

        public override string ToString()
        {
            switch (operation)
            {
                case UnaryOperation.Negate:
                    return "-" + sub.ToString();
                case UnaryOperation.Brackets:
                    return "(" + sub.ToString() + ")";
                default:
                    throw new InvalidOperationException();
            }
        }
    }
}