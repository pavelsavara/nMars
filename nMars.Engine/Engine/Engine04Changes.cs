// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using nMars.RedCode;

namespace nMars.Engine
{
    public abstract class EngineChanges : EngineTasks
    {
        #region Events

        protected virtual void BeforeWritePSpace(int address)
        {
        }

        protected virtual void BeforeWrite(int address, Column column)
        {
        }

        protected virtual void AfterWrite(int address, Column column)
        {
        }

        protected virtual void BeforeRead(int address, Column column)
        {
        }

        #endregion

        #region Accessors

        public override int this[int address, Column column]
        {
            get
            {
                BeforeRead(address, column);
                return base[address, column];
            }
            set
            {
                BeforeWrite(address, column);
                base[address, column] = value;
                AfterWrite(address, column);
            }
        }

        protected int dec(int address, Column column)
        {
            int val = mod(this[address, column] - 1);
            this[address, column] = val;
            return val;
        }

        protected void inc(int address, Column column)
        {
            int val = mod(this[address, column] + 1);
            this[address, column] = val;
        }

        #endregion

        #region Variables

        #endregion
    }
}