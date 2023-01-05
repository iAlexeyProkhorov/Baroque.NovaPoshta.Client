//Copyright 2020 Alexey Prokhorov

//Licensed under the Apache License, Version 2.0 (the "License");
//you may not use this file except in compliance with the License.
//You may obtain a copy of the License at

//    http://www.apache.org/licenses/LICENSE-2.0

//Unless required by applicable law or agreed to in writing, software
//distributed under the License is distributed on an "AS IS" BASIS,
//WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//See the License for the specific language governing permissions and
//limitations under the License.

using Baroque.NovaPoshta.Client.Domain;
using Baroque.NovaPoshta.Client.Http;
using Baroque.NovaPoshta.Client.Serialization;
using System;
using System.Threading.Tasks;

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

        private string _fullUri;

        #endregion

        #region Properties

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
        /// Gets full http request address
        /// </summary>
        public Uri FullUri
        {
            get
            {
                return new Uri(_fullUri);
            }
        }

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
            Initialize();
        }

        /// <summary>
        /// Default nova poshta gateway
        /// </summary>
        /// <param name="apiKey">Your unique Nova Poshta service api key</param>
        public DefaultNovaPoshtaGateway(string apiKey)
        {
            this.ApiKey = apiKey;
            Initialize();
        }

        #endregion

        #region Events

        public event RequestSerialized RequestSerialized;
        public event ResponseArrived ResponseArrived;
        public event ResponseDeserialized ResponseDeserialized;

        #endregion

        #region Utilites

        /// <summary>
        /// Initialize 'Nova Poshta' gateway
        /// </summary>
        protected virtual void Initialize()
        {
            _fullUri = $"{Url}{Version}/{SerializationHelper.Type.ToLower()}/";
        }

        #endregion

        #region Methods

        /// <summary>
        /// Set api version property
        /// </summary>
        /// <param name="version">Version</param>
        public void SetVersion(string version)
        {
            this.Version = version;
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
            var response = CreateRequestAsync<TRequest, TResponse>(request).GetAwaiter().GetResult();
            return response;
        }

        /// <summary>
        /// Create HTTP request to 'Nova Poshta' gateway async
        /// </summary>
        /// <typeparam name="TResponse">Response type</typeparam>
        /// <typeparam name="TRequest">Request type</typeparam>
        /// <param name="request">Request instance</param>
        /// <returns>Deserialized response</returns>
        public async Task<TResponse> CreateRequestAsync<TRequest, TResponse>(IRequestEnvelope<TRequest> request)
            where TRequest : class, new()
            where TResponse : class, new()
        {
            //apply api key to request
            request.ApiKey = this.ApiKey;

            //serialize request
            var serialized = SerializationHelper.Serialize(request);

            //run methods processing serialized request
            if (RequestSerialized != null)
                RequestSerialized(request, ref serialized);

            //create HTTP request
            var responseData = await CreateRequestAsync(request.OverridedMethodUrl, serialized);

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
        public string CreateRequest(string overridedUri, string data)
        {
            var response = CreateRequestAsync(overridedUri, data).GetAwaiter().GetResult();
            return response;
        }

        /// <summary>
        /// Create HTTP request to 'Nova Poshta' gateway async
        /// </summary>
        /// <param name="data">Data to send, usually serialized at JSON or XML format.</param>
        /// <returns>Gateway response. Serialized at XML or JSON format</returns>
        public async Task<string> CreateRequestAsync(string overridedUri, string data)
        {
            //get request bytes
            var requestData = HttpRequestHelper.Encoding.GetBytes(data);

            //create http request
            var httpRequest = new HttpRequest()
            {
                ContentType = SerializationHelper.ContentType,
                Data = requestData,
                Method = HttpMethod.POST,
                Uri = string.IsNullOrEmpty(overridedUri) ? FullUri : new Uri(overridedUri)
            };

            //create http request
            var responseBytes = await HttpRequestHelper.CreateRequestAsync(httpRequest);
            var responseData = HttpRequestHelper.Encoding.GetString(responseBytes);

            return responseData;
        }

        #endregion
    }
}
