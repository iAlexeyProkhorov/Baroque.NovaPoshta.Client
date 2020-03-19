using System;
using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Address
{
    /// <summary>
    /// Load list of Ukrainian cities where 'Nova Poshta' service have warehouses. Represents 'getStreet' method of 'Address' model.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/556d7ccaa0fe4f08e8f7ce43/operations/556d8db0a0fe4f08e8f7ce47
    /// </summary>
    [DataContract]
    public class StreetGetRequest
    {
        /// <summary>
        /// Gets or sets city key
        /// </summary>
        [DataMember]
        public Guid CityRef { get; set; }

        /// <summary>
        /// Gets or sets street name
        /// </summary>
        [DataMember]
        public string FindByString { get; set; }

        /// <summary>
        /// Gets or sets response page number. Each page contains only 500 addresses.
        /// </summary>
        [DataMember]
        public int Page { get; set; }
    }
}
