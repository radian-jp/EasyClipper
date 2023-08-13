using System.Text;

namespace EasyClipper.Serializer
{
    public class XmlConfigSerializer<T> : ConfigSerializer<T>
        where T : new()
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public XmlConfigSerializer(string filePath) : base(filePath)
        {
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public XmlConfigSerializer(string filePath, Encoding encoding) : base(filePath, encoding)
        {
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns></returns>
        public override T Load()
        {
            if (!File.Exists(FilePath))
            {
                return new T();
            }

            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
            using (StreamReader sr = new StreamReader(FilePath, Encoding))
            {
                return (T?)serializer.Deserialize(sr) ?? new T();
            }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="config"></param>
        public override void Save(T config)
        {
            var dirName = Path.GetDirectoryName(FilePath);
            if (dirName != null && !Directory.Exists(dirName))
            {
                Directory.CreateDirectory(dirName);
            }

            var ns = new System.Xml.Serialization.XmlSerializerNamespaces();
            ns.Add("", "");
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
            using (var sw = new StreamWriter(FilePath, false, Encoding))
            {
                serializer.Serialize(sw, config, ns);
            }
        }
    }
}
