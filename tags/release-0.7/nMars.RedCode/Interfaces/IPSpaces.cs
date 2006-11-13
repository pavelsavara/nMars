// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;

namespace nMars.RedCode
{
    public class PSpace
    {
        public PSpace(int size)
        {
            Memory=new int[size];
        }
        public int[] Memory;

        public const int UNSHARED = -1;
        public const int PIN_APPEARED = -2;

        public override bool Equals(object obj)
        {
            PSpace ps = obj as PSpace;
            if (ps.Memory.Length !=Memory.Length) return false;
            for(int i=0;i<Memory.Length;i++)
            {
                if(ps.Memory[i]!=Memory[i]) return false;
            }
            return true;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}