// This file is part of nMars - Core War MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

namespace nMars.Parser.Expressions
{
    public class Address : Value
    {
        public Address(int value)
            : base(value)
        {
        }

        public override int Evaluate(WarriorParser parser, int currentAddress)
        {
            return value - currentAddress;
        }
    }
}