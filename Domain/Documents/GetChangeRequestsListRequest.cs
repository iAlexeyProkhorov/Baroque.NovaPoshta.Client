using System;
using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Documents
{
    /// <summary>
    /// Represents get change requests list request.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/59eef733ff2c200ce4f6f904/operations/59eefd36eea2700b202b9c45
    /// </summary>
    [DataContract]
    public class GetChangeRequestsListRequest
    {
        /// <summary>
        /// Gets or sets searching request number
        /// </summary>
        [DataMember]
        public string Number { get; set; }

        /// <summary>
        /// Gets or sets searching request reference key
        /// </summary>
        [DataMember]
        public Guid? Ref { get; set; }

        /// <summary>
        /// Gets or sets request searching start date. Format: dd.MM.yyyy
        /// </summary>
        [DataMember]
        public string BeginDate { get; set; }

        /// <summary>
        /// Gets or sets request searching end date. Format: dd.MM.yyyy
        /// </summary>
        [DataMember]
        public string EndDate { get; set; }

        /// <summary>
        /// Gets or sets page number
        /// </summary>
        [DataMember]
        public int Page { get; set; }

        /// <summary>
        /// Gets or sets request quantity per page
        /// </summary>
        [DataMember]
        public int Limit { get; set; }
    }
}
