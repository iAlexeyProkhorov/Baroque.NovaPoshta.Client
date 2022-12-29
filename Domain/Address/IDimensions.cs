using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Address
{
    /// <summary>
    /// Represents object dimensions
    /// </summary>
    public interface IDimensions
    {
        /// <summary>
        /// Gets or sets package width
        /// </summary>
        [DataMember]
        int Width { get; set; }

        /// <summary>
        /// Gets or sets package height
        /// </summary>
        [DataMember]
        int Height { get; set; }

        /// <summary>
        /// Gets or sets package length
        /// </summary>
        [DataMember]
        int Length { get; set; }
    }
}
