using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Documents
{
    /// <summary>
    /// Represents delete document chnages query response.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/59eef733ff2c200ce4f6f904/operations/59eefc71eea2700b202b9c44
    /// </summary>
    [DataContract]
    public class DeleteDocumentChangesResponse : BaseResponseEnvelope<DeleteDocumentChangesResponse.Item>
    {
        /// <summary>
        /// Represents response item
        /// </summary>
        [DataContract]
        public class Item
        {
            /// <summary>
            /// Gets or sets change request unique number
            /// </summary>
            [DataMember]
            public string Number { get; set; }
        }
    }
}
