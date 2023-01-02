using System;
using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Documents
{
    /// <summary>
    /// Represents delete document request.
    /// Documentation: https://developers.novaposhta.ua/view/model/a90d323c-8512-11ec-8ced-005056b2dbe1/method/a9f43ff1-8512-11ec-8ced-005056b2dbe1
    /// </summary>
    [DataContract]
    public class DeleteDocumentRequest
    {
        /// <summary>
        /// Gets or sets deleting document uniqu reference key. Required property.
        /// </summary>
        [DataMember]
        public Guid DocumentRefs { get; set; }
    }
}
