using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using nMars.RedCode;

namespace nMars.pMarsDll
{
    static class pMarsDll
    {
        static pMarsDll()
        {
            instructionSize = Marshal.SizeOf(typeof (MemStruct));
        }
        
        [StructLayout(LayoutKind.Sequential)]
        public struct MemStruct
        {
            public int A_value;
            public int B_value;
            public byte opcode;
            public byte A_mode;
            public byte B_mode;
            public byte debuginfo;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class WarriorStruct
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


        [DllImport("pMars.dll")]
        public static extern WarriorStruct pMarsParse(
            [In] int argc,
            [In, MarshalAs(UnmanagedType.LPArray)] string[] argv,
            [In, MarshalAs(UnmanagedType.LPStr)] string errFile);

        [DllImport("pMars.dll")]
        public static extern int pMarsBeginMatch(
            [In] int argc,
            [In, MarshalAs(UnmanagedType.LPArray)] string[] argv,
            [In, MarshalAs(UnmanagedType.LPStr)] string errFile);

        [DllImport("pMars.dll")]
        public static extern int pMarsStepMatch();

        [DllImport("pMars.dll")]
        public static extern void pMarsEndMatch();
        
        /*[DllImport("pMars.dll")]
        public static extern void pMarsGetCore(
            [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] MemStruct[] argv,
            [Out] int size);*/

        [DllImport("pMars.dll")]
        public static extern void pMarsGetCore(
            [Out] out IntPtr core,
            [Out] out int size);

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

        public static int instructionSize;
        public static void FillInstructions(IList<Instruction> list, IntPtr first, int length, int coreSize)
        {
            for (int i = 0; i < length; i++)
            {
                IntPtr instructionPtr = (IntPtr)(((int)first) + (i * instructionSize));
                MemStruct m = (MemStruct)Marshal.PtrToStructure(instructionPtr, typeof(MemStruct));
                Instruction inst = ConvertInstruction(m, coreSize);
                list.Add(inst);
            }

        }

        public static Instruction ConvertInstruction(MemStruct m, int coreSize)
        {
            int op = ((m.opcode & 0xf8)) >> 3;
            int mod = (m.opcode & 0x07);


            return new Instruction(OperationHelper.Convert(op), (Modifier)mod,
                                   ConvertMode(m.A_mode), Instruction.Wrap(m.A_value, coreSize),
                                   ConvertMode(m.B_mode), Instruction.Wrap(m.B_value, coreSize));
        }

        public static List<string> BuildParams(Rules rules, bool parser,params string[] fileNames)
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
                r.Add(rules.rounds.ToString());
            }
            r.Add("-k");
            r.Add("-p");
            r.Add(rules.maxProcesses.ToString());
            r.Add("-s");
            r.Add(rules.coreSize.ToString());
            r.Add("-c");
            r.Add(rules.maxCycles.ToString());
            r.Add("-l");
            r.Add(rules.maxLength.ToString());
            r.Add("-d");
            r.Add(rules.minDistance.ToString());
            r.Add("-S");
            r.Add(rules.pSpaceSize.ToString());
            r.AddRange(fileNames);
            return r;
        }
        
    }
}
