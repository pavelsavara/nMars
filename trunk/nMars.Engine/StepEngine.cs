// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Collections.Generic;
using nMars.RedCode;

namespace nMars.Engine
{
    public class StepEngine : Core, IExtendedStepEngine
    {
        public void BeginMatch(Rules aRules, IWarrior[] aWariors, IPSpaces aPSpaces, Random aRandom,
                               int[] aForcedAddresses)
        {
            BeginMatch(aRules, (IList<IWarrior>) aWariors, aPSpaces, aRandom, aForcedAddresses);
        }

        public void BeginMatch(Rules aRules, IList<IWarrior> aWariors, IPSpaces aPSpaces, Random aRandom,
                               IList<int> aForcedAddresses)
        {
            round = 0;
            cycles = 0;
            rules = aRules;
            random = aRandom;
            pSpaces = aPSpaces;
            forcedAddresses = aForcedAddresses;
            sourceWarriors = aWariors;
            InitRound();
            results = new MatchResult(rules);
        }

        public StepResult NextStep()
        {
            if (round >= rules.Rounds)
            {
                return StepResult.Finished;
            }

            PerformInstruction();
            tasksCopyLoaded = false;

            StepResult res = StepResult.Continue;
            if (LiveWarriorsCount == 1 && WarriorsCount > 1)
            {
                liveWarriors.Peek().Result = FightResult.Win;
                res = StepResult.NextRound;
            }
            else if (LiveWarriorsCount == 0)
            {
                res = StepResult.NextRound;
            }
            else if (cyclesLeft == 0)
            {
                res = StepResult.NextRound;
            }
            if (res == StepResult.NextRound)
            {
                for (int w = 0; w < rules.WarriorsCount; w++)
                {
                    EngineWarrior warrior = warriors[w];
                    results.results[w, round] = warrior.Result;
                }
                round++;
                if (round >= rules.Rounds)
                {
                    res = StepResult.Finished;
                }
                else
                {
                    cycles = 0;
                    InitRound();
                }
            }
            return res;
        }

        private void PerformInstruction()
        {
            EngineWarrior warrior = liveWarriors.Dequeue();
            int insructionPointer = warrior.Tasks.Dequeue();

            PerformInstruction(warrior, insructionPointer);

            if (warrior.LiveTasks > 0)
            {
                liveWarriors.Enqueue(warrior);
            }
            else
            {
                warrior.Result = FightResult.Loose;
                cyclesLeft = cyclesLeft - 1 - (cyclesLeft - 1)/(LiveWarriorsCount + 1);
            }
            cyclesLeft--;
            cycles++;
        }

        private void PerformInstruction(EngineWarrior warrior, int ip)
        {
            lastInstruction = new EngineInstruction(core[ip], core[ip].Address);

            int indirectAadr;
            int indirectBadr;

            EngineInstruction instructionCopy = core[ip];

            int AA_Value = instructionCopy.ValueA;
            int AB_Value = instructionCopy.ValueA;

            GetEffectiveAddress(ip, core[ip].ModeA, out indirectAadr, ref AA_Value, ref instructionCopy.ValueA,
                                instructionCopy.ValueB, core[ip].ValueA);
            GetEffectiveAddress(ip, core[ip].ModeB, out indirectBadr, ref AB_Value, ref instructionCopy.ValueB,
                                instructionCopy.ValueB, core[ip].ValueB);

            Execute(warrior, ref instructionCopy, ip,
                    AA_Value, AB_Value,
                    indirectAadr, indirectBadr,
                    ref core[indirectAadr].ValueA, ref core[indirectAadr].ValueB,
                    ref core[indirectBadr].ValueA, ref core[indirectBadr].ValueB);
        }

