using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Common
{
    /// <summary>
    /// Get list of available backward delivery cargo types. Represents 'getBackwardDeliveryCargoTypes' method response.
    /// Documentation: https://developers.novaposhta.ua/view/model/a55b2c64-8512-11ec-8ced-005056b2dbe1/method/a5b46873-8512-11ec-8ced-005056b2dbe1
    /// </summary>
    [DataContract]
    public class GetBackwardDeliveryCargoTypesResponse : BaseResponseEnvelope<GetBackwardDeliveryCargoTypesResponse.CargoType>
    {
        /// <summary>
        /// Represents backaward delivery cargo type
        /// </summary>
        [DataContract]
        public class CargoType
        {
            /// <summary>
            /// Gets or sets cargo type reference name
            /// </summary>
            [DataMember]
            public string Ref { get; set; }

            /// <summary>
            /// Gets or sets cargo type descirption. On Ukrainian.
            /// </summary>
            [DataMember]
            public string Description { get; set; }

            public override string ToString()
            {
                return this.Description;
            }
        }
    }
}
