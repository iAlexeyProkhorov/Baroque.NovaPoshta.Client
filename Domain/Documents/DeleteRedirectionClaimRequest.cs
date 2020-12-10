using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Documents
{
    /// <summary>
    /// Represents delete redirection claim request.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/58f722b3ff2c200c04673bd1/operations/58f7237bff2c200c04673bd4
    /// </summary>
    [DataContract]
    public class DeleteRedirectionClaimRequest: BaseRefItem
    {
        /// <summary>
        /// Gets or sets contant value
        /// </summary>
        [DataMember]
        public string OrderType { get; set; } = "orderRedirecting";
    }
}
