// This file is part of nMars - Core War MARS for .NET 
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
        static Mono()
        {
            Type t = Type.GetType("Mono.Runtime");
            if (t != null)
                isRunningMono = true;
            else
                isRunningMono = false;
        }

        /// <summary>
        /// Returns true if we are running on MONO runtime
        /// </summary>
        public static bool IsMonoRuntime
        {
            get
            {
                return isRunningMono;
            }
        }

        private static bool isRunningMono;
    }
}
