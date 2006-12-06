using System;
using System.IO;
using System.Text;
using nMars.RedCode;

namespace nMars.IDE.Controls
{
    public partial class Console : IDEFrame, IDebuggerPrompt
    {
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

        public Console()
        {
            InitializeComponent();
            StreamInstance = new ConsoleStream();
            StreamInstance.Console = this;
        }

        ConsoleStream StreamInstance;

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
            tbOut.Text += text + "\r\n";
            tbOut.SelectionStart = tbOut.Text.Length;
            tbOut.ScrollToCaret();
        }

        public void WriteLine(string text)
        {
            tbOut.Text += text + "\r\n";
            tbOut.SelectionStart = tbOut.Text.Length;
            tbOut.ScrollToCaret();
        }

        public void Write(string text)
        {
            tbOut.Text += text;
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
    }
}