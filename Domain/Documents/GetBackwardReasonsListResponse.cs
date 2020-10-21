using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Documents
{
    /// <summary>
    /// Represents backward reasons list response.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/58ad7185eea27006cc36d649/operations/58b6cd6aeea2700d141ccae1
    /// </summary>
    [DataContract]
    public class GetBackwardReasonsListResponse : BaseResponseEnvelope<GetBackwardReasonsListResponse.BackwardReason>
    {
        /// <summary>
        /// Represents backward reason
        /// </summary>
        [DataContract]
        public class BackwardReason : BaseRefItem
        {
            /// <summary>
            /// Gets or sets backward reason description
            /// </summary>
            [DataMember]
            public string Description { get; set; }
        }
    }
}
