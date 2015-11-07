// This file is part of nMars - Core War MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.IO;

namespace nMars.Test
{
    class Utils
    {
        public static string CleanProblems(string basePath, string name)
        {
            string problemsPath = Path.Combine(basePath, name);
            if (Directory.Exists(problemsPath))
            {
                try
                {
                    Directory.Delete(problemsPath, true);
                }
                catch (Exception)
                {
                    //swalow
                }
            }
            Directory.CreateDirectory(problemsPath);
            return problemsPath;
        }

        public static string GetWarrirorsDirectory()
        {
            string current = Directory.GetCurrentDirectory();
            string basePath = Path.Combine(current, "Warriors");
            if (!Directory.Exists(basePath))
            {
                current = Directory.GetParent(current).FullName;
                basePath = Path.Combine(current, "Warriors");
                if (!Directory.Exists(basePath))
                {
                    current = Directory.GetParent(current).FullName;
                    basePath = Path.Combine(current, "Warriors");
                    if (!Directory.Exists(basePath))
                    {
                        current = Directory.GetParent(current).FullName;
                        basePath = Path.Combine(current, "Warriors");
                        if (!Directory.Exists(basePath))
                        {
                            throw new ApplicationException("Could not find Warrirors at: " + basePath);
                        }
                    }
                }
            }
            return basePath;
        }
    }
}