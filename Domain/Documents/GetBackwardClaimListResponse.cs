using System;
using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Documents
{
    /// <summary>
    /// Represents response of get backward claims list method.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/58ad7185eea27006cc36d649/operations/58b6cdc9eea2700d141ccae2
    /// </summary>
    [DataContract]
    public class GetBackwardClaimListResponse : BaseResponseEnvelope<GetBackwardClaimListResponse.BackwardClaim>
    {
        /// <summary>
        /// Represents backward claim response item
        /// </summary>
        [DataContract]
        public class BackwardClaim
        {
            /// <summary>
            /// Gets or sets claim reference key
            /// </summary>
            [DataMember]
            public Guid OrderRef { get; set; }

            /// <summary>
            /// Gets or sets claim friendly number
            /// </summary>
            [DataMember]
            public string OrderNumber { get; set; }

            /// <summary>
            /// Gets or sets claim status
            /// </summary>
            [DataMember]
            public string OrderStatus { get; set; }

            /// <summary>
            /// Gets or sets document tracking number
            /// </summary>
            [DataMember]
            public string DocumentNumber { get; set; }

            /// <summary>
            /// Gets or sets counterparty recipient
            /// </summary>
            [DataMember]
            public string CounterpartyRecipient { get; set; }

            /// <summary>
            /// Gets or sets counterparty recipient contact person
            /// </summary>
            [DataMember]
            public string ContactPersonRecipient { get; set; }

            /// <summary>
            /// Gets or sets recipient address
            /// </summary>
            [DataMember]
            public string AddressRecipient { get; set; }

            /// <summary>
            /// Gets or sets backward delivery cost
            /// </summary>
            [DataMember]
            public decimal DeliveryCost { get; set; }

            /// <summary>
            /// Gets or sets estimated delivery date
            /// </summary>
            [DataMember]
            public DateTime? EstimatedDeliveryDate { get; set; }

            /// <summary>
            /// Gets or sets backward document tracking number
            /// </summary>
            [DataMember]
            public string ExpressWaybillNumber { get; set; }

            /// <summary>
            /// Gets or sets backward document status
            /// </summary>
            [DataMember]
            public string ExpressWaybillStatus { get; set; }
        }
    }
}
