// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using com.calitha.goldparser;
using nMars.RedCode;

namespace nMars.Parser.Expressions
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

        public BinaryExpression(Location location, Expression left, Expression right, BinaryOperation operation)
            : base(location)
        {
            this.left = left;
            this.right = right;
            this.operation = operation;
        }

        private BinaryOperation operation;
        private Expression left;
        private Expression right;

        public override int Evaluate(WarriorParser parser, int currentAddress)
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
                        parser.WriteError("Divide by zero during evaluation of " + ToString() + " at " + Location, Location);
                        return 0;
                    }
                    return l / r;
                case BinaryOperation.Modulo:
                    if (r == 0)
                    {
                        parser.WriteError("Divide by zero during evaluation of " + ToString() + " at " + Location, Location);
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
                    return left + " + " + right;
                case BinaryOperation.Minus:
                    return left + " - " + right;
                case BinaryOperation.Multiply:
                    return left + " * " + right;
                case BinaryOperation.Divide:
                    return left + " / " + right;
                case BinaryOperation.Modulo:
                    return left + " % " + right;
                case BinaryOperation.BinOr:
                    return left + " | " + right;
                case BinaryOperation.BinXor:
                    return left + " ^ " + right;
                case BinaryOperation.BinAnd:
                    return left + " &&& " + right;
                case BinaryOperation.Shl:
                    return left + " << " + right;
                case BinaryOperation.Shr:
                    return left + " >> " + right;
                case BinaryOperation.Or:
                    return left + " || " + right;
                case BinaryOperation.And:
                    return left + " && " + right;
                case BinaryOperation.CompareGt:
                    return left + " > " + right;
                case BinaryOperation.CompareGe:
                    return left + " >= " + right;
                case BinaryOperation.CompareLe:
                    return left + " <= " + right;
                case BinaryOperation.CompareLt:
                    return left + " < " + right;
                case BinaryOperation.CompareEq:
                    return left + " == " + right;
                case BinaryOperation.CompareNe:
                    return left + " != " + right;
                default:
                    throw new InvalidOperationException();
            }
        }

        public override Mode GetMode(WarriorParser parser, int currentAddress)
        {
            Mode l = left.GetMode(parser, currentAddress);
            if (l != Mode.NULL)
                return l;
            return right.GetMode(parser, currentAddress);
        }
    }
}