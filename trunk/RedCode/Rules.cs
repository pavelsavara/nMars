using System;

namespace nMars.RedCode
{
    public class RulesException : Exception
    {
        public RulesException(string message)
            : base(message)
        {
        }
    }

    [Serializable]
    public class Rules
    {
        public int CoreSize = 8000;
        public int PSpaceSize = 500; // CoreSize / 16 
        public int maxCycles = 80000;
        public int NumberOfFighters = 2;
        public int maxLength = 100;
        public int maxProcesses = 1000;
        public bool EnablePSpace = false;
        public int minDistance = 100;
        public int Rounds = 1;
        public int Warriors = 2;
        public int Version = 60;

        public static readonly Rules DefaultRules = new Rules();
    }
}