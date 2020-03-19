using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Address
{
    /// <summary>
    /// Represents week
    /// </summary>
    [DataContract]
    public class Week
    {
        /// <summary>
        /// Gets or sets Monday value
        /// </summary>
        [DataMember]
        public string Monday { get; set; }

        /// <summary>
        /// Gets or sets Tueday value
        /// </summary>
        [DataMember]
        public string Tuesday { get; set; }

        /// <summary>
        /// Gets or sets Wednesday value
        /// </summary>
        [DataMember]
        public string Wednesday { get; set; }

        /// <summary>
        /// Gets or sets Thursday value
        /// </summary>
        [DataMember]
        public string Thursday { get; set; }

        /// <summary>
        /// Gets or sets Friday value
        /// </summary>
        [DataMember]
        public string Friday { get; set; }

        /// <summary>
        /// Gets or sets Saturday value
        /// </summary>
        [DataMember]
        public string Saturday { get; set; }

        /// <summary>
        /// Gets or sets Sunday value
        /// </summary>
        [DataMember]
        public string Sunday { get; set; }
    }
}
