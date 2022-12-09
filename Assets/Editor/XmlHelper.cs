using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


    public static class XmlHelper
    {
        public static void Serialize(string filePath, object obj, Type objectType)
        {
            try
            {
                XmlSerializer mySerializer = new XmlSerializer(objectType);
                StreamWriter myWriter = new StreamWriter(filePath);
                mySerializer.Serialize(myWriter, obj);
                myWriter.Close();
            }
            catch (Exception E)
            {
            }
        }
        public static object Deserialize(string filePath, object obj, Type objectType)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    StreamReader fileURL = new StreamReader(filePath);
                    XmlSerializer mySerializer = new XmlSerializer(objectType);
                    obj = mySerializer.Deserialize(fileURL);
                    fileURL.Close();
                }
            }
            catch (Exception E)
            {
            }
            return obj;
        }

    }
