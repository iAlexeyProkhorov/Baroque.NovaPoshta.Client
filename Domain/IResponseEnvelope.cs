using System.Collections.Generic;

namespace Baroque.NovaPoshta.Client.Domain
{
    /// <summary>
    /// Represents base nova poshta response interface
    /// </summary>
    /// <typeparam name="TResponse"></typeparam>
    public interface IResponseEnvelope<TResponse> where TResponse : class, new()
    {
        /// <summary>
        /// Gets or sets successfull response or not
        /// </summary>
        bool Success { get; set; }

        /// <summary>
        /// Gets or sets response body
        /// </summary>
        TResponse[] Data { get; set; }

        /// <summary>
        /// Gets first data value if response has success result and data has values quantity higher than zero
        /// </summary>
        TResponse FirstOrDefault { get; }

        ///// <summary>
        ///// Gets or sets response errors descriptions
        ///// </summary>
        //string[] Errors { get; set; }

        ///// <summary>
        ///// Gets or sets warning descriptions
        ///// </summary>
        //string[] Warnings { get; set; }

        ///// <summary>
        ///// Gets or sets response information
        ///// </summary>
        //Information Information { get; set; }
    }
}
