using System;
using System.IO;
using System.Text;
using nMars.Parser.Warrior;
using nMars.RedCode;

namespace nMars.Generator
{
    class Gen
    {
        public void Generate()
        {
            swm = new StreamWriter(@"N:\nMars\nMars.Fngine\Fngine\Fngine01Instructions.cs");
            swm.WriteLine("using nMars.RedCode;");
            swm.WriteLine("using nMars.Engine;");
            swm.WriteLine("using System;");
            swm.WriteLine("namespace nMars.Fngine.Fngine");
            swm.WriteLine("{");
            swm.WriteLine("    public partial class Fngine");
            swm.WriteLine("    {");
            swm.WriteLine("        public Fn GetGenFunction(int code)");
            swm.WriteLine("        {");
            swm.WriteLine("            switch(code)");
            swm.WriteLine("            {");


            Generator.Generate(ProcessInstruction);
            sw.WriteLine("    }");
            sw.WriteLine("}");
            sw.Close();


            swm.WriteLine("             default: throw new NotImplementedException();");
            swm.WriteLine("            }");
            swm.WriteLine("        }");
            swm.WriteLine("    }");
            swm.WriteLine("}");
            swm.Close();
        }

        private StreamWriter sw=null;
        private StreamWriter swm = null;

        private ExtendedInstruction last =
            new ExtendedInstruction(Operation.STP, Modifier.NULL, Mode.NULL, 0, Mode.NULL, 0);

