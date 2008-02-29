using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using nMars.Engine;
using nMars.Parser;
using nMars.Parser.Warrior;
using nMars.RedCode;

namespace nMars.Generator
{
    public class EngineTest
    {
        private EngineSteps engine;
        private WarriorParser parser;
        private Instruction empty = new Instruction();
        private Rules rules = Rules.SingleRules;
        public void Generate()
        {
            engine = new EngineSteps();
            parser = new WarriorParser();
            Generator.Generate(ProcessInstruction);
        }
        
        private Random rand = new Random(0);

        public bool ProcessInstruction(ExtendedInstruction test)
        {
            ProcessInstructionInternal(new ExtendedInstruction(test), "test", "test", "dat1", "dat2");
            ProcessInstructionInternal(new ExtendedInstruction(test), "test", "dat3", "dat1", "dat2");
            ProcessInstructionInternal(new ExtendedInstruction(test), "dat3", "test", "dat1", "dat2");
            ProcessInstructionInternal(new ExtendedInstruction(test), "dat3", "dat3", "dat1", "dat2");
            ProcessInstructionInternal(new ExtendedInstruction(test), "dat1", "dat2", "dat1", "dat2");
            ProcessInstructionInternal(new ExtendedInstruction(test), "dat2", "dat1", "dat1", "dat2");
            return false;
        }

