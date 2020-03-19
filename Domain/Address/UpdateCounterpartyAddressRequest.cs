using System;
using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Address
{
    /// <summary>
    /// Represents method 'update' request of 'Address' model.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/556d7ccaa0fe4f08e8f7ce43/operations/556d9db5a0fe4f08e8f7ce4b
    /// </summary>
    [DataContract]
    public class UpdateCounterpartyAddressRequest
    {
        /// <summary>
        /// Gets or sets address reference
        /// </summary>
        [DataMember]
        public Guid Ref { get; set; }

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
        /// Get or sets flat number
        /// </summary>
        [DataMember]
        public string Flat { get; set; }

        /// <summary>
        /// Gets or sets notes
        /// </summary>
        [DataMember]
        public string Note { get; set; }
    }
}
