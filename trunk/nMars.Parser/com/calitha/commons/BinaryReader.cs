using System.IO;
using System.Text;

namespace com.calitha.commons
{
    /// <summary>
    /// This extension to the binary reader supports direct reading of
    /// a unicode (utf-16) string.
    /// </summary>
    public class CalithaBinReader : BinaryReader
    {
        public CalithaBinReader(Stream input)
            : base(input)
        {
        }

        public CalithaBinReader(Stream input, Encoding encoding)
            : base(input, encoding)
        {
        }

        /// <summary>
        /// Reads a unicode (utf-16) string.
        /// </summary>
        /// <returns>Unicode string.</returns>
        public string ReadUnicodeString()
        {
            StringBuilder builder = new StringBuilder();
            ushort ch = ReadUInt16();
            while (ch != 0)
            {
                builder.Append((char)ch);
                ch = ReadUInt16();
            }
            return builder.ToString();
        }
    }
}