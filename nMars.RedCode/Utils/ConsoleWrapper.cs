// This file is part of nMars - Corewars MARS for .NET 
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

        public Stream InputStream
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

    public class WrappedConsole : ISimpleOutput
    {
        public Stream ErrorStream
        {
            get { return System.Console.OpenStandardError(); }
        }

        public Stream OutStream
        {
            get { return System.Console.OpenStandardOutput(); }
        }

        public Stream InputStream
        {
            get { return System.Console.OpenStandardInput(); }
        }

        public virtual string GetCommand()
        {
            return System.Console.ReadLine();
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
    }
}
