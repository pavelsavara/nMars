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
        
        protected virtual void BeforeWrite(int address, Register register)
        {
        }

        protected virtual void AfterWrite(int address, Register register)
        {
        }

        protected virtual void Died(EngineWarrior warrior)
        {
        }

        protected virtual void Split(EngineWarrior warrior)
        {
        }

        #endregion

        protected void PerformInstruction(EngineWarrior warrior, int ip)
        {
            int indirectAadr;
            int indirectBadr;

            EngineInstruction instructionCopy = core[ip];

            int AA_Value = instructionCopy.ValueA;
            int AB_Value = instructionCopy.ValueA;

            GetEffectiveAddress(ip, core[ip].ModeA, out indirectAadr, ref AA_Value, ref instructionCopy.ValueA,
                                instructionCopy.ValueB, instructionCopy.ValueA);
            GetEffectiveAddress(ip, core[ip].ModeB, out indirectBadr, ref AB_Value, ref instructionCopy.ValueB,
                                instructionCopy.ValueB, instructionCopy.ValueB);

            ExecuteInstruction(warrior, ref instructionCopy, ip,
                    AA_Value, AB_Value,
                    indirectAadr, indirectBadr,
                    ref core[indirectAadr].ValueA, ref core[indirectAadr].ValueB,
                    ref core[indirectBadr].ValueA, ref core[indirectBadr].ValueB);
        }

        private void ExecuteInstruction(EngineWarrior warrior, ref EngineInstruction instructionCopy, int ip,
                                          //int directAadr, int directBadr,
                                          int AA_Value, int AB_Value, int indirectAadr, int indirectBadr,
                                          ref int indirectAvalA, ref int indirectAvalB, ref int indirectBvalA,
                                          ref int indirectBvalB)
        {
            bool jump = false;
            bool die = false;
            bool split = false;
            switch (instructionCopy.Operation)
            {
                    #region Simple

                case Operation.DAT:
                    die = true;
                    break;
                case Operation.NOP:
                    ip++;
                    break;
                case Operation.SPL:
                    if (warrior.LiveTasks + 1 < rules.MaxProcesses)
                    {
                        warrior.Tasks.Enqueue(mod(ip + 1));
                        ip = indirectAadr; // as second to queue
                        split = true;
                    }
                    else
                    {
                        ip++;
                    }
                    break;
                case Operation.JMP:
                    ip = indirectAadr;
                    break;

                    #endregion

                    #region JMZ

                case Operation.JMZ:
                    switch (instructionCopy.Modifier)
                    {
                        case Modifier.BA:
                        case Modifier.A:
                            jump = (AB_Value == 0);
                            break;
                        case Modifier.F:
                        case Modifier.X:
                        case Modifier.I:
                            jump = (AB_Value == 0 && instructionCopy.ValueB == 0);
                            break;
                        case Modifier.B:
                        case Modifier.AB:
                            jump = (instructionCopy.ValueB == 0);
                            break;
                    }
                    if (jump)
                        ip = indirectAadr;
                    else
                        ip++;
                    break;

                    #endregion

                    #region JMN

                case Operation.JMN:
                    switch (instructionCopy.Modifier)
                    {
                        case Modifier.BA:
                        case Modifier.A:
                            jump = !(AB_Value == 0);
                            break;
                        case Modifier.B:
                        case Modifier.AB:
                            jump = !(instructionCopy.ValueB == 0);
                            break;
                        case Modifier.F:
                        case Modifier.X:
                        case Modifier.I:
                            jump = !(AB_Value == 0 && instructionCopy.ValueB == 0);
                            break;
                    }
                    if (jump)
                        ip = indirectAadr;
                    else
                        ip++;
                    break;

                    #endregion

                    #region DJN

                case Operation.DJN:
                    switch (instructionCopy.Modifier)
                    {
                        case Modifier.A:
                        case Modifier.BA:
                            jump = (AB_Value != 1);
                            dec(ref indirectBvalA);
                            break;
                        case Modifier.B:
                        case Modifier.AB:
                            jump = (instructionCopy.ValueB != 1);
                            dec(ref indirectBvalB);
                            break;
                        case Modifier.F:
                        case Modifier.X:
                        case Modifier.I:
                            jump = !(AB_Value == 1 && instructionCopy.ValueB == 1);
                            dec(ref indirectBvalA);
                            dec(ref indirectBvalB);
                            break;
                    }
                    if (jump)
                        ip = indirectAadr;
                    else
                        ip++;
                    break;

                    #endregion

                    #region SEQ

                case Operation.CMP:
                    switch (instructionCopy.Modifier)
                    {
                        case Modifier.A:
                            jump = (AA_Value == AB_Value);
                            break;
                        case Modifier.B:
                            jump = (instructionCopy.ValueA == instructionCopy.ValueB);
                            break;
                        case Modifier.AB:
                            jump = (instructionCopy.ValueB == AA_Value);
                            break;
                        case Modifier.BA:
                            jump = (indirectAvalB == indirectBvalA);
                            break;
                        case Modifier.I:
                            jump = (core[indirectAadr].Operation == core[indirectBadr].Operation &&
                                    core[indirectAadr].Modifier == core[indirectBadr].Modifier &&
                                    core[indirectAadr].ModeA == core[indirectBadr].ModeA &&
                                    core[indirectAadr].ModeB == core[indirectBadr].ModeB && AA_Value == AB_Value &&
                                    instructionCopy.ValueA == instructionCopy.ValueB);
                            break;
                        case Modifier.F:
                            jump = (AA_Value == AB_Value && instructionCopy.ValueA == instructionCopy.ValueB);
                            break;
                        case Modifier.X:
                            jump = (instructionCopy.ValueB == AA_Value && AB_Value == instructionCopy.ValueA);
                            break;
                    }
                    if (jump)
                        ip += 2;
                    else
                        ip++;
                    break;

                    #endregion

                    #region SNE

                case Operation.SNE:

                    switch (instructionCopy.Modifier)
                    {
                        case Modifier.A:
                            jump = (AA_Value != AB_Value);
                            break;
                        case Modifier.B:
                            jump = (instructionCopy.ValueA != instructionCopy.ValueB);
                            break;
                        case Modifier.AB:
                            jump = (instructionCopy.ValueB != AA_Value);
                            break;
                        case Modifier.BA:
                            jump = (indirectAvalB != indirectBvalA);
                            break;
                        case Modifier.I:
                            jump = (core[indirectAadr].Operation != core[indirectBadr].Operation ||
                                    core[indirectAadr].Modifier != core[indirectBadr].Modifier ||
                                    core[indirectAadr].ModeA != core[indirectBadr].ModeA ||
                                    core[indirectAadr].ModeB != core[indirectBadr].ModeB || AB_Value != AA_Value ||
                                    instructionCopy.ValueA != instructionCopy.ValueB);
                            break;
                        case Modifier.F:
                            jump = (AA_Value != AB_Value || instructionCopy.ValueA != instructionCopy.ValueB);
                            break;
                        case Modifier.X:
                            jump = (instructionCopy.ValueB != AA_Value || AB_Value != instructionCopy.ValueA);
                            break;
                    }
                    if (jump)
                        ip += 2;
                    else
                        ip++;
                    break;

                    #endregion

                    #region SLT

                case Operation.SLT:

                    switch (instructionCopy.Modifier)
                    {
                        case Modifier.A:
                            jump = (indirectAvalA < indirectBvalA);
                            break;
                        case Modifier.B:
                            jump = (indirectAvalB < indirectBvalB);
                            break;
                        case Modifier.AB:
                            jump = (indirectAvalA < indirectBvalB);
                            break;
                        case Modifier.BA:
                            jump = (indirectAvalB < indirectBvalA);
                            break;
                        case Modifier.I:
                        case Modifier.F:
                            jump = (indirectAvalA < indirectBvalA && indirectAvalB < indirectBvalB);
                            break;
                        case Modifier.X:
                            jump = (indirectAvalA < indirectBvalB && indirectAvalB < indirectBvalA);
                            break;
                    }
                    if (jump)
                        ip += 2;
                    else
                        ip++;
                    break;

                    #endregion

                    #region Binary

                case Operation.MOD:
                case Operation.DIV:
                    die = BinOperation(AA_Value, AB_Value, ref indirectAvalA, ref indirectBvalA, ref indirectBvalB, instructionCopy);
                    ip++;
                    break;
                case Operation.SUB:
                case Operation.ADD:
                case Operation.MUL:
                    BinOperation(AA_Value, AB_Value, ref indirectAvalA, ref indirectBvalA, ref indirectBvalB, instructionCopy);
                    ip++;
                    break;

                    #endregion

                    #region MOV

                case Operation.MOV:
                    switch (instructionCopy.Modifier)
                    {
                        case Modifier.A:
                            indirectBvalA = AA_Value;
                            break;
                        case Modifier.F:
                            indirectBvalA = AA_Value;
                            indirectBvalB = instructionCopy.ValueA;
                            break;
                        case Modifier.B:
                            indirectBvalB = instructionCopy.ValueA;
                            break;
                        case Modifier.AB:
                            indirectBvalB = AA_Value;
                            break;
                        case Modifier.X:
                            indirectBvalB = AA_Value;
                            indirectBvalA = instructionCopy.ValueA;
                            break;
                        case Modifier.BA:
                            indirectBvalA = instructionCopy.ValueA;
                            break;
                        case Modifier.I:
                            core[indirectBadr].Operation = core[indirectAadr].Operation;
                            core[indirectBadr].Modifier = core[indirectAadr].Modifier;
                            core[indirectBadr].ModeA = core[indirectAadr].ModeA;
                            core[indirectBadr].ModeB = core[indirectAadr].ModeB;
                            indirectBvalA = AA_Value;
                            indirectBvalB = instructionCopy.ValueA;
                            break;
                    }
                    ip++;
                    break;

                    #endregion

                    #region LDP

                case Operation.LDP:

                    switch (instructionCopy.Modifier)
                    {
                        case Modifier.A:
                            indirectBvalA = warrior.GetPSpaceValue(AA_Value);
                            break;
                        case Modifier.F:
                        case Modifier.B:
                        case Modifier.X:
                        case Modifier.I:
                            indirectBvalB = warrior.GetPSpaceValue(instructionCopy.ValueA);
                            break;
                        case Modifier.AB:
                            indirectBvalB = warrior.GetPSpaceValue(AA_Value);
                            break;
                        case Modifier.BA:
                            indirectBvalA = warrior.GetPSpaceValue(instructionCopy.ValueA);
                            break;
                    }
                    ip++;
                    break;

                    #endregion

                    #region STP

                case Operation.STP:

                    switch (instructionCopy.Modifier)
                    {
                        case Modifier.A:
                            warrior.SetPSpaceValue(AB_Value, AA_Value);
                            break;
                        case Modifier.F:
                        case Modifier.B:
                        case Modifier.X:
                        case Modifier.I:
                            warrior.SetPSpaceValue(instructionCopy.ValueB, instructionCopy.ValueA);
                            break;
                        case Modifier.AB:
                            warrior.SetPSpaceValue(instructionCopy.ValueB, AA_Value);
                            break;
                        case Modifier.BA:
                            warrior.SetPSpaceValue(AB_Value, instructionCopy.ValueA);
                            break;
                    }
                    ip++;
                    break;

                    #endregion

                default:
                    throw new InvalidOperationException("Unknown instruction");
            }
            if (!die)
            {
                warrior.Tasks.Enqueue(mod(ip));
            }
            else
            {
                Died(warrior);
            }
            if (split)
            {
                Split(warrior);
            }
        }

        private bool BinOperation(int AA_Value, int AB_Value, ref int indirectAvalA, ref int indirectBvalA, ref int indirectBvalB, EngineInstruction instructionCopy)
        {
            bool die;
            die = false;
            switch (instructionCopy.Modifier)
            {
                case Modifier.A:
                    die |= oper(ref indirectBvalA, AB_Value, AA_Value, instructionCopy.Operation);
                    break;
                case Modifier.I:
                case Modifier.F:
                    die |= oper(ref indirectBvalA, AB_Value, AA_Value, instructionCopy.Operation);
                    die |= oper(ref indirectBvalB, instructionCopy.ValueB, instructionCopy.ValueA, instructionCopy.Operation);
                    break;
                case Modifier.B:
                    die |= oper(ref indirectBvalB, instructionCopy.ValueB, instructionCopy.ValueA, instructionCopy.Operation);
                    break;
                case Modifier.AB:
                    die |= oper(ref indirectBvalB, instructionCopy.ValueB, indirectAvalA, instructionCopy.Operation);
                    break;
                case Modifier.X:
                    die |= oper(ref indirectBvalB, instructionCopy.ValueB, indirectAvalA, instructionCopy.Operation);
                    die |= oper(ref indirectBvalA, AB_Value, instructionCopy.ValueA, instructionCopy.Operation);
                    break;
                case Modifier.BA:
                    die |= oper(ref indirectBvalA, AB_Value, instructionCopy.ValueA, instructionCopy.Operation);
                    break;
            }
            return die;
        }
    }
}
