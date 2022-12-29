using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Countrparty
{
    /// <summary>
    /// Represents 'getCounterpartyContactPerson' method request of 'Counterparty' model.
    /// Documentation: https://developers.novaposhta.ua/view/model/a28f4b04-8512-11ec-8ced-005056b2dbe1/method/a3575a67-8512-11ec-8ced-005056b2dbe1
    /// </summary>
    [DataContract]
    public class GetContactPersonRequest : BaseRefItem
    {
        /// <summary>
        /// Gets or sets response page number. Each page contains 100 items.
        /// </summary>
        [DataMember]
        public int Page { get; set; } 
    }
}
