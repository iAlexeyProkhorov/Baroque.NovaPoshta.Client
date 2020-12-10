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
    /// Represents document redirection methods.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/58f722b3ff2c200c04673bd1/operations/58f7233eff2c200c04673bd2
    /// </summary>
    public interface IRedirectionService
    {
        /// <summary>
        /// Check document redirection possibility
        /// </summary>
        /// <param name="checkRedirectionPossibilityRequest">Check document redirection request</param>
        /// <returns>Check document redirection possibility response</returns>
        IResponseEnvelope<CheckRedirectionPossibilityResponse.ResponseItem> CheckPossibilityForRedirecting(CheckRedirectionPossibilityRequest checkRedirectionPossibilityRequest);

        // <summary>
        /// Create redirection claim
        /// </summary>
        /// <param name="createRedirectionClaimRequest">Redirection claim request</param>
        /// <returns>Redirection claim response</returns>
        IResponseEnvelope<CreateRedirectionClaimResponse.ResponseItem> CreateRedirectionClaim(CreateRedirectionClaimRequest createRedirectionClaimRequest);

        /// <summary>
        /// Delete redirection claim
        /// </summary>
        /// <param name="reference">Redirection request reference key</param>
        /// <returns>Redirection claim deleting response</returns>
        IResponseEnvelope<DeleteRedirectionClaimResponse.ResponseItem> DeleteRedirectionClaim(Guid reference);

        /// <summary>
        /// Delete redirection claim
        /// </summary>
        /// <param name="deleteRedirectionClaimRequest">Redirection claim delete request</param>
        /// <returns>Redirection claim deleting response</returns>
        IResponseEnvelope<DeleteRedirectionClaimResponse.ResponseItem> DeleteRedirectionClaim(DeleteRedirectionClaimRequest deleteRedirectionClaimRequest);
    }
}
