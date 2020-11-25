namespace Baroque.NovaPoshta.Client.Serialization
{
    /// <summary>
    /// Represents the serialization helper interface
    /// </summary>
    public interface ISerializationHelper
    {
        /// <summary>
        /// Gets serialization content type for http header
        /// </summary>
        string ContentType { get; }

        /// <summary>
        /// Gets content type for request
        /// </summary>
        string Type { get; }

        /// <summary>
        /// Serialize object reference
        /// </summary>
        /// <typeparam name="T">Object type</typeparam>
        /// <param name="data">Object reference</param>
        /// <returns>Serialized object</returns>
        string Serialize<T>(T data);

        /// <summary>
        /// Deserialize object
        /// </summary>
        /// <typeparam name="T">Object type</typeparam>
        /// <param name="data">Data for deserialization</param>
        /// <returns>Deserialized object</returns>
        T Deserialize<T>(string data);
    }
}
