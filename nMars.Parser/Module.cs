// This file is part of nMars - Core War MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using nMars.RedCode;
using nMars.RedCode.Modules;

namespace nMars.Parser
{
    class Module : BaseModule, IParserModule
    {
        public IParser CreateParser()
        {
            WarriorParser parser = new WarriorParser();
            parser.Module = this;
            return parser;
        }

        #region Module registration

        static Module()
        {
            ModuleRegister.Register(new Module());
        }

        #endregion
    }
}