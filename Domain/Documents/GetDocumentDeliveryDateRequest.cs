using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Baroque.NovaPoshta.Client.Domain.Documents
{
    /// <summary>
    /// Allow to get approximately document delivery date. Represents 'getDocumentDeliveryDate' method request of 'InternetDocument' model.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/556eef34a0fe4f02049c664e/operations/558153cca0fe4f12149812a1
    /// </summary>
    [DataContract]
    public class GetDocumentDeliveryDateRequest
    {
        /// <summary>
        /// Gets or sets document creation date
        /// </summary>
        [DataMember]
        public string DateTime { get; set; }

        /// <summary>
        /// Gets or sets service type: WarehouseWarehouse ane e.t.c
        /// </summary>
        [DataMember]
        public string ServiceType { get; set; }

        /// <summary>
        /// Gets or sets sender city reference code
        /// </summary>
        [DataMember]
        public Guid CitySender { get; set; }

        /// <summary>
        /// Gets or sets recipient city reference code
        /// </summary>
        [DataMember]
        public Guid CityRecipient { get; set; }
    }
}
