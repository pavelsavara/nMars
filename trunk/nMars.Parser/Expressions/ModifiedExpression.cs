// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using nMars.RedCode;

namespace nMars.Parser.Expressions
{
    class ModifiedExpression : Expression
    {
        public ModifiedExpression(Expression original, Mode mode)
        {
            Original = original;
            Mode = mode;
        }
        
        public override int Evaluate(Parser parser, int currentAddress)
        {
            return Original.Evaluate(parser, currentAddress);
        }

        public override Mode GetMode(Parser parser, int currentAddress)
        {
            return Mode;
        }

        private Expression Original;
        private Mode Mode;

    }
}
