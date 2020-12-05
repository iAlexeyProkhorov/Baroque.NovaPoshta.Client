//Copyright 2020 Alexey Prokhorov

//Licensed under the Apache License, Version 2.0 (the "License");
//you may not use this file except in compliance with the License.
//You may obtain a copy of the License at

//    http://www.apache.org/licenses/LICENSE-2.0

//Unless required by applicable law or agreed to in writing, software
//distributed under the License is distributed on an "AS IS" BASIS,
//WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//See the License for the specific language governing permissions and
//limitations under the License.

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
        /// Get list of change requests.
        /// </summary>
        /// <param name="number">Gets or sets searching request number</param>
        /// <param name="reference">Gets or sets searching request reference key</param>
        /// <param name="beginDate">Gets or sets request searching start date. Format: dd.MM.yyyy</param>
        /// <param name="endDate">Gets or sets request searching end date. Format: dd.MM.yyyy</param>
        /// <param name="page">Gets or sets page number</param>
        /// <param name="limit">Gets or sets request quantity per page</param>
        /// <returns>Change request list response</returns>
        public virtual IResponseEnvelope<GetChangeRequestsListResponse.ChangesRequest> GetChangeEWOrdersList(string number, Guid? reference, DateTime beginDate, DateTime endDate, int page = 0, int limit = 100)
        {
            var request = new GetChangeRequestsListRequest()
            {
                BeginDate = beginDate.ToString("dd.MM.yyyy"),
                EndDate = beginDate.ToString("dd.MM.yyyy"),
                Limit = limit,
                Number = number,
                Page = page,
                Ref = reference
            };

            return GetChangeEWOrdersList(request);
        }

        /// <summary>
        /// Get list of change requests.
        /// </summary>
        /// <param name="getChangeRequestsListRequest">Change request list request</param>
        /// <returns>Change request list response</returns>
        public virtual IResponseEnvelope<GetChangeRequestsListResponse.ChangesRequest> GetChangeEWOrdersList(GetChangeRequestsListRequest getChangeRequestsListRequest)
        {
            var request = new RequestEnvelope<GetChangeRequestsListRequest>(getChangeRequestsListRequest)
            {
                ApiKey = _novaPoshtaGateway.ApiKey,
                CalledMethod = "getChangeEWOrdersList",
                ModelName = MODEL
            };

            var response = _novaPoshtaGateway.CreateRequest<GetChangeRequestsListRequest, GetChangeRequestsListResponse>(request);
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
