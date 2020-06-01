using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain
{
    /// <summary>
    /// Represents base gateway response envelope
    /// </summary>
    /// <typeparam name="TResponseBody">Response body type</typeparam>
    [DataContract]
    public abstract class BaseResponseEnvelope<TResponseBody> : IResponseEnvelope<TResponseBody> where TResponseBody : class, new()
    {
        /// <summary>
        /// Gets or sets successfull response or not
        /// </summary>
        [DataMember(Name = "success")]
        public bool Success { get; set; }

        /// <summary>
        /// Gets or sets response body
        /// </summary>
        [DataMember(Name = "data")]
        public IList<TResponseBody> Data { get; set; } = new List<TResponseBody>();

        /// <summary>
        /// Gets first data value when response has successfull result and data has values quantity higher than zero
        /// </summary>
        [IgnoreDataMember]
        public TResponseBody FirstOrDefault
        {
            get
            {
                return Success && Data.Count > 0 ? Data[0] : null;
            }
        }
    }
}
