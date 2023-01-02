using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Documents
{
    /// <summary>
    /// Represents document seat options
    /// </summary>
    [DataContract]
    public class Seat
    {
        /// <summary>
        /// Gets or sets seat volume. (In cubic meter)
        /// </summary>
        [DataMember(Name = "volumetricVolume")]
        public decimal VolumetricVolume { get; set; }

        /// <summary>
        /// Gets or sets seat width. (In centimeter)
        /// </summary>
        [DataMember(Name = "volumetricWidth")]
        public decimal VolumetricWidth { get; set; }

        /// <summary>
        /// Gets or sets seat length. (In centimeter)
        /// </summary>
        [DataMember(Name = "volumetricLength")]
        public decimal VolumetricLength { get; set; }

        /// <summary>
        /// Gets or sets seat height. (In centimeter)
        /// </summary>
        [DataMember(Name = "volumetricHeight")]
        public decimal VolumetricHeight { get; set; }

        /// <summary>
        /// Gets or sets seat weigth. (In kilograms)
        /// </summary>
        [DataMember(Name = "weight")]
        public decimal Weight { get; set; }
    }
}
