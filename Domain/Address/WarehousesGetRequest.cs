﻿using System;
using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Address
{
    /// <summary>
    /// Request to get list of warehouses. Represents 'getWarehouses' method of 'Address' model.
    /// Documentation: https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a2322f38-8512-11ec-8ced-005056b2dbe1
    /// </summary>
    [DataContract]
    public class WarehousesGetRequest
    {
        /// <summary>
        /// Gets or sets warehouses city name
        /// </summary>
        [DataMember]
        public string CityName { get; set; }

        /// <summary>
        /// Gets or sets warehouses city reference
        /// </summary>
        [DataMember]
        public Guid? CityRef { get; set; }

        /// <summary>
        /// Gets or sets warehouses settlement reference
        /// </summary>
        [DataMember]
        public Guid? SettlementRef { get; set; }

        /// <summary>
        /// Get or sets warehouses type reference
        /// </summary>
        [DataMember]
        public Guid? TypeOfWarehouseRef { get; set; }

        /// <summary>
        /// Gets or sets bicycle parking availability. '1' - available, '0' - not available
        /// </summary>
        [DataMember]
        public int BicycleParking { get; set; }

        /// <summary>
        /// Gets or sets post finance cashbox availability. '1' - available, '0' - not available
        /// </summary>
        [DataMember]
        public int PostFinance { get; set; }

        /// <summary>
        /// Gets or sets POS terminal availability. '1' - available, '0' - not available
        /// </summary>
        [DataMember]
        public int POSTerminal { get; set; }

        /// <summary>
        /// Gets or sets searching warehouse number.
        /// </summary>
        [DataMember]
        public int? WarehouseId { get; set; }

        /// <summary>
        /// Gets or sets page number. Each page contains maximum 500 items. Works with 'Limit' property.
        /// </summary>
        [DataMember]
        public int Page { get; set; }

        /// <summary>
        /// Gets or sets limit for items per one page.
        /// </summary>
        [DataMember]
        public int Limit { get; set; }
    }
}
