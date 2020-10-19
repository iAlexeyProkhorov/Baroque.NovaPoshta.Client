using Baroque.NovaPoshta.Client.Domain;
using Baroque.NovaPoshta.Client.Domain.Documents;
using System;

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

        /// <summary>
        /// Change internet document
        /// </summary>
        /// <param name="changeDocumentRequest">Change document request body</param>
        /// <returns>Document change response</returns>
        IResponseEnvelope<ChangeDocumentResponse.Item> ChangeDocument(ChangeDocumentRequest changeDocumentRequest);

        /// <summary>
        /// Delete document changes request
        /// </summary>
        /// <param name="reference">Changes request reference key</param>
        /// <returns>Document changes deleting response.</returns>
        IResponseEnvelope<DeleteDocumentChangesResponse.Item> DeleteChangesRequest(Guid reference);

        /// <summary>
        /// Delete document changes request
        /// </summary>
        /// <param name="deleteDocumentChangesRequest">Document changes delete request body.</param>
        /// <returns>Document changes deleting response.</returns>
        IResponseEnvelope<DeleteDocumentChangesResponse.Item> DeleteChangesRequest(DeleteDocumentChangesRequest deleteDocumentChangesRequest);
    }
}
