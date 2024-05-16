using System;
using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Address
{
    /// <summary>
    /// Create new counterparty address request. Represents 'save' method request of 'Address' model.
    /// Documentation: https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a155d0d9-8512-11ec-8ced-005056b2dbe1
    /// </summary>
    [DataContract]
    public class CreateCounterpartyAddressRequest
    {
        /// <summary>
        /// Gets or sets counterparty reference
        /// </summary>
        [DataMember]
        public Guid CounterpartyRef { get; set; }

        /// <summary>
        /// Gets or sets street reference
        /// </summary>
        [DataMember]
        public Guid StreetRef { get; set; }

        /// <summary>
        /// Gets or sets building number
        /// </summary>
        [DataMember]
        public string BuildingNumber { get; set; }

        /// <summary>
        /// Gets or sets flat number
        /// </summary>
        [DataMember]
        public string Flat { get; set; }

        /// <summary>
        /// Gets or sets note
        /// </summary>
        [DataMember]
        public string Note { get; set; }
    }
}
