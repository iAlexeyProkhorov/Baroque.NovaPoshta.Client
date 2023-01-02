using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Documents
{
    /// <summary>
    /// Represent document update method request.
    /// Documentation: https://developers.novaposhta.ua/view/model/a90d323c-8512-11ec-8ced-005056b2dbe1/method/a98a4354-8512-11ec-8ced-005056b2dbe1
    /// </summary>
    [DataContract]
    public class UpdateDocumentResponse : BaseResponseEnvelope<UpdateDocumentResponse.UpdateResult>
    {
        /// <summary>
        /// Gets or sets document updating warnings
        /// </summary>
        [DataMember(Name = "warnings")]
        public string[] Warnings { get; set; } = new string[0];

        /// <summary>
        /// Gets or sets document updating errors
        /// </summary>
        [DataMember(Name = "errors")]
        public string[] Errors { get; set; } = new string[0];

        /// <summary>
        /// Represents document update result.
        /// </summary>
        [DataContract]
        public class UpdateResult : BaseRefItem
        {
            /// <summary>
            /// Gets or sets delivery cost.
            /// </summary>
            [DataMember]
            public decimal CostOnSite { get; set; }

            /// <summary>
            /// Gets or sets estimated delivery date. Date format: dd.MM.yyyy
            /// </summary>
            [DataMember]
            public string EstimatedDeliveryDate { get; set; }

            /// <summary>
            /// Gets or sets document tracking number.
            /// </summary>
            [DataMember]
            public string IntDocNumber { get; set; }

            /// <summary>
            /// Gets or sets document type.
            /// </summary>
            [DataMember]
            public string TypeDocument { get; set; }
        }
    }
}
