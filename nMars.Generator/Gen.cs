// This file is part of nMars - Core War MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.IO;
using System.Text;
using nMars.Parser.Warrior;
using nMars.RedCode;

namespace nMars.Generator
{
    public class GenBase
    {

        public static void GetBody(ExtendedInstruction instruction, out string sdecl, out string saddra, out string saddrb, out string sexec)
        {
            StringBuilder sbexec = new StringBuilder();
            ExecuteInstruction(sbexec, instruction.Operation, instruction.Modifier);
            sexec = sbexec.ToString();

            StringBuilder sbaddrb = new StringBuilder();
            GetEffectiveAddress(sbaddrb, sexec, instruction.ModeB, "reg_AdrB", "reg_AB_Value", "reg_IR_ValueB", "reg_IR_ValueCpyB");
            saddrb = sbaddrb.ToString();

            StringBuilder sbaddra = new StringBuilder();
            GetEffectiveAddress(sbaddra, sexec + saddrb, instruction.ModeA, "reg_AdrA", "reg_AA_Value", "reg_IR_ValueA", "reg_IR_ValueCpyA");
            saddra = sbaddra.ToString();

            StringBuilder sbdecl = new StringBuilder();

            string sall = saddra + saddrb + sexec;
            string sinit = saddra + saddrb;

            GetDecl(instruction, saddra, sall, sbdecl, sinit);

            sdecl = sbdecl.ToString();
        }

        private static void GetDecl(ExtendedInstruction instruction, string saddra, string sall, StringBuilder sbdecl, string sinit)
        {
            if (sall.Contains("reg_IR_ValueA"))
                if (sinit.Contains("reg_IR_ValueA ="))
                    sbdecl.AppendLine(@"int reg_IR_ValueA;");
                else
                    sbdecl.AppendLine(@"int reg_IR_ValueA = ValuesA[ip];");

            if (sall.Contains("reg_IR_ValueB"))
                if (sinit.Contains("reg_IR_ValueB =") && !saddra.Contains("= reg_IR_ValueB"))
                    sbdecl.AppendLine(@"int reg_IR_ValueB;");
                else
                    sbdecl.AppendLine(@"int reg_IR_ValueB = ValuesB[ip];");
            
            if (sall.Contains("reg_IR_ValueCpyA"))
                if (sinit.Contains("reg_IR_ValueCpyA ="))
                    sbdecl.AppendLine(@"int reg_IR_ValueCpyA;");
                else
                    sbdecl.AppendLine(@"int reg_IR_ValueCpyA = ValuesA[ip];");

            if (sall.Contains("reg_IR_ValueCpyB"))
                if (sinit.Contains("reg_IR_ValueCpyB ="))
                    sbdecl.AppendLine(@"int reg_IR_ValueCpyB;");
                else
                    sbdecl.AppendLine(@"int reg_IR_ValueCpyB = ValuesB[ip];");
            if (sall.Contains("reg_AdrA")) sbdecl.AppendLine(@"int reg_AdrA;");
            if (sall.Contains("reg_AdrB")) sbdecl.AppendLine(@"int reg_AdrB;");
            if (sall.Contains("reg_AA_Value"))
                if (sinit.Contains("reg_AA_Value ="))
                    sbdecl.AppendLine(@"int reg_AA_Value;");
                else
                    sbdecl.AppendLine(@"int reg_AA_Value = ValuesA[ip];");
            
            if (sall.Contains("reg_AB_Value"))
                if (sinit.Contains("reg_AB_Value ="))
                    sbdecl.AppendLine(@"int reg_AB_Value;");
                else
                    sbdecl.AppendLine(@"int reg_AB_Value = ValuesA[ip];");

            if (sall.Contains("reg_direct")) sbdecl.AppendLine(@"int reg_direct;");
            if (sall.Contains("reg_jump")) sbdecl.AppendLine(@"bool reg_jump;");
            if (sall.Contains("reg_die")) 
                if (instruction.Operation==Operation.DAT)
                    sbdecl.AppendLine(@"bool reg_die;");
                else
                    sbdecl.AppendLine(@"bool reg_die = false;");
            if (sall.Contains("reg_psAddress")) sbdecl.AppendLine(@"int reg_psAddress;");
        }

