// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Collections.Generic;
using nMars.RedCode;

namespace nMars.Engine
{
    public class EngineWarrior : IRunningWarrior
    {
        public EngineWarrior(IWarrior warrior, EngineCore core, int index)
        {
            SourceWarrior = warrior;
            warriorIndex = index;
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

        public int GetPSpaceValue(int address)
        {
            if (address != 0)
            {
                return PSpace.Memory[address];
            }
            else
            {
                return LastResult;
            }
        }

        public void SetPSpaceValue(int address, int value)
        {
            if (address != 0)
            {
                PSpace.Memory[address] = value;
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

        public void Add(IInstruction instruction)
        {
            Instructions.Add(instruction);
        }

        public int Length
        {
            get { return SourceWarrior.Length; }
        }

        public void Dump(ISimpleOutput tw)
        {
            SourceWarrior.Dump(tw);
        }

        public void Dump(ISimpleOutput tw, ParserOptions options)
        {
            SourceWarrior.Dump(tw, options);
        }

        public void Dump(string fileName, ParserOptions options)
        {
            SourceWarrior.Dump(fileName, options);
        }

        public void Wrap()
        {
            for (int a = 0; a < Instructions.Count; a++)
            {
                Instructions[a].Wrap(Rules.CoreSize);
            }
        }

        public override string ToString()
        {
            return Name + " (" + LiveTasksCount + ")";
        }

        public int NextInstructionAddress
        {
            get { return Tasks.Peek(); }
        }

        IRunningInstruction IRunningWarrior.PrevInstruction
        {
            get
            {
                return PrevInstruction;
            }
        }

        public int PreviousInstructionAddress
        {
            get
            {
                return PrevInstruction.Address;
            }
        }

        public IRunningInstruction NextInstruction
        {
            get { return core[NextInstructionAddress]; }
        }

        public int LiveTasksCount
        {
            get { return Tasks.Count; }
        }

        int IRunningWarrior.DeadTasksCount
        {
            get
            {
                return DeadTasksCount;
            }
        }

        IEnumerable<int> IRunningWarrior.Tasks
        {
            get
            {
                return Tasks;
            }
        }

        public int TasksCount
        {
            get { return Tasks.Count; }
        }

        IPSpace IRunningWarrior.PSpace
        {
            get { return PSpace; }
        }

        int IRunningWarrior.LastResult
        {
            get { return LastResult; }
        }

        int IRunningWarrior.PSpaceIndex
        {
            get { return PSpaceIndex; }
        }

        public int WarriorIndex
        {
            get
            {
                return warriorIndex;
            }
        }

        public int s
        {
            get { return PSpaceIndex; }
        }

        #endregion

        #region Variables

        public RoundResult Result;
        public Queue<int> Tasks;
        private int warriorIndex;
        public int StartOrder;
        public int PSpaceIndex = -1;
        public IWarrior SourceWarrior;
        public PSpace PSpace = null;
        private EngineCore core;
        private int loadAddress = 0;
        public int LastResult;
        public int DeadTasksCount;
        public EngineInstruction PrevInstruction;

        #endregion
    }
}