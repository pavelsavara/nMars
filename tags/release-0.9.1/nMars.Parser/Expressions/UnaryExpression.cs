// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using com.calitha.goldparser;
using nMars.RedCode;

namespace nMars.Parser.Expressions
{
    public class UnaryExpression : Expression
    {
        public enum UnaryOperation
        {
            Negate,
            Brackets,
        }

        public UnaryExpression(Location location, Expression sub, UnaryOperation operation)
            : base(location)
        {
            this.sub = sub;
            this.operation = operation;
        }

        private UnaryOperation operation;
        private Expression sub;

        public override int Evaluate(WarriorParser parser, int currentAddress)
        {
            switch (operation)
            {
                case UnaryOperation.Negate:
                    return 0 - sub.Evaluate(parser, currentAddress);
                case UnaryOperation.Brackets:
                    return sub.Evaluate(parser, currentAddress);
                default:
                    throw new InvalidOperationException();
            }
        }

        public override string ToString()
        {
            switch (operation)
            {
                case UnaryOperation.Negate:
                    return "-" + sub;
                case UnaryOperation.Brackets:
                    return "(" + sub + ")";
                default:
                    throw new InvalidOperationException();
            }
        }

        public override Mode GetMode(WarriorParser parser, int currentAddress)
        {
            return sub.GetMode(parser, currentAddress);
        }
    }
}