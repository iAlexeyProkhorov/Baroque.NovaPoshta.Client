using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.ScanSheet
{
    /// <summary>
    /// Represents 'removeDocuments' method request of 'ScanSheet' model.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/55662bd3a0fe4f10086ec96e/operations/556c6474a0fe4f08e8f7ce2e
    /// </summary>
    [DataContract]
    public class DeleteScanSheetDocumentsRequest
    {
        /// <summary>
        /// Gets or sets document references
        /// </summary>
        [DataMember]
        public IList<Guid> DocumentRefs { get; set; } = new List<Guid>();
    }
}
