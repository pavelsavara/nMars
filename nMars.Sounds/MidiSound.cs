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
    public partial class MidiSound : Component, ICoreWatch, IDebugWatch
    {
        public MidiSound()
        {
            InitializeComponent();
        }

        public MidiSound(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void Attach(IAsyncEngine aEngine)
        {
            engine = aEngine;
            coreSize = engine.Project.Rules.CoreSize;
            midi=new MidiOut();
            midi.Open(0);
            midi.Instrument(73);
        }

        public void Attach(TabControl frame, string name)
        {
        }

        public void Detach()
        {
            Stop();
            engine = null;
            midi.Close();
            midi = null;
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
            Stop();
        }

        public void RepaintView()
        {
            PlayChanges();
        }

        private void PlayChanges()
        {
            CoreEventRecord[] events = engine.CoreEvents;
            for (int address = 0; address < coreSize; address++)
            {
                //IRunningInstruction ri = engine[address];
                CoreEventRecord record = events[address];
                if ((record.Event & InstructionEvent.Executed) != InstructionEvent.None)
                {
                    if (tones.Count > 2)
                    {
                        midi.Stop(tones.Dequeue());
                    }
                    byte tone = (byte)(((address * 128 / coreSize))+20);
                    midi.Play(tone);
                    tones.Enqueue(tone);
                }
            }
        }

        private void Stop()
        {
            while(tones.Count>0)
            {
                midi.Stop(tones.Dequeue());
            }
        }

        private IAsyncEngine engine = null;
        private int coreSize = 8000;
        private MidiOut midi;
        private Queue<byte> tones = new Queue<byte>();
    }
}
