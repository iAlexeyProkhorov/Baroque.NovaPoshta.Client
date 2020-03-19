using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Common
{
    /// <summary>
    /// Allow to get existing counterparty types. Represents 'getTypesOfCounterparties' method response of 'Common' model.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/55702570a0fe4f0cf4fc53ed/operations/55702571a0fe4f0b64838912
    /// </summary>
    [DataContract]
    public class GetCounterpatyTypesResponse: BaseResponseEnvelope<GetCounterpatyTypesResponse.CounterpartyType>
    {
        /// <summary>
        /// Represent counterpary type
        /// </summary>
        [DataContract]
        public class CounterpartyType
        {
            /// <summary>
            /// Gets or sets counterparty type reference
            /// </summary>
            [DataMember]
            public string Ref { get; set; }

            /// <summary>
            /// Gets or sets counterparty type description on Ukrainian
            /// </summary>
            [DataMember]
            public string Description { get; set; }

            /// <summary>
            /// Get counterparty type description on Ukrainian
            /// </summary>
            /// <returns>String</returns>
            public override string ToString()
            {
                return this.Description;
            }
        }
    }
}
