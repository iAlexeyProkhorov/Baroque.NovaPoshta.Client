using System;
using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Address
{
    /// <summary>
    /// Create new counterparty address request. Represents 'save' method request of 'Address' model.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/556d7ccaa0fe4f08e8f7ce43/operations/556d9925a0fe4f08e8f7ce4a
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
        public int Flat { get; set; }

        /// <summary>
        /// Gets or sets note
        /// </summary>
        [DataMember]
        public string Note { get; set; }
    }
}
