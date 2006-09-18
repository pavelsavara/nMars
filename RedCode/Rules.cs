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
        public int coreSize = 8000;
        public int pSpaceSize = 500; // coreSize / 16 
        public int maxCycles = 80000;
        public int numberOfFighters = 2;
        public int maxLength = 100;
        public int maxProcesses = 1000;
        public bool enablePSpace = false;
        public int minDistance = 100;
        public int rounds = 1;
        public int warriors = 2;
        public int version = 60;

        public static readonly Rules DefaultRules = new Rules();
    }
}