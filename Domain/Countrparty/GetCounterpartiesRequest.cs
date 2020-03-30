using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Countrparty
{
    /// <summary>
    /// Allow to get account counterparties. Represents 'getCounterparties' method request for 'Counterparty' model.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/557eb8c8a0fe4f02fc455b2d/operations/557fd789a0fe4f105c08760f
    /// </summary>
    [DataContract]
    public class GetCounterpartiesRequest
    {
        /// <summary>
        /// Gets or sets counterarty type: 'Sender', 'Recipient' ans so on.
        /// Use 'Sender' value by default
        /// </summary>
        [DataMember]
        public string CounterpartyProperty { get; set; } = "Sender";

        /// <summary>
        /// Gets or sets find by string
        /// </summary>
        [DataMember]
        public string FindByString { get; set; }

        /// <summary>
        /// Gets or sets page number. Each page contains 100 counterparties.
        /// </summary>
        [DataMember]
        public int Page { get; set; } = 1;
    }
}
