using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Documents
{
    /// <summary>
    /// Represents delete redirection claim response.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/58f722b3ff2c200c04673bd1/operations/58f7237bff2c200c04673bd4
    /// </summary>
    [DataContract]
    public class DeleteRedirectionClaimResponse : BaseResponseEnvelope<DeleteRedirectionClaimResponse.ResponseItem>
    {
        /// <summary>
        /// Represents response item
        /// </summary>
        [DataContract]
        public class ResponseItem : BaseRefItem
        {
            /// <summary>
            /// Gets or sets claim friendly number
            /// </summary>
            [DataMember]
            public string Number { get; set; }
        }
    }
}
