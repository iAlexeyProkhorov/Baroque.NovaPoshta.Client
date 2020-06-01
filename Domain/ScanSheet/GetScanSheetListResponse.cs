using System;
using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.ScanSheet
{
    /// <summary>
    /// Represents 'getScanSheetList' method request of 'ScanSheet' model.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/55662bd3a0fe4f10086ec96e/operations/556c7734a0fe4f08e8f7ce31
    /// </summary>
    [DataContract]
    public class GetScanSheetListResponse : BaseResponseEnvelope<GetScanSheetListResponse.ScanSheet>
    {
        /// <summary>
        /// Represents scan sheet
        /// </summary>
        public class ScanSheet : BaseRefItem
        {
            /// <summary>
            /// Gets or sets scan sheet number
            /// </summary>
            [DataMember]
            public string Number { get; set; }

            /// <summary>
            /// Gets or sets scan sheet date time
            /// </summary>
            [DataMember]
            public DateTime DateTime { get; set; }

            /// <summary>
            /// Gets or sets scan sheet printed value. '1' or more when printed.
            /// </summary>
            [DataMember]
            public int Printed { get; set; }
        }
    }
}
