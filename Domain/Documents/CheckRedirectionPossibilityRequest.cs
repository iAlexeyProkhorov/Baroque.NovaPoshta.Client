using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Documents
{
    /// <summary>
    /// Represents document redirection possibility request.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/58f722b3ff2c200c04673bd1/operations/58f7233eff2c200c04673bd2
    /// </summary>
    [DataContract]
    public class CheckRedirectionPossibilityRequest
    {
        /// <summary>
        /// Gets or sets document tracking number
        /// </summary>
        [DataMember]
        public string Number { get; set; }
    }
}
