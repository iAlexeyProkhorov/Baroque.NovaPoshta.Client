using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.ScanSheet
{
    /// <summary>
    /// Represents 'deleteScanSheet' model request of 'ScanSheet' model.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/55662bd3a0fe4f10086ec96e/operations/556c6a2da0fe4f08e8f7ce2f
    /// </summary>
    [DataContract]
    public class DeleteScanSheetRequest
    {
        /// <summary>
        /// Gets or sets list of scan sheet references for removing 
        /// </summary>
        [DataMember]
        public IList<Guid> ScanSheetRefs { get; set; } = new List<Guid>();
    }
}
