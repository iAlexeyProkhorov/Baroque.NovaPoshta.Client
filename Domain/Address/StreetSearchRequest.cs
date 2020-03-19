using System;
using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Address
{
    /// <summary>
    /// Represents search street request
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/556d7ccaa0fe4f08e8f7ce43/operations/58e5f369eea27017540b58ac
    /// </summary>
    [DataContract]
    public class StreetSearchRequest
    {
        /// <summary>
        /// Gets or sets street name
        /// </summary>
        [DataMember(Name = "StreetName")]
        public string StreetName { get; set; }

        /// <summary>
        /// Gets or sets street settlement reference 
        /// </summary>
        [DataMember(Name = "SettlementRef")]
        public Guid SettlementReference { get; set; }

        /// <summary>
        /// Gets or sets response items maximum quantity
        /// </summary>
        [DataMember(Name = "Limit")]
        public int Limit { get; set; }
    }
}
