using System;
using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Documents
{
    /// <summary>
    /// Represents get change requests list response.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/59eef733ff2c200ce4f6f904/operations/59eefd36eea2700b202b9c45
    /// </summary>
    [DataContract]
    public class GetChangeRequestsListResponse : BaseResponseEnvelope<GetChangeRequestsListResponse.ChangesRequest>
    {
        /// <summary>
        /// Represents changes request
        /// </summary>
        [DataContract]
        public class ChangesRequest
        {
            /// <summary>
            /// Gets or sets change request reference key
            /// </summary>
            [DataMember]
            public Guid OrderRef { get; set; }

            /// <summary>
            /// Gets or sets change request unique number
            /// </summary>
            [DataMember]
            public string OrderNumber { get; set; }

            /// <summary>
            /// Gets or sets request status
            /// </summary>
            [DataMember]
            public string OrderStatus { get; set; }

            /// <summary>
            /// Gets or sets internet document number
            /// </summary>
            [DataMember]
            public string DocumentNumber { get; set; }

            /// <summary>
            /// Gets or sets request creation date
            /// </summary>
            [DataMember]
            public DateTime CreateDate { get; set; }

            /// <summary>
            /// Gets or sets sender counterparty before changes
            /// </summary>
            [DataMember]
            public string BeforeChangeSenderCounterparty { get; set; }

            /// <summary>
            /// Gets or sets sender counterparty after changes
            /// </summary>
            [DataMember]
            public string AfterChangeChangeSenderCounterparty { get; set; }

            /// <summary>
            /// Gets or sets document cost
            /// </summary>
            [DataMember]
            public decimal Cost { get; set; }

            /// <summary>
            /// Gets or sets sender phone before changes
            /// </summary>
            [DataMember]
            public string BeforeChangeSenderPhone { get; set; }

            /// <summary>
            /// Gets or sets sender phone after changes
            /// </summary>
            [DataMember]
            public string AfterChangeSenderPhone { get; set; }
        }
    }
}
