// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using nMars.RedCode;

namespace pMars.DllWrapper
{
    /// <summary>
    /// This is PInvoke glue to pMars.dll
    /// </summary>
    static class pMarsDll
    {
        static pMarsDll()
        {
            instructionSize = Marshal.SizeOf(typeof(PmarsInstruction));
            warrirorSize = Marshal.SizeOf(typeof(PmarsWarrior));
            pointerSize = Marshal.SizeOf(typeof(IntPtr));
            intSize = Marshal.SizeOf(typeof(int));
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct PmarsInstruction : IRunningInstruction
        {
            public int A_value;
            public int B_value;
            public byte opcode;
            public byte A_mode;
            public byte B_mode;
            public byte debuginfo;

            public static Mode ConvertMode(int mode)
            {
                switch (mode)
                {
                    case 0x00:
                        return Mode.Immediate;
                    case 0x01:
                        return Mode.Direct;
                    case 0x02:
                        return Mode.IndirectB;
                    case 0x03:
                        return Mode.PreDecIndirectB;
                    case 0x04:
                        return Mode.PostIncIndirectB;
                    case 0x82:
                        return Mode.IndirectA;
                    case 0x83:
                        return Mode.PreDecIndirectA;
                    case 0x84:
                        return Mode.PostIncIndirectA;
                    default:
                        throw new InvalidOperationException("Unknown mode");
                }
            }

            #region IInstruction

            public Operation Operation
            {
                get { return OperationHelper.Convert(((opcode & 0xf8)) >> 3); }
            }

            public Modifier Modifier
            {
                get { return (Modifier)(opcode & 0x07); }
            }

            public Mode ModeA
            {
                get { return ConvertMode(A_mode); }
            }

            public int ValueA
            {
                get { return A_value; }
            }

            public Mode ModeB
            {
                get { return ConvertMode(B_mode); }
            }

            public int ValueB
            {
                get { return B_value; }
            }

            public int Address
            {
                get
                {
                    //TODO stub
                    return 0;
                }
            }

            public string GetLine(ParserOptions options, bool start)
            {
                throw new NotImplementedException();
            }

            #endregion
        }

        [StructLayout(LayoutKind.Sequential)]
        public class PmarsWarrior
        {
            public int pSpaceIDNumber;
            public IntPtr taskHead;
            public IntPtr taskTail;
            public int tasks;
            public int lastResult;
            public int pSpaceIndex;
            public int position; //load position in core
            public int instLen;
            public int offset;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 71)]
            public short[] score;

            public int totalScore;

            [MarshalAs(UnmanagedType.LPStr)]
            public string name;

            [MarshalAs(UnmanagedType.LPStr)]
            public string version;

            [MarshalAs(UnmanagedType.LPStr)]
            public string date;

            [MarshalAs(UnmanagedType.LPStr)]
            public string fileName;

            [MarshalAs(UnmanagedType.LPStr)]
            public string authorName;

            public IntPtr instBank;

            public IntPtr nextWarrior;
        }

        #region Dll

        [DllImport("pMars.dll")]
        public static extern PmarsWarrior pMarsParse([In] int argc,
                                                     [In] [MarshalAs(UnmanagedType.LPArray)] string[] argv,
                                                     [In] [MarshalAs(UnmanagedType.LPStr)] string errFile);

        [DllImport("pMars.dll")]
        public static extern int pMarsBeginMatch([In] int argc, [In] [MarshalAs(UnmanagedType.LPArray)] string[] argv,
                                                 [In] [MarshalAs(UnmanagedType.LPStr)] string errFile);

        [DllImport("pMars.dll")]
        public static extern int pMarsStepMatch();

        [DllImport("pMars.dll")]
        public static extern void pMarsResultsMatch();

        [DllImport("pMars.dll")]
        public static extern void pMarsWatchMatch([Out] out IntPtr aCore, [Out] out int aCoreSize,
                                                  [Out] out IntPtr aCyclesLeft, [Out] out IntPtr aRound,
                                                  [Out] out IntPtr aWarriors, [Out] out int aWarriorsCount,
                                                  [Out] out IntPtr aPSpaces, [Out] out IntPtr aWarrirosLeft,
                                                  [Out] out IntPtr aNextWarrior, [Out] out IntPtr aTaskQueue,
                                                  [Out] out IntPtr aEndQueue);

        [DllImport("pMars.dll")]
        public static extern void pMarsEndMatch();

        [DllImport("pMars.dll")]
        public static extern void pMarsFreeParsed();

        #endregion

        public static int instructionSize;
        public static int warrirorSize;
        public static int pointerSize;
        public static int intSize;

        public static void FillInstructions(IList<IInstruction> list, IntPtr first, int length, int coreSize)
        {
            for (int a = 0; a < length; a++)
            {
                IntPtr instructionPtr = (IntPtr)((int)first + (a * instructionSize));
                PmarsInstruction m = (PmarsInstruction)Marshal.PtrToStructure(instructionPtr, typeof(PmarsInstruction));

                DllInstruction c = new DllInstruction(m);
                c.address = a;
                //c.ValueA = Instruction.Wrap(c.ValueA, coreSize);
                //c.ValueB = Instruction.Wrap(c.ValueB, coreSize);
                list.Add(c);
            }
        }

