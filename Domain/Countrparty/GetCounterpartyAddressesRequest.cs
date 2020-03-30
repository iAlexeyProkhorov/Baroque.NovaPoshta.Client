using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Countrparty
{
    /// <summary>
    /// Represents 'getCounterpartyAddresses' method request from 'Counterparty' model.
    /// Documenataion: https://devcenter.novaposhta.ua/docs/services/557eb8c8a0fe4f02fc455b2d/operations/557fdcb4a0fe4f105c087611
    /// </summary>
    [DataContract]
    public class GetCounterpartyAddressesRequest : BaseRefItem
    {
        /// <summary>
        /// Gets or sets counterparty type like Sender, Recipient.
        /// </summary>
        public string CounterpartyProperty { get; set; }
    }
}
