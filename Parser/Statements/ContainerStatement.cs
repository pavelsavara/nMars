using System.Collections.Generic;

namespace nMars.Parser
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

        public List<Statement> Statements = new List<Statement>();
    }
}