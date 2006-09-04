using System;

namespace nMars.Parser
{
    public class BinaryExpression : Expression
    {
        public enum BinaryOperation
        {
            Plus,
            Minus,
            Multiply,
            Divide,
            Modulo,
            Or,
            Xor,
            And,
            Shl,
            Shr,
        }

        public BinaryExpression(Expression left, Expression right, BinaryOperation operation)
        {
            this.left = left;
            this.right = right;
            this.operation = operation;
        }

        private BinaryOperation operation;
        private Expression left;
        private Expression right;

        public override int Evaluate()
        {
            int l = left.Evaluate();
            int r = right.Evaluate();
            switch (operation)
            {
                case BinaryOperation.Plus:
                    return l + r;
                case BinaryOperation.Minus:
                    return l - r;
                case BinaryOperation.Multiply:
                    return l*r;
                case BinaryOperation.Divide:
                    if (r == 0) throw new ParserException("Divide by zero during evaluation of " + ToString());
                    return l/r;
                case BinaryOperation.Modulo:
                    if (r == 0) throw new ParserException("Divide by zero during evaluation of " + ToString());
                    return l%r;
                case BinaryOperation.And:
                    return l & r;
                case BinaryOperation.Or:
                    return l | r;
                case BinaryOperation.Xor:
                    return l ^ r;
                case BinaryOperation.Shl:
                    return l << r;
                case BinaryOperation.Shr:
                    return l >> r;
                default:
                    throw new InvalidOperationException();
            }
        }

        public override string ToString()
        {
            switch (operation)
            {
                case BinaryOperation.Plus:
                    return left.ToString() + "+" + right.ToString();
                case BinaryOperation.Minus:
                    return left.ToString() + "-" + right.ToString();
                case BinaryOperation.Multiply:
                    return left.ToString() + "*" + right.ToString();
                case BinaryOperation.Divide:
                    return left.ToString() + "/" + right.ToString();
                case BinaryOperation.Modulo:
                    return left.ToString() + "%" + right.ToString();
                default:
                    throw new InvalidOperationException();
            }
        }
    }
}