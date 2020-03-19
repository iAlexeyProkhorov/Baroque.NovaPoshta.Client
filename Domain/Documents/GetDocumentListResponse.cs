using System;
using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Documents
{
    /// <summary>
    /// Represents document for get documents list response of 'getDocumentsList' method of 'InternetDocument' model.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/556eef34a0fe4f02049c664e/operations/557eb417a0fe4f02fc455b2c
    /// </summary>
    [DataContract]
    public class GetDocumentListResponse : BaseResponseEnvelope<GetDocumentListResponse.Document>
    {
        /// <summary>
        /// Represents internet document
        /// </summary>
        [DataContract]
        public class Document : BaseRefItem
        {
            /// <summary>
            /// Gets or sets actual shipment date
            /// </summary>
            [DataMember]
            public DateTime DateTime { get; set; }

            /// <summary>
            /// Gets or sets preferred delivery date
            /// </summary>
            [DataMember]
            public string PreferredDeliveryDate { get; set; }

            /// <summary>
            /// Gets or sets actual weight
            /// </summary>
            [DataMember]
            public decimal Weight { get; set; }

            /// <summary>
            /// Gets or sets shipment seats quantity
            /// </summary>
            [DataMember]
            public int SeatsAmount { get; set; }

            /// <summary>
            /// Gets or sets shipment tracking number
            /// </summary>
            [DataMember]
            public string IntDocNumber { get; set; }

            /// <summary>
            /// Gets or sets shipment cost. Sets by shipment sender.
            /// </summary>
            [DataMember]
            public decimal Cost { get; set; }

            /// <summary>
            /// Gets or sets sender city reference key
            /// </summary>
            [DataMember]
            public Guid CitySender { get; set; }

            /// <summary>
            /// Gets or sets recipient city reference key
            /// </summary>
            [DataMember]
            public Guid CityRecipient { get; set; }

            /// <summary>
            /// Gets or sets package state reference key
            /// </summary>
            [DataMember]
            public Guid State { get; set; }

            /// <summary>
            /// Gets or sets sender address reference key
            /// </summary>
            [DataMember]
            public Guid SenderAddress { get; set; }

            /// <summary>
            /// Gets or sets recipient address reference key
            /// </summary>
            [DataMember]
            public Guid RecipientAddress { get; set; }

            /// <summary>
            /// Gets or sets delivery service cost
            /// </summary>
            [DataMember]
            public decimal CostOnSite { get; set; }

            /// <summary>
            /// Gets or sets delivery service payer type. Displays who will pay for delivery: Sender, recipient, third person.
            /// </summary>
            [DataMember]
            public string PayerType { get; set; }

            /// <summary>
            /// Gets or sets payment method. How can payer pay 'Nova Poshta' service work.
            /// </summary>
            [DataMember]
            public string PaymentMethod { get; set; }

            /// <summary>
            /// Gets or sets return shipping cost
            /// </summary>
            [DataMember]
            public decimal AfterpaymentOnGoodsCost { get; set; }

            /// <summary>
            /// Gets or sets your system internal package number
            /// </summary>
            [DataMember]
            public string PackingNumber { get; set; }

            /// <summary>
            /// Gets or sets shipment additional information
            /// </summary>
            [DataMember]
            public string AdditionalInformation { get; set; }

            /// <summary>
            /// Gets or sets loyalty card reference key
            /// </summary>
            [DataMember]
            public Guid? LoyaltyCard { get; set; }

            /// <summary>
            /// Gets or sets ...
            /// </summary>
            [DataMember]
            public string Posted { get; set; }

            /// <summary>
            /// Gets or sets ...
            /// </summary>
            [DataMember]
            public string Route { get; set; }

            /// <summary>
            /// Gets or sets ...
            /// </summary>
            [DataMember]
            public string DeletionMark { get; set; }

            /// <summary>
            /// Gets or sets cargo type name
            /// </summary>
            [DataMember]
            public string CargoType { get; set; }

            /// <summary>
            /// Gets or sets ...
            /// </summary>
            [DataMember]
            public string EWNumber { get; set; }

            /// <summary>
            /// Gets or sets ...
            /// </summary>
            [DataMember]
            public string SaturdayDelivery { get; set; }

            /// <summary>
            /// Gets or sets ...
            /// </summary>
            [DataMember]
            public string ExpressWaybill { get; set; }

            /// <summary>
            /// Gets or sets ...
            /// </summary>
            [DataMember]
            public string CarCall { get; set; }

            /// <summary>
            /// Gets or sets delivery date from ...
            /// </summary>
            [DataMember]
            public string DeliveryDateFrom { get; set; }

            /// <summary>
            /// Gets or sets ...
            /// </summary>
            [DataMember]
            public string Vip { get; set; }

            /// <summary>
            /// Gets or sets date of document lat modification
            /// </summary>
            [DataMember]
            public string LastModificationDate { get; set; }

            /// <summary>
            /// Gets or sets receipt date
            /// </summary>
            [DataMember]
            public string ReceiptDate { get; set; }

            /// <summary>
            /// Gets or sets redelivery
            /// </summary>
            [DataMember]
            public string Redelivery { get; set; }

            /// <summary>
            /// Gets or sets ...
            /// </summary>
            [DataMember]
            public string SaturdayDeliveryString { get; set; }

            /// <summary>
            /// Gets or sets note. May be 'Nova Poshta' administrator note.
            /// </summary>
            [DataMember]
            public string Note { get; set; }

            /// <summary>
            /// Gets or sets third person payer information
            /// </summary>
            [DataMember]
            public string ThirdPerson { get; set; }

            /// <summary>
            /// Gets or sets ...
            /// </summary>
            [DataMember]
            public string Forwarding { get; set; }

            /// <summary>
            /// Gets or sets number of floors to delivery shipment
            /// </summary>
            [DataMember]
            public string NumberOfFloorsLifting { get; set; }

            /// <summary>
            /// Gets or sets ...
            /// </summary>
            [DataMember]
            public string StatementOfAcceptanceTransferCargoID { get; set; }

            /// <summary>
            /// Gets or sets document state number. Using for document tracking.
            /// </summary>
            [DataMember]
            public int StateId { get; set; }

            /// <summary>
            /// Gets or sets document state name on Ukrainian.
            /// </summary>
            [DataMember]
            public string StateName { get; set; }

            /// <summary>
            /// Gets or sets receipt full name. Only already receipt shipments has this value.
            /// </summary>
            [DataMember]
            public string RecipientFullName { get; set; }

            /// <summary>
            /// Gets or sets ...
            /// </summary>
            [DataMember]
            public string RecipientPost { get; set; }

            /// <summary>
            /// Gets or sets receipt date & time. Only already receipt shipments has this value.
            /// </summary>
            [DataMember]
            public DateTime? RecipientDateTime { get; set; }

            /// <summary>
            /// Gets or sets rejection reason
            /// </summary>
            [DataMember]
            public string RejectionReason { get; set; }

            /// <summary>
            /// Gets or sets ...
            /// </summary>
            [DataMember]
            public string OnlineCreditStatus { get; set; }

            /// <summary>
            /// Gets or sets sender city name
            /// </summary>
            [DataMember]
            public string CitySenderDescription { get; set; }

            /// <summary>
            /// Gets or sets recipient city name
            /// </summary>
            [DataMember]
            public string CityRecipientDescription { get; set; }

            /// <summary>
            /// Gets or sets sender first name & last name. Also possible the middle name
            /// </summary>
            [DataMember]
            public string SenderDescription { get; set; }

            /// <summary>
            /// Gets or sets recipient first name & last name. Also possible the middle name
            /// </summary>
            [DataMember]
            public string RecipientDescription { get; set; }

            /// <summary>
            /// Gets or sets recipient contact phone number. In international format, without '+'
            /// </summary>
            [DataMember]
            public string RecipientContactPhone { get; set; }

            /// <summary>
            /// Gets or sets recipient contact person information
            /// </summary>
            [DataMember]
            public string RecipientContactPerson { get; set; }

            /// <summary>
            /// Gets or sets sender address
            /// </summary>
            [DataMember]
            public string SenderAddressDescription { get; set; }

            /// <summary>
            /// Gets or sets recipient address
            /// </summary>
            [DataMember]
            public string RecipientAddressDescription { get; set; }

            /// <summary>
            /// Gets or sets ...
            /// </summary>
            [DataMember]
            public int Printed { get; set; }

            /// <summary>
            /// Gets or sets ...
            /// </summary>
            [DataMember]
            public int ChangedDataEW { get; set; }

            /// <summary>
            /// Gets or sets ...
            /// </summary>
            [DataMember]
            public DateTime? EWDateCreated { get; set; }

            /// <summary>
            /// Gets or sets schedule delivery date
            /// </summary>
            [DataMember]
            public DateTime? ScheduledDeliveryDate { get; set; }

            /// <summary>
            /// Gets or sets estimated delivery date
            /// </summary>
            [DataMember]
            public DateTime EstimatedDeliveryDate { get; set; }

            /// <summary>
            /// Gets or sets last status change date
            /// </summary>
            [DataMember]
            public DateTime DateLastUpdatedStatus { get; set; }

            /// <summary>
            /// Gets or sets last print date
            /// </summary>
            [DataMember]
            public DateTime? DateLastPrint { get; set; }

            /// <summary>
            /// Gets or sets document creation date time
            /// </summary>
            [DataMember]
            public DateTime CreateTime { get; set; }

            /// <summary>
            /// Gets or sets scan sheet number
            /// </summary>
            [DataMember]
            public string ScanSheetNumber { get; set; }

            /// <summary>
            /// Gets or sets scan sheet printed
            /// </summary>
            [DataMember]
            public string ScanSheetPrinted { get; set; }

            /// <summary>
            /// Gets or sets internal order number
            /// </summary>
            [DataMember]
            public string InfoRegClientBarcodes { get; set; }

            /// <summary>
            /// Gets or sets stay pay id number
            /// </summary>
            [DataMember]
            public int StatePayId { get; set; }

            /// <summary>
            /// Gets or sets stay pay name
            /// </summary>
            [DataMember]
            public string StatePayName { get; set; }

            /// <summary>
            /// Gets or sets backward delivery cargo type. Cash or documents etc
            /// </summary>
            [DataMember]
            public string BackwardDeliveryCargoType { get; set; }

            /// <summary>
            /// Gets or sets backwward delivery amount in UAH
            /// </summary>
            [DataMember]
            public string BackwardDeliverySum { get; set; }

            /// <summary>
            /// Gets or sets backwward delivery amount in UAH
            /// </summary>
            [DataMember]
            public decimal BackwardDeliveryMoney { get; set; }

            /// <summary>
            /// Gets or sets backward delivery documents
            /// </summary>
            [DataMember]
            public string[] BackwardDeliveryDataDocuments { get; set; } = new string[0];

            /// <summary>
            /// Gets or sets marketplace partner description. Busness cabinet, OLX ...
            /// </summary>
            [DataMember]
            public string MarketplacePartnerDescription { get; set; }

            /// <summary>
            /// Gets or sets sender counterparty type
            /// </summary>
            [DataMember]
            public string SenderCounterpartyType { get; set; }

            /// <summary>
            /// Gets or sets elevate shipment to customer apartment
            /// </summary>
            [DataMember]
            public string ElevatorRecipient { get; set; }

            /// <summary>
            /// Gets or sets recipient counterparty type
            /// </summary>
            [DataMember]
            public string RecipientCounterpartyType { get; set; }

            /// <summary>
            /// Gets or sets delivery by hand
            /// </summary>
            [DataMember]
            public string DeliveryByHand { get; set; }

            /// <summary>
            /// Gets or sets forwarding count
            /// </summary>
            [DataMember]
            public int ForwardingCount { get; set; }

            /// <summary>
            /// Gets or sets original geo data
            /// </summary>
            [DataMember]
            public OriginalGeoInformation OriginalGeoData { get; set; } = new OriginalGeoInformation();

            /// <summary>
            /// Gets or sets ownership form
            /// </summary>
            [DataMember]
            public string OwnershipForm { get; set; }

            /// <summary>
            /// Gets or sets EDRPOU
            /// </summary>
            [DataMember]
            public string EDRPOU { get; set; }

            /// <summary>
            /// Gets or sets redbox barcode
            /// </summary>
            [DataMember]
            public string RedBoxBarcode { get; set; }

            /// <summary>
            /// Gets or sets recipient city reference key
            /// </summary>
            [DataMember]
            public Guid? RecipientCityRef { get; set; }

            /// <summary>
            /// Gets or sets recipient street reference key
            /// </summary>
            [DataMember]
            public Guid? RecipientStreetRef { get; set; }

            /// <summary>
            /// Gets or sets recipient warehouse key
            /// </summary>
            [DataMember]
            public Guid? RecipientWarehouseRef { get; set; }

            /// <summary>
            /// Gets or sets take a lawyer
            /// </summary>
            [DataMember]
            public string IsTakeAttorney { get; set; }

            /// <summary>
            /// Gets or sets same day delivery
            /// </summary>
            [DataMember]
            public string SameDayDelivery { get; set; }

            /// <summary>
            /// Gets or sets time interval
            /// </summary>
            [DataMember]
            public string TimeInterval { get; set; }

            /// <summary>
            /// Gets or sets time interval reference key
            /// </summary>
            [DataMember]
            public Guid? TimeIntervalRef { get; set; }

            /// <summary>
            /// Gets or sets time interval description
            /// </summary>
            [DataMember]
            public string TimeIntervalString { get; set; }

            /// <summary>
            /// Gets or sets express pallet
            /// </summary>
            [DataMember]
            public string ExpressPallet { get; set; }

            /// <summary>
            /// Gets or sets term extension
            /// </summary>
            [DataMember]
            public int TermExtension { get; set; }

            /// <summary>
            /// Gets or sets term extension days
            /// </summary>
            [DataMember]
            public string TermExtensionDays { get; set; }

            /// <summary>
            /// Gets or sets
            /// </summary>
            [DataMember]
            public int AviaDelivery { get; set; }

            /// <summary>
            /// Gets or sets redelivery payment card. Where sender will receive money after successful shipment.
            /// </summary>
            [DataMember]
            public PaymentCard RedeliveryPaymentCard { get; set; } = new PaymentCard();

            /// <summary>
            /// Gets or sets shipment seats options
            /// </summary>
            [DataMember]
            public SeatProperties[] OptionsSeat { get; set; } = new SeatProperties[0];

            public override string ToString()
            {
                return $"{IntDocNumber} - {RecipientContactPerson}";
            }
        }

        /// <summary>
        /// Represents original geo information
        /// </summary>
        [DataContract]
        public class OriginalGeoInformation
        {
            /// <summary>
            /// Gets or sets recipient address
            /// </summary>
            [DataMember]
            public string RecipientAddressName { get; set; }

            /// <summary>
            /// Gets or sets recipient area
            /// </summary>
            [DataMember]
            public string RecipientArea { get; set; }

            /// <summary>
            /// Gets or sets recipient area regions
            /// </summary>
            [DataMember]
            public string RecipientAreaRegions { get; set; }

            /// <summary>
            /// Gets or sets recipient city name
            /// </summary>
            [DataMember]
            public string RecipientCityName { get; set; }

            /// <summary>
            /// Gets or sets recipient flat number
            /// </summary>
            [DataMember]
            public string RecipientFlat { get; set; }

            /// <summary>
            /// Gets or sets recipient house number
            /// </summary>
            [DataMember]
            public string RecipientHouse { get; set; }
        }

        /// <summary>
        /// Represents shipment place information
        /// </summary>
        [DataContract]
        public class SeatProperties
        {
            /// <summary>
            /// Gets or sets shipment place volume
            /// </summary>
            [DataMember(Name = "volumetricVolume")]
            public decimal VolumetricVolume { get; set; }

            /// <summary>
            /// Gets or sets shipment place width
            /// </summary>
            [DataMember(Name = "volumetricWidth")]
            public decimal VolumetricWidth { get; set; }

            /// <summary>
            /// Gets or sets shipment place length
            /// </summary>
            [DataMember(Name = "volumetricLength")]
            public decimal VolumetricLength { get; set; }

            /// <summary>
            /// Gets or sets shipment place height
            /// </summary>
            [DataMember(Name = "volumetricHeight")]
            public decimal VolumetricHeight { get; set; }

            /// <summary>
            /// Gets or sets shipment place weight. In kilograms.
            /// </summary>
            [DataMember(Name = "weight")]
            public decimal Weight { get; set; }

            /// <summary>
            /// Gets or sets shipment place volumetric weight. Kilograms / m^3 Weight and volumetric weight are different parameters. 
            /// </summary>
            [DataMember(Name = "volumetricWeight")]
            public decimal VolumetricWeight { get; set; }

            /// <summary>
            /// Gets or sets shipment place cost
            /// </summary>
            [DataMember(Name = "cost")]
            public decimal? Cost { get; set; }

            /// <summary>
            /// Gets or sets shipment place description
            /// </summary>
            [DataMember(Name = "description")]
            public string Description { get; set; }

            /// <summary>
            /// Gets or sets shipment place reference
            /// </summary>
            [DataMember(Name = "packRef")]
            public Guid? PackRef { get; set; }
        }

        /// <summary>
        /// Represents sender bank payment card where 'Nova Poshta' will put recipient money after payment
        /// </summary>
        [DataContract]
        public class PaymentCard
        {
            /// <summary>
            /// Gets or sets bank payment card name. Client can set this value from 'Nova poshta' cabinet.
            /// </summary>
            [DataMember]
            public string CardDescription { get; set; }

            /// <summary>
            /// Gets or sets masked bank payment card number
            /// </summary>
            [DataMember]
            public string CardMaskedNumber { get; set; }

            public override string ToString()
            {
                return $"{CardDescription} - {CardMaskedNumber}";
            }
        }
    }
}
