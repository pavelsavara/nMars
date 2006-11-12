// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace nMars.RedCode
{
    [ComVisible(true)]
    public class DumpOptions
    {
        public DumpOptions()
        {
        }

        public DumpOptions(bool offset, bool labels, bool comments)
        {
            Offset = offset;
            Labels = labels;
            Comments = comments;
        }

        public bool Offset = false;
        public bool Labels = false;
        public bool Comments = false;

        public bool IsDefault()
        {
            return !Offset && !Labels && !Comments;
        }

        public static readonly DumpOptions Default = new DumpOptions();
        public static readonly DumpOptions Full = new DumpOptions(true, true, true);
        public static readonly DumpOptions NoOffset = new DumpOptions(false, true, true);
    }

    [ComVisible(true)]
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
        /// Dump
        /// </summary>
        void Dump(TextWriter tw);

        /// <summary>
        /// Dump with extended options
        /// </summary>
        void Dump(TextWriter tw, DumpOptions options);

        /// <summary>
        /// Dump with extended options
        /// </summary>
        void Dump(string fileName, DumpOptions options);
    }

    [ComVisible(true)]
    public interface IRunningWarrior : IWarrior
    {
        IInstruction NextInstruction { get; }
        int NextInstructionIndex { get; }
        IInstruction PreviousInstruction { get; }
        int PreviousInstructionIndex { get; }
        int LiveTasksCount { get; }
        IList<int> Tasks { get; }
        PSpace PSpace { get; }
        int LastResult { get; }
        int PSpaceIndex{ get; }
    }

}