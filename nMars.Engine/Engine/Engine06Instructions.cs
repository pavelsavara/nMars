// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using nMars.RedCode;

namespace nMars.Engine
{
    public abstract class EngineInstructions : EngineAddressing
    {
        #region Events

        protected virtual void Died(int address)
        {
        }

        protected virtual void Split(int addressTo)
        {
        }

        #endregion

        protected virtual void PerformInstruction(int ip)
        {
            reg.ip = ip;
            BeforeRead(ip, Column.All);
            reg.IR = core[ip];
            activeWarrior.PrevInstruction = new EngineInstruction(reg.IR, ip);
            reg.AA_Value = core[ip].ValueA;
            reg.AB_Value = core[ip].ValueA;

            GetEffectiveAddress(core[ip].ModeA, out reg.AdrA, ref reg.AA_Value, ref reg.IR.ValueA, reg.IR.ValueA);
            GetEffectiveAddress(core[ip].ModeB, out reg.AdrB, ref reg.AB_Value, ref reg.IR.ValueB, reg.IR.ValueB);

            ExecuteInstruction(activeWarrior);
        }

        private void ExecuteInstruction(EngineWarrior warrior)
        {
            bool jump = false;
            bool die = false;
            switch (reg.IR.Operation)
            {
                    #region Simple

                case Operation.DAT:
                    die = true;
                    break;
                case Operation.NOP:
                    reg.ip++;
                    break;
                case Operation.SPL:
                    if (warrior.LiveTasks + 1 < rules.MaxProcesses)
                    {
                        warrior.Tasks.Enqueue(mod(reg.ip + 1));
                        reg.ip = reg.AdrA; // as second to queue
                        Split(reg.AdrA);
                    }
                    else
                    {
                        reg.ip++;
                    }
                    break;
                case Operation.JMP:
                    reg.ip = reg.AdrA;
                    break;

                    #endregion

                    #region JMZ

                case Operation.JMZ:
                    switch (reg.IR.Modifier)
                    {
                        case Modifier.BA:
                        case Modifier.A:
                            jump = (reg.AB_Value == 0);
                            break;
                        case Modifier.F:
                        case Modifier.X:
                        case Modifier.I:
                            jump = (reg.AB_Value == 0 && reg.IR.ValueB == 0);
                            break;
                        case Modifier.B:
                        case Modifier.AB:
                            jump = (reg.IR.ValueB == 0);
                            break;
                    }
                    if (jump)
                        reg.ip = reg.AdrA;
                    else
                        reg.ip++;
                    break;

                    #endregion

                    #region JMN

                case Operation.JMN:
                    switch (reg.IR.Modifier)
                    {
                        case Modifier.BA:
                        case Modifier.A:
                            jump = !(reg.AB_Value == 0);
                            break;
                        case Modifier.B:
                        case Modifier.AB:
                            jump = !(reg.IR.ValueB == 0);
                            break;
                        case Modifier.F:
                        case Modifier.X:
                        case Modifier.I:
                            jump = !(reg.AB_Value == 0 && reg.IR.ValueB == 0);
                            break;
                    }
                    if (jump)
                        reg.ip = reg.AdrA;
                    else
                        reg.ip++;
                    break;

                    #endregion

                    #region DJN

                case Operation.DJN:
                    switch (reg.IR.Modifier)
                    {
                        case Modifier.A:
                        case Modifier.BA:
                            jump = (reg.AB_Value != 1);
                            dec(reg.AdrB, Column.A);
                            break;
                        case Modifier.B:
                        case Modifier.AB:
                            jump = (reg.IR.ValueB != 1);
                            dec(reg.AdrB, Column.B);
                            break;
                        case Modifier.F:
                        case Modifier.X:
                        case Modifier.I:
                            jump = !(reg.AB_Value == 1 && reg.IR.ValueB == 1);
                            dec(reg.AdrB, Column.A);
                            dec(reg.AdrB, Column.B);
                            break;
                    }
                    if (jump)
                        reg.ip = reg.AdrA;
                    else
                        reg.ip++;
                    break;

                    #endregion

                    #region SEQ

                case Operation.CMP:
                    switch (reg.IR.Modifier)
                    {
                        case Modifier.A:
                            jump = (reg.AA_Value == reg.AB_Value);
                            break;
                        case Modifier.B:
                            jump = (reg.IR.ValueA == reg.IR.ValueB);
                            break;
                        case Modifier.AB:
                            jump = (reg.IR.ValueB == reg.AA_Value);
                            break;
                        case Modifier.BA:
                            jump = (this[reg.AdrA, Column.B] == this[reg.AdrB, Column.A]);
                            break;
                        case Modifier.I:
                            BeforeRead(reg.AdrA, Column.All);
                            BeforeRead(reg.AdrB, Column.All);
                            jump = (core[reg.AdrA].Operation == core[reg.AdrB].Operation &&
                                    core[reg.AdrA].Modifier == core[reg.AdrB].Modifier &&
                                    core[reg.AdrA].ModeA == core[reg.AdrB].ModeA &&
                                    core[reg.AdrA].ModeB == core[reg.AdrB].ModeB && 
                                    reg.AA_Value == reg.AB_Value &&
                                    reg.IR.ValueA == reg.IR.ValueB);
                            break;
                        case Modifier.F:
                            jump = (reg.AA_Value == reg.AB_Value && reg.IR.ValueA == reg.IR.ValueB);
                            break;
                        case Modifier.X:
                            jump = (reg.IR.ValueB == reg.AA_Value && reg.AB_Value == reg.IR.ValueA);
                            break;
                    }
                    if (jump)
                        reg.ip += 2;
                    else
                        reg.ip++;
                    break;

                    #endregion

                    #region SNE

                case Operation.SNE:

                    switch (reg.IR.Modifier)
                    {
                        case Modifier.A:
                            jump = (reg.AA_Value != reg.AB_Value);
                            break;
                        case Modifier.B:
                            jump = (reg.IR.ValueA != reg.IR.ValueB);
                            break;
                        case Modifier.AB:
                            jump = (reg.IR.ValueB != reg.AA_Value);
                            break;
                        case Modifier.BA:
                            jump = (this[reg.AdrA, Column.B] != this[reg.AdrB, Column.A]);
                            break;
                        case Modifier.I:
                            BeforeRead(reg.AdrA, Column.All);
                            BeforeRead(reg.AdrB, Column.All);
                            jump = (core[reg.AdrA].Operation != core[reg.AdrB].Operation ||
                                    core[reg.AdrA].Modifier != core[reg.AdrB].Modifier ||
                                    core[reg.AdrA].ModeA != core[reg.AdrB].ModeA ||
                                    core[reg.AdrA].ModeB != core[reg.AdrB].ModeB || reg.AB_Value != reg.AA_Value ||
                                    reg.IR.ValueA != reg.IR.ValueB);
                            break;
                        case Modifier.F:
                            jump = (reg.AA_Value != reg.AB_Value || reg.IR.ValueA != reg.IR.ValueB);
                            break;
                        case Modifier.X:
                            jump = (reg.IR.ValueB != reg.AA_Value || reg.AB_Value != reg.IR.ValueA);
                            break;
                    }
                    if (jump)
                        reg.ip += 2;
                    else
                        reg.ip++;
                    break;

                    #endregion

                    #region SLT

                case Operation.SLT:

                    switch (reg.IR.Modifier)
                    {
                        case Modifier.A:
                            jump = (reg.AB_Value > reg.AA_Value);
                            break;
                        case Modifier.B:
                            jump = (reg.IR.ValueB > reg.IR.ValueA);
                            break;
                        case Modifier.AB:
                            jump = (reg.IR.ValueB > reg.AA_Value);
                            break;
                        case Modifier.BA:
                            jump = (reg.AB_Value > reg.IR.ValueA);
                            break;
                        case Modifier.I:
                        case Modifier.F:
                            jump = (reg.AB_Value > reg.AA_Value &&
                                    reg.IR.ValueB > reg.IR.ValueA);
                            break;
                        case Modifier.X:
                            jump = (reg.IR.ValueB > reg.AA_Value &&
                                    reg.AB_Value > reg.IR.ValueA);
                            break;
                    }
                    if (jump)
                        reg.ip += 2;
                    else
                        reg.ip++;
                    break;

                    #endregion

                    #region Binary

                case Operation.MOD:
                case Operation.DIV:
                    die = BinOperation();
                    reg.ip++;
                    break;
                case Operation.SUB:
                case Operation.ADD:
                case Operation.MUL:
                    BinOperation();
                    reg.ip++;
                    break;

                    #endregion

                    #region MOV

                case Operation.MOV:
                    switch (reg.IR.Modifier)
                    {
                        case Modifier.A:
                            this[reg.AdrB, Column.A] = reg.AA_Value;
                            break;
                        case Modifier.F:
                            this[reg.AdrB, Column.A] = reg.AA_Value;
                            this[reg.AdrB, Column.B] = reg.IR.ValueA;
                            break;
                        case Modifier.B:
                            this[reg.AdrB, Column.B] = reg.IR.ValueA;
                            break;
                        case Modifier.AB:
                            this[reg.AdrB, Column.B] = reg.AA_Value;
                            break;
                        case Modifier.X:
                            this[reg.AdrB, Column.B] = reg.AA_Value;
                            this[reg.AdrB, Column.A] = reg.IR.ValueA;
                            break;
                        case Modifier.BA:
                            this[reg.AdrB, Column.A] = reg.IR.ValueA;
                            break;
                        case Modifier.I:
                            BeforeRead(reg.AdrA, Column.All);
                            BeforeWrite(reg.AdrB, Column.All);
                            core[reg.AdrB].OriginalInstruction = core[reg.AdrA].OriginalInstruction;
                            core[reg.AdrB].OriginalOwner = core[reg.AdrA].OriginalOwner;
                            core[reg.AdrB].Operation = core[reg.AdrA].Operation;
                            core[reg.AdrB].Modifier = core[reg.AdrA].Modifier;
                            core[reg.AdrB].ModeA = core[reg.AdrA].ModeA;
                            core[reg.AdrB].ModeB = core[reg.AdrA].ModeB;
                            core[reg.AdrB].ValueA = reg.AA_Value;
                            core[reg.AdrB].ValueB = reg.IR.ValueA;
                            AfterWrite(reg.AdrB, Column.All);
                            break;
                    }
                    reg.ip++;
                    break;

                    #endregion

                    #region LDP

                case Operation.LDP:

                    switch (reg.IR.Modifier)
                    {
                        case Modifier.A:
                            this[reg.AdrB, Column.A] = warrior.GetPSpaceValue(reg.AA_Value);
                            break;
                        case Modifier.F:
                        case Modifier.B:
                        case Modifier.X:
                        case Modifier.I:
                            this[reg.AdrB, Column.B] = warrior.GetPSpaceValue(reg.IR.ValueA);
                            break;
                        case Modifier.AB:
                            this[reg.AdrB, Column.B] = warrior.GetPSpaceValue(reg.AA_Value);
                            break;
                        case Modifier.BA:
                            this[reg.AdrB, Column.A] = warrior.GetPSpaceValue(reg.IR.ValueA);
                            break;
                    }
                    reg.ip++;
                    break;

                    #endregion

                    #region STP

                case Operation.STP:

                    switch (reg.IR.Modifier)
                    {
                        case Modifier.A:
                            warrior.SetPSpaceValue(reg.AB_Value, reg.AA_Value);
                            break;
                        case Modifier.F:
                        case Modifier.B:
                        case Modifier.X:
                        case Modifier.I:
                            warrior.SetPSpaceValue(reg.IR.ValueB, reg.IR.ValueA);
                            break;
                        case Modifier.AB:
                            warrior.SetPSpaceValue(reg.IR.ValueB, reg.AA_Value);
                            break;
                        case Modifier.BA:
                            warrior.SetPSpaceValue(reg.AB_Value, reg.IR.ValueA);
                            break;
                    }
                    reg.ip++;
                    break;

                    #endregion

                default:
                    throw new InvalidOperationException("Unknown instruction");
            }
            if (!die)
            {
                warrior.Tasks.Enqueue(mod(reg.ip));
            }
            else
            {
                warrior.DeadTasksCount++;
                Died(reg.ip);
            }
        }

