using Newtonsoft.Json;

namespace Baroque.NovaPoshta.Client.Serialization
{
    /// <summary>
    /// Represents JSON serialization helper
    /// </summary>
    public class JsonSerializationHelper : ISerializationHelper
    {
        /// <summary>
        /// Gets serialization content type for http header
        /// </summary>
        public string ContentType { get; protected set; } = "application/json";

        /// <summary>
        /// Gets content type for request
        /// </summary>
        public string Type { get; protected set; } = "json";

        /// <summary>
        /// Serialize object reference
        /// </summary>
        /// <typeparam name="T">Object type</typeparam>
        /// <param name="data">Object reference</param>
        /// <returns>Serialized object</returns>
        public virtual string Serialize<T>(T data)
        {
            var serialized = JsonConvert.SerializeObject(data);
            return serialized;
        }

        /// <summary>
        /// Deserialize object
        /// </summary>
        /// <typeparam name="T">Object type</typeparam>
        /// <param name="data">Data for deserialization</param>
        /// <returns>Deserialized object</returns>
        public virtual T Deserialize<T>(string data)
        {
            var deserialized = JsonConvert.DeserializeObject<T>(data);
            return deserialized;
        }
    }
}
