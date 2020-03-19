using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Address
{
    /// <summary>
    /// Counterparty creation result. Represents 'save' method response of 'Address' model.
    /// Description: https://devcenter.novaposhta.ua/docs/services/556d7ccaa0fe4f08e8f7ce43/operations/556d9925a0fe4f08e8f7ce4a
    /// </summary>
    [DataContract]
    public class CreateCounterpartyAddressResponse : BaseResponseEnvelope<CreateCounterpartyAddressResponse.CounterpartyAddress>
    {
        /// <summary>
        /// Represents counterparty address
        /// </summary>
        [DataContract]
        public class CounterpartyAddress : BaseRefItem
        {
            /// <summary>
            /// Gets or sets street name
            /// </summary>
            [DataMember]
            public string Description { get; set; }

            public override string ToString()
            {
                return Description;
            }
        }
    }
}
