using System.Collections.Generic;
using nMars.Parser.Warrior;

namespace nMars.Parser.Statements
{
    public class ContainerStatement : Statement
    {
        public ContainerStatement()
        {
        }

        public ContainerStatement(Statement instruction)
        {
            if (instruction != null)
                Statements.Add(instruction);
        }

        public void Insert(Statement instruction)
        {
            if (instruction != null)
                Statements.Insert(0, instruction);
        }

        public void Add(Statement instruction)
        {
            if (instruction != null)
                Statements.Add(instruction);
        }

        public override void ExpandStatements(ExtendedWarrior warrior, Dictionary<string, Expression> variables,
                                              ref int currentAddress, int coreSize, bool evaluate)
        {
            foreach (Statement statement in Statements)
            {
                statement.ExpandStatements(warrior, variables, ref currentAddress, coreSize, evaluate);
            }
        }

        public List<Statement> Statements = new List<Statement>();
    }
}