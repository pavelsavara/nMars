// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using nMars.RedCode;

namespace nMars.SimpleEngine
{
    /// <summary>
    /// Persistent P-Spaces
    /// </summary>
    [Serializable]
    public class PSpaces : SerializableDictionary<string, int[]>, IPSpaces
    {
    }
}