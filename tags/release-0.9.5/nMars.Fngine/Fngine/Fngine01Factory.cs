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
        public Fn GetFunction(Operation Operation, Modifier Modifier, Mode ModeA, Mode ModeB)
        {
            int code = Instruction.GetCode(Operation, Modifier, ModeA, ModeB);
            if (!cache.ContainsKey(code))
            {
                FnHolder hl = CreateFn(code, Operation, Modifier, ModeA, ModeB);
                cache.Add(hl.Code, hl);
                resolv.Add(hl.Fn, hl);
            }
            return cache[code].Fn;
        }

        public void GetOperation(Fn function, out Operation Operation, out Modifier Modifier, out Mode ModeA, out Mode ModeB)
        {
            FnHolder holder = resolv[function];
            Operation = holder.Operation;
            Modifier = holder.Modifier;
            ModeA = holder.ModeA;
            ModeB = holder.ModeB;
        }

        private FnHolder CreateFn(int code, Operation Operation, Modifier Modifier, Mode ModeA, Mode ModeB)
        {
            FnHolder res = new FnHolder();
            res.Operation = Operation;
            res.Modifier = Modifier;
            res.ModeA = ModeA;
            res.ModeB = ModeB;
            res.Fn = GetGenFunction(code);
            return res;
        }

        static private Dictionary<int, FnHolder> cache = new Dictionary<int, FnHolder>();
        static private Dictionary<Fn, FnHolder> resolv = new Dictionary<Fn, FnHolder>();
        
    }
}