        public static void FillWarrirors(List<PmarsWarrior> list, IntPtr first, int length)
        {
            for (int w = 0; w < length; w++)
            {
                IntPtr warrirorPtr = (IntPtr)((int)first + (w * warrirorSize));
                list.Add((PmarsWarrior)Marshal.PtrToStructure(warrirorPtr, typeof(PmarsWarrior)));
            }
        }

        public static void FillTasks(List<int> list, IntPtr first, IntPtr last, IntPtr start, IntPtr end, int length)
        {
            IntPtr taskPtr = first;
            for (int a = 0; a < length; a++)
            {
                int task = Marshal.ReadInt32(taskPtr);
                list.Add(task);
                taskPtr = (IntPtr)((int)taskPtr + pointerSize);
                if (taskPtr == end)
                    taskPtr = start;
            }
        }

        public static List<IPSpace> FillPSpace(Rules rules, List<PmarsWarrior> warriorsDllCopy, IntPtr pspaceDll)
        {
            List<IPSpace> res = new List<IPSpace>(rules.WarriorsCount);
            for (int w = 0; w < rules.WarriorsCount; w++)
            {
                PSpace p = new PSpace(rules.PSpaceSize);
                int psindex = warriorsDllCopy[w].pSpaceIndex;
                IntPtr ptr = Marshal.ReadIntPtr(pspaceDll, pointerSize * psindex);
                for (int idx = 0; idx < rules.PSpaceSize; idx++)
                {
                    p.Memory[idx] = Marshal.ReadInt32(ptr, idx * intSize);
                }
                res.Add(p);
            }
            return res;
        }

        public static int WarrirorIndex(IntPtr first, IntPtr currentPtr)
        {
            IntPtr current = Marshal.ReadIntPtr(currentPtr);
            return ((int)current - (int)first) / warrirorSize;
        }

        public static int InstructionAddress(IntPtr taskPtr)
        {
            return Marshal.ReadInt32(taskPtr);
        }

        public static DllWarrior ConvertWarrior(string fileName, PmarsWarrior w, Rules rules)
        {
            DllWarrior warrior;
            warrior = new DllWarrior(rules);
            warrior.StartOffset = w.offset;
            warrior.Name = w.name;
            warrior.Author = w.authorName;
            warrior.Date = w.date;
            warrior.Version = w.version;
            warrior.FileName = fileName;
            if (w.pSpaceIndex != PSpace.UNSHARED)
            {
                warrior.Pin = w.pSpaceIDNumber;
            }
            else
            {
                warrior.Pin = PSpace.UNSHARED;
            }

            FillInstructions(warrior.Instructions, w.instBank, w.instLen, rules.CoreSize);
            return warrior;
        }

        public static List<string> BuildParams(Rules rules, bool parser, IList<int> forcedAddresses,
                                               params string[] fileNames)
        {
            List<string> r = new List<string>();

            r.Add("pMars.dll");
            r.Add("-r");
            if (parser)
            {
                r.Add("0");
            }
            else
            {
                r.Add(rules.Rounds.ToString());
                r.Add("-b");
            }
            //r.Add("-k");
            r.Add("-p");
            r.Add(rules.MaxProcesses.ToString());
            r.Add("-s");
            r.Add(rules.CoreSize.ToString());
            r.Add("-c");
            r.Add(rules.MaxCycles.ToString());
            r.Add("-l");
            r.Add(rules.MaxLength.ToString());
            r.Add("-d");
            r.Add(rules.MinDistance.ToString());
            r.Add("-S");
            r.Add(rules.PSpaceSize.ToString());
            for (int w = 0; w < fileNames.Length; w++)
            {
                r.Add(fileNames[w]);
                if (forcedAddresses != null && w == 1)
                {
                    r.Add("-F");
                    r.Add(forcedAddresses[w].ToString());
                }
            }
            return r;
        }
    }

    class DllWarrior : Warrior, IRunningWarrior
    {
        //TODO just stub
        public DllWarrior(Rules rules)
            : base(rules)
        {
        }

        public IRunningInstruction NextInstruction
        {
            get { throw new NotImplementedException(); }
        }

        public int NextInstructionAddress
        {
            get { throw new NotImplementedException(); }
        }

        public IRunningInstruction PrevInstruction
        {
            get { throw new NotImplementedException(); }
        }

        public int PreviousInstructionAddress
        {
            get { throw new NotImplementedException(); }
        }

        public int LiveTasksCount
        {
            get { throw new NotImplementedException(); }
        }

        public int DeadTasksCount
        {
            get { throw new NotImplementedException(); }
        }

        public IList<int> Tasks
        {
            get { throw new NotImplementedException(); }
        }

        public int TasksCount
        {
            get { throw new NotImplementedException(); }
        }

        public IPSpace PSpace
        {
            get { throw new NotImplementedException(); }
        }

        public int LastResult
        {
            get { throw new NotImplementedException(); }
        }

        public int PSpaceIndex
        {
            get { throw new NotImplementedException(); }
        }
    }

    class DllInstruction : Instruction, IRunningInstruction
    {
        public DllInstruction(IInstruction src)
            : base(src)
        {
        }

        public int address;

        public int Address
        {
            get { return address; }
        }
    }
}