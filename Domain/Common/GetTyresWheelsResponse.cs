using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Common
{
    /// <summary>
    /// Allow to get available tyre wheel types. Represents 'getTiresWheelsList' of 'Common' model.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/55702570a0fe4f0cf4fc53ed/operations/55702571a0fe4f0b64838910
    /// </summary>
    [DataContract]
    public class GetTyresWheelsResponse : BaseResponseEnvelope<GetTyresWheelsResponse.TyreWheelType>
    {
        /// <summary>
        /// Represents tyre wheel type
        /// </summary>
        [DataContract]
        public class TyreWheelType : BaseRefItem
        {
            /// <summary>
            /// Gets or sets tyre wheels type description on Ukrainian.
            /// </summary>
            [DataMember]
            public string Description { get; set; }

            /// <summary>
            /// Gets or sets tyre wheels type description on Russian.
            /// </summary>
            [DataMember]
            public string DescriptionRu { get; set; }

            /// <summary>
            /// Gets or sets tyre wheels type weight
            /// </summary>
            [DataMember]
            public decimal Weight { get; set; }

            /// <summary>
            /// Gets or sets tyre weels type. It's tyres or wheels
            /// </summary>
            [DataMember]
            public string DescriptionType { get; set; }

            public override string ToString()
            {
                return Description;
            }
        }
    }
}
