using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace MouseClicker
{
    public static class DataSerializer
    {
        public static void DeserializeBin<T>(string fileName, ref T container)
        {
            var formatter = new BinaryFormatter();
            var deserializeFile = new FileStream(fileName, FileMode.OpenOrCreate);
            if (deserializeFile.Length > 0)
            {
                container = (T)formatter.Deserialize(deserializeFile);
            }
            deserializeFile.Close();
        }

        public static void SerializeBin<T>(string fileName, ref T container)
        {
            var formatter = new BinaryFormatter();
            var serializeFileStream = new FileStream(fileName, FileMode.OpenOrCreate);
            formatter.Serialize(serializeFileStream, container);
            serializeFileStream.Close();
        }
    }
}