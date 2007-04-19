// This file is part of nMars - Core War MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.Collections.Generic;

namespace nMars.RedCode
{
    public interface IWarrior
    {
        /// <summary>
        /// Index of instruction, which should be first excecuted
        /// </summary>
        int StartOffset { get; }

        /// <summary>
        /// Length
        /// </summary>
        int Length { get; }

        /// <summary>
        /// Warrior Name
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Warrior Name
        /// </summary>
        string Author { get; }

        /// <summary>
        /// Date created
        /// </summary>
        string Date { get; }

        /// <summary>
        /// pMars version
        /// </summary>
        string Version { get; }

        /// <summary>
        /// Loaded from file
        /// </summary>
        string FileName { get; }

        /// <summary>
        /// PIN - P-Space identification number
        /// (-1 is private)
        /// </summary>
        int Pin { get; }

        /// <summary>
        /// Compiled with rules
        /// </summary>
        Rules Rules { get; }

        /// <summary>
        /// List of Instructions
        /// </summary>
        IInstruction this[int offset] { get; }

        /// <summary>
        /// List of Instructions
        /// </summary>
        IList<IInstruction> Instructions { get; }

        /// <summary>
        /// Dump
        /// </summary>
        void Add(IInstruction instruction);

        /// <summary>
        /// Dump
        /// </summary>
        void Dump(ISimpleOutput output);

        /// <summary>
        /// Dump with extended options
        /// </summary>
        void Dump(ISimpleOutput output, ParserOptions options);

        /// <summary>
        /// Dump with extended options
        /// </summary>
        void Dump(string fileName, ParserOptions options);
        
        /// <summary>
        /// Wrap instruction values
        /// </summary>
        void Wrap();
    }
}