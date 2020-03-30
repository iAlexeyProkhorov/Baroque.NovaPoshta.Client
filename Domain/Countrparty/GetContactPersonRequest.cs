using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Countrparty
{
    /// <summary>
    /// Represents 'getCounterpartyContactPerson' method request of 'Counterparty' model.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/557eb8c8a0fe4f02fc455b2d/operations/557fe424a0fe4f105c087612
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
