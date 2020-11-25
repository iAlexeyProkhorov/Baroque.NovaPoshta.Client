using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Documents
{
    /// <summary>
    /// Represents delete backward method response.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/58ad7185eea27006cc36d649/operations/58b6cdf4ff2c200cd80adb93
    /// </summary>
    [DataContract]
    public class DeleteBackwardClaimResponse : BaseResponseEnvelope<DeleteBackwardClaimResponse.ResponseItem>
    {
        /// <summary>
        /// Represents delete backward claim method response item
        /// </summary>
        [DataContract]
        public class ResponseItem
        {
            /// <summary>
            /// Gets or sets backward claim number
            /// </summary>
            [DataMember]
            public string Number { get; set; }
        }
    }
}
