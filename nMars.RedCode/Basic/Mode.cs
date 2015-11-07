// This file is part of nMars - Core War MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Runtime.InteropServices;

namespace nMars.RedCode
{
    [ComVisible(true)]
    public enum Mode
    {
        /// <summary>
        /// #
        /// An immediate mode operand merely serves as storage for data.  
        /// An immediate A/B-mode in the current instruction sets the A/B-pointer to zero.
        /// </summary>
        Immediate,

        /// <summary>
        /// $
        /// A direct mode operand indicates the offset from the program counter.
        /// A direct A/B-mode in the current instruction means the A/B-pointer is
        /// a copy of the offset, the A/B-number of the current instruction.
        /// </summary>
        Direct,

        /// <summary>
        /// @
        /// An indirect mode operand indicates the primary offset (relative to the 
        /// program counter) to the secondary offset (relative to the location 
        /// of the instruction in which the secondary offset is contained).  
        /// An indirect A/B-mode indicates that the A/B-pointer is the sum of the 
        /// A/B-number of the current instruction (the primary offset) and the 
        /// B-number of the instruction pointed to by the A/B-number of the 
        /// current instruction (the secondary offset).
        /// </summary>
        IndirectB,

        /// <summary>
        /// &lt;
        /// A predecrement indirect mode operand indicates the primary offset 
        /// (relative to the program counter) to the secondary offset (relative to
        /// the location of the instruction in which the secondary offset is
        /// contained) which is decremented prior to use.  A predecrement
        /// indirect A/B-mode indicates that the A/B-pointer is the sum of the
        /// A/B-number of the current instruction (the primary offset) and the
        /// decremented B-number of the instruction pointed to by the A/B-number
        /// of the current instruction (the secondary offset).
        /// </summary>
        PreDecIndirectB,

        /// <summary>
        /// &gt;
        /// A postincrement indirect mode operand indicates the primary offset
        /// (relative to the program counter) to the secondary offset (relative to
        /// the location of the instruction in which the secondary offset is
        /// contained) which is incremented after the results of the operand
        /// evaluation are stored.  A postincrement indirect A/B-mode indicates that
        /// the A/B-pointer is the sum of the A/B-number of the current instruction
        /// (the primary offset) and the B-number of the instruction pointed to by
        /// the A/B-number of the current instruction (the secondary offset).  The
        /// B-number of the instruction pointed to by the A/B-number of the current
        /// instruction is incremented after the A/B-instruction is stored, but
        /// before the B-operand is evaluated (for post-increment A-mode), or
        /// the operation is executed (for post-increment indirect B-mode).
        /// </summary>
        PostIncIndirectB,

        /// <summary>
        /// *
        /// An indirect mode operand indicates the primary offset (relative to the 
        /// program counter) to the secondary offset (relative to the location 
        /// of the instruction in which the secondary offset is contained).  
        /// An indirect A/B-mode indicates that the A/B-pointer is the sum of the 
        /// A/B-number of the current instruction (the primary offset) and the 
        /// B-number of the instruction pointed to by the A/B-number of the 
        /// current instruction (the secondary offset).
        /// </summary>
        IndirectA,

        /// <summary>
        /// {
        /// A predecrement indirect mode operand indicates the primary offset 
        /// (relative to the program counter) to the secondary offset (relative to
        /// the location of the instruction in which the secondary offset is
        /// contained) which is decremented prior to use.  A predecrement
        /// indirect A/B-mode indicates that the A/B-pointer is the sum of the
        /// A/B-number of the current instruction (the primary offset) and the
        /// decremented B-number of the instruction pointed to by the A/B-number
        /// of the current instruction (the secondary offset).
        /// </summary>
        PreDecIndirectA,

