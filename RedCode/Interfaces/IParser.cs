// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using nMars.RedCode.Modules;

namespace nMars.RedCode
{
    public class ParserExceptionBase : Exception
    {
        public ParserExceptionBase(string message)
            : base(message)
        {
        }
    }

    public interface IParser
    {
        IWarrior Parse(string fileName);
    }

    public abstract class ParserRoot : IParser
    {
        public abstract IWarrior Parse(string fileName);
        protected Rules rules;
    }

    public interface IParserModule : IModule
    {
        IParser CreateParser(Rules rules);
    }
}