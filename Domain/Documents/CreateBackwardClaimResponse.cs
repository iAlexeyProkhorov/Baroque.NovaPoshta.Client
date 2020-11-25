using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Documents
{
    /// <summary>
    /// Represents backward claim creation response. 
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/58ad7185eea27006cc36d649/operations/58b6d227ff2c200cd80adb94
    /// </summary>
    [DataContract]
    public class CreateBackwardClaimResponse : BaseResponseEnvelope<CreateBackwardClaimResponse.BackwardClaimCreationResult>
    {
        /// <summary>
        /// Gets or sets request processing errors
        /// </summary>
        [DataMember]
        public string[] Errors = new string[0];

        /// <summary>
        /// Represetnst backward claim creation result
        /// </summary>
        public class BackwardClaimCreationResult : BaseRefItem
        {
            /// <summary>
            /// Gets or sets backward claim friendly number
            /// </summary>
            [DataMember]
            public string Number { get; set; }
        }
    }
}
