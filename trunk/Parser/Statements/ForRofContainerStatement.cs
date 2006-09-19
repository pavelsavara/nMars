using System.Collections.Generic;
using nMars.Parser.Expressions;
using nMars.Parser.Warrior;

namespace nMars.Parser.Statements
{
    public class ForRofContainerStatement : ContainerStatement
    {
        public ForRofContainerStatement(string comment)
        {
            Comment = comment;
        }

        public override void ExpandStatements(ExtendedWarrior warrior, Dictionary<string, Expression> variables,
                                              ref int currentAddress, int coreSize, bool evaluate)
        {
            //set labels, except last which is FOR expression
            for (int l = 0; l < Labels.Count - 1; l++)
            {
                LabelName label = Labels[l];
                variables[label.GetFullName(variables, currentAddress)] = new Address(currentAddress);
            }

            string cnt = Labels[Labels.Count - 1].Name;
            int count = variables[cnt + "#start"].Evaluate(variables, currentAddress);

            for (int i = 1; i <= count; i++)
            {
                variables[cnt] = new Value(i);
                base.ExpandStatements(warrior, variables, ref currentAddress, coreSize, evaluate);
            }
        }

        public string Comment;
    }
}