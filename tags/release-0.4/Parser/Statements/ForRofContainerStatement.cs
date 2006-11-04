// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using nMars.Parser.Expressions;
using nMars.Parser.Warrior;

namespace nMars.Parser.Statements
{
    public class ForRofContainerStatement : ContainerStatement
    {
        public override void ExpandStatements(ExtendedWarrior warrior, nMarsParser parser,
                                              ref int currentAddress, int coreSize, bool evaluate)
        {
            //set labels, except last which is FOR expression
            for (int l = 0; l < Labels.Count - 1; l++)
            {
                LabelName label = Labels[l];
                parser.variables[label.GetFullName(parser, currentAddress)] = new Address(currentAddress);
            }

            string cnt = Labels[Labels.Count - 1].Name;
            int count = parser.variables[cnt + "#start"].Evaluate(parser, currentAddress);

            for (int i = 1; i <= count; i++)
            {
                parser.variables[cnt] = new Value(i);
                base.ExpandStatements(warrior, parser, ref currentAddress, coreSize, evaluate);
            }
        }
    }
}