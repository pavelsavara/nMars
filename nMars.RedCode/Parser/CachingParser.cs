// This file is part of nMars - Core War MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.Collections.Generic;

namespace nMars.RedCode
{
    /// <summary>
    /// Parser wrapper which caches warriors compiled under same rules
    /// </summary>
    public class CachingParser : BaseParser
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="aParser">Real parser</param>
        public CachingParser(IParser aParser)
        {
            parser = aParser;
            cache = new Dictionary<string, IWarrior>();
            cachedRules = null;
        }

        private IParser parser;
        private Dictionary<string, IWarrior> cache;
        private Rules cachedRules;

        /// <summary>
        /// Parse warrior files in project parameter considering parser options and rules
        /// </summary>
        /// <param name="aProject">files, rules, options</param>
        /// <param name="aConsole">output console, could be null</param>
        /// <returns>list of errors</returns>
        public override ParseResult Parse(IProject aProject, ISimpleOutput aConsole)
        {
            //cache and ceck rules
            if (cachedRules==null)
            {
                cachedRules = aProject.Rules;
            }
            else if (!cachedRules.Equals(aProject.Rules))
            {
                throw new ParserException("Caching parser can cache only warriors compiled under same rules");
            }
            return base.Parse(aProject, aConsole);
        }

        protected override IWarrior Parse(string filename)
        {
            if (cache.ContainsKey(filename))
            {
                return cache[filename];
            }
            else
            {
                Project tmpProj = new Project(project.Rules);
                tmpProj.ParserOptions = project.ParserOptions;
                tmpProj.WarriorFiles.Add(filename);
                ParseResult res = parser.Parse(tmpProj, console);
                res.Messages.AddRange(res.Messages);
                IWarrior warrior = tmpProj.Warriors[0];
                cache[filename] = warrior;
                return warrior;
            }
        }
    }
}