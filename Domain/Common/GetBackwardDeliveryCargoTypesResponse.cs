using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Common
{
    /// <summary>
    /// Get list of available backward delivery cargo types. Represents 'getBackwardDeliveryCargoTypes' method response.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/55702570a0fe4f0cf4fc53ed/operations/55702571a0fe4f0b64838907
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
