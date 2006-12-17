using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using nMars.RedCode;

namespace nMars.IDE.Controls
{
    public partial class Console : IDEFrame, IDebuggerPrompt
    {
        #region Helper classes

        class ConsoleStream : Stream
        {
            public Console Console;

            public override void Write(byte[] buffer, int offset, int count)
            {
                // Very bad hack: Ignore single newline char. This is because we expect the newline is following
                // previous content and we already placed a newline on that.
                if (count == 1 && buffer[offset] == '\n')
                    return;
                // Code update from ShawnFa to fix case for '\r'
                StringBuilder sb = new StringBuilder();
                while (count > 0)
                {
                    char ch = (char)buffer[offset];
                    if (ch == '\n')
                    {
                        Console.WriteLine(sb.ToString());
                        sb.Length = 0; // reset.                
                    }
                    else if (ch != '\r')
                    {
                        sb.Append(ch);
                    }
                    offset++;
                    count--;
                }

                // Dump remainder. @todo - need some sort of "Write" to avoid adding extra newline.
                if (sb.Length > 0)
                    Console.WriteLine(sb.ToString());
            }

            #region Empty Impl

            public override void Flush()
            {
                //nop
            }

            public override long Seek(long offset, SeekOrigin origin)
            {
                throw new NotSupportedException();
            }

            public override void SetLength(long value)
            {
                throw new NotSupportedException();
            }

            public override int Read(byte[] buffer, int offset, int count)
            {
                throw new NotSupportedException();
            }

            public override bool CanRead
            {
                get { return false; }
            }

            public override bool CanSeek
            {
                get { return false; }
            }

            public override bool CanWrite
            {
                get { return true; }
            }

            public override long Length
            {
                get { throw new NotSupportedException(); }
            }

            public override long Position
            {
                get { throw new NotSupportedException(); }
                set { throw new NotSupportedException(); }
            }

            #endregion
        }

        class AsyncConsole : ISimpleOutput
        {
            public AsyncConsole(Console aConsole)
            {
                console = aConsole;
            }

            public void Clear()
            {
                console.Invoke(new voidDelegate(console.Clear));
            }

            public void WriteLine(string text)
            {
                console.Invoke(new stringDelegate(console.WriteLine), text);
            }


            public void Write(string text)
            {
                console.Invoke(new stringDelegate(console.Write), text);
            }

            public void ErrorWriteLine(string text)
            {
                console.Invoke(new stringDelegate(console.ErrorWriteLine), text);
            }

            private delegate void voidDelegate();
            private delegate void stringDelegate(string text);
            private Console console;
        }

        #endregion

        public Console()
        {
            InitializeComponent();
            StreamInstance = new ConsoleStream();
            StreamInstance.Console = this;
        }

        public void Init(IDebugger debugger, IDebuggerEngine engine, IDebuggerShell aShell)
        {
            throw new NotImplementedException();
        }

        public string GetCommand()
        {
            return null; //TODO block ?
        }

        public void Clear()
        {
            tbOut.Text = String.Empty;
        }

        public void ErrorWriteLine(string text)
        {
            AddLine(text);
        }

        public void WriteLine(string text)
        {
            AddLine(text);
        }

        public void Write(string text)
        {
            AddLine(text);
        }

        private void AddLine(string text)
        {
            if (lines.Count >= maxLength)
            {
                lines.Dequeue();
            }
            lines.Enqueue(text);
            SuspendLayout();
            tbOut.Lines = lines.ToArray();
            MoveCaret();
            ResumeLayout();
        }

        private void MoveCaret()
        {
            tbOut.SelectionStart = tbOut.Text.Length;
            tbOut.ScrollToCaret();
        }

        public Stream ErrorStream
        {
            get { return StreamInstance; }
        }

        public Stream OutStream
        {
            get { return StreamInstance; }
        }

        public Stream InputStream
        {
            get { return StreamInstance; }
        }

        public ISimpleOutput GetAsyncWrapper()
        {
            return new AsyncConsole(this);
        }

        #region Variables

        ConsoleStream StreamInstance;
        private const int maxLength = 100;
        Queue<string> lines = new Queue<string>(maxLength);

        #endregion
    }
}