        protected static void GetEffectiveAddress(StringBuilder sb,string after, Mode mode, string indirect, string AX_Value, string IR_X, string primary)
        {
            switch (mode)
            {
                case Mode.PreDecIndirectA:
                    sb.AppendLine(@"reg_direct = mod(" + primary + @" + ip);");
                    if (after.Contains(indirect) || after.Contains(AX_Value) || after.Contains(IR_X))
                        sb.AppendLine(indirect + @" = mod(reg_direct + dec(ref ValuesA[reg_direct]));");
                    else
                        sb.AppendLine(@"dec(ref ValuesA[reg_direct]);");
                    if (after.Contains(AX_Value)) 
                        sb.AppendLine(AX_Value + @" = ValuesA[" + indirect + @"];");
                    if (after.Contains(IR_X)) 
                        sb.AppendLine(IR_X + @" = ValuesB[" + indirect + @"];");
                    return;
                case Mode.PreDecIndirectB:
                    sb.AppendLine(@"reg_direct = mod(" + primary + @" + ip);");
                    if (after.Contains(indirect) || after.Contains(AX_Value) || after.Contains(IR_X))
                        sb.AppendLine(indirect + @" = mod(reg_direct + dec(ref ValuesB[reg_direct]));");
                    else
                        sb.AppendLine(@"dec(ref ValuesB[reg_direct]);");
                    if (after.Contains(AX_Value))
                        sb.AppendLine(AX_Value + @" = ValuesA[" + indirect + @"];");
                    if (after.Contains(IR_X))
                        sb.AppendLine(IR_X + @" = ValuesB[" + indirect + @"];");
                    return;
                case Mode.IndirectA:
                    if (after.Contains(indirect) || after.Contains(AX_Value) || after.Contains(IR_X) || after.Contains("reg_direct"))
                        sb.AppendLine(@"reg_direct = mod(" + primary + @" + ip);");
                    if (after.Contains(indirect) || after.Contains(AX_Value) || after.Contains(IR_X))
                        sb.AppendLine(indirect + @" = mod(reg_direct + ValuesA[reg_direct]);");
                    if (after.Contains(AX_Value))
                        sb.AppendLine(AX_Value + @" = ValuesA[" + indirect + @"];");
                    if (after.Contains(IR_X))
                        sb.AppendLine(IR_X + @" = ValuesB[" + indirect + @"];");
                    return;
                case Mode.IndirectB:
                    if (after.Contains(indirect) || after.Contains(AX_Value) || after.Contains(IR_X) || after.Contains("reg_direct"))
                        sb.AppendLine(@"reg_direct = mod(" + primary + @" + ip);");
                    if (after.Contains(indirect) || after.Contains(AX_Value) || after.Contains(IR_X))
                        sb.AppendLine(indirect + @" = mod(reg_direct + ValuesB[reg_direct]);");
                    if (after.Contains(AX_Value))
                        sb.AppendLine(AX_Value + @" = ValuesA[" + indirect + @"];");
                    if (after.Contains(IR_X))
                        sb.AppendLine(IR_X + @" = ValuesB[" + indirect + @"];");
                    return;
                case Mode.PostIncIndirectA:
                    sb.AppendLine(@"reg_direct = mod(" + primary + @" + ip);");
                    if (after.Contains(indirect) || after.Contains(AX_Value) || after.Contains(IR_X))
                        sb.AppendLine(indirect + @" = mod(reg_direct + ValuesA[reg_direct]);");
                    if (after.Contains(AX_Value))
                        sb.AppendLine(AX_Value + @" = ValuesA[" + indirect + @"];");
                    if (after.Contains(IR_X))
                        sb.AppendLine(IR_X + @" = ValuesB[" + indirect + @"];");
                    sb.AppendLine("inc(ref ValuesA[reg_direct]);");
                    return;
                case Mode.PostIncIndirectB:
                    sb.AppendLine(@"reg_direct = mod(" + primary + @" + ip);");
                    if (after.Contains(indirect) || after.Contains(AX_Value) || after.Contains(IR_X))
                        sb.AppendLine(indirect + @" = mod(reg_direct + ValuesB[reg_direct]);");
                    if (after.Contains(AX_Value))
                        sb.AppendLine(AX_Value + @" = ValuesA[" + indirect + @"];");
                    if (after.Contains(IR_X))
                        sb.AppendLine(IR_X + @" = ValuesB[" + indirect + @"];");
                    sb.AppendLine("inc(ref ValuesB[reg_direct]);");
                    return;
                case Mode.Direct:
                    if (after.Contains(indirect) || after.Contains(AX_Value) || after.Contains(IR_X) || after.Contains("reg_direct"))
                        sb.AppendLine(@"reg_direct = mod(" + primary + @" + ip);");
                    if (after.Contains(indirect))
                        sb.AppendLine(indirect + @" = reg_direct;");
                    if (after.Contains(AX_Value))
                        sb.AppendLine(AX_Value + @" = ValuesA[reg_direct];");
                    if (after.Contains(IR_X))
                        sb.AppendLine(IR_X + @" = ValuesB[reg_direct];");
                    return;
                case Mode.Immediate:
                    if (after.Contains(indirect))
                        sb.AppendLine(indirect + @" = ip;");
                    if (IR_X != "reg_IR_ValueB")
                    {
                        if (after.Contains(IR_X))
                            sb.AppendLine(IR_X + @" = reg_IR_ValueB;");    
                    }
                    return;
                default:
                    throw new InvalidOperationException("Unknown Mode");
            }
        }

