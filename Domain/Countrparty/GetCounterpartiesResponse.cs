using System;
using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Countrparty
{
    /// <summary>
    /// Allow to get account counterparties. Represents 'getCounterparties' method response for 'Counterparty' model.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/557eb8c8a0fe4f02fc455b2d/operations/557fd789a0fe4f105c08760f
    /// </summary>
    [DataContract]
    public class GetCounterpartiesResponse : BaseResponseEnvelope<GetCounterpartiesResponse.Counterparty>
    {
        /// <summary>
        /// Represents counterparty
        /// </summary>
        [DataContract]
        public class Counterparty : BaseRefItem
        {
            /// <summary>
            /// Gets or sets counterparty city reference number
            /// </summary>
            [DataMember]
            public Guid City { get; set; }

            /// <summary>
            /// Gets or sets some empty data :D
            /// </summary>
            [DataMember]
            public string CounterpartyId { get; set; }

            /// <summary>
            /// Gets or sets counterparty first name
            /// </summary>
            [DataMember]
            public string FirstName { get; set; }

            /// <summary>
            /// Gets or sets counterparty last name
            /// </summary>
            [DataMember]
            public string LastName { get; set; }

            /// <summary>
            /// Gets or sets counterparty middle name
            /// </summary>
            [DataMember]
            public string MiddleName { get; set; }

            /// <summary>
            /// Gets or sets counterparty ownership form reference.
            /// </summary>
            [DataMember]
            public Guid? OwnershipFormRef { get; set; }

            /// <summary>
            /// Gets or sets counterparty ownership form description on Ukrainian
            /// </summary>
            [DataMember]
            public string OwnershipFormDescription { get; set; }

            /// <summary>
            /// Gets or sets counterparty EDRPOU 
            /// </summary>
            [DataMember]
            public string EDRPOU { get; set; }

            /// <summary>
            /// Gets or sets counterparty type
            /// </summary>
            [DataMember]
            public string CounterpartyType { get; set; }

            public override string ToString()
            {
                return $"{LastName} {FirstName} {MiddleName}";
            }
        }
    }
}
