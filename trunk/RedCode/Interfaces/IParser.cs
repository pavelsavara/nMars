using System;
using System.IO;
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