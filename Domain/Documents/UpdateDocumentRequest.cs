using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Documents
{
    /// <summary>
    /// Represent document update method request.
    /// Documentation: https://developers.novaposhta.ua/view/model/a90d323c-8512-11ec-8ced-005056b2dbe1/method/a98a4354-8512-11ec-8ced-005056b2dbe1
    /// </summary>
    [DataContract]
    public class UpdateDocumentRequest : BaseRefItem
    {
        /// <summary>
        /// Gets or sets payer type.
        /// Variants: Sender, Recipient, ThirdPerson
        /// </summary>
        [DataMember]
        public string PayerType { get; set; } = "Sender";

        /// <summary>
        /// Gets or sets payment method type key.
        /// Variants: Cash, NonCash
        /// </summary>
        [DataMember]
        public string PaymentMethod { get; set; } = "Cash";

        /// <summary>
        /// Gets or sets package send date. Date format: dd.MM.yyyy
        /// </summary>
        [DataMember]
        public string DateTime { get; set; }

        /// <summary>
        /// Gets or sets cargo type reference.
        /// Documentation: https://developers.novaposhta.ua/view/model/a55b2c64-8512-11ec-8ced-005056b2dbe1/method/a5912a1e-8512-11ec-8ced-005056b2dbe1
        /// </summary>
        [DataMember]
        public string CargoType { get; set; } = "Cargo";

        /// <summary>
        /// Gets or sets package general volume. Required if property 'OptionSeats' isn't set.
        /// Minimal value: 0,0004
        /// </summary>
        [DataMember]
        public decimal? VolumeGeneral { get; set; }

        /// <summary>
        /// Gets or sets summary package weight. Min value: 0,1.
        /// </summary>
        [DataMember]
        public decimal Weight { get; set; }

        /// <summary>
        /// Gets or sets service type reference.
        /// Variants: DoorsDoors, DoorsWarehouse, WarehouseWarehouse, WarehouseDoors
        /// </summary>
        [DataMember]
        public string ServiceType { get; set; } = "DoorsDoors";

        /// <summary>
        /// Gets or sets package seats amount.
        /// </summary>
        [DataMember]
        public int SeatsAmount { get; set; }

        /// <summary>
        /// Gets or sets package description.
        /// </summary>
        [DataMember]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets package assessed value.
        /// </summary>
        [DataMember]
        public decimal Cost { get; set; }

        /// <summary>
        /// Gets or sets city sender reference key.
        /// </summary>
        [DataMember]
        public Guid CitySender { get; set; }

        /// <summary>
        /// Gets or sets sendere reference key.
        /// </summary>
        [DataMember]
        public Guid Sender { get; set; }

        /// <summary>
        /// Gets or sets sender address reference key.
        /// </summary>
        [DataMember]
        public Guid SenderAddress { get; set; }

        /// <summary>
        /// Gets or sets sender contact person reference key.
        /// </summary>
        [DataMember]
        public Guid ContactSender { get; set; }

        /// <summary>
        /// Gets or sets sender phone number.
        /// </summary>
        [DataMember]
        public string SendersPhone { get; set; }

        /// <summary>
        /// Gets or sets recipient city reference number.
        /// </summary>
        [DataMember]
        public Guid CityRecipient { get; set; }

        /// <summary>
        /// Gets or sets recipeint reference number.
        /// </summary>
        [DataMember]
        public Guid Recipient { get; set; }

        /// <summary>
        /// Gets or sets recipeint address reference key.
        /// </summary>
        [DataMember]
        public Guid RecipientAddress { get; set; }

        /// <summary>
        /// Gets or sets recipeint contact person reference key.
        /// </summary>
        [DataMember]
        public Guid ContactRecipient { get; set; }

        /// <summary>
        /// Gets or sets recipient phone number.
        /// </summary>
        [DataMember]
        public string RecipientsPhone { get; set; }

        /// <summary>
        /// Gets or sets seats options
        /// </summary>
        [DataMember]
        public IList<Seat> OptionsSeat { get; set; } = new List<Seat>();
    }
}
