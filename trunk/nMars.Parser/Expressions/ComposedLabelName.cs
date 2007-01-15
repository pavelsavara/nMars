// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

namespace nMars.Parser.Expressions
{
    public class ComposedLabelName : LabelName
    {
        public ComposedLabelName(string labelName, string parameter)
            : base(labelName)
        {
            this.parameter = new LabelName(parameter);
        }

        protected LabelName parameter;

        public override string Name
        {
            get { return name + "&" + parameter; }
        }

        public override string GetFullName(Parser parser, int currentAddress)
        {
            return name + parameter.Evaluate(parser, currentAddress).ToString("00");
        }
    }
}