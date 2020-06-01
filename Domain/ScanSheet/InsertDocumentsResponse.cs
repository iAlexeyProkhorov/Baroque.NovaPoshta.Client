using System;
using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.ScanSheet
{
    /// <summary>
    /// Represents 'insertDocuments' response of 'ScanSheet' model.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/55662bd3a0fe4f10086ec96e/operations/556c4786a0fe4f0634657b65
    /// </summary>
    [DataContract]
    public class InsertDocumentsResponse : BaseResponseEnvelope<InsertDocumentsResponse.ScanSheet>
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
            /// Gets or sets scan sheet date
            /// </summary>
            [DataMember]
            public DateTime Date { get; set; }

            /// <summary>
            /// Gets or sets scan sheet data
            /// </summary>
            [DataMember]
            public Data Data { get; set; } = new Data();
        }

        /// <summary>
        /// Represents scan sheet creation data
        /// </summary>
        [DataContract]
        public class Data
        {
            /// <summary>
            /// Gets or sets createion errors
            /// </summary>
            [DataMember]
            public Error[] Errors { get; set; } = new Error[0];
        }

        /// <summary>
        /// Represents data error
        /// </summary>
        public class Error : BaseRefItem
        {
            /// <summary>
            /// Gets or sets error description
            /// </summary>
            [DataMember(Name = "Error")]
            public string Description { get; set; }

            /// <summary>
            /// Gets or sets error number
            /// </summary>
            [DataMember]
            public string Number { get; set; }
        }
    }
}
