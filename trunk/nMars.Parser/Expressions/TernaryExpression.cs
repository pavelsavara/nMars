// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;

namespace nMars.Parser.Expressions
{
    class TernaryExpression : Expression
    {
        public enum TernaryOperation
        {
            If,
        }

        public TernaryExpression(Expression left, Expression middle, Expression right, TernaryOperation operation)
        {
            this.operation = operation;
            this.left = left;
            this.middle = middle;
            this.right = right;
        }

        public override int Evaluate(nMarsParser parser, int currentAddress)
        {
            int l = left.Evaluate(parser, currentAddress);
            int m = middle.Evaluate(parser, currentAddress);
            int r = right.Evaluate(parser, currentAddress);
            switch (operation)
            {
                case TernaryOperation.If:
                    return (l != 0) ? m : r;
                default:
                    throw new InvalidOperationException();
            }
        }

        public override string ToString()
        {
            switch (operation)
            {
                case TernaryOperation.If:
                    return left.ToString() + " ? " + middle.ToString() + " : " + right.ToString();
                default:
                    throw new InvalidOperationException();
            }
        }

        private TernaryOperation operation;
        private Expression middle;
        private Expression left;
        private Expression right;
    }
}