using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Documents
{
    /// <summary>
    /// Represents document delete method response.
    /// Documentation: https://developers.novaposhta.ua/view/model/a90d323c-8512-11ec-8ced-005056b2dbe1/method/a9f43ff1-8512-11ec-8ced-005056b2dbe1
    /// </summary>
    public class DeleteDocumentResponse : BaseResponseEnvelope<DeleteDocumentResponse.DeletedDocument>
    {
        /// <summary>
        /// Represents deleted document
        /// </summary>
        [DataContract]
        public class DeletedDocument : BaseRefItem
        {

        }
    }
}
