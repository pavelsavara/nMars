// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Collections.Generic;
using System.IO;
using nMars.RedCode;

namespace nMars.Engine
{
    public class EngineWarrior : IRunningWarrior
    {
        public EngineWarrior(IWarrior warrior, EngineCore core, int index)
        {
            SourceWarrior = warrior;
            Index = index;
            Tasks = new Queue<int>();
            this.core = core;
        }


        public void InitPSpace(IPSpaces pSpaces)
        {
            string pName = Name;
            if (Pin != -1)
                pName = Pin.ToString();
            if (pSpaces.ContainsKey(pName))
            {
                pSpace = pSpaces[pName];
                pSpaceSize = pSpace.Length;
            }
            else
            {
                pSpaceSize = core.rules.PSpaceSize;
                pSpace = new int[pSpaceSize];
                pSpaces[pName] = pSpace;
            }
        }

        public int GetPSpace(int address)
        {
            int addr = address % pSpaceSize;
            if (addr < 0) addr += pSpaceSize;
            return pSpace[addr];
        }

        public void SetPSpace(int address, int value)
        {
            int addr = address % pSpaceSize;
            if (addr < 0) addr += pSpaceSize;
            pSpace[addr] = core.mod(value);
        }

        public Queue<int> Tasks;
        public int Index;
        public int StartOrder;
        public IWarrior SourceWarrior;
        private int[] pSpace = null;
        private int pSpaceSize = 0;
        private EngineCore core;
        private int loadAddress = 0;

        public int LiveTasks
        {
            get { return Tasks.Count; }
        }

        public int StartOffset
        {
            get { return SourceWarrior.StartOffset; }
        }

        public int Pin
        {
            get { return SourceWarrior.Pin; }
        }

        public int LoadAddress
        {
            get { return loadAddress; }
            set { loadAddress = value; }
        }

        public string Name
        {
            get { return SourceWarrior.Name; }
        }

        public string Author
        {
            get { return SourceWarrior.Author; }
        }

        public string Date
        {
            get { return SourceWarrior.Date; }
        }

        public string Version
        {
            get { return SourceWarrior.Version; }
        }

        public string FileName
        {
            get { return SourceWarrior.FileName; }
        }

        public Rules Rules
        {
            get { return SourceWarrior.Rules; }
        }

        public IInstruction this[int offset]
        {
            get { return SourceWarrior[offset]; }
        }

        public int Length
        {
            get { return SourceWarrior.Length; }
        }

        public void Dump(TextWriter tw)
        {
            SourceWarrior.Dump(tw);
        }

        public void Dump(TextWriter tw, DumpOptions options)
        {
            SourceWarrior.Dump(tw, options);
        }

        public void Dump(string fileName, DumpOptions options)
        {
            SourceWarrior.Dump(fileName, options);
        }

        public FightResult Result = FightResult.Tie;

        public override string ToString()
        {
            return Name + " (" + LiveTasks.ToString() + ")";
        }

        public int NextInstructionIndex
        {
            get { return Tasks.Peek(); }
        }

        public IInstruction PreviousInstruction
        {
            get { throw new NotImplementedException(); }
        }

        public int PreviousInstructionIndex
        {
            get { throw new NotImplementedException(); }
        }

        public IInstruction NextInstruction
        {
            get { return core.core[NextInstructionIndex]; }
        }

        public int LiveTasksCount
        {
            get { return Tasks.Count; }
        }

        IList<int> IRunningWarrior.Tasks
        {
            get
            {
                List<int> tasks = new List<int>();
                foreach (int i in Tasks)
                {
                    tasks.Add(i);
                }
                return tasks;
            }
        }
    }
}