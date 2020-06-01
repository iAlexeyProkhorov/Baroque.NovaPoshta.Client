using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Countrparty
{
    /// <summary>
    /// Represents 'delete' method response of 'Counterparty' model.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/557eb8c8a0fe4f02fc455b2d/operations/557fd35da0fe4f105c08760e
    /// </summary>
    [DataContract]
    public class DeleteCounterpartyResponse : BaseResponseEnvelope<DeleteCounterpartyResponse.DeletedCounterparty>
    {
        /// <summary>
        /// Gets or sets request processing errors
        /// </summary>
        [DataMember(Name = "errors")]
        public string[] Errors { get; set; } = new string[0];

        /// <summary>
        /// Gets or sets request processing warnings
        /// </summary>
        [DataMember(Name = "warnings")]
        public string[] Warnigns { get; set; } = new string[0];

        /// <summary>
        /// Gets or sets request processing information
        /// </summary>
        [DataMember(Name = "info")]
        public string[] Information { get; set; } = new string[0];

        /// <summary>
        /// Represents counterparty removing result
        /// </summary>
        [DataContract]
        public class DeletedCounterparty : BaseRefItem
        {

        }
    }
}
