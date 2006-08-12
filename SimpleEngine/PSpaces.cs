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