// This file is part of nMars - Corewars MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System;
using System.IO;

namespace nMars.RedCode
{
    public interface ISimpleOutput
    {
        void Clear();
        void WriteLine(string text);
        void Write(string text);
        void ErrorWriteLine(string text);
    }

    public interface IConsole : ISimpleOutput
    {
        Stream ErrorStream { get; }
        Stream OutStream { get; }
        Stream InputStream { get; }
        string GetCommand();
    }

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
            get { return Console.OpenStandardError(); }
        }

        public Stream OutStream
        {
            get { return Console.OpenStandardOutput(); }
        }

        public Stream InputStream
        {
            get { return Console.OpenStandardInput(); }
        }

        public virtual string GetCommand()
        {
            return Console.ReadLine();
        }

        public virtual void Clear()
        {
            Console.Clear();
        }

        public virtual void ErrorWriteLine(string text)
        {
            Console.Error.WriteLine(text);
        }

        public virtual void WriteLine(string text)
        {
            Console.Out.WriteLine(text);
        }

        public virtual void Write(string text)
        {
            Console.Out.Write(text);
        }
    }
}