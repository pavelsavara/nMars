// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Windows.Forms;
using nMars.IDE;
using nMars.RedCode;

namespace nMars.Sounds
{
    public partial class BeepSound : Component, ICoreWatch, IDebugWatch
    {
        public BeepSound()
        {
            InitializeComponent();
        }

        public BeepSound(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void Attach(IAsyncEngine aEngine)
        {
            engine = aEngine;
            coreSize = engine.Project.Rules.CoreSize;
            rows = coreSize / columns;
            beep = new BeepOut();
            beep.Start();
        }

        public void Attach(TabControl frame, string name)
        {
        }

        public void Detach()
        {
            beep.Reset();
            engine = null;
            beep.Stop();
            beep = null;
        }

        public void ChangingMode(IDEMode newMode)
        {
            throw new NotImplementedException();
        }

        public void ActivateControl()
        {
        }

        public void DeactivateControl()
        {
        }

        public void Resume()
        {
        }

        public void Pause()
        {
            beep.Reset();
        }

        public void RepaintView()
        {
            PlayChanges();
        }

        private void PlayChanges()
        {
            beep.Reset();
            CoreEventRecord[] events = engine.CoreEvents;
            for (int column = 0; column < columns; column++)
            {
                for (int row = 0; row < rows; row++)
                {
                    int address = column + (row * columns);
                    CoreEventRecord record = events[address];
                    if (record.Level == CoreEventsLevel.Flash &&
                        (record.Event & InstructionEvent.Executed) != InstructionEvent.None)
                    {
                        int tone = (address * 12000 / coreSize) + 140;
                        beep.Play(tone);
                    }
                }
            }
        }

        private IAsyncEngine engine = null;
        private int coreSize = 8000;
        protected int columns = 100;
        protected int rows = 80;
        private BeepOut beep;
    }
}
