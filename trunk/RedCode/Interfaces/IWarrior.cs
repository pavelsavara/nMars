using System.IO;

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
        Instruction this[int offset] { get; }

        /// <summary>
        /// Dump
        /// </summary>
        /// <param name="sw"></param>
        void Dump(StreamWriter sw);
    }
}