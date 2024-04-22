using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Common
{
    /// <summary>
    /// Allow to get available package types. Represents 'getPackList' method of 'Common' model.
    /// Documentation: https://developers.novaposhta.ua/view/model/a55b2c64-8512-11ec-8ced-005056b2dbe1/method/a6492db4-8512-11ec-8ced-005056b2dbe1
    /// </summary>
    [DataContract]
    public class GetPackageTypesResponse : BaseResponseEnvelope<GetPackageTypesResponse.PackageType>
    {
        /// <summary>
        /// Represents package type
        /// </summary>
        [DataContract]
        public class PackageType : BaseRefItem
        {
            /// <summary>
            /// Gets or sets the package type description on Russian.
            /// </summary>
            [DataMember]
            public string Description { get; set; }

            /// <summary>
            /// Gets or sets the package type description on Ukrainian.
            /// </summary>
            [DataMember]
            public string DescriptionRu { get; set; }

            /// <summary>
            /// Gets or sets the pacakge type length. In millimeters.
            /// </summary>
            [DataMember]
            public decimal Length { get; set; }

            /// <summary>
            /// Gets or sets the package type height. In millimeters.
            /// </summary>
            [DataMember]
            public decimal Height { get; set; }

            /// <summary>
            /// Gets or sets the package type width. In millimeters.
            /// </summary>
            [DataMember]
            public decimal Width { get; set; }

            /// <summary>
            /// Gets or sets type of packing. Unusing.
            /// </summary>
            [DataMember]
            public string TypeOfPacking { get; set; }

            /// <summary>
            /// Ukrainian description
            /// </summary>
            /// <returns>String</returns>
            public override string ToString()
            {
                return this.Description;
            }
        }
    }
}
