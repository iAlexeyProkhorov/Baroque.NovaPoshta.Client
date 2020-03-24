using System;
using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Documents
{
    /// <summary>
    /// Allow to get approximately document delivery date. Represents 'getDocumentDeliveryDate' method response of 'InternetDocument' model.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/556eef34a0fe4f02049c664e/operations/558153cca0fe4f12149812a1
    /// </summary>
    [DataContract]
    public class GetDocumentDeliveryDateResponse:BaseResponseEnvelope<GetDocumentDeliveryDateResponse.ResponseItem>
    {
        [DataContract]
        public class ResponseItem
        {
            /// <summary>
            /// Gets or sets delivery date information
            /// </summary>
            [DataMember]
            public DeliveryDate DeliveryDate { get; set; } = new DeliveryDate();
        }

        /// <summary>
        /// Represents delivery date
        /// </summary>
        [DataContract]
        public class DeliveryDate
        {
            /// <summary>
            /// Gets or sets delivery date
            /// </summary>
            [DataMember(Name = "data")]
            public DateTime DateTime { get; set; }

            /// <summary>
            /// Gets or sets time zone type
            /// </summary>
            [DataMember(Name = "timezone_type")]
            public string TimeZoneType { get; set; }

            /// <summary>
            /// Gets or  sets time zone description
            /// </summary>
            [DataMember(Name ="timezone")]
            public string TimeZone { get; set; }
        }
    }
}