        public bool ProcessInstruction(ExtendedInstruction instruction)
        {
            if (last.Operation != instruction.Operation)
            {
                if (sw != null)
                {
                    sw.WriteLine("    }");
                    sw.WriteLine("}");
                    sw.Close();
                }

                sw = new StreamWriter(@"N:\nMars\nMars.Fngine\Fngine\Fngine01Instructions" + 
                    instruction.Operation + ".cs");
                sw.WriteLine("using nMars.RedCode;");
                sw.WriteLine("using nMars.Engine;");
                sw.WriteLine("namespace nMars.Fngine.Fngine");
                sw.WriteLine("{");
                sw.WriteLine("    public partial class Fngine");
                sw.WriteLine("    {");
                
            }
            last = instruction;

            swm.WriteLine("             case " + instruction.Code + ": return " + instruction.FunctionName +
                          ";");

            StringBuilder sb = new StringBuilder();
            sb.Append("        public void ");
            sb.Append(instruction.FunctionName);
            sb.AppendLine("(int ip, EngineWarrior warrior)");
            sb.AppendLine("        {");
            sb.AppendLine(@"

            int reg_IR_ValueA = ValuesA[ip];
            int reg_IR_ValueB = ValuesB[ip];
            int reg_IR_ValueACpy = ValuesA[ip];
            int reg_IR_ValueBCpy = ValuesB[ip];
            int reg_AdrA;
            int reg_AdrB;
            int reg_AA_Value;
            int reg_AB_Value;
            int direct;
            bool jump = false;
            bool die = false;
            int psAddress;

            reg_AA_Value = reg_IR_ValueA;
            reg_AB_Value = reg_IR_ValueA;");

            GetEffectiveAddress(sb, instruction.ModeA, "reg_AdrA", "reg_AA_Value", "reg_IR_ValueA", "reg_IR_ValueACpy");
            GetEffectiveAddress(sb, instruction.ModeB, "reg_AdrB", "reg_AB_Value", "reg_IR_ValueB", "reg_IR_ValueBCpy");

            ExecuteInstruction(sb, instruction.Operation, instruction.Modifier);

            sb.AppendLine("        }");

            sw.WriteLine(sb);
            return false;
        }

        protected static void GetEffectiveAddress(StringBuilder sb, Mode mode, string indirect, string AX_Value, string IR_X, string primary)
        {
            switch (mode)
            {
                case Mode.PreDecIndirectA:
                    sb.AppendLine(@"
                    direct = mod(" + primary + @" + ip);
                    " + indirect + @" = mod(direct + (--ValuesA[direct]));
                    " +AX_Value+@" = ValuesA[" + indirect + @"];
                    "+IR_X+@" = ValuesB[" + indirect + @"];
                    "); return;
                case Mode.PreDecIndirectB:
                    sb.AppendLine(@"
                    direct = mod("+primary+@" + ip);
                    " + indirect + @" = mod(direct + (--ValuesB[direct]));
                    " +AX_Value+@" = ValuesA[" + indirect + @"];
                    "+IR_X+@" = ValuesB[" + indirect + @"];
                    "); return;
                case Mode.IndirectA:
                    sb.AppendLine(@"
                    direct = mod("+primary+@" + ip);
                    " + indirect + @" = mod(direct + ValuesA[direct]);
                    " + AX_Value + @" = ValuesA[" + indirect + @"];
                    " + IR_X + @" = ValuesB[" + indirect + @"];
                    "); return;
                case Mode.IndirectB:
                    sb.AppendLine(@"
                    direct = mod("+primary+@" + ip);
                    " + indirect + @" = mod(direct + ValuesB[direct]);
                    " + AX_Value + @" = ValuesA[" + indirect + @"];
                    " + IR_X + @" = ValuesB[" + indirect + @"];
                    "); return;
                case Mode.PostIncIndirectA:
                    sb.AppendLine(@"
                    direct = mod("+primary+@" + ip);
                    " + indirect + @" = mod(direct + ValuesA[direct]);
                    " +AX_Value+@" = ValuesA[" + indirect + @"];
                    "+IR_X+@" = ValuesB[" + indirect + @"];
                    ValuesA[direct]++;
                    "); return;
                case Mode.PostIncIndirectB:
                    sb.AppendLine(@"
                    direct = mod("+primary+@" + ip);
                    " + indirect + @" = mod(direct + ValuesB[direct]);
                    " +AX_Value+@" = ValuesA[" + indirect + @"];
                    "+IR_X+@" = ValuesB[" + indirect + @"];
                    ValuesB[direct]++;
                    "); return;
                case Mode.Direct:
                    sb.AppendLine(@"
                    direct = mod("+primary+@" + ip);
                    " + AX_Value + @" = ValuesA[direct];
                    " +IR_X+@" = ValuesB[direct];
                    " + indirect+@" = direct;
                    "); return;
                case Mode.Immediate:
                    sb.AppendLine(@"
                    "+indirect+@" = ip;
                    "+IR_X+@" = reg_IR_ValueB;
                    "); return;
                default:
                    throw new InvalidOperationException("Unknown Mode");
            }
        }
        
        private static void ExecuteInstruction(StringBuilder sb, Operation operation, Modifier modifier)
        {
            bool alowdie = false;
            switch (operation)
            {
                #region Simple

                case Operation.DAT:
                    alowdie = true;
                    sb.AppendLine(@"die = true;");
                    break;
                case Operation.NOP:
                    sb.AppendLine(@"ip++;");
                    break;
                case Operation.SPL:
                    sb.AppendLine(@"
                    if (warrior.LiveTasks + 1 < rules.MaxProcesses)
                    {
                        warrior.Tasks.Enqueue(mod(ip + 1));
                        ip = reg_AdrA;
                        Split(reg_AdrA);
                    }
                    else
                    {
                        ip++;
                    }");
                    break;
                case Operation.JMP:
                    sb.AppendLine(@"ip = reg_AdrA;");
                    break;

                #endregion

                #region JMZ

                case Operation.JMZ:
                    switch (modifier)
                    {
                        case Modifier.BA:
                        case Modifier.A:
                            sb.AppendLine(@"jump = (reg_AB_Value == 0);");
                            break;
                        case Modifier.F:
                        case Modifier.X:
                        case Modifier.I:
                            sb.AppendLine(@"jump = (reg_AB_Value == 0 && reg_IR_ValueB == 0);");
                            break;
                        case Modifier.B:
                        case Modifier.AB:
                            sb.AppendLine(@"jump = (reg_IR_ValueB == 0);"); 
                            break;
                    }
                    sb.AppendLine(@"
                    if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;
");
                    break;

                #endregion

                #region JMN

                case Operation.JMN:
                    switch (modifier)
                    {
                        case Modifier.BA:
                        case Modifier.A:
                            sb.AppendLine(@"jump = !(reg_AB_Value == 0);"); 
                            break;
                        case Modifier.B:
                        case Modifier.AB:
                            sb.AppendLine(@"jump = !(reg_IR_ValueB == 0);"); 
                            break;
                        case Modifier.F:
                        case Modifier.X:
                        case Modifier.I:
                            sb.AppendLine(@"jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);"); 
                            break;
                    }
                    sb.AppendLine(@"
                    if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;
");
                    break;

                #endregion

                #region DJN

                case Operation.DJN:
                    switch (modifier)
                    {
                        case Modifier.A:
                        case Modifier.BA:
                            sb.AppendLine(@"jump = (reg_AB_Value != 1);
                            ValuesA[reg_AdrB]--;"); 
                            break;
                        case Modifier.B:
                        case Modifier.AB:
                            sb.AppendLine(@"jump = (reg_IR_ValueB != 1);
                            ValuesB[reg_AdrB]--;"); 
                            break;
                        case Modifier.F:
                        case Modifier.X:
                        case Modifier.I:
                            sb.AppendLine(@"jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            ValuesA[reg_AdrB]--;
                            ValuesB[reg_AdrB]--;"); 
                            break;
                    }
                    sb.AppendLine(@"if (jump)
                        ip = reg_AdrA;
                    else
                        ip++;"); 
                    break;

                #endregion

                #region SEQ

                case Operation.CMP:
                    switch (modifier)
                    {
                        case Modifier.A:
                            sb.AppendLine(@"jump = (reg_AA_Value == reg_AB_Value);"); 
                            break;
                        case Modifier.B:
                            sb.AppendLine(@"jump = (reg_IR_ValueA == reg_IR_ValueB);");
                            break;
                        case Modifier.AB:
                            sb.AppendLine(@"jump = (reg_IR_ValueB == reg_AA_Value);");
                            break;
                        case Modifier.BA:
                            sb.AppendLine(@"jump = (reg_AB_Value == reg_IR_ValueA);");

                            break;
                        case Modifier.I:
                            sb.AppendLine(@"jump = (Operations[reg_AdrA] == Operations[reg_AdrB] &&
                                    reg_AA_Value == reg_AB_Value &&
                                    reg_IR_ValueA == reg_IR_ValueB);");
                            break;
                        case Modifier.F:
                            sb.AppendLine(@"jump = (reg_AA_Value == reg_AB_Value && reg_IR_ValueA == reg_IR_ValueB);");
                            break;
                        case Modifier.X:
                            sb.AppendLine(@"jump = (reg_IR_ValueB == reg_AA_Value && reg_AB_Value == reg_IR_ValueA);");
                            break;
                    }
                    sb.AppendLine(@"if (jump)
                        ip += 2;
                    else
                        ip++;");
                    break;

                #endregion

                #region SNE

                case Operation.SNE:

                    switch (modifier)
                    {
                        case Modifier.A:
                            sb.AppendLine(@"jump = (reg_AA_Value != reg_AB_Value);");
                            break;
                        case Modifier.B:
                            sb.AppendLine(@"jump = (reg_IR_ValueA != reg_IR_ValueB);");
                            break;
                        case Modifier.AB:
                            sb.AppendLine(@"jump = (reg_IR_ValueB != reg_AA_Value);");
                            break;
                        case Modifier.BA:
                            sb.AppendLine(@"jump = (reg_AB_Value != reg_IR_ValueA);");
                            break;
                        case Modifier.I:
                            sb.AppendLine(@"jump = (Operations[reg_AdrA] != Operations[reg_AdrB] ||
                                    reg_AB_Value != reg_AA_Value ||
                                    reg_IR_ValueA != reg_IR_ValueB);");
                            break;
                        case Modifier.F:
                            sb.AppendLine(@"jump = (reg_AA_Value != reg_AB_Value || reg_IR_ValueA != reg_IR_ValueB);");
                            break;
                        case Modifier.X:
                            sb.AppendLine(@"jump = (reg_IR_ValueB != reg_AA_Value || reg_AB_Value != reg_IR_ValueA);");
                            break;
                    }
                    sb.AppendLine(@"if (jump)
                        ip += 2;
                    else
                        ip++;");
                    break;

                #endregion

                #region SLT

                case Operation.SLT:

                    switch (modifier)
                    {
                        case Modifier.A:
                            sb.AppendLine(@"jump = (reg_AB_Value > reg_AA_Value);");
                            break;
                        case Modifier.B:
                            sb.AppendLine(@"jump = (reg_IR_ValueB > reg_IR_ValueA);");
                            break;
                        case Modifier.AB:
                            sb.AppendLine(@"jump = (reg_IR_ValueB > reg_AA_Value);");
                            break;
                        case Modifier.BA:
                            sb.AppendLine(@"jump = (reg_AB_Value > reg_IR_ValueA);");
                            break;
                        case Modifier.I:
                        case Modifier.F:
                            sb.AppendLine(@"jump = (reg_AB_Value > reg_AA_Value &&
                                    reg_IR_ValueB > reg_IR_ValueA);");
                            break;
                        case Modifier.X:
                            sb.AppendLine(@"jump = (reg_IR_ValueB > reg_AA_Value &&
                                    reg_AB_Value > reg_IR_ValueA);");
                            break;
                    }
                    sb.AppendLine(@"if (jump)
                        ip += 2;
                    else
                        ip++;");
                    break;

                #endregion

                #region Binary

                case Operation.MOD:
                case Operation.DIV:
                    alowdie = true;
                    BinOperation(sb, operation, modifier);
                    sb.AppendLine(@"ip++;");
                    break;
                case Operation.SUB:
                case Operation.ADD:
                case Operation.MUL:
                    BinOperation(sb, operation, modifier);
                    sb.AppendLine(@"ip++;");
                    break;

                #endregion

                #region MOV

                case Operation.MOV:
                    switch (modifier)
                    {
                        case Modifier.A:
                            sb.AppendLine(@"ValuesA[reg_AdrB] = reg_AA_Value;");
                            break;
                        case Modifier.F:
                            sb.AppendLine(@"ValuesA[reg_AdrB] = reg_AA_Value;");
                            sb.AppendLine(@"ValuesB[reg_AdrB] = reg_IR_ValueA;");
                            break;
                        case Modifier.B:
                            sb.AppendLine(@"ValuesB[reg_AdrB] = reg_IR_ValueA;");
                            break;
                        case Modifier.AB:
                            sb.AppendLine(@"ValuesB[reg_AdrB] = reg_AA_Value;");
                            break;
                        case Modifier.X:
                            sb.AppendLine(@"ValuesB[reg_AdrB] = reg_AA_Value;");
                            sb.AppendLine(@"ValuesA[reg_AdrB] = reg_IR_ValueA;");
                            break;
                        case Modifier.BA:
                            sb.AppendLine(@"ValuesA[reg_AdrB] = reg_IR_ValueA;");
                            break;
                        case Modifier.I:
                            sb.AppendLine(@"Operations[reg_AdrB] = Operations[reg_AdrA];");
                            sb.AppendLine(@"core[reg_AdrB].Modifier = Modifier.NULL;");
                            sb.AppendLine(@"ValuesA[reg_AdrB] = reg_AA_Value;");
                            sb.AppendLine(@"ValuesB[reg_AdrB] = reg_IR_ValueA;");
                            break;
                    }
                    sb.AppendLine(@"ip++;");
                    break;

                #endregion

                #region LDP

                case Operation.LDP:
                    switch (modifier)
                    {
                        case Modifier.A:
                            sb.AppendLine(@"
                            psAddress = Instruction.Mod(reg_AA_Value, rules.PSpaceSize);
                            ValuesA[reg_AdrB] = warrior.GetPSpaceValue(psAddress);");
                            break;
                        case Modifier.F:
                        case Modifier.B:
                        case Modifier.X:
                        case Modifier.I:
                            sb.AppendLine(@"
                            psAddress = Instruction.Mod(reg_IR_ValueA, rules.PSpaceSize);
                            ValuesB[reg_AdrB] = warrior.GetPSpaceValue(psAddress);");
                            break;
                        case Modifier.AB:
                            sb.AppendLine(@"
                            psAddress = Instruction.Mod(reg_AA_Value, rules.PSpaceSize);
                            ValuesB[reg_AdrB] = warrior.GetPSpaceValue(psAddress);");
                            break;
                        case Modifier.BA:
                            sb.AppendLine(@"
                            psAddress = Instruction.Mod(reg_IR_ValueA, rules.PSpaceSize);
                            ValuesA[reg_AdrB] = warrior.GetPSpaceValue(psAddress);");
                            break;
                    }
                    sb.AppendLine(@"ip++;");
                    break;

                #endregion

                #region STP

                case Operation.STP:
                    switch (modifier)
                    {
                        case Modifier.A:
                            sb.AppendLine(@"
                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);");
                            break;
                        case Modifier.F:
                        case Modifier.B:
                        case Modifier.X:
                        case Modifier.I:
                            sb.AppendLine(@"
                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);");
                            break;
                        case Modifier.AB:
                            sb.AppendLine(@"
                            psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_AA_Value);");
                            break;
                        case Modifier.BA:
                            sb.AppendLine(@"
                            psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(psAddress, reg_IR_ValueA);");
                            break;
                    }
                    sb.AppendLine(@"ip++;");
                    break;

                #endregion

                default:
                    throw new InvalidOperationException("Unknown instruction");
            }
            if (alowdie)
            {
                sb.AppendLine(@"
                if (!die)
                {
                    warrior.Tasks.Enqueue(mod(ip));
                }
                else
                {
                    warrior.DeadTasksCount++;
                    Died(ip);
                }");
                
            }
            else
            {
                sb.AppendLine(@"
                warrior.Tasks.Enqueue(mod(ip));");
                
            }
        }

        private static void BinOperation(StringBuilder sb, Operation operation, Modifier modifier)
        {
            switch (modifier)
            {
                case Modifier.A:
                    BinOperation(sb, "ValuesA[reg_AdrB]", "reg_AB_Value", "reg_AA_Value", operation);
                    break;
                case Modifier.I:
                case Modifier.F:
                    BinOperation(sb, "ValuesA[reg_AdrB]", "reg_AB_Value", "reg_AA_Value", operation);
                    BinOperation(sb, "ValuesB[reg_AdrB]", "reg_IR_ValueB", "reg_IR_ValueA", operation);
                    break;
                case Modifier.B:
                    BinOperation(sb, "ValuesB[reg_AdrB]", "reg_IR_ValueB", "reg_IR_ValueA", operation);
                    break;
                case Modifier.AB:
                    BinOperation(sb, "ValuesB[reg_AdrB]", "reg_IR_ValueB", "reg_AA_Value", operation);
                    break;
                case Modifier.X:
                    BinOperation(sb, "ValuesB[reg_AdrB]", "reg_IR_ValueB", "reg_AA_Value", operation);
                    BinOperation(sb, "ValuesA[reg_AdrB]", "reg_AB_Value", "reg_IR_ValueA", operation);
                    break;
                case Modifier.BA:
                    BinOperation(sb, "ValuesA[reg_AdrB]", "reg_AB_Value", "reg_IR_ValueA", operation);
                    break;
            }
        }

        private static void BinOperation(StringBuilder sb, string res, string a, string b, Operation operation)
        {
            switch (operation)
            {
                case Operation.ADD:
                    sb.AppendLine(res+@" = "+a+@" + "+b+@";
                                    if ("+res+@" >= coreSize) "+res+@" -= coreSize;");
                    break;
                case Operation.SUB:
                    sb.AppendLine(res+@" = "+a+@" - "+b+@";");
                    sb.AppendLine(@"if ("+res+@" < 0) "+res+@" += coreSize;");
                    break;
                case Operation.MUL:
                    sb.AppendLine(res+@" = "+a+@" * "+b+@";");
                    sb.AppendLine(res+@" %= coreSize;");
                    break;
                case Operation.MOD:
                    sb.AppendLine(@"if ("+b+@" == 0) die = true;");
                    sb.AppendLine(@"else " + res + @" = " + a + @" % " + b + @";");
                    break;
                case Operation.DIV:
                    sb.AppendLine(@"if ("+b+@" == 0) die = true;");
                    sb.AppendLine(@"else "+res+@" = "+a+@" / "+b+@";");
                    break;
                default:
                    throw new InvalidOperationException("Unknown instruction");
            }
        }
    }
}
