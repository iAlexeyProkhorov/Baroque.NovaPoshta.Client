using System;
using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Address
{
    /// <summary>
    /// Represents cities search request implemented via 'getCities' method in 'Address' model.
    /// Documentation: https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a1e6f0a7-8512-11ec-8ced-005056b2dbe1
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
