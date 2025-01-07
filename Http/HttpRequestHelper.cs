using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baroque.NovaPoshta.Client.Http
{
    /// <summary>
    /// Represents HTTP requests helper
    /// </summary>
    public class HttpRequestHelper : IHttpRequestHelper
    {
        #region Fields

        /// <summary>
        /// Gets requests encoding type
        /// </summary>
        public Encoding Encoding { get; protected set; } = Encoding.UTF8;

        #endregion

        #region Constructor

        public HttpRequestHelper()
        {

        }

        #endregion        

        #region Methods

        /// <summary>
        /// Create parametrized request url
        /// </summary>
        /// <typeparam name="THttpRequest">HTTP request type</typeparam>
        /// <param name="httpRequest">HTTP request instance</param>
        /// <returns>Parametrized request url</returns>
        public virtual string CreateParametrizedRequestUrl<THttpRequest>(THttpRequest httpRequest) where THttpRequest : IHttpRequest
        {
            return CreateParametrizedRequestUrl(httpRequest.Uri, httpRequest.Parameters);
        }

        /// <summary>
        /// Create parametrized request url
        /// </summary>
        /// <param name="uri">Request uri</param>
        /// <param name="parameters">Request parameters</param>
        /// <returns>Parametrized request url</returns>
        public virtual string CreateParametrizedRequestUrl(Uri uri, IDictionary<string, object> parameters)
        {
            if (!parameters.Any())
                return uri.AbsoluteUri;

            //create string builder to make request
            var builder = string.IsNullOrEmpty(uri.Query) ? new StringBuilder($"{uri.AbsoluteUri}?") : new StringBuilder(uri.AbsoluteUri);

            //add request parameters
            var lastParameter = parameters.LastOrDefault();
            foreach (var parameter in parameters)
            {
                var value = parameter.Value ?? string.Empty;
                builder.Append($"{parameter.Key}={value}");

                //add & for next parameter if it's not last
                if (parameter.GetHashCode() != lastParameter.GetHashCode())
                    builder.Append("&");
            }

            return builder.ToString();
        }

        /// <summary>
        /// Create HTTP request
        /// </summary>
        /// <typeparam name="THttpRequest">Request type</typeparam>
        /// <param name="httpRequest">HTTP request</param>
        /// <param name="timeout">Request timeout</param>
        /// <returns>Response byte array</returns>
        public virtual byte[] CreateRequest<THttpRequest>(THttpRequest httpRequest, int timeout = 10) where THttpRequest : IHttpRequest
        {
            return CreateRequest(httpRequest.Uri, httpRequest.Method, httpRequest.Parameters, httpRequest.Data, timeout);
        }

        /// <summary>
        /// Create HTTP request
        /// </summary>
        /// <typeparam name="THttpRequest">Request type</typeparam>
        /// <param name="httpRequest">HTTP request</param>
        /// <param name="timeout">Request timeout</param>
        /// <returns>Response byte array</returns>
        public virtual async Task<byte[]> CreateRequestAsync<THttpRequest>(THttpRequest httpRequest, int timeout = 10) where THttpRequest : IHttpRequest
        {
            return await CreateRequestAsync(httpRequest.Uri, httpRequest.Method, httpRequest.Parameters, httpRequest.Data, timeout);
        }

        /// <summary>
        /// Create HTTP request
        /// </summary>
        /// <param name="uri">Request uri</param>
        /// <param name="httpMethod">HTTP method</param>
        /// <param name="parameters">Request query parameters</param>
        /// <param name="data">Data to sendResponse byte array</param>
        /// <param name="timeout">Request timeout</param>
        /// <returns>Response byte array</returns>
        public virtual byte[] CreateRequest(Uri uri, HttpMethod httpMethod, IDictionary<string, object> parameters, byte[] data, int timeout = 10)
        {
            return CreateRequest(uri, httpMethod, parameters, new Dictionary<string, string>(), data, timeout);
        }

        /// <summary>
        /// Create HTTP request
        /// </summary>
        /// <param name="uri">Request uri</param>
        /// <param name="httpMethod">HTTP method</param>
        /// <param name="parameters">Request query parameters</param>
        /// <param name="data">Data to sendResponse byte array</param>
        /// <param name="timeout">Request timeout</param>
        /// <returns>Response byte array</returns>
        public virtual async Task<byte[]> CreateRequestAsync(Uri uri, HttpMethod httpMethod, IDictionary<string, object> parameters, byte[] data, int timeout = 10)
        {
            return await CreateRequestAsync(uri, httpMethod, parameters, new Dictionary<string, string>(), data, timeout);
        }

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
        public virtual byte[] CreateRequest(Uri uri, HttpMethod httpMethod, IDictionary<string, object> parameters, IDictionary<string, string> headers, byte[] data, int timeout = 10)
        {
            return CreateRequest(uri, httpMethod.ToString(), parameters, headers, data, timeout);
        }

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
        public virtual async Task<byte[]> CreateRequestAsync(Uri uri, HttpMethod httpMethod, IDictionary<string, object> parameters, IDictionary<string, string> headers, byte[] data, int timeout = 10)
        {
            return await CreateRequestAsync(uri, httpMethod.ToString(), parameters, headers, data, timeout);
        }

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
        public virtual byte[] CreateRequest(Uri uri, string method, IDictionary<string, object> parameters, IDictionary<string, string> headers, byte[] data, int timeout = 10)
        {
            using (var client = new BaroqueWebClient())
            {
                //parse parametrized url
                var requestUrl = CreateParametrizedRequestUrl(uri, parameters);

                //add request headers
                foreach (var header in headers)
                    client.Headers.Add(header.Key, header.Value);

                client.Encoding = Encoding;
                client.Timeout = timeout;

                return CreateRequestAsync(uri, method, parameters, headers, data, timeout).Result;
            }
        }

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
        public virtual async Task<byte[]> CreateRequestAsync(Uri uri, string method, IDictionary<string, object> parameters, IDictionary<string, string> headers, byte[] data, int timeout = 10)
        {
            using (var client = new BaroqueWebClient())
            {
                //parse parametrized url
                var requestUrl = CreateParametrizedRequestUrl(uri, parameters);
                var requestUri = new Uri(requestUrl);

                //add request headers
                foreach (var header in headers)
                    client.Headers.Add(header.Key, header.Value);

                client.Encoding = Encoding;
                client.Timeout = timeout;

                return method.Equals("get", StringComparison.InvariantCultureIgnoreCase) ? await client.DownloadDataTaskAsync(requestUri) : await client.UploadDataTaskAsync(requestUri, method, data);
            }
        }

        #endregion
    }
}
