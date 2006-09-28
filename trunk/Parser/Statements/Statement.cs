// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.Collections.Generic;
using nMars.Parser.Expressions;
using nMars.Parser.Warrior;

namespace nMars.Parser.Statements
{
    public abstract class Statement
    {
        public abstract void ExpandStatements(ExtendedWarrior warrior, Dictionary<string, Expression> variables,
                                              ref int currentAddress, int coreSize, bool evaluate);

        public List<LabelName> Labels = null;
        public List<string> Comments = null;
    }
}