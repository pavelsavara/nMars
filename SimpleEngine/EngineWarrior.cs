// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.Collections.Generic;
using System.IO;
using nMars.RedCode;

namespace nMars.SimpleEngine
{
    public class EngineWarrior : IWarrior
    {
        public EngineWarrior(IWarrior warrior, Core core, int index, int loadAddress)
        {
            Warrior = warrior;
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
                Instruction instruction = this[a];
                if (instruction.ValueA >= core.CoreSize || instruction.ValueA <= 0 - core.CoreSize ||
                    instruction.ValueB >= core.CoreSize || instruction.ValueB <= 0 - core.CoreSize)
                {
                    throw new RulesException("operand value out of core size");
                }
                if (instruction.Operation == Operation.LDP ||
                    instruction.Operation == Operation.STP)
                {
                    if (!core.Rules.enablePSpace)
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
                pSpaceSize = core.Rules.pSpaceSize;
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
        public IWarrior Warrior;
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
            get { return Warrior.StartOffset; }
        }

        public int Pin
        {
            get { return Warrior.Pin; }
        }

        public int LoadAddress
        {
            get { return loadAddress; }
        }

        public string Name
        {
            get { return Warrior.Name; }
        }

        public string Author
        {
            get { return Warrior.Author; }
        }

        public Rules Rules
        {
            get { return Warrior.Rules; }
        }

        public Instruction this[int offset]
        {
            get { return Warrior[offset]; }
        }

        public int Length
        {
            get { return Warrior.Length; }
        }

        public void Dump(TextWriter tw)
        {
            Warrior.Dump(tw);
        }

        public void Dump(TextWriter tw, DumpOptions options)
        {
            Warrior.Dump(tw, options);
        }

        public FightResult Result = FightResult.Tie;

        public override string ToString()
        {
            return Name + " (" + LiveTasks.ToString() + ")";
        }
    }
}