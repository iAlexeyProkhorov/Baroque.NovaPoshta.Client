using System;
using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.ScanSheet
{
    /// <summary>
    /// Represents 'removeDocuments' method response of 'ScanSheet' model.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/55662bd3a0fe4f10086ec96e/operations/556c6474a0fe4f08e8f7ce2e
    /// </summary>
    [DataContract]
    public class DeleteScanSheetDocumentsResponse : KernelResponseEnvelope<DeleteScanSheetDocumentsResponse.DataItem>
    {
        /// <summary>
        /// Represents response data item
        /// </summary>
        [DataContract]
        public class DataItem
        {
            /// <summary>
            /// Gets or sets scan shett references
            /// </summary>
            [DataMember]
            public ScanSheetRefsItem ScanSheetRefs { get; set; } = new ScanSheetRefsItem();
        }

        /// <summary>
        /// Represents scan sheet references
        /// </summary>
        public class ScanSheetRefsItem
        {
            /// <summary>
            /// Gets or sets scan sheet remove error items
            /// </summary>
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
