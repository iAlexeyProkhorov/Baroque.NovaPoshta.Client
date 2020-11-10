using System;
using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Documents
{
    /// <summary>
    /// Represents request to get backward claims list.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/58ad7185eea27006cc36d649/operations/58b6cdc9eea2700d141ccae2
    /// </summary>
    [DataContract]
    public class GetBackwardClaimListRequest
    {
        /// <summary>
        /// Gets or sets searching document tracking number
        /// </summary>
        [DataMember]
        public string Number { get; set; }

        /// <summary>
        /// Gets or sets searching document reference
        /// </summary>
        [DataMember]
        public Guid? Ref { get; set; }

        /// <summary>
        /// Gets or sets searching start date. In dd.MM.yyyy
        /// </summary>
        [DataMember]
        public string BeginDate { get; set; }

        /// <summary>
        /// Gets or sets searching end date. In dd.MM.yyyy
        /// </summary>
        [DataMember]
        public string EndDate { get; set; }

        /// <summary>
        /// Gets or sets page number
        /// </summary>
        [DataMember]
        public int Page { get; set; }

        /// <summary>
        /// Gets or sets items quantity per page.
        /// </summary>
        [DataMember]
        public int Limit { get; set; }
    }
}
