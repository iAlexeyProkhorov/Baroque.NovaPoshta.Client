using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Address
{
    /// <summary>
    /// Street where 'Nova Poshta' service has warehouse. Represents 'getStreet' method of 'Address' model.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/556d7ccaa0fe4f08e8f7ce43/operations/556d8db0a0fe4f08e8f7ce47
    /// </summary>
    [DataContract]
    public class StreetGetResponse : BaseResponseEnvelope<StreetGetResponse.Street>
    {
        /// <summary>
        /// Represents street
        /// </summary>
        [DataContract]
        public class Street : BaseRefItem
        {
            /// <summary>
            /// Gets or sets street name on Ukrainian
            /// </summary>
            [DataMember]
            public string Description { get; set; }

            /// <summary>
            /// Gets or sets street reference key
            /// </summary>
            [DataMember]
            public string StreetsTypeRef { get; set; }

            /// <summary>
            /// Gets or sets street type
            /// </summary>
            [DataMember]
            public string StreetsType { get; set; }

            /// <summary>
            /// Returns street presentation
            /// </summary>
            /// <returns>String</returns>
            public override string ToString()
            {
                return $"{StreetsType} {Description}";
            }
        }
    }
}
