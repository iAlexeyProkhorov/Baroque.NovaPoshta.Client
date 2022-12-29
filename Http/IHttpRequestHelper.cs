using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Baroque.NovaPoshta.Client.Http
{
    /// <summary>
    /// Represents http request helper interface
    /// </summary>
    public interface IHttpRequestHelper
    {
        /// <summary>
        /// Gets requests encoding type
        /// </summary>
        Encoding Encoding { get; }

        /// <summary>
        /// Create parametrized request url
        /// </summary>
        /// <typeparam name="THttpRequest">HTTP request type</typeparam>
        /// <param name="httpRequest">HTTP request instance</param>
        /// <returns>Parametrized request url</returns>
        string CreateParametrizedRequestUrl<THttpRequest>(THttpRequest httpRequest) where THttpRequest : IHttpRequest;

        /// <summary>
        /// Create parametrized request url
        /// </summary>
        /// <param name="uri">Request uri</param>
        /// <param name="parameters">Request parameters</param>
        /// <returns>Parametrized request url</returns>
        string CreateParametrizedRequestUrl(Uri uri, IDictionary<string, object> parameters);

        /// <summary>
        /// Create HTTP request
        /// </summary>
        /// <typeparam name="THttpRequest">Request type</typeparam>
        /// <param name="httpRequest">HTTP request</param>
        /// <param name="timeout">Request timeout</param>
        /// <returns>Response byte array</returns>
        byte[] CreateRequest<THttpRequest>(THttpRequest httpRequest, int timeout = 10) where THttpRequest : IHttpRequest;

        /// <summary>
        /// Create HTTP request
        /// </summary>
        /// <param name="uri">Request uri</param>
        /// <param name="httpMethod">HTTP method</param>
        /// <param name="parameters">Request query parameters</param>
        /// <param name="data">Data to sendResponse byte array</param>
        /// <param name="timeout">Request timeout</param>
        /// <returns>Response byte array</returns>
        byte[] CreateRequest(Uri uri, HttpMethod httpMethod, IDictionary<string, object> parameters, byte[] data, int timeout = 10);

        /// <summary>
        /// Create HTTP request
        /// </summary>
        /// <param name="uri">Request uri</param>
        /// <param name="httpMethod">HTTP method</param>
        /// <param name="parameters">Request query parameters</param>
        /// <param name="headers">Request headers</param>
        /// <param name="data">Data to sendResponse byte array</param>
        /// <param name="timeout">Request timeout</param>
        /// <returns>Response byte array</returns>
        byte[] CreateRequest(Uri uri, HttpMethod httpMethod, IDictionary<string, object> parameters, IDictionary<string, string> headers, byte[] data, int timeout = 10);

        /// <summary>
        /// Create HTTP request
        /// </summary>
        /// <param name="uri">Request uri</param>
        /// <param name="method">HTTP method</param>
        /// <param name="parameters">Request query parameters</param>
        /// <param name="headers">Request headers</param>
        /// <param name="data">Data to sendResponse byte array</param>
        /// <param name="timeout">Request timeout</param>
        /// <returns>Response byte array</returns>
        byte[] CreateRequest(Uri uri, string method, IDictionary<string, object> parameters, IDictionary<string, string> headers, byte[] data, int timeout = 10);

        /// <summary>
        /// Create HTTP request
        /// </summary>
        /// <param name="uri">Request uri</param>
        /// <param name="method">HTTP method</param>
        /// <param name="parameters">Request query parameters</param>
        /// <param name="headers">Request headers</param>
        /// <param name="data">Data to sendResponse byte array</param>
        /// <param name="timeout">Request timeout</param>
        /// <returns>Response byte array</returns>
        Task<byte[]> CreateRequestAsync(Uri uri, string method, IDictionary<string, object> parameters, IDictionary<string, string> headers, byte[] data, int timeout = 10);
    }
}
