// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Runtime.InteropServices;

namespace nMars.RedCode
{
    [ComVisible(true)]
    public class EngineOptions
    {
        public bool KOTHFormat = false;
        public bool Permutate = false;
        public bool SortResults = true;
        public Random Random = new Random();
        public static EngineOptions DefaultOptions
        {
            get
            {
                return new EngineOptions();
            }
        }
        public static EngineOptions ConstantRandomOptions
        {
            get
            {
                EngineOptions  e=new EngineOptions();
                e.Random = new Random(0);
                return e;
            }
        }
    }

}
