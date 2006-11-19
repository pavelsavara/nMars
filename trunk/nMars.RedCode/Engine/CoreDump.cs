// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace nMars.RedCode
{
    [Serializable]
    public class CoreDump : ICoreDump
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
            tasks = new List<IList<int>>();
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

        public IRunningInstruction this[int address]
        {
            get { throw new NotImplementedException(); }
        }

        public int CoreSize
        {
            get { return coreSize; }
        }

        public IList<IList<int>> Tasks
        {
            get { return tasks; }
        }

        public int NextWarriorIndex
        {
            get { return nextWarriorIndex; }
        }

        public int Round
        {
            get { return round; }
        }

        public int Cycles
        {
            get { return cycles; }
        }

        public int CyclesLeft
        {
            get { return cyclesLeft; }
        }

        public int LiveWarriorsCount
        {
            get { return liveWarriorsCount; }
        }

        public int WarriorsCount
        {
            get { return warriorsCount; }
        }

        public MatchResult Results
        {
            get { return results; }
        }

        #region
        
        public static void Dump(XmlWriter xw, CoreDump core)
        {
            if (coreSerializer == null)
                coreSerializer = new XmlSerializer(typeof(CoreDump));
            coreSerializer.Serialize(xw, core);
        }

        public static CoreDump Load(XmlReader xr, ICoreLoad engine)
        {
            if (coreSerializer == null)
                coreSerializer = new XmlSerializer(typeof(CoreDump));
            CoreDump cd = coreSerializer.Deserialize(xr) as CoreDump;
            return cd;
        }

        private static XmlSerializer coreSerializer;

        #endregion

        #region Variables

        public MatchResult results;
        public int warriorsCount;
        public int liveWarriorsCount;
        public int cyclesLeft;
        public int cycles;
        public int round;
        public int nextWarriorIndex;
        public int coreSize;
        public List<IList<int>> tasks;
        public Instruction[] core;
        
        #endregion
    }
}
