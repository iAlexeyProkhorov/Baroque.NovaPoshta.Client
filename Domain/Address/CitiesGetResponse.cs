using System;
using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Address
{
    /// <summary>
    /// Represents cities search response implemented via 'getCities' method in 'Address' model.
    /// Documentation: https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a1e6f0a7-8512-11ec-8ced-005056b2dbe1
    /// </summary>
    [DataContract]
    public class CitiesGetResponse : BaseResponseEnvelope<CitiesGetResponse.City>
    {
        /// <summary>
        /// Represents city
        /// </summary>
        [DataContract]
        public class City : BaseRefItem, IWorkDaysItem
        {
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
            /// Gets or sets city area unique key
            /// </summary>
            [DataMember]
            public Guid Area { get; set; }

            /// <summary>
            /// Gets or sets settlement type key
            /// </summary>
            [DataMember]
            public Guid SettlementType { get; set; }

            /// <summary>
            /// Gets or sets I don't know what. No information in Nova Poshta docs
            /// </summary>
            [DataMember]
            public int IsBranch { get; set; }

            /// <summary>
            /// Gets or sets I don't know what. No information in Nova Poshta docs
            /// </summary>
            [DataMember]
            public string PreventEntryNewStreetsUser { get; set; }

            /// <summary>
            /// Gets or sets conglomerates
            /// </summary>
            [DataMember]
            public Guid[] Conglomerates { get; set; }

            /// <summary>
            /// Gets or sets city code
            /// </summary>
            [DataMember(Name = "CityID")]
            public int CityId { get; set; }

            /// <summary>
            /// Gets or sets settlement type description on Russian
            /// </summary>
            [DataMember]
            public string SettlementTypeDescriptionRu { get; set; }

            /// <summary>
            /// Gets or sets settlement type description on Ukrainian
            /// </summary>
            [DataMember]
            public string SettlementTypeDescription { get; set; }

            /// <summary>
            /// Represents city
            /// </summary>
            /// <returns>Sring</returns>
            public override string ToString()
            {
                return $"{SettlementTypeDescription} {Description}";
            }
        }
    }
}
