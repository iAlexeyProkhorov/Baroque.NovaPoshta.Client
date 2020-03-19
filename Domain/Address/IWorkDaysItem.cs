using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Address
{
    /// <summary>
    /// Represents workdays interface for some Nova Poshta service items
    /// </summary>
    public interface IWorkDaysItem
    {
        /// <summary>
        /// Gets or sets work day or not value
        /// </summary>
        [DataMember]
        int Delivery1 { get; set; }

        /// <summary>
        /// Gets or sets work day or not value
        /// </summary>
        [DataMember]
        int Delivery2 { get; set; }

        /// <summary>
        /// Gets or sets work day or not value
        /// </summary>
        [DataMember]
        int Delivery3 { get; set; }

        /// <summary>
        /// Gets or sets work day or not value
        /// </summary>
        [DataMember]
        int Delivery4 { get; set; }

        /// <summary>
        /// Gets or sets work day or not value
        /// </summary>
        [DataMember]
        int Delivery5 { get; set; }

        /// <summary>
        /// Gets or sets work day or not value
        /// </summary>
        [DataMember]
        int Delivery6 { get; set; }

        /// <summary>
        /// Gets or sets work day or not value
        /// </summary>
        [DataMember]
        int Delivery7 { get; set; }
    }
}
