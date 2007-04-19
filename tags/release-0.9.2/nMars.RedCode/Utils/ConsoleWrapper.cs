// This file is part of nMars - Core War MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.IO;

namespace nMars.RedCode
{

    public class WrappedTextWriter : ISimpleOutput
    {
        public WrappedTextWriter(TextWriter output)
        {
            this.output = output;
        }

        TextWriter output;

        public Stream ErrorStream
        {
            get { throw new NotSupportedException(); }
        }

        public Stream OutStream
        {
            get { throw new NotSupportedException(); }
        }

        public string GetCommand()
        {
            throw new NotSupportedException();
        }

        public void Clear()
        {
            throw new NotSupportedException();
        }

        public void ErrorWriteLine(string text)
        {
            output.WriteLine(text);
        }

        public void WriteLine(string text)
        {
            output.WriteLine(text);
        }

        public void Write(string text)
        {
            output.Write(text);
        }
    }

    public class WrappedConsole : ISimpleOutput, IConsole
    {
        public void Interactive()
        {
            string lastline = null;
            bool quit;
            do
            {
                Console.Write(">");
                string line = Console.ReadLine().Trim();
                if (line.Length == 0)
                    line = lastline;
                bool processed = false;
                quit = false;
                if (CommandEntered != null)
                    CommandEntered.Invoke(line, ref processed, ref quit);
                if (processed)
                    lastline = line;
                else
                    lastline = "";
            } while (!quit);
        }

        public void Inject(string command)
        {
            bool p = false, q = false;
            CommandEntered.Invoke(command, ref p, ref q);
        }

        public Stream ErrorStream
        {
            get { return System.Console.OpenStandardError(); }
        }

        public Stream OutStream
        {
            get { return System.Console.OpenStandardOutput(); }
        }

        public virtual void Clear()
        {
            System.Console.Clear();
        }

        public virtual void ErrorWriteLine(string text)
        {
            System.Console.Error.WriteLine(text);
        }

        public virtual void WriteLine(string text)
        {
            System.Console.Out.WriteLine(text);
        }

        public virtual void Write(string text)
        {
            System.Console.Out.Write(text);
        }

        public event ConsoleCommandEntered CommandEntered;
    }
}
