using System;

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

        public override int Evaluate()
        {
            switch (operation)
            {
                case UnaryOperation.Negate:
                    return 0 - sub.Evaluate();
                case UnaryOperation.Brackets:
                    return sub.Evaluate();
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