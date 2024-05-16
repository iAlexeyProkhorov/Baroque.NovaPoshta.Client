using System;
using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Address
{
    /// <summary>
    /// Get list of Ukrainian settlements. Represents 'getSettlements' method response of 'AddressGeneral' model.
    /// Each page contains 150 settlements.
    /// Documentation: https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a1c42723-8512-11ec-8ced-005056b2dbe1
    /// </summary>
    [DataContract]
    public class SettlementsGetResponse : BaseResponseEnvelope<SettlementsGetResponse.Settlement>
    {
        /// <summary>
        /// Represents the settlement
        /// </summary>
        [DataContract]
        public class Settlement : BaseRefItem, IWorkDaysItem
        {
            /// <summary>
            /// Gets or sets settlement type key
            /// </summary>
            [DataMember]
            public Guid SettlementType { get; set; }

            /// <summary>
            /// Get or sets setlltement latitude
            /// </summary>
            [DataMember]
            public string Latitude { get; set; }

            /// <summary>
            /// Gets or sets settlement longitude
            /// </summary>
            [DataMember]
            public string Longitude { get; set; }

            /// <summary>
            /// Gets or sets city name on Ukrainian
            /// </summary>
            [DataMember]
            public string Description { get; set; }

            /// <summary>
            /// Gets or sets city name on Russian
            /// </summary>
            [DataMember]
            public string DescriptionRu { get; set; }

            /// <summary>
            /// Gets or sets region unique key
            /// </summary>
            [DataMember]
            public Guid? Region { get; set; }

            /// <summary>
            /// Gets or sets settlement region description on Ukrainian
            /// </summary>
            [DataMember]
            public string RegionDescription { get; set; }

            /// <summary>
            /// Gets or sets settlement region description on Russian
            /// </summary>
            [DataMember]
            public string RegionDescriptionRu { get; set; }

            /// <summary>
            /// Gets or sets area unique key
            /// </summary>
            [DataMember]
            public Guid Area { get; set; }

            /// <summary>
            /// Gets or sets settlement area type description on Ukrainian
            /// </summary>
            [DataMember]
            public string AreaDescription { get; set; }

            /// <summary>
            /// Gets or sets settlement area description on Russian
            /// </summary>
            [DataMember]
            public string AreaDescriptionRu { get; set; }

            /// <summary>
            /// Gets or sets settlement type description on Ukrainian
            /// </summary>
            [DataMember]
            public string SettlementTypeDescription { get; set; }

            /// <summary>
            /// Gets or sets settlement type description on Russian
            /// </summary>
            [DataMember]
            public string SettlementTypeDescriptionRu { get; set; }

            /// <summary>
            /// Gets or sets index #1
            /// </summary>
            [DataMember]
            public string Index1 { get; set; }

            /// <summary>
            /// Gets or sets index #2
            /// </summary>
            [DataMember]
            public string Index2 { get; set; }

            /// <summary>
            /// Gets or sets COATSU settlement index
            /// </summary>
            [DataMember]
            public string IndexCOATSU1 { get; set; }

            /// <summary>
            /// Gets or sets work day or not value
            /// </summary>
            [DataMember]
            public int Delivery1 { get; set; }

            /// <summary>
            /// Gets or sets work day or not value
            /// </summary>
            [DataMember]
            public int Delivery2 { get; set; }

            /// <summary>
            /// Gets or sets work day or not value
            /// </summary>
            [DataMember]
            public int Delivery3 { get; set; }

            /// <summary>
            /// Gets or sets work day or not value
            /// </summary>
            [DataMember]
            public int Delivery4 { get; set; }

            /// <summary>
            /// Gets or sets work day or not value
            /// </summary>
            [DataMember]
            public int Delivery5 { get; set; }

            /// <summary>
            /// Gets or sets work day or not value
            /// </summary>
            [DataMember]
            public int Delivery6 { get; set; }

            /// <summary>
            /// Gets or sets work day or not value
            /// </summary>
            [DataMember]
            public int Delivery7 { get; set; }

            /// <summary>
            /// Gets or sets settlement conglomerate keys collection
            /// </summary>
            [DataMember]
            public Guid[] Conglomerates { get; set; } = new Guid[0];

            /// <summary>
            /// Represents the settlement
            /// </summary>
            /// <returns>String</returns>
            public override string ToString()
            {
                return $"{SettlementTypeDescription} {Description}";
            }
        }
    }
}