        /// <summary>
        /// (primary)-field effective address calculation
        /// </summary>
        private void GetEffectiveAddress(int ip, Mode mode, out int indirect,
                                         ref int AX_Value, ref int IR_X, int IR_B, int primary)
        {
            int direct;
            switch (mode)
            {
                case Mode.PreDecIndirectA:
                    direct = mod(primary + ip);
                    indirect = mod(direct + predec(ref core[direct].ValueA));
                    AX_Value = core[indirect].ValueA;
                    IR_X = core[indirect].ValueB;
                    return;
                case Mode.PreDecIndirectB:
                    direct = mod(primary + ip);
                    indirect = mod(direct + predec(ref core[direct].ValueB));
                    AX_Value = core[indirect].ValueA;
                    IR_X = core[indirect].ValueB;
                    return;
                case Mode.IndirectA:
                    direct = mod(ip + primary);
                    indirect = mod(direct + core[direct].ValueA);
                    AX_Value = core[indirect].ValueA;
                    IR_X = core[indirect].ValueB;
                    return;
                case Mode.IndirectB:
                    direct = mod(ip + primary);
                    indirect = mod(direct + core[direct].ValueB);
                    AX_Value = core[indirect].ValueA;
                    IR_X = core[indirect].ValueB;
                    return;
                case Mode.PostIncIndirectA:
                    direct = mod(ip + primary);
                    indirect = mod(direct + core[direct].ValueA);
                    AX_Value = core[indirect].ValueA;
                    IR_X = core[indirect].ValueB;
                    postinc(ref core[direct].ValueA);
                    return;
                case Mode.PostIncIndirectB:
                    direct = mod(ip + primary);
                    indirect = mod(direct + core[direct].ValueB);
                    AX_Value = core[indirect].ValueA;
                    IR_X = core[indirect].ValueB;
                    postinc(ref core[direct].ValueB);
                    return;
                case Mode.Direct:
                    direct = mod(ip + primary);
                    indirect = direct;
                    AX_Value = core[indirect].ValueA;
                    IR_X = core[indirect].ValueB;
                    return;
                case Mode.Immediate:
                    indirect = ip;
                    IR_X = IR_B;
                    return;
                default:
                    throw new InvalidOperationException("Unknown Mode");
            }
        }

        private void Execute(EngineWarrior warrior, ref EngineInstruction instructionCopy, int ip,
                             //int directAadr, int directBadr,
                             int AA_Value, int AB_Value,
                             int indirectAadr, int indirectBadr,
                             ref int indirectAvalA, ref int indirectAvalB,
                             ref int indirectBvalA, ref int indirectBvalB)
        {
            bool jump = false;
            bool die = false;
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
                            jump = (indirectBvalA == 0);
                            break;
                        case Modifier.B:
                        case Modifier.AB:
                            jump = (indirectBvalB == 0);
                            break;
                        case Modifier.F:
                        case Modifier.X:
                        case Modifier.I:
                            jump = (indirectBvalA == 0 && indirectBvalB == 0);
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
                            jump = !(AB_Value == 1 &&
                                     instructionCopy.ValueB == 1);
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
                                    core[indirectAadr].ModeB == core[indirectBadr].ModeB &&
                                    AA_Value == AB_Value &&
                                    instructionCopy.ValueA == instructionCopy.ValueB);
                            break;
                        case Modifier.F:
                            jump = (AA_Value == AB_Value &&
                                    instructionCopy.ValueA == instructionCopy.ValueB);
                            break;
                        case Modifier.X:
                            jump = (instructionCopy.ValueB == AA_Value &&
                                    AB_Value == instructionCopy.ValueA);
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
                                    core[indirectAadr].ModeB != core[indirectBadr].ModeB ||
                                    AB_Value != AA_Value ||
                                    instructionCopy.ValueA != instructionCopy.ValueB);
                            break;
                        case Modifier.F:
                            jump = (AA_Value != AB_Value ||
                                    instructionCopy.ValueA != instructionCopy.ValueB);
                            break;
                        case Modifier.X:
                            jump = (instructionCopy.ValueB != AA_Value ||
                                    AB_Value != instructionCopy.ValueA);
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
                            jump = (indirectAvalA < indirectBvalA &&
                                    indirectAvalB < indirectBvalB);
                            break;
                        case Modifier.X:
                            jump = (indirectAvalA < indirectBvalB &&
                                    indirectAvalB < indirectBvalA);
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
                    die =
                        BinaryOperation(instructionCopy, ref indirectAvalA, ref indirectAvalB, ref indirectBvalA,
                                        ref indirectBvalB);
                    ip++;
                    break;
                case Operation.SUB:
                case Operation.ADD:
                case Operation.MUL:
                    BinaryOperation(instructionCopy, ref indirectAvalA, ref indirectAvalB, ref indirectBvalA,
                                    ref indirectBvalB);
                    ip++;
                    break;

