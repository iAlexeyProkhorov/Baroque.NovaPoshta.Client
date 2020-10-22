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
        IResponseEnvelope<CheckReturnPossibilityResponse.Document> CheckPossibilityCreateReturn(int? number);

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
    }
}
