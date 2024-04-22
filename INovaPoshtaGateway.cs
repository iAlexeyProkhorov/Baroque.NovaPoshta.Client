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
using System.Threading.Tasks;

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

        /// <summary>
        /// Create HTTP request to 'Nova Poshta' gateway async
        /// </summary>
        /// <typeparam name="TResponse">Response type</typeparam>
        /// <typeparam name="TRequest">Request type</typeparam>
        /// <param name="request">Request instance</param>
        /// <returns>Deserialized response</returns>
        Task<TResponse> CreateRequestAsync<TRequest, TResponse>(IRequestEnvelope<TRequest> request)
            where TRequest : class, new()
            where TResponse : class, new();
    }
}
