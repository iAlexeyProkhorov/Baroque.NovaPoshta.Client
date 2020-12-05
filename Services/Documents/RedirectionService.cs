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
using System.Collections.Generic;
using System.Text;

namespace Baroque.NovaPoshta.Client.Services.Documents
{
    /// <summary>
    /// Represents document redirection methods.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/58f722b3ff2c200c04673bd1/operations/58f7233eff2c200c04673bd2
    /// </summary>
    public class RedirectionService: IRedirectionService
    {
        #region Fields

        private readonly INovaPoshtaGateway _novaPoshtaGateway;

        #endregion

        #region Constants

        protected const string MODEL = "AdditionalServiceGeneral";

        #endregion

        #region Contructor

        public RedirectionService(INovaPoshtaGateway novaPoshtaGateway)
        {
            _novaPoshtaGateway = novaPoshtaGateway;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Check document redirection possibility
        /// </summary>
        /// <param name="checkRedirectionPossibilityRequest">Check document redirection request</param>
        /// <returns>Check document redirection possibility response</returns>
        public virtual IResponseEnvelope<CheckRedirectionPossibilityResponse.ResponseItem> CheckPossibilityForRedirecting(CheckRedirectionPossibilityRequest checkRedirectionPossibilityRequest)
        {
            var request = new RequestEnvelope<CheckRedirectionPossibilityRequest>(checkRedirectionPossibilityRequest)
            {
                CalledMethod = "checkPossibilityForRedirecting",
                ModelName = MODEL
            };

            var response = _novaPoshtaGateway.CreateRequest<CheckRedirectionPossibilityRequest, CheckRedirectionPossibilityResponse>(request);
            return response;
        }

        /// <summary>
        /// Create redirection claim
        /// </summary>
        /// <param name="createRedirectionClaimRequest">Redirection claim request</param>
        /// <returns>Redirection claim response</returns>
        public virtual IResponseEnvelope<CreateRedirectionClaimResponse.ResponseItem> CreateRedirectionClaim(CreateRedirectionClaimRequest createRedirectionClaimRequest)
        {
            var request = new RequestEnvelope<CreateRedirectionClaimRequest>(createRedirectionClaimRequest)
            {
                CalledMethod = "save",
                ModelName = MODEL
            };

            var response = _novaPoshtaGateway.CreateRequest<CreateRedirectionClaimRequest, CreateRedirectionClaimResponse>(request);
            return response;
        }

        #endregion
    }
}
