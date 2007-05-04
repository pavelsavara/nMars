using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using nMars.Parser.Warrior;
using nMars.RedCode;

namespace nMars.Generator
{
    public class GenCS : GenBase
    {
        public void Generate()
        {
            swm = new StreamWriter(@"N:\nMars\nMars.Fngine\Fngine\Fngine01Instructions.cs");
            swm.WriteLine("using nMars.RedCode;");
            swm.WriteLine("using nMars.Engine;");
            swm.WriteLine("using System;");
            swm.WriteLine("namespace nMars.Fngine.Fngine");
            swm.WriteLine("{");
            swm.WriteLine("    public partial class Fngine");
            swm.WriteLine("    {");
            swm.WriteLine("        public Fn GetGenFunction(int code)");
            swm.WriteLine("        {");
            swm.WriteLine("            switch(code)");
            swm.WriteLine("            {");


            Generator.Generate(ProcessInstruction);
            sw.WriteLine("    }");
            sw.WriteLine("}");
            sw.Close();


            swm.WriteLine("             default: throw new NotImplementedException();");
            swm.WriteLine("            }");
            swm.WriteLine("        }");
            swm.WriteLine("    }");
            swm.WriteLine("}");
            swm.Close();
        }

        private StreamWriter sw = null;
        private StreamWriter swm = null;

        private ExtendedInstruction last =
            new ExtendedInstruction(Operation.STP, Modifier.NULL, Mode.NULL, 0, Mode.NULL, 0);

        public bool ProcessInstruction(ExtendedInstruction instruction)
        {
            if (last.Operation != instruction.Operation)
            {
                if (sw != null)
                {
                    sw.WriteLine("    }");
                    sw.WriteLine("}");
                    sw.Close();
                }

                sw = new StreamWriter(@"N:\nMars\nMars.Fngine\Fngine\Fngine01Instructions" +
                    instruction.Operation + ".cs");
                sw.WriteLine("using nMars.RedCode;");
                sw.WriteLine("using nMars.Engine;");
                sw.WriteLine("namespace nMars.Fngine.Fngine");
                sw.WriteLine("{");
                sw.WriteLine("    public partial class Fngine");
                sw.WriteLine("    {");

            }
            last = instruction;

            swm.WriteLine("             case " + instruction.Code + ": return " + instruction.FunctionName +
                          ";");

            sw.WriteLine("        public void ");
            sw.WriteLine(instruction.FunctionName);
            sw.WriteLine("(int ip, EngineWarrior warrior)");
            sw.WriteLine("        {");

            string sdecl;
            string saddra;
            string saddrb;
            string sexec;
            GetBody(instruction, out sdecl, out saddra, out saddrb, out sexec);

            sw.Write(sdecl);
            sw.Write(saddra);
            sw.Write(saddrb);
            sw.Write(sexec);
            sw.WriteLine("        }");
            return false;
        }
    }

}
