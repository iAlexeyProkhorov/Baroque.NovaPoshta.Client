using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Address
{
    /// <summary>
    /// Represents 'update' method response of 'Address' model.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/556d7ccaa0fe4f08e8f7ce43/operations/556d9db5a0fe4f08e8f7ce4b
    /// </summary>
    [DataContract]
    public class UpdateCounterpartyAddressResponse : BaseResponseEnvelope<UpdateCounterpartyAddressResponse.CounterpartyAddress>
    {
        /// <summary>
        /// Represents counterparty address
        /// </summary>
        [DataContract]
        public class CounterpartyAddress : BaseRefItem
        {
            /// <summary>
            /// Gets or sets address value
            /// </summary>
            public string Description { get; set; }
        }
    }
}
