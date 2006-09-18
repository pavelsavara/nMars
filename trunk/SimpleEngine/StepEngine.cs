using System;
using System.Collections.Generic;
using nMars.RedCode;

namespace nMars.SimpleEngine
{
    public class StepEngine : Core, IStepEngine
    {
        public void BeginMatch(IList<IWarrior> aWariors, IPSpaces aPSpaces, Random aRandom,
                               IList<int> forcedAddresses)
        {
            Init(aWariors, aPSpaces, aRandom, forcedAddresses);
        }

        public bool NextStep()
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
            }

            if (warrior.Index == WarriorsCount - 1)
            {
                Cycles++;
            }

            if (LiveWarriorsCount == 1 && WarriorsCount > 1)
            {
                liveWarriors.Dequeue().Result = FightResult.Win;
                return false;
            }
            if (LiveWarriorsCount == 0)
            {
                return false;
            }
            if (Cycles >= rules.maxCycles)
            {
                return false;
            }
            return true;
        }

        private void PerformInstruction(EngineWarrior warrior, int ip)
        {
            EngineInstruction instruction = core[ip];

            int indirectA;
            int indirectB;

            GetEffectiveAddress(ip, instruction.ModeA, out indirectA, core[ip].ValueA);
            GetEffectiveAddress(ip, instruction.ModeB, out indirectB, core[ip].ValueB);

            Execute(warrior, instruction, ip,
                    indirectA, indirectB,
                    ref core[indirectA].ValueA, ref core[indirectA].ValueB,
                    ref core[indirectB].ValueA, ref core[indirectB].ValueB);
        }

        private void Execute(EngineWarrior warrior, EngineInstruction instruction, int ip,
                             //int directAadr, int directBadr,
                             int indirectAadr, int indirectBadr,
                             ref int indirectAvalA, ref int indirectAvalB,
                             ref int indirectBvalA, ref int indirectBvalB)
        {
            bool jump = false;
            bool die = false;
            switch (instruction.Operation)
            {
                    #region Simple

                case Operation.DAT:
                    die = true;
                    break;
                case Operation.NOP:
                    ip++;
                    break;
                case Operation.SPL:
                    if (warrior.LiveTasks < rules.maxProcesses)
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
                    switch (instruction.Modifier)
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
                    switch (instruction.Modifier)
                    {
                        case Modifier.BA:
                        case Modifier.A:
                            jump = !(indirectBvalA == 0);
                            break;
                        case Modifier.B:
                        case Modifier.AB:
                            jump = !(indirectBvalB == 0);
                            break;
                        case Modifier.F:
                        case Modifier.X:
                        case Modifier.I:
                            jump = !(indirectBvalA == 0 && indirectBvalB == 0);
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
                    switch (instruction.Modifier)
                    {
                        case Modifier.A:
                        case Modifier.BA:
                            jump = !decz(ref indirectBvalA);
                            break;
                        case Modifier.B:
                        case Modifier.AB:
                            jump = !decz(ref indirectBvalB);
                            break;
                        case Modifier.F:
                        case Modifier.X:
                        case Modifier.I:
                            jump = !(decz(ref indirectBvalA) && decz(ref indirectBvalB));
                            break;
                    }
                    if (jump)
                        ip = indirectAadr;
                    else
                        ip++;
                    break;

                    #endregion

                    #region SEQ

                case Operation.SEQ:
                    switch (instruction.Modifier)
                    {
                        case Modifier.A:
                            jump = (indirectAvalA == indirectBvalA);
                            break;
                        case Modifier.B:
                            jump = (indirectAvalB == indirectBvalB);
                            break;
                        case Modifier.AB:
                            jump = (indirectAvalA == indirectBvalB);
                            break;
                        case Modifier.BA:
                            jump = (indirectAvalB == indirectBvalA);
                            break;
                        case Modifier.I:
                            jump = (core[indirectAadr].Operation == core[indirectBadr].Operation &&
                                    core[indirectAadr].Modifier == core[indirectBadr].Modifier &&
                                    indirectAvalA == indirectBvalA &&
                                    indirectAvalB == indirectBvalB);
                            break;
                        case Modifier.F:
                            jump = (indirectAvalA == indirectBvalA &&
                                    indirectAvalB == indirectBvalB);
                            break;
                        case Modifier.X:
                            jump = (indirectAvalA == indirectBvalB &&
                                    indirectAvalB == indirectBvalA);
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

                    switch (instruction.Modifier)
                    {
                        case Modifier.A:
                            jump = (indirectAvalA != indirectBvalA);
                            break;
                        case Modifier.B:
                            jump = (indirectAvalB != indirectBvalB);
                            break;
                        case Modifier.AB:
                            jump = (indirectAvalA != indirectBvalB);
                            break;
                        case Modifier.BA:
                            jump = (indirectAvalB != indirectBvalA);
                            break;
                        case Modifier.I:
                            jump = (core[indirectAadr].Operation != core[indirectBadr].Operation ||
                                    core[indirectAadr].Modifier != core[indirectBadr].Modifier ||
                                    indirectAvalA != indirectBvalA ||
                                    indirectAvalB != indirectBvalB);
                            break;
                        case Modifier.F:
                            jump = (indirectAvalA != indirectBvalA ||
                                    indirectAvalB != indirectBvalB);
                            break;
                        case Modifier.X:
                            jump = (indirectAvalA != indirectBvalB ||
                                    indirectAvalB != indirectBvalA);
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

                    switch (instruction.Modifier)
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
                        BinaryOperation(instruction, ref indirectAvalA, ref indirectAvalB, ref indirectBvalA,
                                        ref indirectBvalB);
                    ip++;
                    break;
                case Operation.SUB:
                case Operation.ADD:
                case Operation.MUL:
                    BinaryOperation(instruction, ref indirectAvalA, ref indirectAvalB, ref indirectBvalA,
                                    ref indirectBvalB);
                    ip++;
                    break;

                    #endregion

                    #region MOV

                case Operation.MOV:
                    switch (instruction.Modifier)
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
                            indirectBvalA = indirectAvalA;
                            indirectBvalB = indirectAvalB;
                            core[indirectBadr].Operation = core[indirectAadr].Operation;
                            core[indirectBadr].Modifier = core[indirectAadr].Modifier;
                            break;
                    }
                    ip++;
                    break;

                    #endregion

                    #region LDP

                case Operation.LDP:

                    switch (instruction.Modifier)
                    {
                        case Modifier.A:
                            indirectAvalA = warrior.GetPSpace(indirectAvalA);
                            break;
                        case Modifier.AB:
                            indirectBvalB = warrior.GetPSpace(indirectAvalA);
                            break;
                        case Modifier.BA:
                            indirectBvalA = warrior.GetPSpace(indirectAvalB);
                            break;
                        case Modifier.F:
                        case Modifier.B:
                        case Modifier.X:
                        case Modifier.I:
                            indirectBvalB = warrior.GetPSpace(indirectAvalB);
                            break;
                    }
                    ip++;
                    break;

                    #endregion

                    #region STP

                case Operation.STP:

                    switch (instruction.Modifier)
                    {
                        case Modifier.A:
                            warrior.SetPSpace(indirectBvalA, indirectAvalA);
                            break;
                        case Modifier.AB:
                            warrior.SetPSpace(indirectBvalB, indirectAvalA);
                            break;
                        case Modifier.BA:
                            warrior.SetPSpace(indirectBvalA, indirectAvalB);
                            break;
                        case Modifier.F:
                        case Modifier.B:
                        case Modifier.X:
                        case Modifier.I:
                            warrior.SetPSpace(indirectBvalB, indirectAvalB);
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

        /// <summary>
        /// (primary)-field effective address calculation
        /// </summary>
        private void GetEffectiveAddress(int ip, Mode mode, out int ir, int primary)
        {
            int direct;
            int indirect;
            switch (mode)
            {
                case Mode.Direct:
                    direct = mod(ip + primary);
                    ir = direct;
                    return;
                case Mode.PreDecIndirectA:
                    direct = mod(primary + ip);
                    indirect = mod(direct + predec(ref core[direct].ValueA));
                    ir = indirect;
                    return;
                case Mode.IndirectA:
                    direct = mod(ip + primary);
                    indirect = mod(direct + core[direct].ValueA);
                    ir = indirect;
                    return;
                case Mode.PostIncIndirectA:
                    direct = mod(ip + primary);
                    indirect = mod(direct + postinc(ref core[direct].ValueA));
                    ir = indirect;
                    return;
                case Mode.PreDecIndirectB:
                    direct = mod(primary + ip);
                    indirect = mod(direct + predec(ref core[direct].ValueB));
                    ir = indirect;
                    return;
                case Mode.IndirectB:
                    direct = mod(ip + primary);
                    indirect = mod(direct + core[direct].ValueB);
                    ir = indirect;
                    return;
                case Mode.PostIncIndirectB:
                    direct = mod(ip + primary);
                    indirect = mod(direct + postinc(ref core[direct].ValueB));
                    ir = indirect;
                    return;
                case Mode.Immediate:
                    ir = ip;
                    return;
                default:
                    throw new InvalidOperationException("Unknown Mode");
            }
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

        public IList<FightResult> EndMatch()
        {
            List<FightResult> res = new List<FightResult>();

            foreach (EngineWarrior warrior in warriors)
            {
                res.Add(warrior.Result);
            }

            return res;
        }
    }
}