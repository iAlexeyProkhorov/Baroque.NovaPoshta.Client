using System;
using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.ScanSheet
{
    /// <summary>
    /// Represents 'getScanSheet' method response of 'ScanSheet' model.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/55662bd3a0fe4f10086ec96e/operations/556c72d7a0fe4f08e8f7ce30
    /// </summary>
    [DataContract]
    public class GetScanSheetResponse : BaseResponseEnvelope<GetScanSheetResponse.ScanSheet>
    {
        /// <summary>
        /// Represents scan sheet
        /// </summary>
        [DataContract]
        public class ScanSheet : BaseRefItem
        {
            /// <summary>
            /// Gets or sets scan sheet number
            /// </summary>
            [DataMember]
            public string Number { get; set; }

            /// <summary>
            /// Gets or sets sacn sheet creation date
            /// </summary>
            [DataMember]
            public DateTime DateTime { get; set; }

            /// <summary>
            /// Gets or sets csan sheet documents count
            /// </summary>
            [DataMember]
            public int Count { get; set; }

            /// <summary>
            /// Gets or sets scan sheet city reference
            /// </summary>
            [DataMember]
            public Guid CitySenderReference { get; set; }

            /// <summary>
            /// Gets or sets sender city name
            /// </summary>
            [DataMember]
            public string CitySender { get; set; }

            /// <summary>
            /// Gets or sets sender city address reference
            /// </summary>
            [DataMember]
            public Guid SenderAddressRef { get; set; }

            /// <summary>
            /// Gets or sets sender address
            /// </summary>
            [DataMember]
            public string SenderAddress { get; set; }

            /// <summary>
            /// Gets or sets sender reference
            /// </summary>
            [DataMember]
            public Guid SenderRef { get; set; }

            /// <summary>
            /// Gets or sets sender presentation
            /// </summary>
            [DataMember]
            public string Sender { get; set; }
        }
    }
}
