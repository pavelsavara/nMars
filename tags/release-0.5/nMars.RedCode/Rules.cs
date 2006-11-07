// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Runtime.InteropServices;

namespace nMars.RedCode
{
    [ComVisible(true)]
    public class RulesException : Exception
    {
        public RulesException(string message)
            : base(message)
        {
        }
    }

    [ComVisible(true)]
    public enum ICWStandard
    {
        ICWS88,
        ICWS94,
    }

    [ComVisible(true)]
    public enum PointsFormula
    {
        Standard, // (W*W-1)/S
    }

    [Serializable]
    [ComVisible(true)]
    public class Rules : IComparable
    {
        public int CoreSize = 8000;
        public int PSpaceSize = 500; // coreSize / 16 
        public int MaxCycles = 80000;
        public int MaxLength = 100;
        public int MaxProcesses = 1000;
        public bool EnablePSpace = true;
        public int MinDistance = 100;
        public int Rounds = 1;
        public int WarriorsCount = 2;
        public int Version = 60;
        public PointsFormula ScoreFormula = PointsFormula.Standard;
        public ICWStandard ICWSStandard = ICWStandard.ICWS94;

        public static readonly Rules DefaultRules = new Rules();

        public int CompareTo(object obj)
        {
            Rules r2 = obj as Rules;
            if (CoreSize != r2.CoreSize) return -1;
            if (PSpaceSize != r2.PSpaceSize) return -1;
            if (MaxCycles != r2.MaxCycles) return -1;
            if (MaxLength != r2.MaxLength) return -1;
            if (MaxProcesses != r2.MaxProcesses) return -1;
            if (EnablePSpace != r2.EnablePSpace) return -1;
            if (MinDistance != r2.MinDistance) return -1;
            if (Rounds != r2.Rounds) return -1;
            if (WarriorsCount != r2.WarriorsCount) return -1;
            if (Version != r2.Version) return -1;
            return 0;
        }
    }
}