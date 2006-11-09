// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Runtime.InteropServices;

namespace nMars.RedCode
{
    [ComVisible(true)]
    public enum Operation
    {
        /// <summary>
        /// Move replaces the B-target with the A-value and queues the next
        /// instruction (PC + 1).
        /// </summary>
        MOV = 0,

        /// <summary>
        /// ADD replaces the B-target with the sum of the A-value and the B-value
        /// (A-value + B-value) and queues the next instruction (PC + 1).  ADD.I
        /// functions as ADD.F would.
        /// </summary>
        ADD = 1,

        /// <summary>
        /// SUB replaces the B-target with the difference of the B-value and the
        /// A-value (B-value - A-value) and queues the next instruction (PC + 1).
        /// SUB.I functions as SUB.F would.
        /// </summary>
        SUB = 2,

        /// <summary>
        /// MUL replaces the B-target with the product of the A-value and the
        /// B-value (A-value * B-value) and queues the next instruction (PC + 1).
        /// MUL.I functions as MUL.F would.
        /// </summary>
        MUL = 3,

        /// <summary>
        /// DIV replaces the B-target with the integral result of dividing the
        /// B-value by the A-value (B-value / A-value) and queues the next
        /// instruction (PC + 1).  DIV.I functions as DIV.F would. If the
        /// A-value is zero, the B-value is unchanged and the current task is
        /// removed from the warrior's task queue.
        /// </summary>
        DIV = 4,

        /// <summary>
        /// MOD replaces the B-target with the integral remainder of dividing the
        /// B-value by the A-value (B-value % A-value) and queues the next
        /// instruction (PC + 1).  MOD.I functions as MOD.F would. If the
        /// A-value is zero, the B-value is unchanged and the current task is
        /// removed from the warrior's task queue.
        /// </summary>
        MOD = 5,

        /// <summary>
        /// JMZ tests the B-value to determine if it is zero.  If the B-value is
        /// zero, the sum of the program counter and the A-pointer is queued.
        /// Otherwise, the next instruction is queued (PC + 1).  JMZ.I functions
        /// as JMZ.F would, i.e. it jumps if both the A-number and the B-number
        /// of the B-instruction are zero.
        /// </summary>
        JMZ = 6,

        /// <summary>
        /// JMN tests the B-value to determine if it is zero.  If the B-value is
        /// not zero, the sum of the program counter and the A-pointer is queued.
        /// Otherwise, the next instruction is queued (PC + 1).  JMN.I functions
        /// as JMN.F would, i.e. it jumps if both the A-number and the B-number
        /// of the B-instruction are non-zero. This is not the negation of the
        /// condition for JMZ.F.
        /// </summary>
        JMN = 7,

        /// <summary>
        /// DJN decrements the B-value and the B-target, then tests the B-value
        /// to determine if it is zero.  If the decremented B-value is not zero,
        /// the sum of the program counter and the A-pointer is queued.
        /// Otherwise, the next instruction is queued (PC + 1).  DJN.I functions
        /// as DJN.F would, i.e. it decrements both both A/B-numbers of the B-value
        /// and the B-target, and jumps if both A/B-numbers of the B-value are
        /// non-zero.
        /// </summary>
        DJN = 8,

        /// <summary>
        /// SEQ compares the A-value to the B-value.  If the result of the
        /// comparison is equal, the instruction after the next instruction
        /// (PC + 2) is queued (skipping the next instruction).  Otherwise, the
        /// the next instruction is queued (PC + 1).
        /// </summary>
        /// <remarks>Same as SEQ</remarks>
        CMP = 9,

        /// <summary>
        /// SLT compares the A-value to the B-value.  If the A-value is less than
        /// the B-value, the instruction after the next instruction (PC + 2) is
        /// queued (skipping the next instruction).  Otherwise, the next
        /// instruction is queued (PC + 1).  SLT.I functions as SLT.F would.
        /// </summary>
        SLT = 10,

        /// <summary>
        /// SPL queues the next instruction (PC + 1) and then queues the sum of
        /// the program counter and A-pointer. If the queue is full, only the
        /// next instruction is queued.
        /// </summary>
        SPL = 11,

        /// <summary>
        /// No additional processing takes place.  This effectively removes the
        /// current task from the current warrior's task queue.
        /// </summary>
        DAT = 12,

        /// <summary>
        /// JMP queues the sum of the program counter and the A-pointer.
        /// </summary>
        JMP = 13,

        /// <summary>
        /// skip if equal (compares two instructions, and skips the next instruction if they are equal)
        /// </summary>
        //SEQ = 14,
        /// <summary>
        /// skip if not equal (compares two instructions, and skips the next instruction if they aren't equal)
        /// </summary>
        SNE = 15,

        /// <summary>
        /// No operation (does nothing)
        /// </summary>
        NOP = 16,

        /// <summary>
        /// load from p-space (loads a number from private storage space)
        /// </summary>
        LDP = 17,

        /// <summary>
        /// save to p-space (saves a number to private storage space)
        /// </summary>
        STP = 18,
    }

    public class OperationHelper
    {
        public static Operation Convert(int i)
        {
            if (i == 14) return Operation.CMP;
            return (Operation)i;
        }

        public static Operation Parse(string s)
        {
            switch (s.ToUpper())
            {
                case "DAT":
                    return Operation.DAT;
                case "SPL":
                    return Operation.SPL;
                case "MOV":
                    return Operation.MOV;
                case "DJN":
                    return Operation.DJN;
                case "ADD":
                    return Operation.ADD;
                case "JMZ":
                    return Operation.JMZ;
                case "SUB":
                    return Operation.SUB;
                case "SEQ":
                case "CMP":
                    return Operation.CMP;
                case "SNE":
                    return Operation.SNE;
                case "SLT":
                    return Operation.SLT;
                case "JMN":
                    return Operation.JMN;
                case "JMP":
                    return Operation.JMP;
                case "NOP":
                    return Operation.NOP;
                case "MUL":
                    return Operation.MUL;
                case "MOD":
                    return Operation.MOD;
                case "DIV":
                    return Operation.DIV;
                case "LDP":
                    return Operation.LDP;
                case "STP":
                    return Operation.STP;
                default:
                    throw new ArgumentException();
            }
        }
    }

    /*
            switch (instruction.Operation)
            {
                case Operation.DAT:
                case Operation.SPL:
                case Operation.MOV:
                case Operation.DJN:
                case Operation.ADD:
                case Operation.JMZ:
                case Operation.SUB:
                case Operation.SEQ:
                case Operation.SNE:
                case Operation.SLT:
                case Operation.JMN:
                case Operation.JMP:
                case Operation.NOP:
                case Operation.MUL:
                case Operation.MOD:
                case Operation.DIV:
                case Operation.LDP:
                case Operation.STP:
                default:
                    throw new InvalidOperationException("Unknown instruction");
            }
     
     */
}