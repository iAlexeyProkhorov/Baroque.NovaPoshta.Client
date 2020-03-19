using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Address
{
    /// <summary>
    /// Represents find locality(city) request.
    /// You can find description here: https://devcenter.novaposhta.ua/docs/services/556d7ccaa0fe4f08e8f7ce43/operations/58e5ebeceea27017bc851d67
    /// </summary>
    [DataContract]
    public class SettlementsSearchRequest
    {
        /// <summary>
        /// Gets or sets locality name or zip code
        /// </summary>
        [DataMember(Name = "CityName")]
        public string SettlementName { get; set; }

        /// <summary>
        /// Gets or sets response items quantity
        /// </summary>
        [DataMember(Name ="Limit")]
        public int Limit { get; set; }
    }
}
