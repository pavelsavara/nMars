// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Collections.Generic;
using System.Xml;

namespace nMars.RedCode
{
    [Serializable]
    public class CoreDump
    {
        public CoreDump(ICoreDump source)
        {
            results = new MatchResult(source.Results);
            warriorsCount = source.WarriorsCount;
            liveWarriorsCount = source.LiveWarriorsCount;
            cyclesLeft = source.CyclesLeft;
            cycles = source.Cycles;
            round = source.Round;
            nextWarriorIndex = source.NextWarriorIndex;
            coreSize = source.CoreSize;
            tasks = new List<List<int>>();
            foreach (IList<int> list in source.Tasks)
            {
                tasks.Add(new List<int>(list));
            }
            core = new Instruction[coreSize];
            for (int a = 0; a < coreSize; a++)
            {
                core[a] = new Instruction(source[a]);
            }
        }

        public static void Dump(XmlWriter xw, ICoreDump engine)
        {
        }

        public static void Load(XmlReader xw, ICoreLoad engine)
        {
        }

        #region Variables

        public MatchResult results;
        public int warriorsCount;
        public int liveWarriorsCount;
        public int cyclesLeft;
        public int cycles;
        public int round;
        public int nextWarriorIndex;
        public int coreSize;
        public List<List<int>> tasks;
        public Instruction[] core;

        #endregion
    }
}
