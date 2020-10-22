﻿using Baroque.NovaPoshta.Client.Domain;
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
        }

        #endregion

        #region Methods

        /// <summary>
        /// Check document return possibility.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/58ad7185eea27006cc36d649/operations/58b6b830ff2c200cd80adb91
        /// </summary>
        /// <param name="number">Document tracking number. Stay empty if you need list of all documents.</param>
        /// <returns>List of documents</returns>
        public virtual IResponseEnvelope<CheckReturnPossibilityResponse.Document> CheckPossibilityCreateReturn(int? number)
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

        #endregion
    }
}
