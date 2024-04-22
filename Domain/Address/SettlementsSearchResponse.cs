using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Address
{
    /// <summary>
    /// Represents search settlemnts response
    /// Documentation: https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a0eb83ab-8512-11ec-8ced-005056b2dbe1
    /// </summary>
    [DataContract]
    public class SettlementsSearchResponse: BaseResponseEnvelope<SettlementsSearchResponse.ResponseItem>
    {
        /// <summary>
        /// Represents settlements search response item
        /// </summary>
        [DataContract]
        public class ResponseItem
        {
            /// <summary>
            /// Gets or sets addresses quantity
            /// </summary>
            [DataMember(Name = "TotalCount")]
            public int TotalCount { get; set; }

            /// <summary>
            /// Gets or sets response addresses
            /// </summary>
            [DataMember(Name = "Addresses")]
            public IList<Settlement> Addresses { get; set; } = new List<Settlement>();

            /// <summary>
            /// Represents find locality(city) response item
            /// </summary>
            [DataContract]
            public class Settlement : BaseRefItem
            {
                /// <summary>
                /// Gets or sets warehouses quantity
                /// </summary>
                [DataMember(Name = "Warehouses")]
                public int WarehousesQuantity { get; set; }

                /// <summary>
                /// Gets or sets settlement name
                /// </summary>
                [DataMember(Name = "MainDescription")]
                public string MainDescription { get; set; }

                /// <summary>
                /// Gets or sets area name
                /// </summary>
                [DataMember(Name = "Area")]
                public string Area { get; set; }

                /// <summary>
                /// Gets or sets region name
                /// </summary>
                [DataMember(Name = "Region")]
                public string Region { get; set; }

                /// <summary>
                /// Gets or sets settlement type code like: city, village etc
                /// </summary>
                [DataMember(Name = "SettlementTypeCode")]
                public string SettlementTypeCode { get; set; }

                /// <summary>
                /// Gets or sets delivery city reference guid
                /// </summary>
                [DataMember(Name = "DeliveryCity")]
                public Guid DeliveryCity { get; set; }

                /// <summary>
                /// Returns the settlement representation
                /// </summary>
                /// <returns>String</returns>
                public override string ToString()
                {
                    return $"{SettlementTypeCode} {MainDescription}";
                }
            }
        }
    }
}
