using System;
using System.Collections.Generic;
using System.Text;

namespace nMars.Parser.Expressions
{
    public class Variables
    {
        public bool ContainsKey(string name)
        {
            if (name.Length == 1)
                name = name.ToLower(); //registers
            return var.ContainsKey(name);
        }

        public Expression this[string name]
        {
            get
            {
                if (name.Length == 1)
                    name = name.ToLower(); //registers
                return var[name];
            }
            set
            {
                if (name.Length == 1)
                    name = name.ToLower(); //registers
                var[name] = value;
            }
        }
        private Dictionary<string, Expression> var=new Dictionary<string, Expression>();
    }
}
