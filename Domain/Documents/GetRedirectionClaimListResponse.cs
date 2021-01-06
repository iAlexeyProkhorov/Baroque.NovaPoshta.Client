using System;
using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Documents
{
    /// <summary>
    /// Represents get redirection claims list method response.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/58f722b3ff2c200c04673bd1/operations/58f72396ff2c200c04673bd5
    /// </summary>
    [DataContract]
    public class GetRedirectionClaimListResponse : BaseResponseEnvelope<GetRedirectionClaimListResponse.RedirectionClaimItem>
    {
        /// <summary>
        /// Represents redirection claim item
        /// </summary>
        [DataContract]
        public class RedirectionClaimItem
        {
            /// <summary>
            /// Gets or sets redirection claim reference key
            /// </summary>
            [DataMember]
            public Guid OrderRef { get; set; }

            /// <summary>
            /// Gets or sets redirection claim number
            /// </summary>
            [DataMember]
            public string OrderNumber { get; set; }

            /// <summary>
            /// Gets or sets redirection claim creation date
            /// </summary>
            [DataMember]
            public DateTime DateTime { get; set; }

            /// <summary>
            /// Gets or sets redirection claim document tracking number
            /// </summary>
            [DataMember]
            public string DocumentNumber { get; set; }

            /// <summary>
            /// Gets or sets notes
            /// </summary>
            [DataMember]
            public string Note { get; set; }

            /// <summary>
            /// Gets or sets recipient city
            /// </summary>
            [DataMember]
            public string CityRecipient { get; set; }

            /// <summary>
            /// Gets or sets recipient address
            /// </summary>
            [DataMember]
            public string RecipientAddress { get; set; }

            /// <summary>
            /// Gets or sets counterparty recipient type description
            /// </summary>
            [DataMember]
            public string CounterpartyRecipient { get; set; }

            /// <summary>
            /// Gets or sets recipeint full name
            /// </summary>
            [DataMember]
            public string RecipientName { get; set; }

            /// <summary>
            /// Gets or sets recipeint phone number
            /// </summary>
            [DataMember]
            public string PhoneRecipient { get; set; }

            /// <summary>
            /// Gets or sets payer type reference
            /// </summary>
            [DataMember]
            public string PayerType { get; set; }

            /// <summary>
            /// Gets or sets delivery cost
            /// </summary>
            [DataMember]
            public decimal DeliveryCost { get; set; }

            /// <summary>
            /// Gets or sets estimated delivery date
            /// </summary>
            [DataMember]
            public string EstimatedDeliveryDate { get; set; }

            /// <summary>
            /// Gets or sets express delivery tracking number
            /// </summary>
            [DataMember]
            public string ExpressWaybillNumber { get; set; }

            /// <summary>
            /// Gets or sets waybill status
            /// </summary>
            [DataMember]
            public string ExpressWaybillStatus { get; set; }
        }
    }
}
