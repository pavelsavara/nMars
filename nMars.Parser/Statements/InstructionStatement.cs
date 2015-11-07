// This file is part of nMars - Core War MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using com.calitha.goldparser;
using nMars.Parser.Expressions;
using nMars.Parser.Warrior;
using nMars.RedCode;

namespace nMars.Parser.Statements
{
    public class InstructionStatement : Statement
    {
        public InstructionStatement(Operation operation, Modifier modifier, Parameter a, Parameter b, Location location)
            : base(location)
        {
            Operation = operation;
            Modifier = modifier;
            A = a;
            B = b;
            Location = location;
        }

        public string OriginalInstruction
        {
            get { return ToString(); }
        }

        public Operation Operation;
        public Modifier Modifier;
        public Parameter A;
        public Parameter B;

        public override void ExpandStatements(ExtendedWarrior warrior, WarriorParser parser, ref int currentAddress,
                                              int coreSize, bool evaluate)
        {
            //set all labels
            foreach (LabelName label in Labels)
            {
                parser.variables[label.GetFullName(parser, currentAddress)] = new Address(currentAddress);
            }

            ExtendedInstruction instruction;
            if (!evaluate)
            {
                instruction =
                    new ExtendedInstruction(Operation, Modifier, A.Mode, Int32.MinValue, B.Mode, Int32.MinValue);
                instruction.Address = currentAddress;
                warrior.Add(instruction);
            }
            else
            {
                instruction = (ExtendedInstruction)warrior.Instructions[currentAddress];
                instruction.ValueA = Instruction.Mod(A.Expression.Evaluate(parser, currentAddress, coreSize), coreSize);
                instruction.ValueB = Instruction.Mod(B.Expression.Evaluate(parser, currentAddress, coreSize), coreSize);
                instruction.ExpressionA = A.Expression.ToString();
                instruction.ExpressionB = B.Expression.ToString();
                if (instruction.ModeA == Mode.NULL)
                {
                    instruction.ModeA=A.Expression.GetMode(parser, currentAddress);
                }
                if (instruction.ModeA == Mode.NULL)
                {
                    instruction.ModeA = Mode.Direct;
                }
                if (instruction.ModeB == Mode.NULL)
                {
                    instruction.ModeB=B.Expression.GetMode(parser, currentAddress);
                }
                if (instruction.ModeB == Mode.NULL)
                {
                    instruction.ModeB = Mode.Direct;
                }
                if (instruction.Modifier == Modifier.NULL)
                {
                    instruction.Modifier =
                        Instruction.DefaultModifier(instruction.Operation, instruction.ModeA, instruction.ModeB);
                }

                if (Comments != null)
                {
                    instruction.Comment = Comments[Comments.Count - 1];
                }
                else
                {
                    instruction.Comment = "";
                }
                instruction.OriginalInstruction = OriginalInstruction;


                if (Labels.Count > 0)
                {
                    instruction.Label = Labels[Labels.Count - 1].GetFullName(parser, currentAddress);
                }
                else
                {
                    instruction.Label = "";
                }
            }
            currentAddress++;
            parser.variables["CURLINE"] = new Value(currentAddress);
        }


        public override string ToString()
        {
            return
                Operation.ToString() + "." + Modifier.ToString().PadRight(5) + " " + A.ToString().PadRight(15) + "," +
                B.ToString().PadRight(15);
        }
    }
}