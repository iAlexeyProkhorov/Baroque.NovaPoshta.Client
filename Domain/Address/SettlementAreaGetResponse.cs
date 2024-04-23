using System;
using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Address
{
    /// <summary>
    /// Represents settlement areas response for 'getSettlementAreas' method
    /// Documentation: https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/c0bfb1a3-2a73-11ee-a60f-48df37b921db
    /// </summary>
    [DataContract]
    public partial class SettlementAreaGetResponse : BaseResponseEnvelope<SettlementAreaGetResponse.Area>
    {
        /// <summary>
        /// Represents area for settlements. 
        /// </summary>
        [DataContract]
        public partial class Area : BaseRefItem
        {
            /// <summary>
            /// Gets or sets
            /// </summary>
            [DataMember]
            public string Description { get; set; }

            /// <summary>
            /// Gets or sets area center settlement reference key
            /// </summary>
            [DataMember]
            public Guid AreaCenterReference { get; set; }

            /// <summary>
            /// Gets or sets region type name
            /// </summary>
            [DataMember]
            public string RegionType { get; set; }
        }
    }
}
