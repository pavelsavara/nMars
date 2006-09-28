// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.Collections.Generic;

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

        public override string GetFullName(Dictionary<string, Expression> variables, int currentAddress)
        {
            return name + parameter.Evaluate(variables, currentAddress).ToString("00");
        }
    }
}