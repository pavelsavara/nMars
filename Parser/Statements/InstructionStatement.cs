using System;
using System.Collections.Generic;
using com.calitha.goldparser;
using nMars.Parser.Expressions;
using nMars.Parser.Warrior;
using nMars.RedCode;

namespace nMars.Parser.Statements
{
    public class InstructionStatement : Statement
    {
        public InstructionStatement(Operation operation, Modifier modifier, Parameter a, Parameter b, Location location)
        {
            Operation = operation;
            Modifier = modifier;
            A = a;
            B = b;
            Location = location;
        }

        public string Comment = "";

        public string OriginalInstruction
        {
            get { return ToString(); }
        }

        public Operation Operation;
        public Modifier Modifier;
        public Parameter A;
        public Parameter B;
        public Location Location;


        public override void ExpandStatements(ExtendedWarrior warrior, Dictionary<string, Expression> variables,
                                              ref int currentAddress, int coreSize, bool evaluate)
        {
            //set all labels
            variables["CURLINE"] = new Address(currentAddress);
            foreach (LabelName label in Labels)
            {
                variables[label.GetFullName(variables)] = new Address(currentAddress);
            }

            ExtendedInstruction instruction;
            if (!evaluate)
            {
                instruction = new ExtendedInstruction(
                    Operation,
                    Modifier,
                    A.Mode, Int32.MinValue,
                    B.Mode, Int32.MinValue);
                instruction.Address = currentAddress;
                if (Labels.Count > 0)
                {
                    instruction.Label = Labels[Labels.Count - 1].Name;
                }
                else
                {
                    instruction.Label = "";
                }
                instruction.Comment = Comment;
                instruction.OriginalInstruction = OriginalInstruction;
                warrior.Instructions.Add(instruction);
            }
            else
            {
                instruction = warrior.Instructions[currentAddress];
                instruction.ValueA = A.Expression.Evaluate(variables, coreSize, currentAddress);
                instruction.ValueB = B.Expression.Evaluate(variables, coreSize, currentAddress);
            }
            currentAddress++;
        }


        public override string ToString()
        {
            return
                Operation.ToString() + "." + Modifier.ToString().PadRight(5) + " " + A.ToString().PadRight(15) + "," +
                B.ToString().PadRight(15);
        }
    }
}