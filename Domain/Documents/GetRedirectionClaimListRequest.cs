using System;
using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Documents
{
    /// <summary>
    /// Represents get redirection claims list method request.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/58f722b3ff2c200c04673bd1/operations/58f72396ff2c200c04673bd5
    /// </summary>
    [DataContract]
    public class GetRedirectionClaimListRequest
    {
        /// <summary>
        /// Gets or sets redirection claim reference
        /// </summary>
        [DataMember(Name = "Ref")]
        public Guid? Reference { get; set; }

        /// <summary>
        /// Gets or sets redirection claim number
        /// </summary>
        [DataMember]
        public string Number { get; set; }

        /// <summary>
        /// Gets or sets from which system will search redirection claim. Format: dd.MM.yyyy
        /// </summary>
        [DataMember]
        public string BeginDate { get; set; }

        /// <summary>
        /// Gets or sets date before which system will search redirection claim. Format: dd.MM.yyyy
        /// </summary>
        [DataMember]
        public string EndDate { get; set; }

        /// <summary>
        /// Gets or sets claims list page number
        /// </summary>
        [DataMember]
        public int Page { get; set; }

        /// <summary>
        /// Gets or sets page size limit. 50 by default
        /// </summary>
        [DataMember]
        public int Limit { get; set; } = 50;
    }
}
