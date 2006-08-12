using System;
using System.IO;
using nMars.RedCode;

namespace nMars.Parser
{
    public class RedCodeParser : RedCodeTree, IParser
    {
        public RedCodeParser(Rules rules)
            : base(rules)
        {
        }

        public IWarrior Load(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);
            string source = sr.ReadToEnd();
            sr.Close();
            return Parse(source, Path.GetFileNameWithoutExtension(fileName));
        }

        public IWarrior Parse(string source, string implicitName)
        {
            Prepare();
            ContainerStatement container = Parse(source);
            ExtendedWarrior warrior = new ExtendedWarrior(rules);

            Translate(container, warrior);

            warrior.Name = implicitName;
            if (org != null)
            {
                if (!labels.ContainsKey(org))
                {
                    throw new Exception("Variable not defined : " + org);
                }
                warrior.StartOffset = labels[org].Address;
            }
            else
            {
                warrior.StartOffset = 0;
            }
            warrior.Variables = variables;
            return warrior;
        }

        private void Translate(ContainerStatement container, ExtendedWarrior warrior)
        {
            foreach (Statement statement in container.Statements)
            {
                if (statement is InstructionStatement)
                {
                    Translate((InstructionStatement) statement, warrior);
                }
                else if (statement is ForRofContainerStatement)
                {
                    Translate((ForRofContainerStatement) statement, warrior);
                }
                else if (statement is ContainerStatement)
                {
                    Translate((ContainerStatement) statement, warrior);
                }
                else
                {
                    throw new InvalidOperationException("Unknown statement");
                }
            }
        }

        private void Translate(ForRofContainerStatement statement, ExtendedWarrior warrior)
        {
            int count = variables[statement.Label].Evaluate();
            for (int i = 1; i <= count; i++)
            {
                variables[statement.Label] = new Value(i);
                Translate(statement.Container, warrior);
            }
        }

        private void Translate(InstructionStatement statement, ExtendedWarrior warrior)
        {
            int valA;
            int valB;
            if (statement.Address == -1)
            {
                statement.Address = warrior.Length;
            }
            variables["curline"] = new Value(warrior.Length);
            Variable va = statement.A.Expression as Variable;
            Variable vb = statement.B.Expression as Variable;
            if (va != null && va.IsLabel)
            {
                valA = statement.A.Value - warrior.Length;
            }
            else
            {
                valA = statement.A.Value;
            }
            if (vb != null && vb.IsLabel)
            {
                valB = statement.B.Value - warrior.Length;
            }
            else
            {
                valB = statement.B.Value;
            }

            ExtendedInstruction instruction = new ExtendedInstruction(
                statement.Operation,
                statement.Modifier,
                statement.A.Mode, valA,
                statement.B.Mode, valB
                );

            instruction.Address = warrior.Length;
            instruction.Label = statement.Label;
            instruction.Comment = statement.Comment;
            instruction.OriginalInstruction = statement.OriginalInstruction;

            warrior.Instructions.Add(instruction);
        }
    }
}
