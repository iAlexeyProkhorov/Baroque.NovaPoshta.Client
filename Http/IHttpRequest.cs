using System;
using System.Collections.Generic;

namespace Baroque.NovaPoshta.Client.Http
{
    /// <summary>
    /// Represents base HTTP request interface
    /// </summary>
    public interface IHttpRequest
    {
        /// <summary>
        /// Request url
        /// </summary>
        Uri Uri { get; set; }

        /// <summary>
        /// Gets or sets request query parameters collection
        /// </summary>
        IDictionary<string, object> Parameters { get; set; }

        /// <summary>
        /// Gets or sets request headers headers
        /// </summary>
        IDictionary<string, string> Headers { get; set; }

        /// <summary>
        /// Gets or sets HTTP request method
        /// </summary>
        HttpMethod Method { get; set; }

        /// <summary>
        /// Gets or sets sending data array
        /// </summary>
        byte[] Data { get; set; }
    }
}
