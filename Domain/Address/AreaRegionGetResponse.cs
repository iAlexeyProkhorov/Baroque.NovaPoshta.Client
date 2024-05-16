using System;
using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Address
{
    /// <summary>
    /// Represents area region response for 'getSettlementCountryRegion' method
    /// Documentation: https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a98072f9-2a78-11ee-a60f-48df37b921db
    /// </summary>
    [DataContract]
    public partial class AreaRegionGetResponse : BaseResponseEnvelope<AreaRegionGetResponse.Region>
    {
        /// <summary>
        /// Represents region entity for 'getSettlementCountryRegion' method response
        /// </summary>
        [DataContract]
        public class Region : BaseRefItem
        {
            /// <summary>
            /// Gets or sets area administrative center reference key
            /// </summary>
            [DataMember(Name = "AreaCenter")]
            public Guid AreaCenterReference { get; set; }

            /// <summary>
            /// Gets or sets region name
            /// </summary>
            [DataMember]
            public string Description { get; set; }

            /// <summary>
            /// Gets or sets region type
            /// </summary>
            [DataMember]
            public string RegionType { get; set; }
        }
    }
}