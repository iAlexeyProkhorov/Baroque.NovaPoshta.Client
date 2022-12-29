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
            /// Gets or sets warehouse short address by Ukrainian
            /// </summary>
            [DataMember]
            public string ShortAddress { get; set; }

            /// <summary>
            /// Gets or sets warehouse short address by russian
            /// </summary>
            [DataMember]
            public string ShortAddressRu { get; set; }

            /// <summary>
            /// Gets or sets phone
            /// </summary>
            [DataMember]
            public string Phone { get; set; }

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
            /// Gets or sets settlement unique reference number
            /// </summary>
            [DataMember]
            public Guid SettlementRef { get; set; }

            /// <summary>
            /// Gets or sets settlement description
            /// </summary>
            [DataMember]
            public string SettlementDescription { get; set; }

            /// <summary>
            /// Gets or sets settlement area description
            /// </summary>
            [DataMember]
            public string SettlementAreaDescription { get; set; }

            /// <summary>
            /// Gets or sets settlement region description
            /// </summary>
            [DataMember]
            public string SettlementRegionsDescription { get; set; }

            /// <summary>
            /// Gets or sets settlement type description by Ukrainian
            /// </summary>
            [DataMember]
            public string SettlementTypeDescription { get; set; }

            /// <summary>
            /// Gets or sets settlement type description by russian
            /// </summary>
            [DataMember]
            public string SettlementTypeDescriptionRu { get; set; }

            /// <summary>
            /// Gets or sets warehouse location longitude
            /// </summary>
            [DataMember]
            public string Longitude { get; set; }

            /// <summary>
            /// Gets or sets warehouse location latitude
            /// </summary>
            [DataMember]
            public string Latitude { get; set; }

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
            /// Gets or sets payment at warehouse availability
            /// </summary>
            [DataMember]
            public int PaymentAccess { get; set; }

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
            /// Gets or sets warehouse self-service workplace availability
            /// </summary>
            [DataMember]
            public int SelfServiceWorkplacesCount { get; set; }

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
            /// Gets or sets sending packages limitations
            /// </summary>
            [DataMember]
            public WarehouseLimitations SendingLimitationsOnDimensions { get; set; }

            /// <summary>
            /// Gets or sets receiving packages limitiations
            /// </summary>
            [DataMember]
            public WarehouseLimitations ReceivingLimitationsOnDimensions { get; set; }

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
            /// Gets or sets district code
            /// </summary>
            [DataMember]
            public string DistrictCode { get; set; }

            /// <summary>
            /// Gets or sets warehouse status.
            /// </summary>
            [DataMember]
            public string WarehouseStatus { get; set; }

            /// <summary>
            /// Gets or sets warehouse status date
            /// </summary>
            [DataMember]
            public DateTime WarehouseStatusDate { get; set; }

            /// <summary>
            /// Gets or sets warehouse category
            /// </summary>
            [DataMember]
            public string CategoryOfWarehouse { get; set; }

            /// <summary>
            /// Gets or sets city name
            /// </summary>
            [DataMember]
            public string RegionCity { get; set; }

            /// <summary>
            /// Gets or sets membership of the branch to the franchise network
            /// </summary>
            [DataMember]
            public int WarehouseForAgent { get; set; }

            /// <summary>
            /// Gets or sets maximal package daclare cost
            /// </summary>
            [DataMember]
            public int MaxDeclaredCost { get; set; }

            /// <summary>
            /// Gets or sets warehouse availability
            /// </summary>
            [DataMember]
            public int DenyToSelect { get; set; }

            /// <summary>
            /// Gets or sets post machine type.
            /// </summary>
            [DataMember]
            public string PostMachineType { get; set; }

            /// <summary>
            /// Gets or sets warehouse postal code
            /// </summary>
            [DataMember]
            public string PostalCodeUA { get; set; }

            /// <summary>
            /// Gets or sets warehouse work mode. 1 - if warehouse works for pacakge receiveing only
            /// </summary>
            [DataMember]
            public int OnlyReceivingParcel { get; set; }

            /// <summary>
            /// Gets or sets warehouse digital address. Example: 101/102
            /// Number before slash - city index, after - store number.
            /// </summary>
            [DataMember]
            public string WarehouseIndex { get; set; }

            /// <summary>
            /// Returns warehouse description
            /// </summary>
            /// <returns>String</returns>
            public override string ToString()
            {
                return this.Description;
            }
        }

        /// <summary>
        /// Represents warehouse 
        /// </summary>
        [DataContract]
        public class WarehouseLimitations : IDimensions
        {
            /// <summary>
            /// Gets or sets package width
            /// </summary>
            [DataMember]
            public int Width { get; set; }

            /// <summary>
            /// Gets or sets package height
            /// </summary>
            [DataMember]
            public int Height { get; set; }

            /// <summary>
            /// Gets or sets package length
            /// </summary>
            [DataMember]
            public int Length { get; set; }
        }
    }
}
