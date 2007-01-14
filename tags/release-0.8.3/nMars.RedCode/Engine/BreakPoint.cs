using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace nMars.RedCode
{
    public abstract class BreakPoint
    {
        public abstract bool ShouldBreak(IDebuggerEngine engine);
        public bool IsActive=true;
    }

    public class BreakPoints : List<BreakPoint>
    {
        public bool ShouldBreak(IDebuggerEngine engine)
        {
            foreach (BreakPoint breakPoint in this)
            {
                if (breakPoint.ShouldBreak(engine))
                    return true;
            }
            return false;
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

    public class ExecuteAddressBreakPoint : BreakPoint
    {
        static ExecuteAddressBreakPoint()
        {
            BreakPoints.knownTypes.Add(typeof(ExecuteAddressBreakPoint));
        }

        public ExecuteAddressBreakPoint(int address)
        {
            Address = address;
        }

        public override bool ShouldBreak(IDebuggerEngine engine)
        {
            return engine.NextInstruction.Address == Address;
        }

        public int Address;
    }


}
