// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Collections.Generic;
using nMars.RedCode;

namespace nMars.Engine
{
    public class Engine : StepEngine, IEngine
    {
        public MatchResult Run(IProject project, IPSpaces pspaces, Random aRandom)
        {
            BeginMatch(project, pspaces, aRandom);
            while (NextStep() != StepResult.Finished)
            {
            }
            return EndMatch();
        }
    }
}