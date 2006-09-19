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