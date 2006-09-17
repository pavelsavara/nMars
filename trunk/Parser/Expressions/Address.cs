using System.Collections.Generic;

namespace nMars.Parser.Expressions
{
    class Address : Value
    {
        public Address(int value)
            : base(value)
        {
        }

        public override bool ContainsAddress(Dictionary<string, Expression> variables)
        {
            return true;
        }
    }
}