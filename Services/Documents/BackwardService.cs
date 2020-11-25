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
    /// Represents document return service.
    /// </summary>
    public class BackwardService : IBackwardService
    {
        #region Fields

        private readonly INovaPoshtaGateway _novaPoshtaGateway;

        #endregion

        #region Constants

        public const string MODEL = "AdditionalService";

        #endregion

        #region Constructor

        public BackwardService(INovaPoshtaGateway novaPoshtaGateway)
        {
            _novaPoshtaGateway = novaPoshtaGateway;

            //somebody get great shit idea to change url specially for this service
            //_novaPoshtaGateway.
        }

        #endregion

        #region Methods

        /// <summary>
        /// Check document return possibility.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/58ad7185eea27006cc36d649/operations/58b6b830ff2c200cd80adb91
        /// </summary>
        /// <param name="number">Document tracking number. Stay empty if you need list of all documents.</param>
        /// <returns>List of documents</returns>
        public virtual IResponseEnvelope<CheckReturnPossibilityResponse.Document> CheckPossibilityCreateReturn(string number)
        {
            var request = new CheckReturnPossibilityRequest()
            {
                Number = number
            };

            return CheckPossibilityCreateReturn(request);
        }

        /// <summary>
        /// Check document return possibility.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/58ad7185eea27006cc36d649/operations/58b6b830ff2c200cd80adb91
        /// </summary>
        /// <param name="checkReturnPossibilityRequest">Request body</param>
        /// <returns>List of documents</returns>
        public virtual IResponseEnvelope<CheckReturnPossibilityResponse.Document> CheckPossibilityCreateReturn(CheckReturnPossibilityRequest checkReturnPossibilityRequest)
        {
            var request = new RequestEnvelope<CheckReturnPossibilityRequest>(checkReturnPossibilityRequest)
            {
                CalledMethod = "CheckPossibilityCreateReturn",
                ModelName = MODEL
            };

            var response = _novaPoshtaGateway.CreateRequest<CheckReturnPossibilityRequest, CheckReturnPossibilityResponse>(request);
            return response;
        }

        /// <summary>
        /// Get backward reasons list.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/58ad7185eea27006cc36d649/operations/58b6cd6aeea2700d141ccae1
        /// </summary>
        /// <returns></returns>
        public virtual IResponseEnvelope<GetBackwardReasonsListResponse.BackwardReason> GetReturnReasons()
        {
            var request = new RequestEnvelope<EmptyRequest>()
            {
                CalledMethod = "getReturnReasons",
                ModelName = MODEL
            };

            var response = _novaPoshtaGateway.CreateRequest<EmptyRequest, GetBackwardReasonsListResponse>(request);
            return response;
        }

        /// <summary>
        /// Get backward subreason types list.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/58ad7185eea27006cc36d649/operations/58b6cdb2ff2c200cd80adb92
        /// </summary>
        /// <param name="reasonReference">Backward reason reference code.</param>
        /// <returns>List of available backward subreasons.</returns>
        public virtual IResponseEnvelope<GetBackwardSubreasonsListResponse.BackwardSubreason> GetReturnReasonsSubtypes(Guid reasonReference)
        {
            var request = new GetBackwardSubreasonsListRequest()
            {
                ReasonRef = reasonReference
            };

            return GetReturnReasonsSubtypes(request);
        }

        /// <summary>
        /// Get backward subreason types list.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/58ad7185eea27006cc36d649/operations/58b6cdb2ff2c200cd80adb92
        /// </summary>
        /// <param name="getBackwardSubreasonsListRequest">Get backward subreason types request</param>
        /// <returns>List of available backward subreasons.</returns>
        public virtual IResponseEnvelope<GetBackwardSubreasonsListResponse.BackwardSubreason> GetReturnReasonsSubtypes(GetBackwardSubreasonsListRequest getBackwardSubreasonsListRequest)
        {
            var request = new RequestEnvelope<GetBackwardSubreasonsListRequest>(getBackwardSubreasonsListRequest)
            {
                CalledMethod = "getReturnReasonsSubtypes",
                ModelName = MODEL
            };

            var response = _novaPoshtaGateway.CreateRequest<GetBackwardSubreasonsListRequest, GetBackwardSubreasonsListResponse>(request);
            return response;
        }

        /// <summary>
        /// Create backward claim.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/58ad7185eea27006cc36d649/operations/58b6d227ff2c200cd80adb94
        /// </summary>
        /// <param name="createBackwardClaimRequest">Backward claim creation request</param>
        /// <returns>Backward claim creation result</returns>
        public virtual IResponseEnvelope<CreateBackwardClaimResponse.BackwardClaimCreationResult> CreateBackwardClaim(CreateBackwardClaimRequest createBackwardClaimRequest)
        {
            var request = new RequestEnvelope<CreateBackwardClaimRequest>(createBackwardClaimRequest)
            {
                CalledMethod = "save",
                ModelName = MODEL
            };

            var response = _novaPoshtaGateway.CreateRequest<CreateBackwardClaimRequest, CreateBackwardClaimResponse>(request);
            return response;
        }

        /// <summary>
        /// Get backward claims list
        /// </summary>
        /// <param name="getBackwardClaimListRequest">Get backward claims request</param>
        /// <returns>Backward claims list</returns>
        public virtual IResponseEnvelope<GetBackwardClaimListResponse.BackwardClaim> GetReturnOrdersList(GetBackwardClaimListRequest getBackwardClaimListRequest)
        {
            var request = new RequestEnvelope<GetBackwardClaimListRequest>(getBackwardClaimListRequest)
            {
                CalledMethod = "getReturnOrdersList",
                ModelName = MODEL
            };

            var response = _novaPoshtaGateway.CreateRequest<GetBackwardClaimListRequest, GetBackwardClaimListResponse>(request);
            return response;
        }

        /// <summary>
        /// Delete backward claim.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/58ad7185eea27006cc36d649/operations/58b6cdf4ff2c200cd80adb93
        /// </summary>
        /// <param name="deleteBackwardClaimRequest">Delete backward claim request</param>
        /// <returns>Delete backward claim response</returns>
        public virtual IResponseEnvelope<DeleteBackwardClaimResponse.ResponseItem> DeleteBackwardClaim(Guid reference)
        {
            var request = new DeleteBackwardClaimRequest()
            {
                Reference = reference
            };

            return DeleteBackwardClaim(request);
        }

        /// <summary>
        /// Delete backward claim.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/58ad7185eea27006cc36d649/operations/58b6cdf4ff2c200cd80adb93
        /// </summary>
        /// <param name="deleteBackwardClaimRequest">Delete backward claim request</param>
        /// <returns>Delete backward claim response</returns>
        public virtual IResponseEnvelope<DeleteBackwardClaimResponse.ResponseItem> DeleteBackwardClaim(DeleteBackwardClaimRequest deleteBackwardClaimRequest)
        {
            var request = new RequestEnvelope<DeleteBackwardClaimRequest>(deleteBackwardClaimRequest)
            {
                ModelName = MODEL,
                CalledMethod = "delete"
            };

            var response = _novaPoshtaGateway.CreateRequest<DeleteBackwardClaimRequest, DeleteBackwardClaimResponse>(request);
            return response;
        }

        #endregion
    }
}
