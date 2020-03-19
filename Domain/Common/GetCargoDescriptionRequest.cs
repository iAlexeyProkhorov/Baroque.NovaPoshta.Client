using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Common
{
    /// <summary>
    /// Allow to get possible cargo description. Represents request for 'getCargoDescriptionList' method of 'Common' model.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/55702570a0fe4f0cf4fc53ed/operations/55702571a0fe4f0b64838908
    /// </summary>
    [DataContract]
    public class GetCargoDescriptionRequest
    {
        /// <summary>
        /// Gets or sets searched cargo description name
        /// </summary>
        [DataMember]
        public string FindByString { get; set; }

        /// <summary>
        /// Gets or sets response page number. One page contains 500 items.
        /// </summary>
        [DataMember]
        public int Page { get; set; } = 1;
    }
}
