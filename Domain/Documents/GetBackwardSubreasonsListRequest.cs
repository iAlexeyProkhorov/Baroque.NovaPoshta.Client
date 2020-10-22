using System;
using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Documents
{
    /// <summary>
    /// Represents get backward subreasons request.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/58ad7185eea27006cc36d649/operations/58b6cdb2ff2c200cd80adb92
    /// </summary>
    [DataContract]
    public class GetBackwardSubreasonsListRequest
    {
        /// <summary>
        /// Gets or sets backward reason reference code
        /// </summary>
        [DataMember]
        public Guid ReasonRef { get; set; }
    }
}
