using System;
using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Documents
{
    /// <summary>
    /// Represents get backward subreasons response.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/58ad7185eea27006cc36d649/operations/58b6cdb2ff2c200cd80adb92
    /// </summary>
    [DataContract]
    public class GetBackwardSubreasonsListResponse : BaseResponseEnvelope<GetBackwardSubreasonsListResponse.BackwardSubreason>
    {
        /// <summary>
        /// Represents backward subreason
        /// </summary>
        [DataContract]
        public class BackwardSubreason : BaseRefItem
        {
            /// <summary>
            /// Gets or sets backward reason reference key
            /// </summary>
            [DataMember]
            public Guid ReasonRef { get; set; }

            /// <summary>
            /// Gets or sets backward subreason description
            /// </summary>
            [DataMember]
            public string Description { get; set; }
        }
    }
}
