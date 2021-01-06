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
using Baroque.NovaPoshta.Client.Extensions;
using System;

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

        /// <summary>
        /// Delete redirection claim
        /// </summary>
        /// <param name="reference">Redirection request reference key</param>
        /// <returns>Redirection claim deleting response</returns>
        public virtual IResponseEnvelope<DeleteRedirectionClaimResponse.ResponseItem> DeleteRedirectionClaim(Guid reference)
        {
            var request = new DeleteRedirectionClaimRequest()
            {
                Reference = reference
            };

            return DeleteRedirectionClaim(request);
        }

        /// <summary>
        /// Delete redirection claim
        /// </summary>
        /// <param name="deleteRedirectionClaimRequest">Redirection claim delete request</param>
        /// <returns>Redirection claim deleting response</returns>
        public virtual IResponseEnvelope<DeleteRedirectionClaimResponse.ResponseItem> DeleteRedirectionClaim(DeleteRedirectionClaimRequest deleteRedirectionClaimRequest)
        {
            var request = new RequestEnvelope<DeleteRedirectionClaimRequest>(deleteRedirectionClaimRequest)
            {
                CalledMethod = "delete",
                ModelName = MODEL
            };

            var response = _novaPoshtaGateway.CreateRequest<DeleteRedirectionClaimRequest, DeleteRedirectionClaimResponse>(request);
            return response;
        }

        /// <summary>
        /// Get redirection claims list
        /// </summary>
        /// <param name="reference">Claim reference key</param>
        /// <param name="number">Claim number</param>
        /// <param name="beginDate">Searching start date</param>
        /// <param name="endDate">Searching end date</param>
        /// <param name="page">List page number</param>
        /// <param name="limit">List page size</param>
        /// <returns></returns>
        public virtual IResponseEnvelope<GetRedirectionClaimListResponse.RedirectionClaimItem> GetRedirectionOrdersList(Guid? reference, string number, DateTime? beginDate, DateTime? endDate, int page = 0, int limit = 50)
        {
            var request = new GetRedirectionClaimListRequest()
            {
                Reference = reference,
                Number = number,
                BeginDate = beginDate.ParseToString(),
                EndDate = endDate.ParseToString(),
                Page = page,
                Limit = limit
            };

            return GetRedirectionOrdersList(request);
        }

        /// <summary>
        /// Get redirection claims list
        /// </summary>
        /// <param name="getRedirectionClaimListRequest">Redirection claims list request</param>
        /// <returns>Redirection claims list response</returns>
        public virtual IResponseEnvelope<GetRedirectionClaimListResponse.RedirectionClaimItem> GetRedirectionOrdersList(GetRedirectionClaimListRequest getRedirectionClaimListRequest)
        {
            var request = new RequestEnvelope<GetRedirectionClaimListRequest>(getRedirectionClaimListRequest)
            {
                CalledMethod = "getRedirectionOrdersList",
                ModelName = MODEL
            };

            var response = _novaPoshtaGateway.CreateRequest<GetRedirectionClaimListRequest, GetRedirectionClaimListResponse>(request);
            return response;
        }

        #endregion
    }
}
