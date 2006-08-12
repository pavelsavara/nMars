using System;
using System.Collections.Generic;
using nMars.RedCode;

namespace nMars.SimpleEngine
{
    public class StepEngine : Core, IStepEngine
    {
        public void BeginMatch(IList<IWarrior> aWariors, Rules aRules, Random aRandom)
        {
            Init(aWariors, aRules, aRandom);
        }

        public bool NextStep()
        {
            EngineWarrior warrior = liveWarriors.Dequeue();
            int insructionPointer = warrior.Tasks.Dequeue();

            PerformInstruction(warrior, insructionPointer);

            if (warrior.LiveTasks > 0)
                liveWarriors.Enqueue(warrior);
            else
                warrior.Result = FightResult.Loose;

            if (warrior.Index == WarriorsCount - 1)
            {
                Cycles++;
            }

            if (LiveWarriorsCount == 1 && WarriorsCount>1)
            {
                liveWarriors.Dequeue().Result = FightResult.Win;
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

            int da = GetEffectiveAddress(ip, instruction.ModeA, core[ip].ValueA);
            int db = GetEffectiveAddress(ip, instruction.ModeB, core[ip].ValueB);

            if (instruction.ModeA != Mode.Immediate)
            {
                if (instruction.ModeB != Mode.Immediate)
                {
                    Execute(warrior, instruction, ip, da, db,
                            ref core[da].ValueA, ref core[da].ValueB,
                            ref core[db].ValueA, ref core[db].ValueB);
                }
                else
                {
                    Execute(warrior, instruction, ip, da, db,
                            ref core[da].ValueA, ref core[da].ValueB,
                            ref core[da].ValueA, ref core[db].ValueB);
                }
            }
            else
            {
                if (instruction.ModeB != Mode.Immediate)
                {
                    Execute(warrior, instruction, ip, da, db,
                            ref core[da].ValueA, ref core[db].ValueB,
                            ref core[db].ValueA, ref core[db].ValueB);
                }
                else
                {
                    Execute(warrior, instruction, ip, da, db,
                            ref core[da].ValueA, ref core[db].ValueB,
                            ref core[da].ValueA, ref core[db].ValueB);
                }
            }
        }

        private void Execute(EngineWarrior warrior, EngineInstruction instruction, int ip, int da, int db, ref int ra_a,
                             ref int ra_b, ref int rb_a, ref int rb_b)
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
                        ip = da; // as second to queue
                    }
                    else
                    {
                        ip++;
                    }
                    break;
                case Operation.JMP:
                    ip = da;
                    break;

                    #endregion

                    #region JMZ

