// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace nMars.Sounds
{
    class BeepOut
    {
        public void Start()
        {
            worker = new Thread(new ThreadStart(Loop));
            worker.Start();
        }

        public void Stop()
        {
            Play(-2);
            worker.Join();
        }

        public void Play(int tone)
        {
            lock (this)
            {
                tones.Enqueue(tone);
            }
        }

        public void Reset()
        {
            lock (this)
            {
                tones.Clear();
            }
        }

        private void Loop()
        {
            try
            {
                while (true)
                {
                    int tone;
                    lock (this)
                    {
                        if (tones.Count > 0)
                            tone = tones.Dequeue();
                        else
                            tone = -1;
                    }
                    if (tone == -2)
                    {
                        return;
                    }
                    else if (tone == -1)
                    {
                        Thread.Sleep(length);
                    }
                    else
                    {
                        Console.Beep(tone, length);
                    }
                }
            }
            catch (ThreadInterruptedException)
            {
                //swallow
            }
        }

        private int length = 20;
        private Thread worker;
        private Queue<int> tones=new Queue<int>();
    }
}