        private static void ExecuteInstruction(StringBuilder sb, Operation operation, Modifier modifier)
        {
            switch (operation)
            {
                #region Simple

                case Operation.DAT:
                    sb.AppendLine(@"reg_die = true;");
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
                            sb.AppendLine(@"reg_jump = (reg_AB_Value == 0);");
                            break;
                        case Modifier.F:
                        case Modifier.X:
                        case Modifier.I:
                            sb.AppendLine(@"reg_jump = (reg_AB_Value == 0 && reg_IR_ValueB == 0);");
                            break;
                        case Modifier.B:
                        case Modifier.AB:
                            sb.AppendLine(@"reg_jump = (reg_IR_ValueB == 0);");
                            break;
                    }
                    sb.AppendLine(@"
                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;");
                    break;

                #endregion

                #region JMN

                case Operation.JMN:
                    switch (modifier)
                    {
                        case Modifier.BA:
                        case Modifier.A:
                            sb.AppendLine(@"reg_jump = !(reg_AB_Value == 0);");
                            break;
                        case Modifier.B:
                        case Modifier.AB:
                            sb.AppendLine(@"reg_jump = !(reg_IR_ValueB == 0);");
                            break;
                        case Modifier.F:
                        case Modifier.X:
                        case Modifier.I:
                            sb.AppendLine(@"reg_jump = !(reg_AB_Value == 0 && reg_IR_ValueB == 0);"); 
                            break;
                    }
                    sb.AppendLine(@"
                    if (reg_jump)
                        ip = reg_AdrA;
                    else
                        ip++;");
                    break;

                #endregion

                #region DJN

                case Operation.DJN:
                    switch (modifier)
                    {
                        case Modifier.A:
                        case Modifier.BA:
                            sb.AppendLine(@"reg_jump = (reg_AB_Value != 1);
                            dec(ref ValuesA[reg_AdrB]);"); 
                            break;
                        case Modifier.B:
                        case Modifier.AB:
                            sb.AppendLine(@"reg_jump = (reg_IR_ValueB != 1);
                            dec(ref ValuesB[reg_AdrB]);"); 
                            break;
                        case Modifier.F:
                        case Modifier.X:
                        case Modifier.I:
                            sb.AppendLine(@"reg_jump = !(reg_AB_Value == 1 && reg_IR_ValueB == 1);
                            dec(ref ValuesA[reg_AdrB]);
                            dec(ref ValuesB[reg_AdrB]);"); 
                            break;
                    }
                    sb.AppendLine(@"if (reg_jump)
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
                            sb.AppendLine(@"reg_jump = (reg_AA_Value == reg_AB_Value);"); 
                            break;
                        case Modifier.B:
                            sb.AppendLine(@"reg_jump = (reg_IR_ValueA == reg_IR_ValueB);");
                            break;
                        case Modifier.AB:
                            sb.AppendLine(@"reg_jump = (reg_IR_ValueB == reg_AA_Value);");
                            break;
                        case Modifier.BA:
                            sb.AppendLine(@"reg_jump = (reg_AB_Value == reg_IR_ValueA);");

                            break;
                        case Modifier.I:
                            sb.AppendLine(@"reg_jump = (Operations[reg_AdrA] == Operations[reg_AdrB] &&
                                    reg_AA_Value == reg_AB_Value &&
                                    reg_IR_ValueA == reg_IR_ValueB);");
                            break;
                        case Modifier.F:
                            sb.AppendLine(@"reg_jump = (reg_AA_Value == reg_AB_Value && reg_IR_ValueA == reg_IR_ValueB);");
                            break;
                        case Modifier.X:
                            sb.AppendLine(@"reg_jump = (reg_IR_ValueB == reg_AA_Value && reg_AB_Value == reg_IR_ValueA);");
                            break;
                    }
                    sb.AppendLine(@"if (reg_jump)
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
                            sb.AppendLine(@"reg_jump = (reg_AA_Value != reg_AB_Value);");
                            break;
                        case Modifier.B:
                            sb.AppendLine(@"reg_jump = (reg_IR_ValueA != reg_IR_ValueB);");
                            break;
                        case Modifier.AB:
                            sb.AppendLine(@"reg_jump = (reg_IR_ValueB != reg_AA_Value);");
                            break;
                        case Modifier.BA:
                            sb.AppendLine(@"reg_jump = (reg_AB_Value != reg_IR_ValueA);");
                            break;
                        case Modifier.I:
                            sb.AppendLine(@"reg_jump = (Operations[reg_AdrA] != Operations[reg_AdrB] ||
                                    reg_AB_Value != reg_AA_Value ||
                                    reg_IR_ValueA != reg_IR_ValueB);");
                            break;
                        case Modifier.F:
                            sb.AppendLine(@"reg_jump = (reg_AA_Value != reg_AB_Value || reg_IR_ValueA != reg_IR_ValueB);");
                            break;
                        case Modifier.X:
                            sb.AppendLine(@"reg_jump = (reg_IR_ValueB != reg_AA_Value || reg_AB_Value != reg_IR_ValueA);");
                            break;
                    }
                    sb.AppendLine(@"if (reg_jump)
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
                            sb.AppendLine(@"reg_jump = (reg_AB_Value > reg_AA_Value);");
                            break;
                        case Modifier.B:
                            sb.AppendLine(@"reg_jump = (reg_IR_ValueB > reg_IR_ValueA);");
                            break;
                        case Modifier.AB:
                            sb.AppendLine(@"reg_jump = (reg_IR_ValueB > reg_AA_Value);");
                            break;
                        case Modifier.BA:
                            sb.AppendLine(@"reg_jump = (reg_AB_Value > reg_IR_ValueA);");
                            break;
                        case Modifier.I:
                        case Modifier.F:
                            sb.AppendLine(@"reg_jump = (reg_AB_Value > reg_AA_Value &&
                                    reg_IR_ValueB > reg_IR_ValueA);");
                            break;
                        case Modifier.X:
                            sb.AppendLine(@"reg_jump = (reg_IR_ValueB > reg_AA_Value &&
                                    reg_AB_Value > reg_IR_ValueA);");
                            break;
                    }
                    sb.AppendLine(@"if (reg_jump)
                        ip += 2;
                    else
                        ip++;");
                    break;

                #endregion

                #region Binary

                case Operation.MOD:
                case Operation.DIV:
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
                            reg_psAddress = Instruction.Mod(reg_AA_Value, rules.PSpaceSize);
                            ValuesA[reg_AdrB] = warrior.GetPSpaceValue(reg_psAddress);");
                            break;
                        case Modifier.F:
                        case Modifier.B:
                        case Modifier.X:
                        case Modifier.I:
                            sb.AppendLine(@"
                            reg_psAddress = Instruction.Mod(reg_IR_ValueA, rules.PSpaceSize);
                            ValuesB[reg_AdrB] = warrior.GetPSpaceValue(reg_psAddress);");
                            break;
                        case Modifier.AB:
                            sb.AppendLine(@"
                            reg_psAddress = Instruction.Mod(reg_AA_Value, rules.PSpaceSize);
                            ValuesB[reg_AdrB] = warrior.GetPSpaceValue(reg_psAddress);");
                            break;
                        case Modifier.BA:
                            sb.AppendLine(@"
                            reg_psAddress = Instruction.Mod(reg_IR_ValueA, rules.PSpaceSize);
                            ValuesA[reg_AdrB] = warrior.GetPSpaceValue(reg_psAddress);");
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
                            reg_psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(reg_psAddress, reg_AA_Value);");
                            break;
                        case Modifier.F:
                        case Modifier.B:
                        case Modifier.X:
                        case Modifier.I:
                            sb.AppendLine(@"
                            reg_psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(reg_psAddress, reg_IR_ValueA);");
                            break;
                        case Modifier.AB:
                            sb.AppendLine(@"
                            reg_psAddress = Instruction.Mod(reg_IR_ValueB, rules.PSpaceSize);
                            warrior.SetPSpaceValue(reg_psAddress, reg_AA_Value);");
                            break;
                        case Modifier.BA:
                            sb.AppendLine(@"
                            reg_psAddress = Instruction.Mod(reg_AB_Value, rules.PSpaceSize);
                            warrior.SetPSpaceValue(reg_psAddress, reg_IR_ValueA);");
                            break;
                    }
                    sb.AppendLine(@"ip++;");
                    break;

                #endregion

                default:
                    throw new InvalidOperationException("Unknown instruction");
            }
            if (sb.ToString().Contains("reg_die"))
            {
                sb.AppendLine(@"
                if (!reg_die)
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
                sb.AppendLine(@"warrior.Tasks.Enqueue(mod(ip));");
                
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
                    sb.AppendLine(res + @" = " + a + @" + " + b + @";");
                    sb.AppendLine(@"if ("+res+@" >= coreSize) "+res+@" -= coreSize;");
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
                    sb.AppendLine(@"if ("+b+@" == 0) reg_die = true;");
                    sb.AppendLine(@"else " + res + @" = " + a + @" % " + b + @";");
                    break;
                case Operation.DIV:
                    sb.AppendLine(@"if ("+b+@" == 0) reg_die = true;");
                    sb.AppendLine(@"else "+res+@" = "+a+@" / "+b+@";");
                    break;
                default:
                    throw new InvalidOperationException("Unknown instruction");
            }
        }
    }
}
