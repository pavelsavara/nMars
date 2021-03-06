// This file is part of nMars - Core War MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using nMars.RedCode;
using nMars.RedCode.Modules;

namespace pMars.DllWrapper
{
    class Module : BaseModule, IParserModule, IEngineModule
    {
        public IParser CreateParser()
        {
            pMarsDllParser parser = new pMarsDllParser();
            parser.Module = this;
            return parser;
        }

        public IEngine CreateEngine()
        {
            pMarsDllEngine engine = new pMarsDllEngine();
            engine.Module = this;
            return engine;
        }

        #region Module registration

        static Module()
        {
            ModuleRegister.Register(new Module());
        }

        #endregion
    }
}