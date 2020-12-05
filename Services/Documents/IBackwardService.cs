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
    /// Represents electronic document backward service 
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/58ad7185eea27006cc36d649/operations/58b6b830ff2c200cd80adb91
    /// </summary>
    public interface IBackwardService
    {
        /// <summary>
        /// Check document return possibility.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/58ad7185eea27006cc36d649/operations/58b6b830ff2c200cd80adb91
        /// </summary>
        /// <param name="number">Document tracking number. Stay empty if you need list of all documents.</param>
        /// <returns>List of documents</returns>
        IResponseEnvelope<CheckReturnPossibilityResponse.Document> CheckPossibilityCreateReturn(string number);

        /// <summary>
        /// Check document return possibility.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/58ad7185eea27006cc36d649/operations/58b6b830ff2c200cd80adb91
        /// </summary>
        /// <param name="checkReturnPossibilityRequest">Request body</param>
        /// <returns>List of documents</returns>
        IResponseEnvelope<CheckReturnPossibilityResponse.Document> CheckPossibilityCreateReturn(CheckReturnPossibilityRequest checkReturnPossibilityRequest);

        /// <summary>
        /// Get backward reasons list.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/58ad7185eea27006cc36d649/operations/58b6cd6aeea2700d141ccae1
        /// </summary>
        /// <returns></returns>
        IResponseEnvelope<GetBackwardReasonsListResponse.BackwardReason> GetReturnReasons();

        /// <summary>
        /// Get backward subreason types list.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/58ad7185eea27006cc36d649/operations/58b6cdb2ff2c200cd80adb92
        /// </summary>
        /// <param name="reasonReference">Backward reason reference code.</param>
        /// <returns>List of available backward subreasons.</returns>
        IResponseEnvelope<GetBackwardSubreasonsListResponse.BackwardSubreason> GetReturnReasonsSubtypes(Guid reasonReference);

        /// <summary>
        /// Get backward subreason types list.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/58ad7185eea27006cc36d649/operations/58b6cdb2ff2c200cd80adb92
        /// </summary>
        /// <param name="getBackwardSubreasonsListRequest">Get backward subreason types request</param>
        /// <returns>List of available backward subreasons.</returns>
        IResponseEnvelope<GetBackwardSubreasonsListResponse.BackwardSubreason> GetReturnReasonsSubtypes(GetBackwardSubreasonsListRequest getBackwardSubreasonsListRequest);

        /// <summary>
        /// Create backward claim.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/58ad7185eea27006cc36d649/operations/58b6d227ff2c200cd80adb94
        /// </summary>
        /// <param name="createBackwardClaimRequest">Backward claim creation request</param>
        /// <returns>Backward claim creation result</returns>
        IResponseEnvelope<CreateBackwardClaimResponse.BackwardClaimCreationResult> CreateBackwardClaim(CreateBackwardClaimRequest createBackwardClaimRequest);

        /// <summary>
        /// Get backward claims list
        /// </summary>
        /// <param name="getBackwardClaimListRequest">Get backward claims request</param>
        /// <returns>Backward claims list</returns>
        IResponseEnvelope<GetBackwardClaimListResponse.BackwardClaim> GetReturnOrdersList(GetBackwardClaimListRequest getBackwardClaimListRequest);

        /// <summary>
        /// Delete backward claim.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/58ad7185eea27006cc36d649/operations/58b6cdf4ff2c200cd80adb93
        /// </summary>
        /// <param name="deleteBackwardClaimRequest">Delete backward claim request</param>
        /// <returns>Delete backward claim response</returns>
        IResponseEnvelope<DeleteBackwardClaimResponse.ResponseItem> DeleteBackwardClaim(Guid reference);

        /// <summary>
        /// Delete backward claim.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/58ad7185eea27006cc36d649/operations/58b6cdf4ff2c200cd80adb93
        /// </summary>
        /// <param name="deleteBackwardClaimRequest">Delete backward claim request</param>
        /// <returns>Delete backward claim response</returns>
        IResponseEnvelope<DeleteBackwardClaimResponse.ResponseItem> DeleteBackwardClaim(DeleteBackwardClaimRequest deleteBackwardClaimRequest);
    }
}
