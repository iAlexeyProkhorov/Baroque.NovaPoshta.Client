using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Documents
{
    /// <summary>
    /// Represents change document response.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/59eef733ff2c200ce4f6f904/operations/59eef989eea2700b202b9c43
    /// </summary>
    [DataContract]
    public class ChangeDocumentResponse : BaseResponseEnvelope<ChangeDocumentResponse.Item>
    {
        /// <summary>
        /// Represents change response
        /// </summary>
        [DataContract]
        public class Item : BaseRefItem
        {
            /// <summary>
            /// Gets or sets document changes unique number
            /// </summary>
            [DataMember]
            public string Number { get; set; }
        }
    }
}
