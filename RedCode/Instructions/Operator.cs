namespace nMars.RedCode
{
    public enum Operation
    {
        /// <summary>
        /// No additional processing takes place.  This effectively removes the
        /// current task from the current warrior's task queue.
        /// </summary>
        DAT,

        /// <summary>
        /// SPL queues the next instruction (PC + 1) and then queues the sum of
        /// the program counter and A-pointer. If the queue is full, only the
        /// next instruction is queued.
        /// </summary>
        SPL,

        /// <summary>
        /// Move replaces the B-target with the A-value and queues the next
        /// instruction (PC + 1).
        /// </summary>
        MOV,

        /// <summary>
        /// DJN decrements the B-value and the B-target, then tests the B-value
        /// to determine if it is zero.  If the decremented B-value is not zero,
        /// the sum of the program counter and the A-pointer is queued.
        /// Otherwise, the next instruction is queued (PC + 1).  DJN.I functions
        /// as DJN.F would, i.e. it decrements both both A/B-numbers of the B-value
        /// and the B-target, and jumps if both A/B-numbers of the B-value are
        /// non-zero.
        /// </summary>
        DJN,

        /// <summary>
        /// ADD replaces the B-target with the sum of the A-value and the B-value
        /// (A-value + B-value) and queues the next instruction (PC + 1).  ADD.I
        /// functions as ADD.F would.
        /// </summary>
        ADD,

        /// <summary>
        /// JMZ tests the B-value to determine if it is zero.  If the B-value is
        /// zero, the sum of the program counter and the A-pointer is queued.
        /// Otherwise, the next instruction is queued (PC + 1).  JMZ.I functions
        /// as JMZ.F would, i.e. it jumps if both the A-number and the B-number
        /// of the B-instruction are zero.
        /// </summary>
        JMZ,

        /// <summary>
        /// SUB replaces the B-target with the difference of the B-value and the
        /// A-value (B-value - A-value) and queues the next instruction (PC + 1).
        /// SUB.I functions as SUB.F would.
        /// </summary>
        SUB,

        /// <summary>
        /// SEQ compares the A-value to the B-value.  If the result of the
        /// comparison is equal, the instruction after the next instruction
        /// (PC + 2) is queued (skipping the next instruction).  Otherwise, the
        /// the next instruction is queued (PC + 1).
        /// </summary>
        /// <remarks>Same as SEQ</remarks>
        SEQ,

        /// <summary>
        /// skip if not equal (compares two instructions, and skips the next instruction if they aren't equal)
        /// </summary>
        SNE,

        /// <summary>
        /// SLT compares the A-value to the B-value.  If the A-value is less than
        /// the B-value, the instruction after the next instruction (PC + 2) is
        /// queued (skipping the next instruction).  Otherwise, the next
        /// instruction is queued (PC + 1).  SLT.I functions as SLT.F would.
        /// </summary>
        SLT,

        /// <summary>
        /// JMN tests the B-value to determine if it is zero.  If the B-value is
        /// not zero, the sum of the program counter and the A-pointer is queued.
        /// Otherwise, the next instruction is queued (PC + 1).  JMN.I functions
        /// as JMN.F would, i.e. it jumps if both the A-number and the B-number
        /// of the B-instruction are non-zero. This is not the negation of the
        /// condition for JMZ.F.
        /// </summary>
        JMN,

        /// <summary>
        /// JMP queues the sum of the program counter and the A-pointer.
        /// </summary>
        JMP,

        /// <summary>
        /// No operation (does nothing)
        /// </summary>
        NOP,

        /// <summary>
        /// MUL replaces the B-target with the product of the A-value and the
        /// B-value (A-value * B-value) and queues the next instruction (PC + 1).
        /// MUL.I functions as MUL.F would.
        /// </summary>
        MUL,

        /// <summary>
        /// MOD replaces the B-target with the integral remainder of dividing the
        /// B-value by the A-value (B-value % A-value) and queues the next
        /// instruction (PC + 1).  MOD.I functions as MOD.F would. If the
        /// A-value is zero, the B-value is unchanged and the current task is
        /// removed from the warrior's task queue.
        /// </summary>
        MOD,

        /// <summary>
        /// DIV replaces the B-target with the integral result of dividing the
        /// B-value by the A-value (B-value / A-value) and queues the next
        /// instruction (PC + 1).  DIV.I functions as DIV.F would. If the
        /// A-value is zero, the B-value is unchanged and the current task is
        /// removed from the warrior's task queue.
        /// </summary>
        DIV,

        /// <summary>
        /// load from p-space (loads a number from private storage space)
        /// </summary>
        LDP,

        /// <summary>
        /// save to p-space (saves a number to private storage space)
        /// </summary>
        STP
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