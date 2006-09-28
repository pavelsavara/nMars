// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.Collections.Generic;

namespace nMars.Parser.Expressions
{
    class Address : Value
    {
        public Address(int value)
            : base(value)
        {
        }

        public override int Evaluate(Dictionary<string, Expression> variables, int currentAddress)
        {
            return value - currentAddress;
        }
    }
}