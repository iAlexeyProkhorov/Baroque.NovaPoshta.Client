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
        /// Get list of change requests.
        /// </summary>
        /// <param name="number">Gets or sets searching request number</param>
        /// <param name="reference">Gets or sets searching request reference key</param>
        /// <param name="beginDate">Gets or sets request searching start date. Format: dd.MM.yyyy</param>
        /// <param name="endDate">Gets or sets request searching end date. Format: dd.MM.yyyy</param>
        /// <param name="page">Gets or sets page number</param>
        /// <param name="limit">Gets or sets request quantity per page</param>
        /// <returns>Change request list response</returns>
        IResponseEnvelope<GetChangeRequestsListResponse.ChangesRequest> GetChangeEWOrdersList(string number, Guid? reference, DateTime beginDate, DateTime endDate, int page = 0, int limit = 100);

        /// <summary>
        /// Get list of change requests.
        /// </summary>
        /// <param name="getChangeRequestsListRequest">Change request list request</param>
        /// <returns>Change request list response</returns>
        IResponseEnvelope<GetChangeRequestsListResponse.ChangesRequest> GetChangeEWOrdersList(GetChangeRequestsListRequest getChangeRequestsListRequest);

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
