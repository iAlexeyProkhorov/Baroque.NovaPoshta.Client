using System;
using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Address
{
    /// <summary>
    /// Represents area region request body for 'getSettlementCountryRegion' method
    /// Documentation: https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a98072f9-2a78-11ee-a60f-48df37b921db
    /// </summary>
    [DataContract]
    public partial class AreaRegionGetRequest
    {
        [DataMember(Name = "AreaRef")]
        public Guid AreaReference { get; set; }
    }
}
