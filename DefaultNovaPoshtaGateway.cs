using Baroque.NovaPoshta.Client.Domain;
using Baroque.NovaPoshta.Client.Http;
using Baroque.NovaPoshta.Client.Serialization;
using System;

namespace Baroque.NovaPoshta.Client
{
    /// <summary>
    /// Represents after serialization methods signature.
    /// </summary>
    /// <param name="request">Request reference</param>
    /// <param name="serialized">Serialized request</param>
    public delegate void RequestSerialized(object request, ref string serialized);

    /// <summary>
    /// Represents response arrived methods signature.
    /// </summary>
    /// <param name="data">Serialized response</param>
    public delegate void ResponseArrived(ref string data);

    /// <summary>
    /// Represents response deserialized method signature
    /// </summary>
    /// <param name="deserialized">Deserialized response object</param>
    /// <param name="response">Serialized response</param>
    public delegate void ResponseDeserialized(object deserialized, ref string response);

    /// <summary>
    /// Represents default 'Nova Poshta' service gateway
    /// </summary>
    public class DefaultNovaPoshtaGateway : INovaPoshtaGateway
    {
        #region Fields

        /// <summary>
        /// Gets or sets individual api key
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// Gets 'Nova Poshta' service address
        /// </summary>
        public string Url { get; private set; } = "https://api.novaposhta.ua/";

        /// <summary>
        /// Gets Nova Poshta Api version
        /// </summary>
        public string Version { get; private set; } = "v2.0";

        /// <summary>
        /// Gets serialization helper which will use for connection
        /// </summary>
        public ISerializationHelper SerializationHelper { get; private set; } = new JsonSerializationHelper();

        /// <summary>
        /// Gets HTTP request helper, which allow to send request to service
        /// </summary>
        public IHttpRequestHelper HttpRequestHelper { get; private set; } = new HttpRequestHelper();

        #endregion

        #region Constructors

        public DefaultNovaPoshtaGateway()
        {

        }

        /// <summary>
        /// Default nova poshta gateway
        /// </summary>
        /// <param name="apiKey">Your unique Nova Poshta service api key</param>
        public DefaultNovaPoshtaGateway(string apiKey)
        {
            this.ApiKey = apiKey;
        }

        #endregion

        #region Events

        public event RequestSerialized RequestSerialized;
        public event ResponseArrived ResponseArrived;
        public event ResponseDeserialized ResponseDeserialized;

        #endregion

        #region Methods

        /// <summary>
        /// Gets full http request address
        /// </summary>
        public Uri FullUri
        {
            get
            {
                return new Uri($"{Url}{Version}/{SerializationHelper.Type.ToLower()}/");
            }
        }

        /// <summary>
        /// Set api version property
        /// </summary>
        /// <param name="version">Version</param>
        public void SetVersion(string version)
        {
            this.Version = version;
        }

        /// <summary>
        /// Set Nova Poshta API url
        /// </summary>
        /// <param name="url">Url</param>
        public void SetUrl(string url)
        {
            this.Url = url;
        }

        /// <summary>
        /// Set serialization helper
        /// </summary>
        /// <param name="serializationHelper">Serialization helper</param>
        public void SetSerializationHelper(ISerializationHelper serializationHelper)
        {
            this.SerializationHelper = serializationHelper;
        }

        /// <summary>
        /// Create HTTP request to 'Nova Poshta' gateway
        /// </summary>
        /// <typeparam name="TResponse">Response type</typeparam>
        /// <typeparam name="TRequest">Request type</typeparam>
        /// <param name="request">Request instance</param>
        /// <returns>Deserialized response</returns>
        public TResponse CreateRequest<TRequest, TResponse>(IRequestEnvelope<TRequest> request)
            where TRequest: class, new()
            where TResponse: class, new()
        {
            //serialize request
            var serialized = SerializationHelper.Serialize(request);

            //run methods processing serialized request
            if (RequestSerialized != null)
                RequestSerialized(request, ref serialized);

            //create HTTP request
            var responseData = CreateRequest(serialized);

            //run method processing arrived response data
            if (ResponseArrived != null)
                ResponseArrived(ref responseData);

            var deserialized = SerializationHelper.Deserialize<TResponse>(responseData);

            //run methods processing response deserialization result
            if (ResponseDeserialized != null)
                ResponseDeserialized(deserialized, ref responseData);

            return deserialized;
        }

        /// <summary>
        /// Create HTTP request to 'Nova Poshta' gateway 
        /// </summary>
        /// <param name="data">Data to send, usually serialized at JSON or XML format.</param>
        /// <returns>Gateway response. Serialized at XML or JSON format</returns>
        public string CreateRequest(string data)
        {
            //get request bytes
            var requestData = HttpRequestHelper.Encoding.GetBytes(data);

            //create http request
            var httpRequest = new HttpRequest()
            {
                ContentType = SerializationHelper.ContentType,
                Data = requestData,
                Method = HttpMethod.POST,
                Uri = this.FullUri
            };

            //create http request
            var responseBytes = HttpRequestHelper.CreateRequest(httpRequest);
            var responseData = HttpRequestHelper.Encoding.GetString(responseBytes);

            return responseData;
        }

        #endregion
    }
}
