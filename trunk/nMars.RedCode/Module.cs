// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using nMars.RedCode;
using nMars.RedCode.Modules;

namespace nMars.RedCode
{
    class Module : BaseModule, IParserWrapperModule
    {
        #region Module registration

        static Module()
        {
            ModuleRegister.Register(new Module());
            ModuleRegister.Register(new ASyncModule());
        }

        #endregion

        public override string Name
        {
            get { return typeof(Module).Namespace + "-Caching"; }
        }

        public IParser CreateParser(IParser parser)
        {
            return new CachingParser(parser);
        }
    }

    class ASyncModule : BaseModule, IEngineWrapperModule
    {
        public IEngine CreateEngine(IEngine engine)
        {
            IDebuggerEngine en = engine as IDebuggerEngine;
            if (en == null)
                throw new ArgumentException(
                    "Argument should implement IDebuggerEngine interface for usage with EngineASync");
            return new AsyncEngine(en);
        }

        public override string Name
        {
            get { return typeof(Module).Namespace + "-ASync"; }
        }
    }


}