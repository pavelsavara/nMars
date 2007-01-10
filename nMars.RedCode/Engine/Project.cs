// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace nMars.RedCode
{
    /// <summary>
    /// Default implementation of IProject interface, 
    /// setup of rules, 
    /// options for parser and engine,
    /// list of warrior filenames and compiled warriors
    /// </summary>
    [Serializable]
    public class Project : IProject
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Project()
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public Project(Rules rules)
        {
            Rules = rules;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public Project(Rules rules, string file)
        {
            Rules = rules;
            WarriorFiles.Add(file);
        }

        #region Interface

        Rules IProject.Rules
        {
            get { return Rules; }
        }

        EngineOptions IProject.EngineOptions
        {
            get { return EngineOptions; }
            set { EngineOptions = value; }
        }

        ParserOptions IProject.ParserOptions
        {
            get { return ParserOptions; }
            set { ParserOptions = value; }
        }

        IList<IWarrior> IProject.Warriors
        {
            get { return Warriors; }
        }

        IList<string> IProject.WarriorFiles
        {
            get { return WarriorFiles; }
        }

        #endregion

        #region Persistence

        /// <summary>
        /// Shared XML serializer
        /// </summary>
        public static XmlSerializer Serializer
        {
            get
            {
                if (serializerCached == null)
                {
                    serializerCached = new XmlSerializer(typeof(Project));
                }
                return serializerCached;
            }
        }

        /// <summary>
        /// Save/serialize project to file
        /// </summary>
        /// <param name="filename">filename should have extension .nmproj</param>
        public void SaveXml(string filename)
        {
            StreamWriter sw = new StreamWriter(filename);
            try
            {
                Serializer.Serialize(sw, this);
            }
            finally
            {
                sw.Close();
            }
        }

        /// <summary>
        /// Load/deserialize project from file
        /// </summary>
        /// <param name="filename">filename should have extension .nmproj</param>
        public static Project LoadXml(string filename)
        {
            StreamReader sr = new StreamReader(filename);
            try
            {
                Project proj = Serializer.Deserialize(sr) as Project;
                return proj;
            }
            finally
            {
                sr.Close();
            }
        }

        /// <summary>
        /// Import pmars compatible project
        /// </summary>
        /// <param name="filename">recomended extension is .pmproj</param>
        /// <returns></returns>
        public static Project ImportPmars(string filename)
        {
            return CommandLine.ParseArguments(File.ReadAllText(filename));
        }

        #endregion

        #region Variables

        [XmlIgnore]
        public IList<IWarrior> Warriors = new List<IWarrior>();

        public List<string> WarriorFiles = new List<string>();
        public List<string> InactiveWarriorFiles = new List<string>();
        public Rules Rules = Rules.DefaultRules;
        public EngineOptions EngineOptions = EngineOptions.Default;
        public ParserOptions ParserOptions = ParserOptions.Default;
        
        private static XmlSerializer serializerCached;

        #endregion
    }
}