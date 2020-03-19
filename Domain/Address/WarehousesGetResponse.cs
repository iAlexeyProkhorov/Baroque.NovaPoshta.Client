using System;
using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Address
{
    /// <summary>
    /// Response represents warehouse. Represents 'getWarehouses' method of 'Address' model.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/556d7ccaa0fe4f08e8f7ce43/operations/556d8211a0fe4f08e8f7ce45
    /// </summary>
    [DataContract]
    public class WarehousesGetResponse : BaseResponseEnvelope<WarehousesGetResponse.Warehouse>
    {
        /// <summary>
        /// Represents warehouse
        /// </summary>
        [DataContract]
        public class Warehouse : BaseRefItem
        {
            /// <summary>
            /// Get or sets warehouse code
            /// </summary>
            [DataMember]
            public decimal SiteKey { get; set; }

            /// <summary>
            /// Gets or sets warehouse description on Ukrainian
            /// </summary>
            [DataMember]
            public string Description { get; set; }

            /// <summary>
            /// Gets or sets warehouse description on Russian
            /// </summary>
            [DataMember]
            public string DescriptionRu { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [DataMember]
            public Guid TypeOfWarehouse { get; set; }

            /// <summary>
            /// Gets or sets warehouse number
            /// </summary>
            [DataMember]
            public int Number { get; set; }

            /// <summary>
            /// Gets or sets warehouse city reference
            /// </summary>
            [DataMember]
            public Guid CityRef { get; set; }

            /// <summary>
            /// Gets or sets warehouse city name on Ukrainian
            /// </summary>
            [DataMember]
            public string CityDescription { get; set; }

            /// <summary>
            /// Gets or sets warehouse city name on Russian
            /// </summary>
            [DataMember]
            public string CityDescriptionRu { get; set; }

            /// <summary>
            /// Gets or sets warehouse location latitude
            /// </summary>
            [DataMember]
            public string Latitude { get; set; }

            /// <summary>
            /// Gets or sets warehouse location longitude
            /// </summary>
            [DataMember]
            public string Longitude { get; set; }

            /// <summary>
            /// Gets or sets post finance cashbox availability. '1' - available, '0' - not available
            /// </summary>
            [DataMember]
            public int PostFinance { get; set; }

            /// <summary>
            /// Gets or sets bicycle parking availability. '1' - parking available, '0' - not available
            /// </summary>
            [DataMember]
            public int BicycleParking { get; set; }

            /// <summary>
            /// Gets or sets warehouse POS terminal availability. '1' - terminal available, '0' - not available
            /// </summary>
            [DataMember]
            public int POSTerminal { get; set; }

            /// <summary>
            /// Gets or sets international shipping service availability. '1' - possible to do internation shipments, '0' - not possible.
            /// </summary>
            [DataMember]
            public int InternationalShipping { get; set; }

            /// <summary>
            /// Gets or sets all shipment total max weight
            /// </summary>
            [DataMember]
            public int TotalMaxWeightAllowed { get; set; }

            /// <summary>
            /// Gets or sets one shipment weight max weight
            /// </summary>
            [DataMember]
            public int PlaceMaxWeightAllowed { get; set; }

            /// <summary>
            /// Gets or sets schedule of packages receiving
            /// </summary>
            [DataMember]
            public Week Reception { get; set; } = new Week();

            /// <summary>
            /// Gets or sets schedule sending day to day
            /// </summary>
            [DataMember]
            public Week Delivery { get; set; } = new Week();

            /// <summary>
            /// Gets or sets warehouse work schedule
            /// </summary>
            [DataMember]
            public Week Schedule { get; set; } = new Week();

            /// <summary>
            /// Returns warehouse description
            /// </summary>
            /// <returns>String</returns>
            public override string ToString()
            {
                return this.Description;
            }
        }
    }
}
