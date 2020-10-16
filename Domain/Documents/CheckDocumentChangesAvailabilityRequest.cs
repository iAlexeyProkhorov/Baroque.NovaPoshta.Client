using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Documents
{
    /// <summary>
    /// Represents 'CheckPossibilityChangeEW' method request of 'AdditionalService' model
    /// </summary>
    [DataContract]
    public class CheckDocumentChangesAvailabilityRequest
    {
        /// <summary>
        /// Gets or sets document tracking number
        /// </summary>
        [DataMember]
        public string IntDocNumber { get; set; }
    }
}
