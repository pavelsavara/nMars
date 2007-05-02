using System;
using System.Collections.Generic;
using System.Text;
using nMars.Engine;
using nMars.RedCode;
using nMars.RedCode.Modules;

namespace nMars.Fngine.Fngine
{
    public sealed partial class Fngine 
    {
        protected override void InitializeMatch(IProject project)
        {
            base.InitializeMatch(project);
            CoreSize = rules.CoreSize;
            ValuesA = new int[CoreSize];
            ValuesB = new int[CoreSize];
            Operations = new Fn[CoreSize];
        }

        protected override void InitializeRound()
        {
            base.InitializeRound();
            for (int a = 0; a < CoreSize; a++)
            {
                IRunningInstruction instruction = core[a];
                ValuesA[a] = instruction.ValueA;
                ValuesB[a] = instruction.ValueB;
                Operations[a] = GetFunction(instruction.Operation, instruction.Modifier, instruction.ModeA, instruction.ModeB);
            }
        }

        public override IRunningInstruction this[int address]
        {
            get
            {
                int adr = mod(address);
                core[adr].ValueA = ValuesA[adr];
                core[adr].ValueB = ValuesB[adr];
                if (core[adr].Modifier == Modifier.NULL)
                {
                    GetOperation(Operations[adr], out core[adr].Operation, out core[adr].Modifier,
                                           out core[adr].ModeA, out core[adr].ModeB);
                }
                return core[adr];
            }
            set { throw new NotImplementedException(); }
        }

        public override int this[int address, Column column]
        {
            get
            {
                switch (column)
                {
                    case Column.A:
                        return ValuesA[mod(address)];
                    case Column.B:
                        return ValuesB[mod(address)];
                    default:
                        throw new ApplicationException("Unknown register");
                }
            }
            set
            {
                switch (column)
                {
                    case Column.A:
                        ValuesA[mod(address)]=value;
                        break;
                    case Column.B:
                        ValuesB[mod(address)] = value;
                        break;
                    default:
                        throw new ApplicationException("Unknown register");
                }
            }
        }

        new internal int CoreSize;
        internal int[] ValuesA;
        internal int[] ValuesB;
        internal Fn[] Operations;
    }
}
