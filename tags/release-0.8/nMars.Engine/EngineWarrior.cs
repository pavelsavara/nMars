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
            if (Pin == PSpace.UNSHARED)
            {
                PSpaceIndex = PSpace.UNSHARED;
            }
            else
            {
                PSpaceIndex = PSpace.PIN_APPEARED;
            }
            Tasks = new Queue<int>();
            this.core = core;
            LastResult = core.rules.CoreSize - 1;
        }

        #region PSpace

        public int GetPSpaceValue(int idx)
        {
            int addr = idx % core.rules.PSpaceSize;
            if (addr != 0)
            {
                return PSpace.Memory[addr];
            }
            else
            {
                return LastResult;
            }
        }

        public void SetPSpaceValue(int address, int value)
        {
            int addr = address % core.rules.PSpaceSize;
            if (addr != 0)
            {
                PSpace.Memory[addr] = value;
            }
            else
            {
                LastResult = value;
            }
        }
        
        #endregion

        #region Interface

        public int LiveTasks
        {
            get { return Tasks.Count; }
        }

        public int StartOffset
        {
            get { return SourceWarrior.StartOffset; }
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

        public int Pin
        {
            get { return SourceWarrior.Pin; }
        }

        public Rules Rules
        {
            get { return SourceWarrior.Rules; }
        }

        public IInstruction this[int offset]
        {
            get { return SourceWarrior[offset]; }
        }

        public IList<IInstruction> Instructions
        {
            get { return SourceWarrior.Instructions; }
        }

        public int Length
        {
            get { return SourceWarrior.Length; }
        }

        public void Dump(TextWriter tw)
        {
            SourceWarrior.Dump(tw);
        }

        public void Dump(TextWriter tw, ParserOptions options)
        {
            SourceWarrior.Dump(tw, options);
        }

        public void Dump(string fileName, ParserOptions options)
        {
            SourceWarrior.Dump(fileName, options);
        }

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
            get { return core[NextInstructionIndex]; }
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

        public int TasksCount
        {
            get
            {
                return Tasks.Count;
            }
        }

        IPSpace IRunningWarrior.PSpace
        {
            get
            {
                return PSpace;
            }
        }

        int IRunningWarrior.LastResult
        {
            get
            {
                return LastResult;
            }
        }

        int IRunningWarrior.PSpaceIndex
        {
            get { return PSpaceIndex; }
        }

        public int s
        {
            get { return PSpaceIndex; }
        }

        #endregion

        #region Variables

        public RoundResult Result;
        public Queue<int> Tasks;
        public int Index;
        public int StartOrder;
        public int PSpaceIndex=-1;
        public IWarrior SourceWarrior;
        public PSpace PSpace = null;
        private EngineCore core;
        private int loadAddress = 0;
        public int LastResult;

        #endregion
    }
}