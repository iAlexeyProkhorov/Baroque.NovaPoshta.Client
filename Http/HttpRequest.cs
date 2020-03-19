using System;
using System.Collections.Generic;

namespace Baroque.NovaPoshta.Client.Http
{
    /// <summary>
    /// Represents http request
    /// </summary>
    public class HttpRequest : IHttpRequest
    {
        #region Fields

        /// <summary>
        /// Gets or sets request uri
        /// </summary>
        public Uri Uri { get; set; }

        /// <summary>
        /// Gets or sets request query parameters collection
        /// </summary>
        public IDictionary<string, object> Parameters { get; set; } = new Dictionary<string, object>();

        /// <summary>
        /// Gets or sets request headers
        /// </summary>
        public IDictionary<string, string> Headers { get; set; } = new Dictionary<string, string>();

        /// <summary>
        /// Gets or sets request method
        /// </summary>
        public HttpMethod Method { get; set; }

        /// <summary>
        /// Gets or sets request content type
        /// </summary>
        public string ContentType { get; set; }

        /// <summary>
        /// Gets or sets sending data
        /// </summary>
        public byte[] Data { get; set; }

        #endregion

        public HttpRequest()
        {
            Headers["Content-Type"] = "application/json";
        }


    }
}
