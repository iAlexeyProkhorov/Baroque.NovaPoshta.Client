using System;
using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Address
{
    /// <summary>
    /// Get list of Ukrainian settlements. Represents 'getSettlements' method request of 'AddressGeneral' model.
    /// Maximum 150 settlements per page.
    /// Documentation: https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a1c42723-8512-11ec-8ced-005056b2dbe1
    /// </summary>
    [DataContract]
    public class SettlementsGetRequest
    {
        /// <summary>
        /// Gets or sets filtering address reference key
        /// </summary>
        [DataMember]
        public Guid? Ref { get; set; }

        /// <summary>
        /// Gets or sets filtering region reference key
        /// </summary>
        [DataMember]
        public Guid? RegionRef { get; set; }

        /// <summary>
        /// Gets or sets filtering area reference key
        /// </summary>
        [DataMember]
        public Guid? AreaRef { get; set; }

        /// <summary>
        /// Gets or sets settlement name
        /// </summary>
        [DataMember]
        public string FindByString { get; set; }

        /// <summary>
        /// Gets or sets settlement warehouses availablity
        /// </summary>
        [DataMember]
        public int Warehouse { get; set; } = 1;

        /// <summary>
        /// Gets or sets page number. Each page contains 150 settlements.
        /// </summary>
        [DataMember]
        public int Page { get; set; } = 1;
    }
}
