using System;
using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Address
{
    /// <summary>
    /// Represents cities search request implemented via 'getCities' method in 'Address' model.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/556d7ccaa0fe4f08e8f7ce43/operations/556d885da0fe4f08e8f7ce46
    /// </summary>
    [DataContract]
    public class CitiesGetRequest
    {
        /// <summary>
        /// Gets or sets city unique key
        /// </summary>
        public Guid? Ref { get; set; }

        /// <summary>
        /// Gets or sets city unique key
        /// </summary>
        [DataMember]
        public string FindByString { get; set; }
    }
}
