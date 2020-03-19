using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain
{
    /// <summary>
    /// Represents base Nova Poshat service request
    /// </summary>
    /// <typeparam name="TRequestBody">Request body type</typeparam>
    [DataContract]
    public class RequestEnvelope<TRequestBody> : IRequestEnvelope<TRequestBody> where TRequestBody : class, new()
    {
        /// <summary>
        /// Gets or sets individual api key
        /// </summary>
        [DataMember(Name = "apiKey")]
        public string ApiKey { get; set; }

        /// <summary>
        /// Gets or sets using model name
        /// </summary>
        [DataMember(Name = "modelName")]
        public string ModelName { get; set; }

        /// <summary>
        /// Gets or sets called method name
        /// </summary>
        [DataMember(Name = "calledMethod")]
        public string CalledMethod { get; set; }

        /// <summary>
        /// Gets or sets request method properties
        /// </summary>
        [DataMember(Name = "methodProperties")]
        public TRequestBody MethodProperties { get; set; } = new TRequestBody();

        public RequestEnvelope()
        {

        }

        public RequestEnvelope(TRequestBody request)
        {
            this.MethodProperties = request;
        }
    }
}
