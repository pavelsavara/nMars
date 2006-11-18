// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Runtime.InteropServices;
using nMars.RedCode.Modules;

namespace nMars.RedCode
{
    [ComVisible(true)]
    public class EngineException : Exception
    {
        public EngineException(string message)
            : base(message)
        {
        }
    }
}