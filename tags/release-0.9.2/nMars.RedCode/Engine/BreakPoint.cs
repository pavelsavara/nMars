using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace nMars.RedCode
{
    public abstract class BreakPoint
    {
        public abstract string ShouldBreak(IDebuggerEngine engine);
    }

    public class CoreEventBreakpoint : BreakPoint
    {
        CoreEventBreakpoint()
        {
        }

        public static CoreEventBreakpoint FindByAddress(BreakPoints breakPoints, int address)
        {
            foreach (BreakPoint breakPoint in breakPoints)
            {
                CoreEventBreakpoint item = breakPoint as CoreEventBreakpoint;
                if (item != null)
                {
                    if (item.AddressStart <=item.AddressEnd)
                    {
                        if (address >= item.AddressStart && address <= item.AddressEnd)
                            return item;
                    }
                    else
                    {
                        if (address >= item.AddressStart || address <= item.AddressEnd)
                            return item;
                    }
                }
            }
            return null;
        }

        public CoreEventBreakpoint(InstructionEvent evnt, int address)
        {
            Event = evnt;
            AddressStart = address;
            AddressEnd = address;
        }

        public CoreEventBreakpoint(InstructionEvent evnt, int addressStart, int addressEnd)
        {
            Event = evnt;
            AddressStart = addressStart;
            AddressEnd = addressEnd;
        }

        [XmlAttribute]
        public InstructionEvent Event;
        [XmlAttribute]
        public int AddressStart;
        [XmlAttribute]
        public int AddressEnd;

        public override string ShouldBreak(IDebuggerEngine engine)
        {
            for(int address=AddressStart;address<=AddressEnd;address++)
            {
                if (address > engine.CoreSize)
                    address = 0;
                CoreEventRecord record = engine.CoreEvents[address];
                InstructionEvent instructionEvent = record.Event & Event;
                if (record.Cycle == engine.Cycle-1 && instructionEvent != InstructionEvent.None)
                    return "Core event " + instructionEvent + " on address " + address;
            }
            return null;
        }

        public override string ToString()
        {
            if (AddressStart!=AddressEnd)
            {
                return "Core event " + Event + " on addresses " + AddressStart + " - " + AddressEnd;
            }
            else
            {
                return "Core event " + Event + " on address " + AddressStart;
            }
        }
    }

    public class BreakPoints : List<BreakPoint>
    {
        static BreakPoints()
        {
            knownTypes.Add(typeof(CoreEventBreakpoint));
        }

        public BreakPoint ShouldBreak(IDebuggerEngine engine, out string reason)
        {
            foreach (BreakPoint breakPoint in this)
            {
                string rea = breakPoint.ShouldBreak(engine);
                if (rea!=null)
                {
                    reason = rea;
                    return breakPoint;
                }
                    
            }
            reason = null;
            return null;
        }

        #region Persistence

        /// <summary>
        /// Shared XML serializer
        /// </summary>
        public static XmlSerializer Serializer
        {
            get
            {
                if (serializerCached == null)
                {

                    serializerCached = new XmlSerializer(typeof(BreakPoints), KnownTypes);
                }
                return serializerCached;
            }
        }

        /// <summary>
        /// Save/serialize solution to file
        /// </summary>
        /// <param name="filename">filename should have extension .nmsln</param>
        public void SaveXml(string filename)
        {
            StreamWriter sw = new StreamWriter(filename);
            try
            {
                Serializer.Serialize(sw, this);
            }
            finally
            {
                sw.Close();
            }
        }

        /// <summary>
        /// Load/deserialize solution from file
        /// </summary>
        /// <param name="filename">filename should have extension .nmsln</param>
        public static BreakPoints LoadXml(string filename)
        {
            StreamReader sr = new StreamReader(filename);
            try
            {
                BreakPoints proj = Serializer.Deserialize(sr) as BreakPoints;
                return proj;
            }
            finally
            {
                sr.Close();
            }
        }

        private static XmlSerializer serializerCached;
        public static List<Type> knownTypes=new List<Type>();
        
        public static Type[] KnownTypes
        {
            get
            {
                return knownTypes.ToArray();
            }
        }

        #endregion
    }
}
