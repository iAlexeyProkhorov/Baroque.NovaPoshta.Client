using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.ContactPerson
{
    /// <summary>
    /// Represent 'delete' method response of 'ContactPerson' model.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/557eb8c8a0fe4f02fc455b2d/operations/55829aa2a0fe4f0adc08ef29
    /// </summary>
    [DataContract]
    public class DeleteContactPersonResponse : BaseResponseEnvelope<DeleteContactPersonResponse.DeletedItem>
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
        /// Represent deleted contact person
        /// </summary>
        [DataContract]
        public class DeletedItem : BaseRefItem
        {

        }
    }
}
