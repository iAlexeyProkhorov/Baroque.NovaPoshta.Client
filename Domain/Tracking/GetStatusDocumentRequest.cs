using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Tracking
{
    /// <summary>
    /// Represents 'getStatusDocuments' request.
    /// https://developers.novaposhta.ua/view/model/a99d2f28-8512-11ec-8ced-005056b2dbe1/method/a9ae7bc9-8512-11ec-8ced-005056b2dbe1
    /// </summary>
    [DataContract]
    public class GetStatusDocumentRequest
    {
        /// <summary>
        /// Gets or sets list of serachable documents.
        /// </summary>
        [DataMember]
        public IList<Document> Documents { get; set; } = new List<Document>();

        /// <summary>
        /// Represents document for 'getStatusDocuments' request
        /// </summary>
        [DataContract]
        public class Document
        {
            /// <summary>
            /// Gets or sets document tracking number.Requeired
            /// </summary>
            [DataMember]
            public string DocumentNumber { get; set; }

            /// <summary>
            /// Gets or sets document owner phone number. Not required.
            /// </summary>
            [DataMember]
            public string Phone { get; set; }
        }
    }
}
