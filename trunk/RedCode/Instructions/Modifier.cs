namespace nMars.RedCode
{
    public enum Modifier
    {
        /// <summary>
        /// Instruction execution proceeds with the A-value set to both the
        /// A-number and B-number of the A-instruction (in that order) and the
        /// B-value set to both the A-number and B-number of the B-instruction
        /// (also in that order).  A write to core replaces both the A-number and
        /// the B-number of the instruction pointed to by the B-pointer (in that
        /// order).
        /// </summary>
        /// <example>
        /// For example, a SEQ.F instruction would compare the A-number of the
        /// A-instruction to the A-number of the B-instruction and the B-number of
        /// the A-instruction to B-number of the B-instruction.  A MOV.F instruction
        /// would replace the A-number of the instruction pointed to by the
        /// B-pointer with the A-number of the A-instruction and would also replace
        /// the B-number of the instruction pointed to by the B-pointer with the
        /// B-number of the A-instruction.
        /// </example>
        F,

        /// <summary>
        /// Instruction execution proceeds with the A-value set to the A-number of
        /// the A-instruction and the B-value set to the A-number of the
        /// B-instruction.  A write to core replaces the A-number of the
        /// instruction pointed to by the B-pointer.
        /// </summary>
        /// <example>
        ///  For example, a SEQ.A instruction would compare the A-number of the
        /// A-instruction with the A-number of the B-instruction.  A MOV.A
        /// instruction would replace the A-number of the instruction pointed to
        /// by the B-pointer with the A-number of the A-instruction.
        /// </example>
        A,

        /// <summary>
        /// Instruction execution proceeds with the A-value set to the B-number of
        /// the A-instruction and the B-value set to the B-number of the
        /// B-instruction.  A write to core replaces the B-number of the
        /// instruction pointed to by the B-pointer.
        /// </summary>
        /// <example>
        ///  For example, a SEQ.B instruction would compare the B-number of the
        /// A-instruction with the B-number of the B-instruction.  A MOV.B
        /// instruction would replace the B-number of the instruction pointed to
        /// by the B-pointer with the B-number of the A-instruction.
        /// </example>
        B,

        /// <summary>
        ///  Instruction execution proceeds with the A-value set to the A-number of
        /// the A-instruction and the B-value set to the B-number of the
        /// B-instruction.  A write to core replaces the B-number of the
        /// instruction pointed to by the B-pointer.
        /// </summary>
        /// <example>
        /// For example, a SEQ.AB instruction would compare the A-number of the
        /// A-instruction with the B-number of the B-instruction.  A MOV.AB
        /// instruction would replace the B-number of the instruction pointed to
        /// by the B-pointer with the A-number of the A-instruction.
        /// </example>
        AB,

        /// <summary>
        /// Instruction execution proceeds with the A-value set to the B-number of
        /// the A-instruction and the B-value set to the A-number of the
        /// B-instruction.  A write to core replaces the A-number of the
        /// instruction pointed to by the B-pointer.
        /// </summary>
        /// <example>
        /// For example, a SEQ.BA instruction would compare the B-number of the
        /// A-instruction with the A-number of the B-instruction.  A MOV.BA
        /// instruction would replace the A-number of the instruction pointed to
        /// by the B-pointer with the B-number of the A-instruction.
        /// </example>
        BA,

        /// <summary>
        /// Instruction execution proceeds with the A-value set to both the
        /// A-number and B-number of the A-instruction (in that order) and the
        /// B-value set to both the B-number and A-number of the B-instruction
        /// (in that order).  A write to to core replaces both the B-number and
        /// the A-number of the instruction pointed to by the B-pointer (in that
        /// order).
        /// </summary>
        /// <example>
        /// For example, a SEQ.X instruction would compare the A-number of the
        /// A-instruction to the B-number of the B-instruction and the B-number of the
        /// A-instruction to A-number of the B-instruction.  A MOV.X instruction would
        /// replace the B-number of the instruction pointed to by the B-pointer with the
        /// A-number of the A-instruction and would also replace the A-number of the
        /// instruction pointed to by the B-pointer with the B-number of the
        /// A-instruction.
        /// </example>
        X,

        /// <summary>
        /// Instruction execution proceeds with the A-value set to the
        /// A-instruction and the B-value set to the B-instruction.  A write to
        /// core replaces the entire instruction pointed to by the B-pointer.
        /// </summary>
        /// <example>
        /// For example, a SEQ.I instruction would compare the A-instruction to
        ///  the B-instruction.  A MOV.I instruction would replace the instruction
        /// pointed to by the B-pointer with the A-instruction.
        /// </example>
        I
    }

    /*
                    switch (instruction.Modifier)
                    {
                        case Modifier.A:
                        case Modifier.F:
                        case Modifier.B:
                        case Modifier.AB:
                        case Modifier.X:
                        case Modifier.BA:
                        case Modifier.I:
                    }
                    ip++;
                    break;
     */
}