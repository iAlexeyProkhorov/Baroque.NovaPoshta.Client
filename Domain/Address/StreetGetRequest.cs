using System;
using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Address
{
    /// <summary>
    /// Load list of Ukrainian cities where 'Nova Poshta' service have warehouses. Represents 'getStreet' method of 'Address' model.
    /// Documentation: https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a27c20d7-8512-11ec-8ced-005056b2dbe1
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
