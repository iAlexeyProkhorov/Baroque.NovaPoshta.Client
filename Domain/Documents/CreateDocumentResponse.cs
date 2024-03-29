﻿using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Documents
{
    /// <summary>
    /// Represents method 'save' request of 'InternetDocument' model.
    /// Documentation: https://developers.novaposhta.ua/view/model/a90d323c-8512-11ec-8ced-005056b2dbe1/method/a965630e-8512-11ec-8ced-005056b2dbe1
    /// </summary>
    [DataContract]
    public class CreateDocumentResponse : BaseResponseEnvelope<CreateDocumentResponse.CreationResult>
    {
        /// <summary>
        /// Gets or sets errors list
        /// </summary>
        [DataMember(Name = "errors")]
        public string[] Errors { get; set; } = new string[0];

        /// <summary>
        /// Gets or sets information messages
        /// </summary>
        [DataMember(Name = "info")]
        public string[] Info { get; set; } = new string[0];

        /// <summary>
        /// Gets or sets warnings list
        /// </summary>
        [DataMember(Name = "warnings")]
        public string[] Warnings { get; set; } = new string[0];

        /// <summary>
        /// Represents document creation result
        /// </summary>
        [DataContract]
        public class CreationResult : BaseRefItem
        {
            /// <summary>
            /// Gets or sets 
            /// </summary>
            [DataMember]
            public int CostOnSite { get; set; }

            /// <summary>
            /// Gets or sets 
            /// </summary>
            [DataMember]
            public string EstimatedDeliveryDate { get; set; }

            /// <summary>
            /// Gets or sets 
            /// </summary>
            [DataMember]
            public string IntDocNumber { get; set; }

            /// <summary>
            /// Gets or sets 
            /// </summary>
            [DataMember]
            public string TypeDocument { get; set; }
        }
    }
}
