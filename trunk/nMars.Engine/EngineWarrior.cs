// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.Collections.Generic;
using System.IO;
using nMars.RedCode;

namespace nMars.Engine
{
    public class EngineWarrior : IRunningWarrior
    {
        public EngineWarrior(IWarrior warrior, Core core, int index, int loadAddress)
        {
            SourceWarrior = warrior;
            Index = index;
            Tasks = new Queue<int>();
            this.core = core;
            this.loadAddress = loadAddress;
            Load();
        }

        private void Load()
        {
            bool initpspace = false;

            //copy warrior to core
            for (int a = 0; a < Length; a++)
            {
                IInstruction instruction = this[a];
                if (instruction.ValueA >= core.CoreSize || instruction.ValueA <= 0 - core.CoreSize ||
                    instruction.ValueB >= core.CoreSize || instruction.ValueB <= 0 - core.CoreSize)
                {
                    throw new RulesException("operand value out of core size");
                }
                if (instruction.Operation == Operation.LDP ||
                    instruction.Operation == Operation.STP)
                {
                    if (!core.Rules.EnablePSpace)
                    {
                        throw new RulesException("Current rules don't support p-space operations");
                    }
                    initpspace = true;
                }
                int addr = core.mod(loadAddress + a);
                core.core[addr] = new EngineInstruction(instruction, addr);
            }

            if (initpspace)
                InitPSpace(core.PSpaces);

            Tasks.Enqueue(core.mod(loadAddress + StartOffset));
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
                pSpaceSize = core.Rules.PSpaceSize;
                pSpace = new int[pSpaceSize];
                pSpaces[pName] = pSpace;
            }
        }

        public int GetPSpace(int address)
        {
            int addr = address%pSpaceSize;
            if (addr < 0) addr += pSpaceSize;
            return pSpace[addr];
        }

        public void SetPSpace(int address, int value)
        {
            int addr = address%pSpaceSize;
            if (addr < 0) addr += pSpaceSize;
            pSpace[addr] = core.mod(value);
        }

        public Queue<int> Tasks;
        public int Index;
        public IWarrior SourceWarrior;
        private int[] pSpace = null;
        private int pSpaceSize = 0;
        private Core core;
        private int loadAddress;

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