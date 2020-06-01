using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.ScanSheet
{
    /// <summary>
    /// Represents 'insertDocuments' request of 'ScanSheet' model.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/55662bd3a0fe4f10086ec96e/operations/556c4786a0fe4f0634657b65
    /// </summary>
    [DataContract]
    public class InsertDocumentsRequest
    {
        /// <summary>
        /// Gets or sets scansheet reference if it's already existing in system
        /// </summary>
        [DataMember]
        public Guid? Ref { get; set; }

        /// <summary>
        /// Gets or sets list of documents references
        /// </summary>
        [DataMember]
        public IList<Guid> DocumentRefs { get; set; } = new List<Guid>();
    }
}
