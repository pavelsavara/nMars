// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using nMars.RedCode;

namespace nMars.Parser.Expressions
{
    public class Value : Expression
    {
        public Value(int value)
        {
            this.value = value;
        }

        public Value(string value)
        {
            this.value = Int32.Parse(value);
        }

        protected int value = 0;

        public override int Evaluate(Parser parser, int currentAddress)
        {
            return value;
        }

        public override string ToString()
        {
            return value.ToString();
        }

        public override Mode GetMode(Parser parser, int currentAddress)
        {
            return Mode.NULL;
        }

        public static readonly Value Zero = new Value(0);
    }
}