using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Address
{
    /// <summary>
    /// Counterparty creation result. Represents 'save' method response of 'Address' model.
    /// Description: https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a155d0d9-8512-11ec-8ced-005056b2dbe1
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

        [DataMember(Name = "errors")]
        public string[] Errors { get; set; }
    }
}
