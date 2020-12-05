using System;
using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Documents
{
    /// <summary>
    /// Represents document redirection possibility response.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/58f722b3ff2c200c04673bd1/operations/58f7233eff2c200c04673bd2
    /// </summary>
    [DataContract]
    public class CheckRedirectionPossibilityResponse: BaseResponseEnvelope<CheckRedirectionPossibilityResponse.ResponseItem>
    {
        /// <summary>
        /// Gets or sets request processing errors
        /// </summary>
        [DataMember]
        public string[] Errors { get; set; } = new string[0];

        /// <summary>
        /// Represents check redirection possibility response item
        /// </summary>
        [DataContract]
        public class ResponseItem : BaseRefItem
        {
            /// <summary>
            /// Gets or sets document tracking number
            /// </summary>
            [DataMember]
            public string Number { get; set; }

            /// <summary>
            /// Gets or sets payer type
            /// </summary>
            [DataMember]
            public string PayerType { get; set; }

            /// <summary>
            /// Gets or sets payment method reference
            /// </summary>
            [DataMember]
            public string PaymentMethod { get; set; }

            /// <summary>
            /// Gets or sets warehouse reference key
            /// </summary>
            [DataMember]
            public Guid WarehouseRef { get; set; }

            /// <summary>
            /// Gets or sets warehouse description
            /// </summary>
            [DataMember]
            public string WarehouseDescription { get; set; }

            /// <summary>
            /// Gets or sets address description
            /// </summary>
            [DataMember]
            public string AddressDescription { get; set; }

            /// <summary>
            /// Gets or sets street description
            /// </summary>
            [DataMember]
            public string StreetDescription { get; set; }

            /// <summary>
            /// Gets or sets house number
            /// </summary>
            [DataMember]
            public string BuildingNumber { get; set; }

            /// <summary>
            /// Gets or sets recipeint city reference key
            /// </summary>
            [DataMember]
            public Guid? CityRecipient { get; set; }

            /// <summary>
            /// Gets or sets recipeint city description
            /// </summary>
            [DataMember]
            public string CityRecipientDescription { get; set; }

            /// <summary>
            /// Gets or sets recipient city reference key
            /// </summary>
            [DataMember]
            public Guid? SettlementRecipient { get; set; }

            /// <summary>
            /// Gets or sets recipient settlement description
            /// </summary>
            [DataMember]
            public string SettlementRecipientDescription { get; set; }

            /// <summary>
            /// Gets or sets settlement type reference key
            /// </summary>
            [DataMember]
            public Guid? SettlementType { get; set; }

            /// <summary>
            /// Gets or sets counterparty recipient reference key
            /// </summary>
            [DataMember]
            public Guid CounterpartyRecipientRef { get; set; }

            /// <summary>
            /// Gets or sets counterparty recipient description
            /// </summary>
            [DataMember]
            public string CounterpartyRecipientDescription { get; set; }

            /// <summary>
            /// Gets or sets recipient name
            /// </summary>
            [DataMember]
            public string RecipientName { get; set; }

            /// <summary>
            /// Gets or sets sender phone number
            /// </summary>
            [DataMember]
            public string PhoneSender { get; set; }

            /// <summary>
            /// Gets or sets recipient phone number
            /// </summary>
            [DataMember]
            public string PhoneRecipient { get; set; }

            /// <summary>
            /// Gets or sets package weight
            /// </summary>
            [DataMember]
            public decimal DocumentWeight { get; set; }
        }
    }
}
