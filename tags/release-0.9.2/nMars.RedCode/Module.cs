// This file is part of nMars - Core War MARS for .NET 
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
            ModuleRegister.Register(new AsyncModule());
        }

        #endregion

        public override string Name
        {
            get { return typeof(Module).Namespace + "-Caching"; }
        }

        public IParser CreateParser(IParser parser)
        {
            CachingParser p = new CachingParser(parser);
            p.Module = this;
            return p;
        }
    }

    class AsyncModule : BaseModule, IEngineWrapperModule
    {
        public IEngine CreateEngine(IEngine engine)
        {
            IDebuggerEngine en = engine as IDebuggerEngine;
            if (en == null)
                throw new ArgumentException(
                    "Argument should implement IDebuggerEngine interface for usage with EngineASync");
            AsyncEngine e = new AsyncEngine(en);
            e.Module = this;
            return e;
        }

        public override string Name
        {
            get { return typeof(Module).Namespace + "-ASync"; }
        }
    }


}