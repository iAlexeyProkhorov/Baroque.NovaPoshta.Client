using System;
using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Tracking
{
    /// <summary>
    /// Represents 'getStatusDocuments' method response.
    /// https://developers.novaposhta.ua/view/model/a99d2f28-8512-11ec-8ced-005056b2dbe1/method/a9ae7bc9-8512-11ec-8ced-005056b2dbe1
    /// </summary>
    [DataContract]
    public class GetStatusDocumentResponse : BaseResponseEnvelope<GetStatusDocumentResponse.TrackingDocument>
    {
        /// <summary>
        /// Gets or sets request processing errors
        /// </summary>
        [DataMember(Name = "errors")]
        public string[] Errors { get; set; } = new string[0];

        /// <summary>
        /// Gets or sets request processing information
        /// </summary>
        [DataMember(Name = "info")]
        public string[] Information { get; set; } = new string[0];

        /// <summary>
        /// Represents tracking document for 'getStatusDocuments' method response.
        /// </summary>
        [DataContract]
        public class TrackingDocument
        {
            /// <summary>
            /// Gets or sets tracking document reference number
            /// </summary>
            [DataMember(Name = "RefEW")]
            public Guid Reference { get; set; }

            /// <summary>
            /// Gets or sets package return availability.
            /// </summary>
            [DataMember]
            public bool PossibilityCreateReturn { get; set; }

            /// <summary>
            /// Gets or sets package cancellation availability.
            /// </summary>
            [DataMember]
            public bool PossibilityCreateRefusal { get; set; }

            /// <summary>
            /// Gets or sets document information changes availability.
            /// </summary>
            [DataMember]
            public bool PossibilityChangeEW { get; set; }

            /// <summary>
            /// Gets or sets package address change availability.
            /// </summary>
            [DataMember]
            public bool PossibilityCreateRedirecting { get; set; }

            /// <summary>
            /// Gets or sets document tracking number
            /// </summary>
            [DataMember]
            public string Number { get; set; }

            /// <summary>
            /// Gets or sets redelivery flag. 0 - no redeliver, 1 - redelivery available
            /// </summary>
            [DataMember]
            public int Redelivery { get; set; }

            /// <summary>
            /// Gets or sets redelivery amount.
            /// </summary>
            [DataMember]
            public string RedeliverySum { get; set; }

            /// <summary>
            /// Gets or sets redelivery document tracking number.
            /// </summary>
            [DataMember]
            public string RedeliveryNum { get; set; }

            /// <summary>
            /// Gets or sets redelivery payer identifier.
            /// </summary>
            [DataMember]
            public string RedeliveryPayer { get; set; }

            /// <summary>
            /// Gets or sets owner document type. I don't know does it means.
            /// </summary>
            [DataMember]
            public string OwnerDocumentType { get; set; }

            /// <summary>
            /// Gets or sets latest document type changes.
            /// </summary>
            [DataMember]
            public string LastCreatedOnTheBasisDocumentType { get; set; }

            /// <summary>
            /// Gets or sets latest payer type changes.
            /// </summary>
            [DataMember]
            public string LastCreatedOnTheBasisPayerType { get; set; }

            /// <summary>
            /// Gets or sets latest creation date changes.
            /// </summary>
            [DataMember]
            public string LastCreatedOnTheBasisDateTime { get; set; }

            /// <summary>
            /// Gets or sets latest status of money transfer.
            /// </summary>
            [DataMember]
            public string LastTransactionStatusGM { get; set; }

            /// <summary>
            /// Gets or sets date & time of money transfer.
            /// </summary>
            [DataMember]
            public string LastTransactionDateTimeGM { get; set; }

            /// <summary>
            /// Gets or sets money transfer value.
            /// </summary>
            [DataMember]
            public string LastAmountTransferGM { get; set; }

            /// <summary>
            /// Gets or sets document creation date.
            /// </summary>
            [DataMember]
            public string DateCreated { get; set; }

            /// <summary>
            /// Gets or sets package weight
            /// </summary>
            [DataMember]
            public decimal DocumentWeight { get; set; }

            /// <summary>
            /// Gets or sets package factual weight with document 
            /// </summary>
            [DataMember]
            public decimal FactualWeight { get; set; }

            /// <summary>
            /// Gets or sets package volume weight
            /// </summary>
            [DataMember]
            public decimal VolumeWeight { get; set; }

            /// <summary>
            /// Gets or sets weight control value
            /// </summary>
            [DataMember]
            public decimal CheckWeight { get; set; }

            /// <summary>
            /// Get or sets check weight method
            /// </summary>
            [DataMember]
            public string CheckWeightMethod { get; set; }

            /// <summary>
            /// Gets or sets calculated weight
            /// </summary>
            [DataMember]
            public decimal? CalculatedWeight { get; set; }

            /// <summary>
            /// Gets or sets information before weighing
            /// </summary>
            [DataMember]
            public decimal SumBeforeCheckWeight { get; set; }

            /// <summary>
            /// Gets or sets document delivery cost
            /// </summary>
            [DataMember]
            public decimal DocumentCost { get; set; }

            /// <summary>
            /// Get or sets payer type code
            /// </summary>
            [DataMember]
            public string PayerType { get; set; }

            /// <summary>
            /// Get or sets recipient full name. Available with phone number.
            /// </summary>
            [DataMember]
            public string RecipientFullName { get; set; }

            /// <summary>
            /// Gets or sets date & time when recipient gets package
            /// </summary>
            [DataMember]
            public string RecipientDateTime { get; set; }

            /// <summary>
            /// Gets or sets package schedule delivery date
            /// </summary>
            [DataMember]
            public string ScheduledDeliveryDate { get; set; }

            /// <summary>
            /// Gets or sets payment method code
            /// </summary>
            [DataMember]
            public string PaymentMethod { get; set; }

            /// <summary>
            /// Gets or sets cargo description
            /// </summary>
            [DataMember]
            public string CargoDescriptionString { get; set; }

            /// <summary>
            /// Gets or sets cargo type code
            /// </summary>
            [DataMember]
            public string CargoType { get; set; }

            /// <summary>
            /// Gets or sets city name from where package sends
            /// </summary>
            [DataMember]
            public string CitySender { get; set; }

            /// <summary>
            /// Gets or sets city name where package will arive
            /// </summary>
            [DataMember]
            public string CityRecipient { get; set; }

            /// <summary>
            /// Gets or sets recipient warehouse name
            /// </summary>
            [DataMember]
            public string WarehouseRecipient { get; set; }

            /// <summary>
            /// Gets or sets counterparty type code
            /// </summary>
            [DataMember]
            public string CounterpartyType { get; set; }

            /// <summary>
            /// Gets or sets payment control
            /// </summary>
            [DataMember]
            public string AfterpaymentOnGoodsCost { get; set; }

            /// <summary>
            /// Gets or sets service type code
            /// </summary>
            [DataMember]
            public string ServiceType { get; set; }

            /// <summary>
            /// Gets or sets undelivery reason. When recipient don't wants to open package.
            /// </summary>
            [DataMember]
            public string UndeliveryReasonsSubtypeDescription { get; set; }

            /// <summary>
            /// Gets or sets recipient warehouse number
            /// </summary>
            [DataMember]
            public int WarehouseRecipientNumber { get; set; }

            /// <summary>
            /// Gets or sets latest changes in document number
            /// </summary>
            [DataMember]
            public string LastCreatedOnTheBasisNumber { get; set; }

            /// <summary>
            /// Gets or sets recipient phone number
            /// </summary>
            [DataMember]
            public string PhoneRecipient { get; set; }

            /// <summary>
            /// Gets or sets recipient full name. Displays value when document phone number is set at request.
            /// </summary>
            [DataMember()]
            public string RecipientFullNameEW { get; set; }

            /// <summary>
            /// Gets or sets recipeint warehouse reference number
            /// </summary>
            [DataMember]
            public Guid WarehouseRecipientInternetAddressRef { get; set; }

            /// <summary>
            /// Gets or sets marketplace token
            /// </summary>
            [DataMember]
            public string MarketplacePartnerToken { get; set; }

            /// <summary>
            /// Gets or sets client internal order number.
            /// </summary>
            [DataMember]
            public string ClientBarcode { get; set; }

            /// <summary>
            /// Gets or sets recipient address
            /// </summary>
            [DataMember]
            public string RecipientAddress { get; set; }

            /// <summary>
            /// Gets or sets recipient counterparty description
            /// </summary>
            [DataMember]
            public string CounterpartyRecipientDescription { get; set; }

            /// <summary>
            /// Gets or sets counterparty sender type code
            /// </summary>
            [DataMember]
            public string CounterpartySenderType { get; set; }

            /// <summary>
            /// Gets or sets scanning date. Date when package was scan for status change.
            /// </summary>
            [DataMember]
            public string DateScan { get; set; }

            /// <summary>
            /// Gets or sets payment status. For internet acquiring
            /// </summary>
            [DataMember]
            public string PaymentStatus { get; set; }

            /// <summary>
            /// Gets or sets internet acquiring date
            /// </summary>
            [DataMember]
            public string PaymentStatusDate { get; set; }

            /// <summary>
            /// Gets or sets payment amount for internet acquiring
            /// </summary>
            [DataMember]
            public string AmountToPay { get; set; }

            /// <summary>
            /// Gets or sets internet acquiring payment amount
            /// </summary>
            [DataMember]
            public string AmountPaid { get; set; }

            /// <summary>
            /// Gets or sets document status description
            /// </summary>
            [DataMember]
            public string Status { get; set; }

            /// <summary>
            /// Gets or sets document status code
            /// </summary>
            [DataMember]
            public int StatusCode { get; set; }

            /// <summary>
            /// Gets or sets information for unstandard backward type
            /// </summary>
            [DataMember]
            public string BackwardDeliverySubTypesActions { get; set; }

            /// <summary>
            /// Gets or sets information for unstandard backward type
            /// </summary>
            [DataMember]
            public string BackwardDeliverySubTypesServices { get; set; }

            /// <summary>
            /// Gets or sets undelivery reason
            /// </summary>
            [DataMember]
            public string UndeliveryReasons { get; set; }

            /// <summary>
            /// Gets or sets date when storage became to paying.
            /// </summary>
            [DataMember]
            public DateTime DatePayedKeeping { get; set; }

            /// <summary>
            /// Gets or sets international delivery type
            /// </summary>
            [DataMember]
            public string InternationalDeliveryType { get; set; }

            /// <summary>
            /// Gets or sets package seats amount
            /// </summary>
            [DataMember]
            public int SeatsAmount { get; set; }

            /// <summary>
            /// Gets or sets masked number of payment card
            /// </summary>
            [DataMember]
            public string CardMaskedNumber { get; set; }

            /// <summary>
            /// Gets or sets invoice payment status
            /// </summary>
            [DataMember]
            public string ExpressWaybillPaymentStatus { get; set; }

            /// <summary>
            /// Gets or sets invoice payment amount
            /// </summary>
            [DataMember]
            public string ExpressWaybillAmountToPay { get; set; }

            /// <summary>
            /// Gets or sets sender phone number
            /// </summary>
            [DataMember]
            public string PhoneSender { get; set; }

            /// <summary>
            /// Gets or sets updated tracking date
            /// </summary>
            [DataMember]
            public DateTime? TrackingUpdateDate { get; set; }

            /// <summary>
            /// Gets or sets sender warehouse description
            /// </summary>
            [DataMember]
            public string WarehouseSender { get; set; }

            /// <summary>
            /// Gets or sets cargo turns back by this date
            /// </summary>
            [DataMember]
            public string DateReturnCargo { get; set; }

            /// <summary>
            /// Gets or sets moning date
            /// </summary>
            [DataMember]
            public string DateMoving { get; set; }

            /// <summary>
            /// Gets or sets storage first day date. I don't know why, but this date equals date when package became pay.
            /// </summary>
            [DataMember]
            public DateTime? DateFirstDayStorage { get; set; }

            /// <summary>
            /// Gets or sets recipient city reference number
            /// </summary>
            [DataMember]
            public Guid RefCityRecipient { get; set; }

            /// <summary>
            /// Gets or sets sender city reference number
            /// </summary>
            [DataMember]
            public Guid RefCitySender { get; set; }

            /// <summary>
            /// Gets or sets recipient settlement reference number
            /// </summary>
            [DataMember]
            public Guid RefSettlementRecipient { get; set; }

            /// <summary>
            /// Gets or sets sender settlement reference number
            /// </summary>
            [DataMember]
            public Guid RefSettlementSender { get; set; }

            /// <summary>
            /// Gets or sets sender address
            /// </summary>
            [DataMember]
            public string SenderAddress { get; set; }

            /// <summary>
            /// Gets or sets sender full name
            /// </summary>
            [DataMember]
            public string SenderFullNameEW { get; set; }

            /// <summary>
            /// Gets or sets announced price
            /// </summary>
            [DataMember]
            public string AnnouncedPrice { get; set; }

            /// <summary>
            /// Gets or sets some edditional information about package
            /// </summary>
            [DataMember]
            public string AdditionalInformationEW { get; set; }

            /// <summary>
            /// Gets or sets actual delivery date
            /// </summary>
            [DataMember]
            public DateTime? ActualDeliveryDate { get; set; }

            /// <summary>
            /// Gets or sets book postomat cell number. Int postmat usage cases
            /// </summary>
            [DataMember]
            public string PostomatV3CellReservationNumber { get; set; }

            /// <summary>
            /// Gets or sets owner document number
            /// </summary>
            [DataMember]
            public string OwnerDocumentNumber { get; set; }

            /// <summary>
            /// Gets or sets last payment commision amount
            /// </summary>
            [DataMember]
            public decimal LastAmountReceivedCommissionGM { get; set; }

            /// <summary>
            /// Gets or sets delivery time frame
            /// </summary>
            [DataMember]
            public string DeliveryTimeframe { get; set; }

            /// <summary>
            /// Gets or sets document created on basis
            /// </summary>
            [DataMember]
            public string CreatedOnTheBasis { get; set; }

            /// <summary>
            /// Gets or sets undelivery reason date
            /// </summary>
            [DataMember]
            public string UndeliveryReasonsDate { get; set; }

            /// <summary>
            /// Gets or sets recipient warehouse type reference number
            /// </summary>
            [DataMember]
            public Guid RecipientWarehouseTypeRef { get; set; }

            /// <summary>
            /// Gets or sets recipient warehouse reference number
            /// </summary>
            [DataMember]
            public Guid WarehouseRecipientRef { get; set; }

            /// <summary>
            /// Gets or sets warehouse category code
            /// </summary>
            [DataMember]
            public string CategoryOfWarehouse { get; set; }

            /// <summary>
            /// Gets or sets recipient warehouse address
            /// </summary>
            [DataMember]
            public string WarehouseRecipientAddress { get; set; }

            /// <summary>
            /// Gets or sets sender warehouse address reference
            /// </summary>
            [DataMember]
            public Guid WarehouseSenderInternetAddressRef { get; set; }

            /// <summary>
            /// Gets or sets sender warehouse address
            /// </summary>
            [DataMember]
            public string WarehouseSenderAddress { get; set; }

            /// <summary>
            /// Gets or sets delivery by airlines
            /// </summary>
            [DataMember]
            public int AviaDelivery { get; set; }

            /// <summary>
            /// Gets or sets redbox barcode
            /// </summary>
            [DataMember]
            public string BarcodeRedBox { get; set; }

            /// <summary>
            /// Gets or sets cargo refusal return flag. Backward cancellation.
            /// </summary>
            [DataMember]
            public bool CargoReturnRefusal { get; set; }

            /// <summary>
            /// Gets or sets cargo storage day
            /// </summary>
            [DataMember]
            public string DaysStorageCargo { get; set; }

            /// <summary>
            /// Gets or sets 
            /// </summary>
            [DataMember]
            public string[] Packaging { get; set; } = new string[0];

            /// <summary>
            /// Gets or sets partial backward
            /// </summary>
            [DataMember]
            public string[] PartialReturnGoods { get; set; } = new string[0];

            /// <summary>
            /// Gets or sets secure payment flag
            /// </summary>
            [DataMember]
            public bool SecurePayment { get; set; }

            /// <summary>
            /// Gets or sets possibility to change payment on card
            /// </summary>
            [DataMember]
            public bool PossibilityChangeCash2Card { get; set; }

            /// <summary>
            /// Gets or sets possibility to change delivery intervals
            /// </summary>
            [DataMember]
            public bool PossibilityChangeDeliveryIntervals { get; set; }

            /// <summary>
            /// Gets or sets possibility to changes storage period
            /// </summary>
            [DataMember]
            public bool PossibilityTermExtensio { get; set; }

            /// <summary>
            /// Gets or sets storage days amount
            /// </summary>
            [DataMember]
            public string StorageAmount { get; set; }

            /// <summary>
            /// Gets or sets storage price
            /// </summary>
            [DataMember]
            public string StoragePrice { get; set; }

            /// <summary>
            /// Gets or sets free shipping sign
            /// </summary>
            [DataMember]
            public string FreeShipping { get; set; }

            /// <summary>
            /// Gets or sets recipeint loyalty card number
            /// </summary>
            [DataMember]
            public string LoyaltyCardRecipient { get; set; }

            public override string ToString()
            {
                return $"{Number} - {CityRecipient} - {WarehouseRecipient}";
            }
        }
    }
}
