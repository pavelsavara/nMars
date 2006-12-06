using System;
using System.IO;

namespace nMars.RedCode
{
    public interface IConsole
    {
        Stream ErrorStream { get; }
        Stream OutStream { get; }
        Stream InputStream { get; }
        string GetCommand();
        void Clear();
        void ErrorWriteLine(string text);
        void WriteLine(string text);
        void Write(string text);
    }

    public class WrappedTextWriter : IConsole
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

    public class WrappedConsole : IConsole
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