                    #endregion

                    #region MOV

                case Operation.MOV:
                    switch (instructionCopy.Modifier)
                    {
                        case Modifier.A:
                            indirectBvalA = indirectAvalA;
                            break;
                        case Modifier.F:
                            indirectBvalA = indirectAvalA;
                            indirectBvalB = indirectAvalB;
                            break;
                        case Modifier.B:
                            indirectBvalB = indirectAvalB;
                            break;
                        case Modifier.AB:
                            indirectBvalB = indirectAvalA;
                            break;
                        case Modifier.X:
                            indirectBvalB = indirectAvalA;
                            indirectBvalA = indirectAvalB;
                            break;
                        case Modifier.BA:
                            indirectBvalA = indirectAvalB;
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
                            indirectAvalA = warrior.GetPSpace(AA_Value);
                            break;
                        case Modifier.F:
                        case Modifier.B:
                        case Modifier.X:
                        case Modifier.I:
                            indirectBvalB = warrior.GetPSpace(instructionCopy.ValueA);
                            break;
                        case Modifier.AB:
                            indirectBvalB = warrior.GetPSpace(AA_Value);
                            break;
                        case Modifier.BA:
                            indirectBvalA = warrior.GetPSpace(instructionCopy.ValueA);
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
                            warrior.SetPSpace(AB_Value, AA_Value);
                            break;
                        case Modifier.F:
                        case Modifier.B:
                        case Modifier.X:
                        case Modifier.I:
                            warrior.SetPSpace(instructionCopy.ValueB, instructionCopy.ValueA);
                            break;
                        case Modifier.AB:
                            warrior.SetPSpace(instructionCopy.ValueB, AA_Value);
                            break;
                        case Modifier.BA:
                            warrior.SetPSpace(AB_Value, instructionCopy.ValueA);
                            break;
                    }
                    ip++;
                    break;

                    #endregion

                default:
                    throw new InvalidOperationException("Unknown instruction");
            }
            if (!die)
                warrior.Tasks.Enqueue(mod(ip));
        }

        /// <returns>T- should die</returns>
        private bool BinaryOperation(EngineInstruction instruction, ref int indirectAvalA, ref int indirectAvalB,
                                     ref int indirectBvalA, ref int indirectBvalB)
        {
            bool die = false;
            switch (instruction.Modifier)
            {
                case Modifier.I:
                case Modifier.F:
                    die |= oper(ref indirectBvalB, indirectBvalB, indirectAvalB, instruction.Operation);
                    die |= oper(ref indirectBvalA, indirectBvalA, indirectAvalA, instruction.Operation);
                    break;
                case Modifier.A:
                    die = oper(ref indirectBvalA, indirectBvalA, indirectAvalA, instruction.Operation);
                    break;
                case Modifier.B:
                    die = oper(ref indirectBvalB, indirectBvalB, indirectAvalB, instruction.Operation);
                    break;
                case Modifier.X:
                    die |= oper(ref indirectBvalA, indirectBvalA, indirectAvalB, instruction.Operation);
                    die |= oper(ref indirectBvalB, indirectBvalB, indirectAvalA, instruction.Operation);
                    break;
                case Modifier.AB:
                    die = oper(ref indirectBvalB, indirectBvalB, indirectAvalA, instruction.Operation);
                    break;
                case Modifier.BA:
                    die = oper(ref indirectBvalA, indirectBvalA, indirectAvalB, instruction.Operation);
                    break;
            }
            return die;
        }

        public MatchResult EndMatch()
        {
            tasksCopyLoaded = false;
            lastInstruction = null;
            results.ComputePoints();
            return results;
        }

        private MatchResult results;
    }
}