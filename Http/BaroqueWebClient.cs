using System;
using System.Net;

namespace Baroque.NovaPoshta.Client.Http
{
    /// <summary>
    /// Represents expanded web client class.
    /// Possible to use timeout settings by this extension.
    /// </summary>
    public class BaroqueWebClient : WebClient
    {
        /// <summary>
        /// Web request timeout in seconds
        /// </summary>
        public int Timeout { get; set; }

        /// <summary>
        /// Get web request
        /// </summary>
        /// <param name="uri">Request uri</param>
        /// <returns>Web request</returns>
        protected override WebRequest GetWebRequest(Uri uri)
        {
            var w = base.GetWebRequest(uri);
            w.Timeout = Timeout * 1000;
            return w;
        }
    }
}
