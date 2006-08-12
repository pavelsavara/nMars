using System;

namespace nMars.Parser
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

        private int value = 0;

        public override int Evaluate()
        {
            return value;
        }

        public override string ToString()
        {
            return value.ToString();
        }

        public static readonly Value Zero = new Value(0);
    }
}