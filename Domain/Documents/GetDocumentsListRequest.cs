using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Documents
{
    /// <summary>
    /// Allow to get documents list by needed parameters. Represents method 'getDocumentsList' from 'InternetDocument' model
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/556eef34a0fe4f02049c664e/operations/557eb417a0fe4f02fc455b2c
    /// </summary>
    [DataContract]
    public class GetDocumentsListRequest
    {
        /// <summary>
        /// Gets or sets searching documents creation date time
        /// </summary>
        [DataMember]
        public string DateTime { get; set; }

        /// <summary>
        /// Gets or sets date to search documents created after this date
        /// </summary>
        [DataMember]
        public string DateTimeFrom { get; set; }

        /// <summary>
        /// Gets or sets date  to search documents created before this date
        /// </summary>
        [DataMember]
        public string DateTimeTo { get; set; }

        /// <summary>
        /// Gets or sets value to gel all documents list by one request without paging
        /// </summary>
        [DataMember]
        public int GetFullList { get; set; }

        /// <summary>
        /// Gets or sets page number. Each page contains 100 documents.
        /// </summary>
        [DataMember]
        public int Page { get; set; } = 1;     
    }
}
