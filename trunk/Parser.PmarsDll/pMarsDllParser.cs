using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using nMars.RedCode;

namespace nMars.pMarsDll
{
    public class pMarsDllParser : ParserRoot
    {
        [StructLayout(LayoutKind.Sequential)]
        struct MemStruct
        {
            public int A_value;
            public int B_value;
            public byte opcode;
            public byte A_mode;
            public byte B_mode;
            public byte debuginfo;
        }

        [StructLayout(LayoutKind.Sequential)]
        class WarriorStruct
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

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 71)] public short[] score;

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


        [DllImport("pMarsDll.dll")]
        //[return : MarshalAs(UnmanagedType.LPStruct)]
        private static extern WarriorStruct pMarsParse(
            [In] int argc,
            [In, MarshalAs(UnmanagedType.LPArray)] string[] argv,
            [In, MarshalAs(UnmanagedType.LPStr)] string errFile);

        
        private Mode convertMode(int mode)
        {
            switch(mode)
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

        public pMarsDllParser(Rules rules)
        {
            InitParser(rules);
        }

        public override IWarrior Parse(string fileName, TextWriter err)
        {
            string errFile=Path.GetTempFileName();
            IWarrior res = Parse(fileName, errFile);
            if (res==null)
            {
                string errors = File.ReadAllText(errFile);
                err.Write(errors);
                File.Delete(errFile);
            }
            return res;
        }
        
        public override IWarrior Parse(string fileName, string errFileName)
        {
            int instructionSize = Marshal.SizeOf(typeof(MemStruct));
            List<string> r=new List<string>();

            r.Add("pMarsDll.dll");
            r.Add("-r");
            r.Add("0");
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
            r.Add(fileName);

            WarriorStruct w=pMarsParse(r.Count, r.ToArray(), errFileName);
            if (w == null) return null;
            
            //convert
            Warrior warrior=new Warrior(rules);
            for (int i = 0; i < w.instLen; i++)
            {
                IntPtr instructionPtr = (IntPtr) (((int)w.instBank) + (i*instructionSize));
                MemStruct m = (MemStruct) Marshal.PtrToStructure(instructionPtr, typeof(MemStruct));
                int op = ((m.opcode & 0xf8)) >> 3;
                int mod = (m.opcode & 0x07);
                
                
                
                
                Instruction inst = new Instruction(OperationHelper.Convert(op), (Modifier) mod,
                                                   convertMode(m.A_mode), Instruction.Wrap(m.A_value, rules.coreSize),
                                                   convertMode(m.B_mode), Instruction.Wrap(m.B_value, rules.coreSize));
                //string test = inst.ToString();
                warrior.Instructions.Add(inst);
            }
            warrior.StartOffset = w.offset;
            warrior.Name = w.name;
            warrior.Author = w.authorName;
            warrior.Date = w.date;
            warrior.Version = w.version;

            return warrior;
        }
    }
}
