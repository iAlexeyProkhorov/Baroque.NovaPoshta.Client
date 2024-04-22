using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Common
{
    /// <summary>
    /// Allow to get available tyre wheel types. Represents 'getTiresWheelsList' of 'Common' model.
    /// Documentation: https://developers.novaposhta.ua/view/model/a55b2c64-8512-11ec-8ced-005056b2dbe1/method/a66fada0-8512-11ec-8ced-005056b2dbe1
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
