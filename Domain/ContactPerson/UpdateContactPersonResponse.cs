using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.ContactPerson
{
    /// <summary>
    /// Represents 'update' method response of 'ContactPerson' model.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/557eb8c8a0fe4f02fc455b2d/operations/558297aca0fe4f0adc08ef28
    /// </summary>
    [DataContract]
    public class UpdateContactPersonResponse : BaseResponseEnvelope<CounterpartyContactPerson>
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
    }
}

