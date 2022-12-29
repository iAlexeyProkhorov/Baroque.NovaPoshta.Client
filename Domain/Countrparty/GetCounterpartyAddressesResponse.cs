using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Countrparty
{
    /// <summary>
    /// Represents 'getCounterpartyAddresses' method response from 'Counterparty' model.
    /// Documenataion: https://devcenter.novaposhta.ua/docs/services/557eb8c8a0fe4f02fc455b2d/operations/557fdcb4a0fe4f105c087611
    /// </summary>
    [DataContract]
    public class GetCounterpartyAddressesResponse : BaseResponseEnvelope<GetCounterpartyAddressesResponse.CounterpartyAddress>
    {
        /// <summary>
        /// Represents counterparty address
        /// </summary>
        [DataContract]
        public class CounterpartyAddress : BaseRefItem
        {
            /// <summary>
            /// Gets or sets address description
            /// </summary>
            [DataMember]
            public string Description { get; set; }

            public override string ToString()
            {
                return this.Description;
            }
        }

        [DataMember(Name = "errors")]
        public string[] Errors { get; set; } = new string[0];
    }
}
