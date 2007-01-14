// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

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
            BinOr,
            BinXor,
            BinAnd,
            Shl,
            Shr,
            Or,
            And,
            CompareGt,
            CompareGe,
            CompareLe,
            CompareLt,
            CompareEq,
            CompareNe,
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

        public override int Evaluate(nMarsParser parser, int currentAddress)
        {
            int l = left.Evaluate(parser, currentAddress);
            int r = right.Evaluate(parser, currentAddress);
            switch (operation)
            {
                case BinaryOperation.Plus:
                    return l + r;
                case BinaryOperation.Minus:
                    return l - r;
                case BinaryOperation.Multiply:
                    return l * r;
                case BinaryOperation.Divide:
                    if (r == 0)
                    {
                        parser.WriteError("Divide by zero during evaluation of " + ToString());
                        return 0;
                    }
                    return l / r;
                case BinaryOperation.Modulo:
                    if (r == 0)
                    {
                        parser.WriteError("Divide by zero during evaluation of " + ToString());
                        return 0;
                    }
                    return l % r;
                case BinaryOperation.BinOr:
                    return l | r;
                case BinaryOperation.BinXor:
                    return l ^ r;
                case BinaryOperation.BinAnd:
                    return l & r;
                case BinaryOperation.Shl:
                    return l << r;
                case BinaryOperation.Shr:
                    return l >> r;
                case BinaryOperation.Or:
                    return ((l != 0) || (r != 0)) ? 1 : 0;
                case BinaryOperation.And:
                    return ((l != 0) && (r != 0)) ? 1 : 0;
                case BinaryOperation.CompareGt:
                    return (l > r) ? 1 : 0;
                case BinaryOperation.CompareGe:
                    return (l >= r) ? 1 : 0;
                case BinaryOperation.CompareLe:
                    return (l <= r) ? 1 : 0;
                case BinaryOperation.CompareLt:
                    return (l < r) ? 1 : 0;
                case BinaryOperation.CompareEq:
                    return (l == r) ? 1 : 0;
                case BinaryOperation.CompareNe:
                    return (l != r) ? 1 : 0;
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
                case BinaryOperation.BinOr:
                    return left.ToString() + "|" + left.ToString();
                case BinaryOperation.BinXor:
                    return left.ToString() + "^" + left.ToString();
                case BinaryOperation.BinAnd:
                    return left.ToString() + "&&&" + left.ToString();
                case BinaryOperation.Shl:
                    return left.ToString() + "<<" + left.ToString();
                case BinaryOperation.Shr:
                    return left.ToString() + ">>" + left.ToString();
                case BinaryOperation.Or:
                    return left.ToString() + "||" + left.ToString();
                case BinaryOperation.And:
                    return left.ToString() + "&&" + left.ToString();
                case BinaryOperation.CompareGt:
                    return left.ToString() + ">" + left.ToString();
                case BinaryOperation.CompareGe:
                    return left.ToString() + ">=" + left.ToString();
                case BinaryOperation.CompareLe:
                    return left.ToString() + "<=" + left.ToString();
                case BinaryOperation.CompareLt:
                    return left.ToString() + "<" + left.ToString();
                case BinaryOperation.CompareEq:
                    return left.ToString() + "==" + left.ToString();
                case BinaryOperation.CompareNe:
                    return left.ToString() + "!=" + left.ToString();
                default:
                    throw new InvalidOperationException();
            }
        }
    }
}