using System.Collections.Generic;

namespace Baroque.NovaPoshta.Client.Domain
{
    /// <summary>
    /// Represents base nova poshta response interface
    /// </summary>
    /// <typeparam name="TResponse"></typeparam>
    public interface IResponseEnvelope<TResponse> : IBaseResponseEnvelope<IList<TResponse>>
        //where TResponse : class, new()
    {
        /// <summary>
        /// Gets first data value if response has success result and data has values quantity higher than zero
        /// </summary>
        TResponse FirstOrDefault { get; }
    }
}
