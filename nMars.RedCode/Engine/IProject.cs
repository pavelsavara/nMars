// This file is part of nMars - Core War MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.Collections.Generic;

namespace nMars.RedCode
{
    /// <summary>
    /// Setup of rules, 
    /// options for parser and engine,
    /// list of warrior filenames and compiled warriors
    /// </summary>
    public interface IProject
    {
        /// <summary>
        /// Rules
        /// </summary>
        Rules Rules { get; }

        /// <summary>
        /// List of compiled warriors, empty before compilation, failed warriors has null item
        /// </summary>
        IList<IWarrior> Warriors { get; }

        /// <summary>
        /// List of filenames
        /// </summary>
        IList<string> WarriorFiles { get; }

        /// <summary>
        /// Options for engine
        /// </summary>
        EngineOptions EngineOptions { get; set; }

        /// <summary>
        /// Options for parser
        /// </summary>
        ParserOptions ParserOptions { get; set; }

        /// <summary>
        /// Breakpoints
        /// </summary>
        BreakPoints BreakPoints { get; }

        /// <summary>
        /// Save/serialize project to file
        /// </summary>
        /// <param name="filename">filename should have extension .nmproj</param>
        void SaveXml(string filename);
    }
}