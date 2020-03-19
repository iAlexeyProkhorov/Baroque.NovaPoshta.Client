using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain
{
    /// <summary>
    /// Represents one of possible 'Nova Poshta' response interface.
    /// Unfortunately this API has no one common response body for all requests. Some times they use string arrays, some times some strange types, which aren't described in documentation.
    /// We add this interface to allow you create your own response envelope to see response errors, warnings, info and other data.
    /// </summary>
    public interface IResponseEnvelopeDescription
    {
        /// <summary>
        /// Gets or sets response errors list
        /// </summary>
        [DataMember(Name = "errors")]
        string[] Errors { get; set; }

        /// <summary>
        /// Gets or sets response warning list
        /// </summary>
        [DataMember(Name = "warnings")]
        string[] Warnings { get; set; }

        /// <summary>
        /// Gets or sets response additional information
        /// </summary>
        [DataMember(Name = "info")]
        string[] Info { get; set; }
    }
}
