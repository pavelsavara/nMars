// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;

namespace nMars.RedCode.Utils
{
    /// <summary>
    /// Mono Helper class
    /// </summary>
    public class Mono
    {
        /// <summary>
        /// Returns true if we are running on MONO runtime
        /// </summary>
        public static bool IsMonoRuntime
        {
            get
            {
                Type t = Type.GetType("Mono.Runtime");
                if (t != null)
                    return true;
                else
                    return false;
            }
        }

    }
}
