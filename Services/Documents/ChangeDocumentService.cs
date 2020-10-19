using Baroque.NovaPoshta.Client.Domain;
using Baroque.NovaPoshta.Client.Domain.Documents;
using System;

namespace Baroque.NovaPoshta.Client.Services.Documents
{
    /// <summary>
    /// Represents 'AdditionalService' model method for changing internet document content
    /// </summary>
    public class ChangeDocumentService : IChangeDocumentService
    {
        #region Fields

        private readonly INovaPoshtaGateway _novaPoshtaGateway;

        #endregion

        #region Constants

        public const string MODEL = "AdditionalService";

        #endregion

        #region Constructor

        public ChangeDocumentService(INovaPoshtaGateway novaPoshtaGateway)
        {
            this._novaPoshtaGateway = novaPoshtaGateway;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Get document changes availability state
        /// </summary>
        /// <param name="documentNumber">Document number</param>
        /// <returns>Changes availability response</returns>
        public virtual IResponseEnvelope<CheckDocumentChangesAvailabilityResponse.ChangesAvailabilityItem> CheckPossibilityChangeEW(string documentNumber)
        {
            var request = new CheckDocumentChangesAvailabilityRequest()
            {
                IntDocNumber = documentNumber
            };

            return CheckPossibilityChangeEW(request);
        }

        /// <summary>
        /// Get document changes availability state
        /// </summary>
        /// <param name="checkDocumentChangesAvailabilityRequest">Chec the document changes availability state request</param>
        /// <returns>Changes availability response</returns>
        public virtual IResponseEnvelope<CheckDocumentChangesAvailabilityResponse.ChangesAvailabilityItem> CheckPossibilityChangeEW(CheckDocumentChangesAvailabilityRequest checkDocumentChangesAvailabilityRequest)
        {
            var request = new RequestEnvelope<CheckDocumentChangesAvailabilityRequest>(checkDocumentChangesAvailabilityRequest)
            {
                ApiKey = _novaPoshtaGateway.ApiKey,
                CalledMethod = "CheckPossibilityChangeEW",
                ModelName = MODEL
            };

            var response = _novaPoshtaGateway.CreateRequest<CheckDocumentChangesAvailabilityRequest, CheckDocumentChangesAvailabilityResponse>(request);
            return response;
        }

        /// <summary>
        /// Change internet document
        /// </summary>
        /// <param name="changeDocumentRequest">Change document request body</param>
        /// <returns>Document change response</returns>
        public virtual IResponseEnvelope<ChangeDocumentResponse.Item> ChangeDocument(ChangeDocumentRequest changeDocumentRequest)
        {
            var request = new RequestEnvelope<ChangeDocumentRequest>(changeDocumentRequest)
            {
                CalledMethod = "save",
                ModelName = MODEL
            };

            var response = _novaPoshtaGateway.CreateRequest<ChangeDocumentRequest, ChangeDocumentResponse>(request);
            return response;
        }

        /// <summary>
        /// Delete document changes request
        /// </summary>
        /// <param name="reference">Changes request reference key</param>
        /// <returns>Document changes deleting response.</returns>
        public virtual IResponseEnvelope<DeleteDocumentChangesResponse.Item> DeleteChangesRequest(Guid reference)
        {
            var request = new DeleteDocumentChangesRequest()
            {
                Reference = reference
            };

            return DeleteChangesRequest(request);
        }

        /// <summary>
        /// Delete document changes request
        /// </summary>
        /// <param name="deleteDocumentChangesRequest">Document changes delete request body.</param>
        /// <returns>Document changes deleting response.</returns>
        public virtual IResponseEnvelope<DeleteDocumentChangesResponse.Item> DeleteChangesRequest(DeleteDocumentChangesRequest deleteDocumentChangesRequest)
        {
            var request = new RequestEnvelope<DeleteDocumentChangesRequest>(deleteDocumentChangesRequest)
            {
                CalledMethod = "delete",
                ModelName = MODEL
            };

            var response = _novaPoshtaGateway.CreateRequest<DeleteDocumentChangesRequest, DeleteDocumentChangesResponse>(request);
            return response;
        }

        #endregion
    }
}
