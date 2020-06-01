using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Countrparty
{
    /// <summary>
    /// Represents 'update' method of 'Counterparty' model.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/557eb8c8a0fe4f02fc455b2d/operations/557fbe62a0fe4f105c08760d
    /// </summary>
    [DataContract]
    public class UpdateCounterpartyResponse : BaseResponseEnvelope<CounterpartyCreateOrUpdate>
    {
        /// <summary>
        /// Gets or sets request processing errors
        /// </summary>
        [DataMember(Name = "errors")]
        public string[] Errors { get; set; } = new string[0];

        /// <summary>
        /// Gets or sets request processing information
        /// </summary>
        [DataMember(Name = "info")]
        public string[] Information { get; set; } = new string[0];
    }
}
