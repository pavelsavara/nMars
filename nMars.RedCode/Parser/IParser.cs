// This file is part of nMars - Core War MARS for .NET 
// Whole solution including it's license could be found at
// http://sourceforge.net/projects/nmars/
// 2006 Pavel Savara

using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using nMars.RedCode.Modules;

namespace nMars.RedCode
{
    /// <summary>
    /// Level of parser message
    /// </summary>
    public enum ParseMessageLevel
    {
        /// <summary>
        /// Dump all messages
        /// </summary>
        AllMessages = 0,

        /// <summary>
        /// Non critical problem
        /// </summary>
        Warning,

        /// <summary>
        /// Critical error
        /// </summary>
        Error,

        /// <summary>
        /// Dump no messages
        /// </summary>
        NoMessage,
    }

    /// <summary>
    /// Parser Message
    /// </summary>
    public class ParserMessage
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public ParserMessage()
        {
        }

        /// <summary>
        /// Parametrized constructor
        /// </summary>
        public ParserMessage(string message, ParseMessageLevel level, string fileName, int line, int column)
        {
            Message = message;
            Level = level;
            FileName = fileName;
            Line = line;
            Column = column;
        }

        public string Message;
        public ParseMessageLevel Level;
        public string FileName;
        public int Line;
        public int Column;

        public override string ToString()
        {
            return Message;
        }
    }

    /// <summary>
    /// Parser Result - contains messages about compilation
    /// </summary>
    public class ParseResult
    {
        public List<ParserMessage> Messages = new List<ParserMessage>();
        public bool Succesfull = true;

        /// <summary>
        /// Dump all messages
        /// </summary>
        /// <returns></returns>
        public string Dump()
        {
            StringBuilder sb=new StringBuilder();
            foreach (ParserMessage message in Messages)
            {
                sb.AppendLine(message.Message);
            }
            return sb.ToString();
        }
    }

    /// <summary>
    /// Interface of RedCode parsers
    /// </summary>
    [ComVisible(true)]
    public interface IParser : IComponent
    {
        /// <summary>
        /// Parse warrior files in project parameter considering parser options and rules
        /// </summary>
        /// <param name="project">files, rules, options</param>
        /// <param name="console">output console, could be null</param>
        /// <returns>list of errors</returns>
        ParseResult Parse(IProject project, ISimpleOutput console);
    }
}