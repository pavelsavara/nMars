using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using nMars.RedCode.Modules;

namespace nMars.RedCode
{

    [Serializable]
    public class Solution
    {
        public Solution()
        {
            Components = new ComponentLoader();
            ProjectFiles=new List<string>();
        }

        public ComponentLoader Components;
        public List<string> ProjectFiles;
        public string ActiveProject;


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
                    serializerCached = new XmlSerializer(typeof(Solution));
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
        public static Solution LoadXml(string filename)
        {
            StreamReader sr = new StreamReader(filename);
            try
            {
                Solution proj = Serializer.Deserialize(sr) as Solution;
                return proj;
            }
            finally
            {
                sr.Close();
            }
        }

        private static XmlSerializer serializerCached;

        #endregion
    }
}
