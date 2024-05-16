using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Address
{
    /// <summary>
    /// Represents search street response
    /// Documentation: https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a1329635-8512-11ec-8ced-005056b2dbe1
    /// </summary>
    [DataContract]
    public class StreetSearchResponse : BaseResponseEnvelope<StreetSearchResponse.ResponseItem>
    {
        /// <summary>
        /// Represents street search response item
        /// </summary>
        [DataContract]
        public class ResponseItem
        {
            /// <summary>
            /// Gets or sets total items count
            /// </summary>
            [DataMember]
            public int TotalCount { get; set; }

            [DataMember]
            public List<StreetItem> Addresses { get; set; } = new List<StreetItem>();

            /// <summary>
            /// Represents street item
            /// </summary>
            [DataContract]
            public class StreetItem
            {
                /// <summary>
                /// 
                /// </summary>
                [DataMember(Name = "SettlementRef")]
                public Guid SettlementRef { get; set; }

                /// <summary>
                /// 
                /// </summary>
                [DataMember(Name = "SettlementStreetRef")]
                public Guid SettlementStreetRef { get; set; }

                /// <summary>
                /// 
                /// </summary>
                [DataMember(Name = "SettlementStreetDescription")]
                public string SettlementStreetDescription { get; set; }

                /// <summary>
                /// Gets or sets street full description
                /// </summary>
                [DataMember]
                public string Present { get; set; }

                /// <summary>
                /// Gets or sets streets type guid
                /// </summary>
                [DataMember]
                public Guid StreetsType { get; set; }

                /// <summary>
                /// Gets or sets street type name. Like 'street' or square
                /// </summary>
                [DataMember]
                public string StreetsTypeDescription { get; set; }

                /// <summary>
                /// Gets or sets street location
                /// </summary>
                [DataMember]
                public Location Location { get; set; }

                /// <summary>
                /// Returns street representation
                /// </summary>
                /// <returns>String</returns>
                public override string ToString()
                {
                    return this.Present;
                }
            }
        }

        /// <summary>
        /// Represents street geografical location coordinates
        /// </summary>
        [DataContract]
        public class Location
        {
            /// <summary>
            /// Gets or sets coordinates latitude
            /// </summary>
            [DataMember(Name ="lat")]
            public double Latitude { get; set; }

            /// <summary>
            /// Gets or sets coordinates longitude
            /// </summary>
            [DataMember(Name = "lon")]
            public double Longitude { get; set; }
        }
    }
}
