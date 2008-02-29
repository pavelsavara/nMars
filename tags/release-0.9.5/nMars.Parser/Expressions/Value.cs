// This file is part of nMars - Core War MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using com.calitha.goldparser;
using nMars.RedCode;

namespace nMars.Parser.Expressions
{
    public class Value : Expression
    {
        public Value(int value)
            : base(null)
        {
            this.value = value;
        }

        public Value(Location location, int value)
            : base(location)
        {
            this.value = value;
        }

        public Value(Location location, string value)
            : base(location)
        {
            this.value = Int32.Parse(value);
        }

        protected int value = 0;

        public override int Evaluate(WarriorParser parser, int currentAddress)
        {
            return value;
        }

        public override string ToString()
        {
            return value.ToString();
        }

        public override Mode GetMode(WarriorParser parser, int currentAddress)
        {
            return Mode.NULL;
        }

        public static readonly Value Zero = new Value(0);
    }
}