        /// <summary>
        /// }
        /// A postincrement indirect mode operand indicates the primary offset
        /// (relative to the program counter) to the secondary offset (relative to
        /// the location of the instruction in which the secondary offset is
        /// contained) which is incremented after the results of the operand
        /// evaluation are stored.  A postincrement indirect A/B-mode indicates that
        /// the A/B-pointer is the sum of the A/B-number of the current instruction
        /// (the primary offset) and the B-number of the instruction pointed to by
        /// the A/B-number of the current instruction (the secondary offset).  The
        /// B-number of the instruction pointed to by the A/B-number of the current
        /// instruction is incremented after the A/B-instruction is stored, but
        /// before the B-operand is evaluated (for post-increment A-mode), or
        /// the operation is executed (for post-increment indirect B-mode).
        /// </summary>
        PostIncIndirectA,

        /// <summary>
        /// Not defined, unknown
        /// </summary>
        NULL,
    }

    public class ModeHelper
    {
        public static bool IsIndirA(Mode mode)
        {
            switch (mode)
            {
                case Mode.IndirectA:
                case Mode.PostIncIndirectA:
                case Mode.PreDecIndirectA:
                    return true;
                case Mode.Direct:
                case Mode.Immediate:
                case Mode.IndirectB:
                case Mode.PostIncIndirectB:
                case Mode.PreDecIndirectB:
                    return false;
            }
            throw new ArgumentException();
        }

        public static bool IsPreDec(Mode mode)
        {
            switch (mode)
            {
                case Mode.PreDecIndirectA:
                case Mode.PreDecIndirectB:
                    return true;
                case Mode.IndirectA:
                case Mode.PostIncIndirectA:
                case Mode.Direct:
                case Mode.Immediate:
                case Mode.IndirectB:
                case Mode.PostIncIndirectB:
                    return false;
            }
            throw new ArgumentException();
        }

        public const int ModeCount = 8;

        public static bool IsPostInc(Mode mode)
        {
            switch (mode)
            {
                case Mode.PostIncIndirectB:
                case Mode.PostIncIndirectA:
                    return true;
                case Mode.PreDecIndirectA:
                case Mode.PreDecIndirectB:
                case Mode.IndirectA:
                case Mode.Direct:
                case Mode.Immediate:
                case Mode.IndirectB:
                    return false;
            }
            throw new ArgumentException();
        }

        public static Mode Parse(string s)
        {
            switch (s)
            {
                case "$":
                    return Mode.Direct;
                case "#":
                    return Mode.Immediate;
                case "*":
                    return Mode.IndirectA;
                case "@":
                    return Mode.IndirectB;
                case "}":
                    return Mode.PostIncIndirectA;
                case ">":
                    return Mode.PostIncIndirectB;
                case "{":
                    return Mode.PreDecIndirectA;
                case "<":
                    return Mode.PreDecIndirectB;
                default:
                    throw new ArgumentException();
            }
        }

        public static string ToString(Mode mode)
        {
            switch (mode)
            {
                case Mode.Direct:
                    return "$";
                case Mode.Immediate:
                    return "#";
                case Mode.IndirectA:
                    return "*";
                case Mode.IndirectB:
                    return "@";
                case Mode.PostIncIndirectA:
                    return "}";
                case Mode.PostIncIndirectB:
                    return ">";
                case Mode.PreDecIndirectA:
                    return "{";
                case Mode.PreDecIndirectB:
                    return "<";
                case Mode.NULL:
                    return "";
                default:
                    throw new ArgumentException();
            }
        }

        public static string ToAbrev(Mode mode)
        {
            switch (mode)
            {
                case Mode.Direct:
                    return "Di";
                case Mode.Immediate:
                    return "Im";
                case Mode.IndirectA:
                    return "Ai";
                case Mode.IndirectB:
                    return "Bi";
                case Mode.PostIncIndirectA:
                    return "Ap";
                case Mode.PostIncIndirectB:
                    return "Bp";
                case Mode.PreDecIndirectA:
                    return "Am";
                case Mode.PreDecIndirectB:
                    return "Bm";
                case Mode.NULL:
                    return "";
                default:
                    throw new ArgumentException();
            }
        }
    
    }
}