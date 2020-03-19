using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Common
{
    /// <summary>
    /// Allow to get possible cargo types. Represents 'getCartoTypes' method 'Common' model response.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/55702570a0fe4f0cf4fc53ed/operations/55702571a0fe4f0b64838909
    /// </summary>
    [DataContract]
    public class GetCargoTypesResponse : BaseResponseEnvelope<GetCargoTypesResponse.CargoType>
    {
        /// <summary>
        /// Represents cargo type
        /// </summary>
        [DataContract]
        public class CargoType
        {
            /// <summary>
            /// Gets or sets cargo type name. On Ukrainian.
            /// </summary>
            [DataMember]
            public string Description { get; set; }

            /// <summary>
            /// Gets or sets cargo type reference name
            /// </summary>
            [DataMember]
            public string Ref { get; set; }

            public override string ToString()
            {
                return Description;
            }
        }
    }
}
