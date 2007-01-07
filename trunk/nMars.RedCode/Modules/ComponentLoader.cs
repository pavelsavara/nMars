// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.IO;
using System.Xml.Serialization;

namespace nMars.RedCode.Modules
{
    /// <summary>
    /// Basic Components loader
    /// </summary>
    public class ComponentLoader
    {
        #region Public

        /// <summary>
        /// Parser Component
        /// </summary>
        [XmlIgnore]
        public IParser Parser
        {
            get
            {
                if (parser == null)
                    LoadParser();
                return parser;
            }
            set
            {
                parser = value;
            }
        }

        /// <summary>
        /// Engine Component
        /// </summary>
        [XmlIgnore]
        public IEngine Engine
        {
            get
            {
                if (engine == null)
                    LoadEngine();
                return engine;
            }
            set
            {
                engine = value;
            }
        }

        public string ParserName;
        public string EngineName;

        #endregion

        #region Helpers

        private void LoadParser()
        {
            try
            {
                int idx = ParserName.IndexOf('-');
                if (idx!=-1)
                {
                    string assembly = ParserName.Substring(0, idx);
                    parser = ModuleRegister.CreateParser(assembly, ParserName);
                }
                else
                {
                    parser = ModuleRegister.CreateParser(ParserName, ParserName);
                }
            }
            catch (FileNotFoundException)
            {
                //swallow
            }
        }

        private void LoadEngine()
        {
            try
            {
                int idx = EngineName.IndexOf('-');
                if (idx != -1)
                {
                    string assembly = EngineName.Substring(0, idx);
                    engine = ModuleRegister.CreateEngine(assembly, EngineName);
                }
                else
                {
                    engine = ModuleRegister.CreateEngine(EngineName, EngineName);
                }
            }
            catch (FileNotFoundException)
            {
                //swallow
            }
        }

        #endregion

        #region Variables

        private IParser parser;
        private IEngine engine;

        #endregion
    }
}