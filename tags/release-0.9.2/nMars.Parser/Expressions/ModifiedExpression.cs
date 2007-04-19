// This file is part of nMars - Core War MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using com.calitha.goldparser;
using nMars.RedCode;

namespace nMars.Parser.Expressions
{
    public class ModifiedExpression : Expression
    {
        public ModifiedExpression(Location location, Expression original, Mode mode)
            : base(location)
        {
            Original = original;
            Mode = mode;
        }
        
        public override int Evaluate(WarriorParser parser, int currentAddress)
        {
            return Original.Evaluate(parser, currentAddress);
        }

        public override Mode GetMode(WarriorParser parser, int currentAddress)
        {
            return Mode;
        }

        private Expression Original;
        private Mode Mode;

    }
}