                case Operation.JMZ:
                    switch (instruction.Modifier)
                    {
                        case Modifier.BA:
                        case Modifier.A:
                            jump = (rb_a == 0);
                            break;
                        case Modifier.B:
                        case Modifier.AB:
                            jump = (rb_b == 0);
                            break;
                        case Modifier.F:
                        case Modifier.X:
                        case Modifier.I:
                            jump = (rb_a == 0 && rb_b == 0);
                            break;
                    }
                    if (jump)
                        ip = da;
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
                            jump = (rb_a != 0);
                            break;
                        case Modifier.B:
                        case Modifier.AB:
                            jump = (rb_b != 0);
                            break;
                        case Modifier.F:
                        case Modifier.X:
                        case Modifier.I:
                            jump = (rb_a != 0 && rb_b != 0);
                            break;
                    }
                    if (jump)
                        ip = da;
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
                            jump = !decz(ref rb_a);
                            break;
                        case Modifier.B:
                        case Modifier.AB:
                            jump = !decz(ref rb_b);
                            break;
                        case Modifier.F:
                        case Modifier.X:
                        case Modifier.I:
                            jump = !decz(ref rb_a) && decz(ref rb_b);
                            break;
                    }
                    if (jump)
                        ip = da;
                    else
                        ip++;
                    break;

                    #endregion

                    #region SEQ

                case Operation.SEQ:
                    switch (instruction.Modifier)
                    {
                        case Modifier.A:
                            jump = (ra_a == rb_a);
                            break;
                        case Modifier.B:
                            jump = (ra_b == rb_b);
                            break;
                        case Modifier.AB:
                            jump = (ra_a == rb_b);
                            break;
                        case Modifier.BA:
                            jump = (ra_b == rb_a);
                            break;
                        case Modifier.I:
                            jump = (core[da].Operation == core[db].Operation &&
                                    core[da].Modifier == core[db].Modifier &&
                                    ra_a == rb_a &&
                                    ra_b == rb_b);
                            break;
                        case Modifier.F:
                            jump = (ra_a == rb_a &&
                                    ra_b == rb_b);
                            break;
                        case Modifier.X:
                            jump = (ra_a == rb_b &&
                                    ra_b == rb_a);
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
                            jump = (ra_a != rb_a);
                            break;
                        case Modifier.B:
                            jump = (ra_b != rb_b);
                            break;
                        case Modifier.AB:
                            jump = (ra_a != rb_b);
                            break;
                        case Modifier.BA:
                            jump = (ra_b != rb_a);
                            break;
                        case Modifier.I:
                            jump = (core[da].Operation != core[db].Operation ||
                                    core[da].Modifier != core[db].Modifier ||
                                    ra_a != rb_a ||
                                    ra_b != rb_b);
                            break;
                        case Modifier.F:
                            jump = (ra_a != rb_a ||
                                    ra_b != rb_b);
                            break;
                        case Modifier.X:
                            jump = (ra_a != rb_b ||
                                    ra_b != rb_a);
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
                            jump = (ra_a < rb_a);
                            break;
                        case Modifier.B:
                            jump = (ra_b < rb_b);
                            break;
                        case Modifier.AB:
                            jump = (ra_a < rb_b);
                            break;
                        case Modifier.BA:
                            jump = (ra_b < rb_a);
                            break;
                        case Modifier.I:
                        case Modifier.F:
                            jump = (ra_a < rb_a && ra_b < rb_b);
                            break;
                        case Modifier.X:
                            jump = (ra_a < rb_b && ra_b < rb_a);
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
                    die = BinaryOperation(instruction, ra_a, ra_b, rb_a, rb_b);
                    ip++;
                    break;
                case Operation.SUB:
                case Operation.ADD:
                case Operation.MUL:
                    BinaryOperation(instruction, ra_a, ra_b, rb_a, rb_b);
                    ip++;
                    break;

                    #endregion

                    #region MOV

                case Operation.MOV:
                    switch (instruction.Modifier)
                    {
                        case Modifier.A:
                            rb_a = ra_a;
                            break;
                        case Modifier.F:
                            rb_a = ra_a;
                            rb_b = ra_b;
                            break;
                        case Modifier.B:
                            rb_b = ra_b;
                            break;
                        case Modifier.AB:
                            rb_b = ra_a;
                            break;
                        case Modifier.X:
                            rb_b = ra_a;
                            rb_a = ra_b;
                            break;
                        case Modifier.BA:
                            rb_a = ra_b;
                            break;
                        case Modifier.I:
                            rb_a = ra_a;
                            rb_b = ra_b;
                            core[db].Operation = core[da].Operation;
                            core[db].Modifier = core[da].Modifier;
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
                            ra_a = warrior.GetPSpace(ra_a);
                            break;
                        case Modifier.AB:
                            rb_b = warrior.GetPSpace(ra_a);
                            break;
                        case Modifier.BA:
                            rb_a = warrior.GetPSpace(ra_b);
                            break;
                        case Modifier.F:
                        case Modifier.B:
                        case Modifier.X:
                        case Modifier.I:
                            rb_b = warrior.GetPSpace(ra_b);
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
                            warrior.SetPSpace(rb_a, ra_a);
                            break;
                        case Modifier.AB:
                            warrior.SetPSpace(rb_b, ra_a);
                            break;
                        case Modifier.BA:
                            warrior.SetPSpace(rb_a, ra_b);
                            break;
                        case Modifier.F:
                        case Modifier.B:
                        case Modifier.X:
                        case Modifier.I:
                            warrior.SetPSpace(rb_b, ra_b);
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
        private int GetEffectiveAddress(int ip, Mode mode, int primary)
        {
            int direct;
            int indirect;
            switch (mode)
            {
                case Mode.Immediate:
                    return ip;
                case Mode.Direct:
                    direct = mod(ip + primary);
                    return direct;
                case Mode.PreDecIndirectA:
                    direct = mod(primary + ip);
                    indirect = mod(direct + predec(ref core[direct].ValueA));
                    return indirect;
                case Mode.IndirectA:
                    direct = mod(ip + primary);
                    indirect = mod(direct + core[direct].ValueA);
                    return indirect;
                case Mode.PostIncIndirectA:
                    direct = mod(ip + primary);
                    indirect = mod(direct + postinc(ref core[direct].ValueA));
                    return indirect;
                case Mode.PreDecIndirectB:
                    direct = mod(primary + ip);
                    indirect = mod(direct + predec(ref core[direct].ValueB));
                    return indirect;
                case Mode.IndirectB:
                    direct = mod(ip + primary);
                    indirect = mod(direct + core[direct].ValueB);
                    return indirect;
                case Mode.PostIncIndirectB:
                    direct = mod(ip + primary);
                    indirect = mod(direct + postinc(ref core[direct].ValueB));
                    return indirect;
                default:
                    throw new InvalidOperationException("Unknown Mode");
            }
        }

        /// <returns>T- should die</returns>
        private bool BinaryOperation(EngineInstruction instruction, int ra_a, int ra_b, int rb_a, int rb_b)
        {
            bool die = false;
            switch (instruction.Modifier)
            {
                case Modifier.I:
                case Modifier.F:
                    die |= oper(ref rb_b, rb_b, ra_b, instruction.Operation);
                    die |= oper(ref rb_a, rb_a, ra_a, instruction.Operation);
                    break;
                case Modifier.A:
                    die = oper(ref rb_a, rb_a, ra_a, instruction.Operation);
                    break;
                case Modifier.B:
                    die = oper(ref rb_b, rb_b, ra_b, instruction.Operation);
                    break;
                case Modifier.X:
                    die |= oper(ref rb_a, rb_a, ra_b, instruction.Operation);
                    die |= oper(ref rb_b, rb_b, ra_a, instruction.Operation);
                    break;
                case Modifier.AB:
                    die = oper(ref rb_b, rb_b, ra_a, instruction.Operation);
                    break;
                case Modifier.BA:
                    die = oper(ref rb_a, rb_a, ra_b, instruction.Operation);
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