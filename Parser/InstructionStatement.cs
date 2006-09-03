using System.Collections.Generic;
using nMars.RedCode;

namespace nMars.Parser
{
    public class InstructionStatement : Statement
    {
        public InstructionStatement(Operation operation, Modifier modifier, Parameter a, Parameter b)
        {
            Operation = operation;
            Modifier = modifier;
            A = a;
            B = b;
        }

        public List<string> Labels = null;
        public string Comment = "";

        public string OriginalInstruction
        {
            get { return ToString(); }
        }

        public int Address = -1;
        public Operation Operation;
        public Modifier Modifier;
        public Parameter A;
        public Parameter B;

        public override string ToString()
        {
            return
                Operation.ToString() + "." + Modifier.ToString().PadRight(5) + " " + A.ToString().PadRight(15) + "," +
                B.ToString().PadRight(15);
        }
    }
}