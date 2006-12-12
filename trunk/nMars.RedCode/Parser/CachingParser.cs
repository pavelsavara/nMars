// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.Collections.Generic;
using nMars.RedCode.Modules;

namespace nMars.RedCode
{
    public class CachingParser : ParserBase
    {
        public CachingParser(IParser aParser)
        {
            parser = aParser;
        }

        public override void InitParser(Rules aRules)
        {
            parser.InitParser(aRules);
            base.InitParser(aRules);
            cache = new Dictionary<string, IWarrior>();
        }

        private IParser parser;
        private Dictionary<string, IWarrior> cache;

        public override IWarrior Parse(string fileName, ISimpleOutput err)
        {
            if (cache.ContainsKey(fileName))
            {
                return cache[fileName];
            }
            else
            {
                IWarrior res = parser.Parse(fileName, err);
                cache[fileName] = res;
                return res;
            }
        }

        public override string Name
        {
            get { return GetType().Namespace; }
        }

        public override string Version
        {
            get { return ModuleRegister.GetVersion(GetType()); }
        }
    }
}