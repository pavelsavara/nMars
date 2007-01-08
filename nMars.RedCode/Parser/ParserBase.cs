// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.IO;

namespace nMars.RedCode
{
    /// <summary>
    /// Abstract base for parsers
    /// </summary>
    public abstract class ParserBase : IParser
    {
        /// <summary>
        /// Parse warrior files in project parameter considering parser options and rules
        /// </summary>
        /// <param name="aProject">files, rules, options</param>
        /// <param name="aConsole">output console, could be null</param>
        /// <returns>list of errors</returns>
        public virtual ParseResult Parse(IProject aProject, ISimpleOutput aConsole)
        {
            project = aProject;
            result = new ParseResult();
            console = aConsole;
            project.Warriors.Clear();
            int succ = 0;
            foreach (string file in project.WarriorFiles)
            {
                if (project.ParserOptions.StatusLine && console != null)
                {
                    console.WriteLine("========== Parsing " + file + "==========");
                }
                IWarrior warrior = Parse(file);
                project.Warriors.Add(warrior);
                if (warrior != null)
                {
                    succ++;
                    if (project.ParserOptions.DumpFiles)
                    {
                        StreamWriter sw = new StreamWriter(Path.ChangeExtension(file, project.ParserOptions.DumpExt));
                        warrior.Dump(new WrappedTextWriter(sw), project.ParserOptions);
                        sw.Close();
                    }
                    else if (!project.ParserOptions.Brief && console != null)
                        warrior.Dump(console, project.ParserOptions);
                }
                else
                {
                    result.Succesfull = false;
                }
            }
            if (project.ParserOptions.StatusLine && console!=null)
            {
                console.WriteLine("========== Compiled " + project.WarriorFiles.Count + " warriors, " +
                                 (project.WarriorFiles.Count - succ) + " failed ==========");
            }
            return result;
        }

        /// <summary>
        /// Override this method
        /// </summary>
        protected abstract IWarrior Parse(string aFileName);

        #region Variables

        protected ISimpleOutput console;
        protected IProject project;
        protected ParseResult result;

        #endregion
    }
}