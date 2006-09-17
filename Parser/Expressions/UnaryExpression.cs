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

        public override int Evaluate(Dictionary<string, Expression> variables)
        {
            switch (operation)
            {
                case UnaryOperation.Negate:
                    return 0 - sub.Evaluate(variables);
                case UnaryOperation.Brackets:
                    return sub.Evaluate(variables);
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