using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Documents
{
    /// <summary>
    /// Create internet document request. Represents method 'save' request of 'InternetDocument' model.
    /// Documentation: https://developers.novaposhta.ua/view/model/a90d323c-8512-11ec-8ced-005056b2dbe1/method/a965630e-8512-11ec-8ced-005056b2dbe1
    /// </summary>
    [DataContract]
    public class CreateDocumentRequest
    {
        /// <summary>
        /// Gets or sets sender warehouse digital address
        /// </summary>
        [DataMember]
        public string SenderWarehouseIndex { get; set; }

        /// <summary>
        /// Gets or sets recipient warehouse digital address
        /// </summary>
        [DataMember]
        public string RecipientWarehouseIndex { get; set; }

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
        /// Gets or sets shipping date
        /// </summary>
        [DataMember]
        public string DateTime { get; set; }

        /// <summary>
        /// Gets or sets document cargo type reference. To get list of available cargo types use 'GetCargoTypes' method of common service.
        /// 'GetCargoTypes' method documentation: https://devcenter.novaposhta.ua/docs/services/55702570a0fe4f0cf4fc53ed/operations/55702571a0fe4f0b64838909
        /// </summary>
        [DataMember]
        public string CargoType { get; set; } = "Parcel";

        /// <summary>
        /// Gets or sets general package volume. Required if 'OptionsSeat' aren't set.
        /// </summary>
        [DataMember]
        public decimal VolumeGeneral { get; set; }

        /// <summary>
        /// Gets or sets total weight
        /// </summary>
        [DataMember]
        public decimal Weight { get; set; }

        /// <summary>
        /// Gets or sets service type reference. To get list of available service types use 'GetServiceTypes' method of common service.
        /// 'GetServiceTypes' method documentation: https://devcenter.novaposhta.ua/docs/services/55702570a0fe4f0cf4fc53ed/operations/55702571a0fe4f0b6483890e
        /// Required field.
        /// </summary>
        [DataMember]
        public string ServiceType { get; set; } = "WarehouseWarehouse";

        /// <summary>
        /// Gets or sets seats quantity.Required field.
        /// </summary>
        [DataMember]
        public int SeatsAmount { get; set; }

        /// <summary>
        /// Gets or sets cargo description
        /// </summary>
        [DataMember]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets cargo cost. Required field.
        /// </summary>
        [DataMember]
        public int Cost { get; set; }

        /// <summary>
        /// Gets or sets sender city reference key. Required field.
        /// </summary>
        [DataMember]
        public Guid CitySender { get; set; }

        /// <summary>
        /// Gets or sets sender reference key. Required field.
        /// </summary>
        [DataMember]
        public Guid Sender { get; set; }

        /// <summary>
        /// Gets or sets sender address reference key. Required field.
        /// Use next method to get counterparty information: https://developers.novaposhta.ua/view/model/a28f4b04-8512-11ec-8ced-005056b2dbe1/method/a30dbb7c-8512-11ec-8ced-005056b2dbe1?_lang=ua
        /// </summary>
        [DataMember]
        public Guid SenderAddress { get; set; }

        /// <summary>
        /// Gets or sets sender contact person reference key. Required field.
        /// Use next method to get contact person information: https://developers.novaposhta.ua/view/model/a28f4b04-8512-11ec-8ced-005056b2dbe1/method/a3575a67-8512-11ec-8ced-005056b2dbe1?_lang=ua
        /// </summary>
        [DataMember]
        public Guid ContactSender { get; set; }

        /// <summary>
        /// Gets or sets sender phone number. Required field.
        /// </summary>
        [DataMember]
        public string SendersPhone { get; set; }

        /// <summary>
        /// Gets or sets recipient city reference number. Required field.
        /// </summary>
        [DataMember]
        public Guid CityRecipient { get; set; }

        /// <summary>
        /// Gets or sets recipient reference key. Required field.
        /// </summary>
        [DataMember]
        public Guid Recipient { get; set; }

        /// <summary>
        /// Gets or sets recipient address reference key or recipient store reference key. Required field.
        /// </summary>
        [DataMember]
        public Guid RecipientAddress { get; set; }

        /// <summary>
        /// Gets or sets recipient contact person reference key.
        /// </summary>
        [DataMember]
        public Guid ContactRecipient { get; set; }

        /// <summary>
        /// Gets or sets recipient phone number. Required field. Examples: +380660000000, 380660000000, 0660000001
        /// </summary>
        [DataMember]
        public string RecipientsPhone { get; set; }

        /// <summary>
        /// Gets or sets list of document seats details.
        /// </summary>
        [DataMember]
        public IList<Seat> OptionsSeat { get; set; } = new List<Seat>();


        /// <summary>
        /// Represents document seat options
        /// </summary>
        [DataContract]
        public class Seat
        {
            /// <summary>
            /// Gets or sets seat volume. (In cubic meter)
            /// </summary>
            [DataMember(Name = "volumetricVolume")]
            public decimal VolumetricVolume { get; set; }

            /// <summary>
            /// Gets or sets seat width. (In centimeter)
            /// </summary>
            [DataMember(Name = "volumetricWidth")]
            public decimal VolumetricWidth { get; set; }

            /// <summary>
            /// Gets or sets seat length. (In centimeter)
            /// </summary>
            [DataMember(Name = "volumetricLength")]
            public decimal VolumetricLength { get; set; }

            /// <summary>
            /// Gets or sets seat height. (In centimeter)
            /// </summary>
            [DataMember(Name = "volumetricHeight")]
            public decimal VolumetricHeight { get; set; }

            /// <summary>
            /// Gets or sets seat weigth. (In kilograms)
            /// </summary>
            [DataMember(Name = "weight")]
            public decimal Weight { get; set; }
        }
    }
}
