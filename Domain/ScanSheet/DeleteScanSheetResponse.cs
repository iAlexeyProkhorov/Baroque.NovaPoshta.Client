using System;
using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.ScanSheet
{
    /// <summary>
    /// Represents 'deleteScanSheet' response of 'ScanSheet' model.
    /// Documentation: https://developers.novaposhta.ua/view/model/a46fc4f4-8512-11ec-8ced-005056b2dbe1/method/a50e049b-8512-11ec-8ced-005056b2dbe1
    /// </summary>
    [DataContract]
    public class DeleteScanSheetResponse : KernelResponseEnvelope<DeleteScanSheetResponse.ScanSheetRefs>
    {
        /// <summary>
        /// Represents response data item
        /// </summary>
        [DataContract]
        public class DataItem
        {
            /// <summary>
            /// Gets or sets scan sheets references
            /// </summary>
            [DataMember]
            public ScanSheetRefs ScanSheetRefs { get; set; } = new ScanSheetRefs();
        }

        /// <summary>
        /// Represents scan sheet references
        /// </summary>
        [DataContract]
        public class ScanSheetRefs
        {
            /// <summary>
            /// Gets or sets scan sheet remove error items
            /// </summary>
            [DataMember]
            public ErrorItem[] Errors { get; set; } = new ErrorItem[0];
        }

        /// <summary>
        /// Represents scan sheet removing error
        /// </summary>
        [DataContract]
        public class ErrorItem : BaseRefItem
        {
            /// <summary>
            /// Gets or sets error message
            /// </summary>
            [DataMember]
            public string Error { get; set; }

            /// <summary>
            /// Gets or sets error type identification
            /// </summary>
            [DataMember]
            public Guid Number { get; set; }
        }
    }
}
