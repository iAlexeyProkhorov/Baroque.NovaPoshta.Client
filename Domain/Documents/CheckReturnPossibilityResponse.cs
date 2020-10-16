using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Documents
{
    /// <summary>
    /// Check document return possibility response.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/58ad7185eea27006cc36d649/operations/58b6b830ff2c200cd80adb91
    /// </summary>
    [DataContract]
    public class CheckReturnPossibilityResponse: BaseResponseEnvelope<CheckReturnPossibilityResponse.Document>
    {
        /// <summary>
        /// Represents document which can be return
        /// </summary>
        public class Document : BaseRefItem
        {
            /// <summary>
            /// Gets or sets noncash payments possibility
            /// </summary>
            [DataMember]
            public bool NonCash { get; set; }

            /// <summary>
            /// Gets or sets city name
            /// </summary>
            [DataMember]
            public string City { get; set; }

            /// <summary>
            /// Gets or sets counterparty name
            /// </summary>
            [DataMember]
            public string Counterparty { get; set; }

            /// <summary>
            /// Gets or sets counterparty address
            /// </summary>
            [DataMember]
            public string Address { get; set; }

            /// <summary>
            /// Gets or sets counterparty phone
            /// </summary>
            [DataMember]
            public string Phone { get; set; }
        }
    }
}
