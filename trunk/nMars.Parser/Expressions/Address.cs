// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

namespace nMars.Parser.Expressions
{
    class Address : Value
    {
        public Address(int value)
            : base(value)
        {
        }

        public override int Evaluate(Parser parser, int currentAddress)
        {
            return value - currentAddress;
        }
    }
}