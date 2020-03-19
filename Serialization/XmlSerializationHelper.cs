using System.IO;
using System.Xml.Serialization;

namespace Baroque.NovaPoshta.Client.Serialization
{
    /// <summary>
    /// Represents xml serailization helper
    /// </summary>
    public class XmlSerializationHelper : ISerializationHelper
    {
        /// <summary>
        /// Gets serialization content type for http header
        /// </summary>
        public string ContentType { get; } = "text/xml";

        /// <summary>
        /// Gets content type for request
        /// </summary>
        public string Type { get; } = "xml";

        /// <summary>
        /// Serialize object reference
        /// </summary>
        /// <typeparam name="T">Object type</typeparam>
        /// <param name="data">Object reference</param>
        /// <returns>Serialized object</returns>
        public string Serialize<T>(T data)
        {
            using (var writer = new StringWriter())
            {
                var xmlSerializer = new XmlSerializer(typeof(T));
                xmlSerializer.Serialize(writer, data);

                return xmlSerializer.ToString();
            }
        }

        /// <summary>
        /// Deserialize object
        /// </summary>
        /// <typeparam name="T">Object type</typeparam>
        /// <param name="data">Data for deserialization</param>
        /// <returns>Deserialized object</returns>
        public T Deserialize<T>(string data)
        {
            using (var reader = new StringReader(data))
            {
                var xmlSerializer = new XmlSerializer(typeof(T));
                var result = xmlSerializer.Deserialize(reader);

                return (T)result;
            }
        }
    }
}
