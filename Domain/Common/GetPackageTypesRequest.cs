using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Common
{
    /// <summary>
    /// Allow to get available package types. Represents 'getPackList' method of 'Common' model.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/55702570a0fe4f0cf4fc53ed/operations/582b1069a0fe4f0298618f06
    /// </summary>
    [DataContract]
    public class GetPackageTypesRequest
    {
        /// <summary>
        /// Gets or sets searching package type length
        /// </summary>
        [DataMember]
        public decimal? Length { get; set; }

        /// <summary>
        /// Gets or sets searching package type width
        /// </summary>
        [DataMember]
        public decimal? Width { get; set; }

        /// <summary>
        /// Gets or sets searching package type height
        /// </summary>
        [DataMember]
        public decimal? Height { get; set; }

        /// <summary>
        /// Gets or sets searching type of packing. This value are empty for all package types, so it's not require to put something here.
        /// </summary>
        [DataMember]
        public string TypeOfPacking { get; set; }
    }
}
