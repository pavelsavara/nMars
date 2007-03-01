// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Runtime.InteropServices;

namespace nMars.Sounds
{
    class MidiOut
    {
        [DllImport("winmm.dll")]
        private static extern int midiOutOpen(ref int handle, int deviceID, IntPtr proc, int instance, int flags);

        [DllImport("winmm.dll")]
        private static extern int midiOutClose(int handle);

        [DllImport("winmm.dll")]
        private static extern int midiOutShortMsg(int handle, uint message);

        private int handle;

        public void Open(int port)
        {
            midiOutOpen(ref handle, port, IntPtr.Zero, 0, 0);
        }

        public void Close()
        {
            midiOutClose(handle);
        }

        public void Instrument(uint instrument)
        {
            uint message = 0;
            message += (uint)0x00000001 * 0xC0; // choose instrument
            message += (uint)0x00000100 * instrument; // instrument
            midiOutShortMsg(handle, message);
        }

        public void Play(byte tone)
        {
            uint message = 0;
            message += (uint)0x00000001 * 0x90; // note on
            message += (uint)0x00000100 * tone; // tone #
            message += (uint)0x00010000 * 100; // volume
            midiOutShortMsg(handle, message);
        }

        public void Stop(uint tone)
        {
            uint message = 0;
            message += (uint)0x00000001 * 0x80; // note on
            message += (uint)0x00000100 * tone; // tone #
            message += (uint)0x00010000 * 100; // volume
            midiOutShortMsg(handle, message);
        }
    }
}

