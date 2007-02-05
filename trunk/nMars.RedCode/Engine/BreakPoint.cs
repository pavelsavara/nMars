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
        public abstract bool ShouldBreak(IDebuggerEngine engine);
        public bool IsActive=true;
    }

    public class BreakPoints : List<BreakPoint>
    {
        static BreakPoints()
        {
            knownTypes.Add(typeof(ExecuteAddressBreakPoint));
        }

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

    public class ExecuteAddressBreakPoint : BreakPoint, INotifyPropertyChanged
    {
        static ExecuteAddressBreakPoint()
        {
            BreakPoints.knownTypes.Add(typeof(ExecuteAddressBreakPoint));
        }

        //for XML
        private ExecuteAddressBreakPoint()
        {
        }

        public ExecuteAddressBreakPoint(int aAddress)
        {
            address = aAddress;
        }

        public override bool ShouldBreak(IDebuggerEngine engine)
        {
            return engine.NextInstruction.Address == Address;
        }

        public int Address
        {
            get
            {
                return address;
            }
            set
            {
                CheckPropertyChanged("Address", ref address, ref value);
            }
        }

        private int address;
        public override string ToString()
        {
            return "Break at address " + Address;
        }

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        private bool CheckPropertyChanged<T>(string propertyName, ref T oldValue, ref T newValue)
        {
            if (oldValue == null && newValue == null)
            {
                return false;
            }

            if ((oldValue == null && newValue != null) || !oldValue.Equals((T)newValue))
            {
                oldValue = newValue;

                FirePropertyChanged(propertyName);

                return true;
            }

            return false;
        }

        private void FirePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

    }


}
