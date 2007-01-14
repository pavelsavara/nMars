using System;
using System.Collections.Generic;
using System.Text;

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
