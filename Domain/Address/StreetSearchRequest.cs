using System;
using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Address
{
    /// <summary>
    /// Represents search street request
    /// Documentation: https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a1329635-8512-11ec-8ced-005056b2dbe1
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
