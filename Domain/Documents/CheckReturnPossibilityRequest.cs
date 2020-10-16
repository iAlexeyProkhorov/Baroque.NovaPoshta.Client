using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Documents
{
    /// <summary>
    /// Check document return possibility request.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/58ad7185eea27006cc36d649/operations/58b6b830ff2c200cd80adb91
    /// </summary>
    [DataContract]
    public class CheckReturnPossibilityRequest
    {
        /// <summary>
        /// Gets or sets document tracking number. Empty when need to receive list of doduments which can be return.
        /// </summary>
        [DataMember]
        public int? Number { get; set; }
    }
}