        private bool BinOperation()
        {
            bool die;
            die = false;
            switch (reg.IR.Modifier)
            {
                case Modifier.A:
                    BeforeWrite(reg.AdrB, Column.A);
                    die |= oper(ref core[reg.AdrB].ValueA, reg.AB_Value, reg.AA_Value, reg.IR.Operation);
                    AfterWrite(reg.AdrB, Column.A);
                    break;
                case Modifier.I:
                case Modifier.F:
                    BeforeWrite(reg.AdrB, Column.AB);
                    die |= oper(ref core[reg.AdrB].ValueA, reg.AB_Value, reg.AA_Value, reg.IR.Operation);
                    die |= oper(ref core[reg.AdrB].ValueB, reg.IR.ValueB, reg.IR.ValueA, reg.IR.Operation);
                    AfterWrite(reg.AdrB, Column.AB);
                    break;
                case Modifier.B:
                    BeforeWrite(reg.AdrB, Column.B);
                    die |= oper(ref core[reg.AdrB].ValueB, reg.IR.ValueB, reg.IR.ValueA, reg.IR.Operation);
                    AfterWrite(reg.AdrB, Column.B);
                    break;
                case Modifier.AB:
                    BeforeRead(reg.AdrA, Column.A);
                    BeforeWrite(reg.AdrB, Column.B);
                    die |= oper(ref core[reg.AdrB].ValueB, reg.IR.ValueB, reg.AA_Value, reg.IR.Operation);
                    AfterWrite(reg.AdrB, Column.B);
                    break;
                case Modifier.X:
                    BeforeRead(reg.AdrA, Column.A);
                    BeforeWrite(reg.AdrB, Column.B);
                    die |= oper(ref core[reg.AdrB].ValueB, reg.IR.ValueB, core[reg.AdrA].ValueA, reg.IR.Operation);
                    die |= oper(ref core[reg.AdrB].ValueA, reg.AB_Value, reg.IR.ValueA, reg.IR.Operation);
                    AfterWrite(reg.AdrB, Column.B);
                    break;
                case Modifier.BA:
                    BeforeWrite(reg.AdrB, Column.A);
                    die |= oper(ref core[reg.AdrB].ValueA, reg.AB_Value, reg.IR.ValueA, reg.IR.Operation);
                    AfterWrite(reg.AdrB, Column.A);
                    break;
            }
            return die;
        }
    }
}