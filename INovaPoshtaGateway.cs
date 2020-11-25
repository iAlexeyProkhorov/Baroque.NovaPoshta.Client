using Baroque.NovaPoshta.Client.Domain;
using Baroque.NovaPoshta.Client.Http;
using Baroque.NovaPoshta.Client.Serialization;

namespace Baroque.NovaPoshta.Client
{
    /// <summary>
    /// Represents a nova poshta api gateway
    /// </summary>
    public interface INovaPoshtaGateway
    {
        /// <summary>
        /// Gets or sets individual api key
        /// </summary>
        string ApiKey { get; set; }

        /// <summary>
        /// Gets 'Nova Poshta' service address
        /// </summary>
        string Url { get; }

        /// <summary>
        /// Gets Nova Poshta Api version
        /// </summary>
        string Version { get; }

        /// <summary>
        /// Gets serialization helper which will use requests body serialization
        /// </summary>
        ISerializationHelper SerializationHelper { get; }

        /// <summary>
        /// Gets HTTP request helper, which allow to send request to service
        /// </summary>
        IHttpRequestHelper HttpRequestHelper { get; }

        /// <summary>
        /// Create HTTP request to 'Nova Poshta' gateway
        /// </summary>
        /// <typeparam name="TResponse">Response type</typeparam>
        /// <typeparam name="TRequest">Request type</typeparam>
        /// <param name="request">Request instance</param>
        /// <returns>Deserialized response</returns>
        TResponse CreateRequest<TRequest, TResponse>(IRequestEnvelope<TRequest> request)
            where TRequest : class, new()
            where TResponse : class, new();
    }
}