        public void ProcessInstructionInternal(ExtendedInstruction test, string tA, string tB, string dA, string dB)
        {
            string name = "test-" + test.Operation + "." + test.Modifier + "-" + test.ModeA + tA + "-" + test.ModeB + tB +
                          "-" + dA + dB + ".red";

            ExtendedWarrior w = new ExtendedWarrior(rules);

            w.FileName = @"N:\nMarsRelease\regression\gen\" + name;
            w.Name = name;
            w.Author = "Pavel Savara";
            w.Date = DateTime.Today.ToShortDateString();

            ExtendedInstruction dat1 = new ExtendedInstruction();
            dat1.Modifier = Modifier.A;
            dat1.Label = "dat1";
            dat1.ValueA = rand.Next(0, Rules.DefaultRules.CoreSize - 1);
            dat1.ValueB = rand.Next(0, Rules.DefaultRules.CoreSize - 1);
            w.Add(dat1);

            ExtendedInstruction dat2 = new ExtendedInstruction();
            dat2.Modifier = Modifier.B;
            dat2.Label = "dat2";
            dat2.ValueA = rand.Next(0, Rules.DefaultRules.CoreSize - 1);
            dat2.ValueB = rand.Next(0, Rules.DefaultRules.CoreSize - 1);
            w.Add(dat2);

            ExtendedInstruction dat3 = new ExtendedInstruction();
            dat3.Modifier = Modifier.AB;
            dat3.Label = "dat3";
            dat3.ExpressionA = dA;
            dat3.ExpressionB = dB;
            w.Add(dat3);

            //tested instruction
            test.Label = "test";
            test.ExpressionA = tA;
            test.ExpressionB = tB;
            w.Add(test);
            w.StartOffset = test.Address;

            ExtendedInstruction step = new ExtendedInstruction();
            //step.Modifier = Modifier.BA;
            step.Label = "step";
            w.Add(step);

            ExtendedInstruction skip = new ExtendedInstruction();
            //skip.Modifier = Modifier.X;
            skip.Label = "skip";
            w.Add(skip);

            ExtendedInstruction jump = new ExtendedInstruction();
            //jump.Modifier = Modifier.I;
            jump.Label = "jump";
            w.Add(jump);

            switch (test.ModeA)
            {
                case Mode.Direct:
                case Mode.Immediate:
                    test.ExpressionA = "dat1";
                    break;
                default:
                    break;
            }
            switch (test.ModeB)
            {
                case Mode.Direct:
                case Mode.Immediate:
                    test.ExpressionB = "dat2";
                    break;
                default:
                    break;
            }
            switch (test.Operation)
            {
                case Operation.JMZ:
                case Operation.JMP:
                case Operation.JMN:
                case Operation.DJN:
                case Operation.SLT:
                case Operation.SNE:
                    switch (test.ModeA)
                    {
                        case Mode.Direct:
                            test.ExpressionA = "skip";
                            break;
                        case Mode.Immediate:
                            //jump to same address
                            File.Delete(w.FileName);
                            return;
                        case Mode.IndirectA:
                        case Mode.PreDecIndirectA:
                        case Mode.PostIncIndirectA:
                            test.ExpressionA = "dat1";
                            dat1.ExpressionA = "skip";
                            break;
                        case Mode.IndirectB:
                        case Mode.PreDecIndirectB:
                        case Mode.PostIncIndirectB:
                            test.ExpressionA = "dat2";
                            dat2.ExpressionB = "skip";
                            break;
                        default:
                            throw new NotImplementedException();
                    }
                    /*switch (test.ModeB)
                    {
                        case Mode.Direct:
                        case Mode.Immediate:
                            test.ExpressionB = "skip";
                            break;
                        case Mode.IndirectA:
                        case Mode.PreDecIndirectA:
                        case Mode.PostIncIndirectA:
                            test.ExpressionB = "dat1";
                            dat1.ExpressionA = "skip-test";
                            break;
                        case Mode.IndirectB:
                        case Mode.PreDecIndirectB:
                        case Mode.PostIncIndirectB:
                            test.ExpressionB = "dat2";
                            dat2.ExpressionB = "skip-test";
                            break;
                        default:
                            throw new NotImplementedException();
                    }*/
                    break;
                default:
                    break;
            }

            DumpWarrior(w, ParserOptions.Full);

            Project project = new Project(rules);
            project.WarriorFiles.Add(w.FileName);
            parser.Parse(project, null);

            engine.BeginMatch(project);
            engine.NextStep();

            if (engine.NextInstructionAddress == skip.Address)
            {
                skip.Operation = Operation.JMP;
                skip.ExpressionA = "cck0";
                /*
                step.Label = "k1ll";
                jump.Label = "k3ll";
                 */
            }
            else if (engine.NextInstructionAddress == step.Address)
            {
                step.Operation = Operation.JMP;
                step.ExpressionA = "cck0";
                /*
                skip.Label = "k2ll";
                jump.Label = "k3ll";
                 */
            }
            else if (engine.NextInstructionAddress == jump.Address)
            {
                jump.Operation = Operation.JMP;
                jump.ExpressionA = "cck0";
                /*
                skip.Label = "k1ll";
                step.Label = "k2ll";
                 */
            }
            else if (engine.NextInstructionAddress == -1)
            {
                //died
                File.Delete(w.FileName);
                return;
            }
            else
            {
                while(true)
                {
                    engine.EndMatch(null);
                    engine.BeginMatch(project);
                    engine.NextStep();
                }
            }

            List<ExtendedInstruction> check=new List<ExtendedInstruction>();

            for (int address = 0; address < rules.CoreSize; address++)
            {
                IRunningInstruction runningInstruction = engine[address];
                if (!runningInstruction.Equals(empty) || address<=w.StartOffset)
                {
                    ExtendedInstruction cck = new ExtendedInstruction();
                    cck.Operation = Operation.CMP;
                    cck.Modifier = Modifier.I;
                    cck.ExpressionA = "cpy" + check.Count;
                    cck.ExpressionB = runningInstruction.Address + "+" + "dat1";
                    cck.Label = "cck" + check.Count;
                    w.Add(cck);

                    ExtendedInstruction killer=new ExtendedInstruction();
                    killer.Label = "klr" + check.Count;
                    killer.Modifier = Modifier.I;
                    w.Add(killer);

                    ExtendedInstruction copy = new ExtendedInstruction(runningInstruction);
                    copy.Label = "cpy" + check.Count;
                    check.Add(copy);
                }
            }

            ExtendedInstruction loop = new ExtendedInstruction();
            loop.Label = "loop";
            loop.Operation = Operation.JMP;
            w.Add(loop);

            engine.EndMatch(null);

            foreach (ExtendedInstruction ccks in check)
            {
                w.Add(ccks);
            }

            DumpWarrior(w, ParserOptions.Full);
            parser.Parse(project, null);
            DumpWarrior(project.Warriors[0], ParserOptions.Pure);
        }

        private static void DumpWarrior(IWarrior w, ParserOptions opt)
        {
            StreamWriter sw = new StreamWriter(w.FileName);
            WrappedTextWriter wr=new WrappedTextWriter(sw);
            w.Dump(wr, opt);
            sw.Close();
        }
    }
}
