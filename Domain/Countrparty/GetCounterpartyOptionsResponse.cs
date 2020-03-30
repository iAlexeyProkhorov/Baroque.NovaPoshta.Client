using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Countrparty
{
    /// <summary>
    /// Represents 'getCounterpartyOptions' method response of 'Counterparty' model.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/557eb8c8a0fe4f02fc455b2d/operations/55801976a0fe4f105c087614
    /// </summary>
    [DataContract]
    public class GetCounterpartyOptionsResponse: BaseResponseEnvelope<GetCounterpartyOptionsResponse.CounterpartyOptions>
    {
        /// <summary>
        /// Represents counterparty options
        /// </summary>
        [DataContract]
        public class CounterpartyOptions
        {
            /// <summary>
            /// Gets or sets warranty
            /// </summary>
            [DataMember]
            public bool FillingWarranty { get; set; }

            /// <summary>
            /// Gets or sets is 3rd person payer
            /// </summary>
            [DataMember]
            public bool CanPayTheThirdPerson { get; set; }

            /// <summary>
            /// Gets or sets payment control
            /// </summary>
            [DataMember]
            public bool CanAfterpaymentOnGoodsCost { get; set; }

            /// <summary>
            /// Gets or sets can use non cash payment
            /// </summary>
            [DataMember]
            public bool CanNonCashPayment { get; set; }

            /// <summary>
            /// Gets or sets can credit documents
            /// </summary>
            [DataMember]
            public bool CanCreditdocuments { get; set; }

            /// <summary>
            /// Gets or sets hide delivery cost
            /// </summary>
            [DataMember]
            public bool HideDeliveryCost { get; set; }

            /// <summary>
            /// Gets or sets can same day delivery
            /// </summary>
            [DataMember]
            public bool CanSameDayDelivery { get; set; }

            /// <summary>
            /// Gets or sets can forwarding service
            /// </summary>
            [DataMember]
            public bool CanForwardingService { get; set; }

            /// <summary>
            /// Gets or sets show delivery by hand
            /// </summary>
            [DataMember]
            public bool ShowDeliveryByHand { get; set; }

            /// <summary>
            /// Gets or sets delivery by hand
            /// </summary>
            [DataMember]
            public bool DeliveryByHand { get; set; }

            /// <summary>
            /// Gets or sets descent from floor
            /// </summary>
            [DataMember]
            public bool DescentFromFloor { get; set; }

            /// <summary>
            /// Gets or sets back delivery valuable papers
            /// </summary>
            [DataMember]
            public bool BackDeliveryValuablePapers { get; set; }

            /// <summary>
            /// Gets or sets back delivery subtype documents
            /// </summary>
            [DataMember]
            public bool BackwardDeliverySubtypesDocuments { get; set; }

            /// <summary>
            /// Gets or sets afterpayment type
            /// </summary>
            [DataMember]
            public string AfterpaymentType { get; set; }

            /// <summary>
            /// Gets or sets address document delivery
            /// </summary>
            [DataMember]
            public bool AddressDocumentDelivery { get; set; }

            /// <summary>
            /// Gets or sets block internation sender 
            /// </summary>
            [DataMember]
            public bool BlockInternationalSenderLKK { get; set; }

            /// <summary>
            /// Gets or sets partial return availability
            /// </summary>
            [DataMember]
            public bool PartialReturn { get; set; }

            /// <summary>
            /// Gets or sets debtor
            /// </summary>
            [DataMember]
            public bool Debtor { get; set; }

            /// <summary>
            /// Gets or sets can...
            /// </summary>
            [DataMember]
            public bool CanEWTransporter { get; set; }

            /// <summary>
            /// Gets or sets can same day delivery standart
            /// </summary>
            [DataMember]
            public bool CanSameDayDeliveryStandart { get; set; }

            /// <summary>
            /// Gets or sets credit documents
            /// </summary>
            [DataMember]
            public bool CreditDocuments { get; set; }

            /// <summary>
            /// Gets or sets signed documents
            /// </summary>
            [DataMember]
            public bool SignedDocuments { get; set; }

            /// <summary>
            /// Gets or sets services
            /// </summary>
            [DataMember]
            public bool Services { get; set; }

            /// <summary>
            /// Gets or sets loyalty program
            /// </summary>
            [DataMember]
            public bool LoyaltyProgram { get; set; }

            /// <summary>
            /// Gets or sets have money wallets
            /// </summary>
            [DataMember]
            public bool HaveMoneyWallets { get; set; }
        }
    }
}
