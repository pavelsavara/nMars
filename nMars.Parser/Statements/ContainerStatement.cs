// This file is part of nMars - Core War MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.Collections.Generic;
using com.calitha.goldparser;
using nMars.Parser.Warrior;

namespace nMars.Parser.Statements
{
    public class ContainerStatement : Statement
    {
        public ContainerStatement(Location location)
            : base(location)
        {
        }

        public ContainerStatement(Statement instruction, Location location)
            : base(location)
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

        public void AppendComments(List<string> comments)
        {
            if (comments != null && comments.Count > 0 && Statements.Count > 0)
                Statements[Statements.Count - 1].Comments = comments;
        }

        public override void ExpandStatements(ExtendedWarrior warrior, WarriorParser parser, ref int currentAddress,
                                              int coreSize, bool evaluate)
        {
            foreach (Statement statement in Statements)
            {
                statement.ExpandStatements(warrior, parser, ref currentAddress, coreSize, evaluate);
            }
        }

        public List<Statement> Statements = new List<Statement>();
    }
}