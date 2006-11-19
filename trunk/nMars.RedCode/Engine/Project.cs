// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Collections.Generic;

namespace nMars.RedCode
{
    public class Project : IProject
    {
        public Project()
        {
        }

        public Project(Rules rules)
        {
            this.rules = rules;
        }

        private IList<IWarrior> warriors = new List<IWarrior>();
        private IList<int> forcedAddresses = null;
        private Rules rules = Rules.DefaultRules;
        private EngineOptions engineOptions = EngineOptions.Default;
        private ParserOptions parserOptions = ParserOptions.Default;

        public Rules Rules
        {
            get { return rules; }
            set { rules = value; }
        }

        public EngineOptions EngineOptions
        {
            get { return engineOptions; }
            set { engineOptions = value; }
        }

        public ParserOptions ParserOptions
        {
            get { return parserOptions; }
            set { parserOptions = value; }
        }

        public IList<IWarrior> Warriors
        {
            get { return warriors; }
        }

        public IList<int> ForcedAddresses
        {
            get { return forcedAddresses; }
            set { forcedAddresses = value; }
        }
    }
}
