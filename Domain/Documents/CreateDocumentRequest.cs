using System;
using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Documents
{
    /// <summary>
    /// Create internet document request. Represents method 'save' request of 'InternetDocument' model.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/556eef34a0fe4f02049c664e/operations/56261f14a0fe4f1e503fe187
    /// </summary>
    [DataContract]
    public class CreateDocumentRequest
    {
        /// <summary>
        /// Gets or sets using new address value. 1 - if yes, 0 - no
        /// </summary>
        [DataMember]
        public int NewAddress { get; set; }

        /// <summary>
        /// Gets or sets payer type. To get list of payer types use 'GetTypesOfPayers' method from common service.
        /// 'GetTypesOfPayers' method documentation: https://devcenter.novaposhta.ua/docs/services/55702570a0fe4f0cf4fc53ed/operations/55702571a0fe4f0b64838913
        /// </summary>
        [DataMember]
        public string PayerType { get; set; } = "Sender";

        /// <summary>
        /// Gets or sets payment method reference. To get list of available payment methods use 'GetPaymentForms' method from common service.
        /// 'GetPaymentForms' method documentantion: https://devcenter.novaposhta.ua/docs/services/55702570a0fe4f0cf4fc53ed/operations/55702571a0fe4f0b6483890d
        /// </summary>
        [DataMember]
        public string PaymentMethod { get; set; } = "Cash";

        /// <summary>
        /// Gets or sets document cargo type reference. To get list of available cargo types use 'GetCargoTypes' method of common service.
        /// 'GetCargoTypes' method documentation: https://devcenter.novaposhta.ua/docs/services/55702570a0fe4f0cf4fc53ed/operations/55702571a0fe4f0b64838909
        /// </summary>
        [DataMember]
        public string CargoType { get; set; } = "Parcel";

        /// <summary>
        /// Gets or sets service type reference. To get list of available service types use 'GetServiceTypes' method of common service.
        /// 'GetServiceTypes' method documentation: https://devcenter.novaposhta.ua/docs/services/55702570a0fe4f0cf4fc53ed/operations/55702571a0fe4f0b6483890e
        /// </summary>
        [DataMember]
        public string ServiceType { get; set; } = "WarehouseWarehouse";

        /// <summary>
        /// Gets or sets general package volume. Required if 'OptionsSeat' aren't set.
        /// </summary>
        [DataMember]
        public decimal VolumeGeneral { get; set; }

        /// <summary>
        /// Gets or sets total weight
        /// </summary>
        [DataMember]
        public decimal  Weight { get; set; }

        /// <summary>
        /// Gets or sets seats quantity
        /// </summary>
        [DataMember]
        public int SeatsAmount { get; set; }

        /// <summary>
        /// Gets or sets cargo description
        /// </summary>
        [DataMember]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets cargo cost
        /// </summary>
        [DataMember]
        public int Cost { get; set; }

        /// <summary>
        /// Gets or sets sender city reference key
        /// </summary>
        [DataMember]
        public Guid CitySender { get; set; }

        /// <summary>
        /// Gets or sets sender reference key
        /// </summary>
        [DataMember]
        public Guid Sender { get; set; }

        /// <summary>
        /// Gets or sets sender address reference key
        /// </summary>
        [DataMember]
        public Guid SenderAddress { get; set; }

        /// <summary>
        /// Gets or sets sender contact person reference key
        /// </summary>
        [DataMember]
        public Guid ContactSender { get; set; }

        /// <summary>
        /// Gets or sets sender phone number
        /// </summary>
        [DataMember]
        public string SendersPhone { get; set; }

        /// <summary>
        /// Gets or sets recipient city name
        /// </summary>
        [DataMember]
        public string RecipientCityName { get; set; }

        /// <summary>
        /// Gets or sets recipient area reference key
        /// </summary>
        [DataMember]
        public Guid? RecipientArea { get; set; }

        /// <summary>
        /// Gets or sets recipient area regions
        /// </summary>
        [DataMember]
        public string RecipientAreaRegions { get; set; }

        /// <summary>
        /// Gets or sets recipient address
        /// </summary>
        [DataMember]
        public string RecipientAddressName { get; set; }

        /// <summary>
        /// Gets or sets recipient house
        /// </summary>
        [DataMember]
        public string RecipientHouse { get; set; }

        /// <summary>
        /// Gets or sets recipient flat number
        /// </summary>
        [DataMember]
        public string RecipientFlat { get; set; }

        /// <summary>
        /// Gets or sets recipient full name
        /// </summary>
        [DataMember]
        public string RecipientName { get; set; }

        /// <summary>
        /// Gets or sets recipient type. To get list of available recipient types use 'GetTypesOfCounterparties' method of common service.
        /// 'GetTypesOfCounterparties' method documentation: https://devcenter.novaposhta.ua/docs/services/55702570a0fe4f0cf4fc53ed/operations/55702571a0fe4f0b64838912
        /// </summary>
        [DataMember]
        public string RecipientType { get; set; } = "PrivatePerson";

        /// <summary>
        /// Gets or sets recipient phone number
        /// </summary>
        [DataMember]
        public string RecipientsPhone { get; set; }

        /// <summary>
        /// Gets or sets shipping date
        /// </summary>
        [DataMember]
        public string DateTime { get; set; }

        /// <summary>
        /// Gets or sets settlement type. Use 'SettlementTypeDescription' property from 'getSettlements' method response. Method located in address service 
        /// </summary>
        [DataMember]
        public string SettlementType { get; set; }

        /// <summary>
        /// Gets or sets ownership forrm reference. To get available ownership forms use 'GetOwnershipFormsList' method of common service.
        /// 'GetOwnershipFormsList' method documentation: https://devcenter.novaposhta.ua/docs/services/55702570a0fe4f0cf4fc53ed/operations/55702571a0fe4f0b6483890b
        /// </summary>
        [DataMember]
        public Guid? OwnershipForm { get; set; }

        /// <summary>
        /// Gets or sets recipient contact name
        /// </summary>
        [DataMember]
        public string RecipientContactName { get; set; }

        /// <summary>
        /// Gets or sets recipient EDRPOU
        /// </summary>
        [DataMember]
        public string EDRPOU { get; set; }
    }
}
