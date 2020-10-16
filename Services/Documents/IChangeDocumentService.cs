using Baroque.NovaPoshta.Client.Domain;
using Baroque.NovaPoshta.Client.Domain.Documents;

namespace Baroque.NovaPoshta.Client.Services.Documents
{
    /// <summary>
    /// Represents 'AdditionalService' model method for changing internet document content
    /// </summary>
    public interface IChangeDocumentService
    {
        /// <summary>
        /// Get document changes availability state
        /// </summary>
        /// <param name="documentNumber">Document number</param>
        /// <returns>Changes availability response</returns>
        IResponseEnvelope<CheckDocumentChangesAvailabilityResponse.ChangesAvailabilityItem> CheckPossibilityChangeEW(string documentNumber);

        /// <summary>
        /// Get document changes availability state
        /// </summary>
        /// <param name="checkDocumentChangesAvailabilityRequest">Chec the document changes availability state request</param>
        /// <returns>Changes availability response</returns>
        IResponseEnvelope<CheckDocumentChangesAvailabilityResponse.ChangesAvailabilityItem> CheckPossibilityChangeEW(CheckDocumentChangesAvailabilityRequest checkDocumentChangesAvailabilityRequest);
    }
}
