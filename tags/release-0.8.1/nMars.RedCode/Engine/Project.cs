// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Collections.Generic;

namespace nMars.RedCode
{
    [Serializable]
    public class Project : IProject
    {
        public Project()
        {
        }

        public Project(Rules rules)
        {
            Rules = rules;
        }

        public IList<IWarrior> Warriors = new List<IWarrior>();
        public List<int> ForcedAddresses = null;
        public Rules Rules = Rules.DefaultRules;
        public EngineOptions EngineOptions = EngineOptions.Default;
        public ParserOptions ParserOptions = ParserOptions.Default;

        Rules IProject.Rules
        {
            get { return Rules; }
        }

        EngineOptions IProject.EngineOptions
        {
            get { return EngineOptions; }
            set { EngineOptions = value; }
        }

        ParserOptions IProject.ParserOptions
        {
            get { return ParserOptions; }
            set { ParserOptions = value; }
        }

        IList<IWarrior> IProject.Warriors
        {
            get { return Warriors; }
        }

        IList<int> IProject.ForcedAddresses
        {
            get { return ForcedAddresses; }
        }
    }
}