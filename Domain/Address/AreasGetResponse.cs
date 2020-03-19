using System;
using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Address
{
    /// <summary>
    /// Contains list of Ukraine areas. Represents 'getAreas' method response of 'Address' model. 
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/556d7ccaa0fe4f08e8f7ce43/operations/556d9130a0fe4f08e8f7ce48
    /// </summary>
    [DataContract]
    public class AreasGetResponse : BaseResponseEnvelope<AreasGetResponse.Area>
    {
        /// <summary>
        /// Represents area
        /// </summary>
        [DataContract]
        public class Area : BaseRefItem
        {
            /// <summary>
            /// Gets or sets area name
            /// </summary>
            [DataMember]
            public string Description { get; set; }

            /// <summary>
            /// Gets or sets area city cented guid code
            /// </summary>
            [DataMember]
            public Guid AreasCenter { get; set; }

            /// <summary>
            /// Represents area
            /// </summary>
            /// <returns>String</returns>
            public override string ToString()
            {
                return Description;
            }
        }
    }
}
