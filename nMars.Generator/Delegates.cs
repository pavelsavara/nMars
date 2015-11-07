using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using Microsoft.CSharp;
using nMars.Parser.Warrior;
using System.Runtime.CompilerServices;

namespace nMars.Generator
{
    public class FastEngine
    {
    }


    public class DelegatesGenerator
    {
        public void Generate()
        {
            Generator.Generate(ProcessInstruction);
        }

        public bool ProcessInstruction(ExtendedInstruction test)
        {

            string name = "Perform" + test.Operation + test.Modifier + test.ModeA + test.ModeB;

            /*
            DynamicMethod dm = new DynamicMethod(name, typeof(void), new Type[] {}, typeof(FastEngine));
            ILGenerator generator = dm.GetILGenerator();
            DynamicILInfo info = dm.GetDynamicILInfo();
            info.GetTokenFor("")
             */

            //new CSharpCodeProvider().CompileAssemblyFromSource();

            return false;
        }
    }
}
