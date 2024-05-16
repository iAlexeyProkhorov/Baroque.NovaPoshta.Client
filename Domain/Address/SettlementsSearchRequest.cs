using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Address
{
    /// <summary>
    /// Represents find locality(city) request.
    /// You can find description here: https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a0eb83ab-8512-11ec-8ced-005056b2dbe1
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
        [DataMember(Name = "Limit")]
        public int Limit { get; set; }

        /// <summary>
        /// Gets or sets response page number
        /// </summary>
        [DataMember(Name = "Page")]
        public int Page { get; set; } = 1;
    }
}
