using Baroque.NovaPoshta.Client.Domain;
using Baroque.NovaPoshta.Client.Domain.Documents;
using System;

namespace Baroque.NovaPoshta.Client.Services.Documents
{
    /// <summary>
    /// Represents 'InternalDocument' model service methods interface.
    /// </summary>
    public interface IDocumentService
    {
        /// <summary>
        /// Estimate document price. Represents 'getDocumentPrice' method of 'InternetDocument' model.
        /// </summary>
        /// <param name="getDocumentPriceRequest">Get document price request</param>
        /// <returns>Calculated document price</returns>
        IResponseEnvelope<GetDocumentPriceResponse.PriceCalculationInfo> GetDocumentPrice(GetDocumentPriceRequest getDocumentPriceRequest);

        /// <summary>
        /// Get client documents list from 'Nova Poshta' service. Represents method 'getDocumentList' of 'InternalDocument' model.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/556eef34a0fe4f02049c664e/operations/557eb417a0fe4f02fc455b2c
        /// </summary>
        /// <param name="dateTime">Search documents by creation date.</param>
        /// <param name="dateFrom">Search documents, which was created after this date.</param>
        /// <param name="dateTimeTo">Search documents created before this date.</param>
        /// <param name="page">Page number. Each page contains 100 items. If 'getFullList' has 'true' value page parameter aren't use.</param>
        /// <param name="getFullList">Display all searched documents without paging.</param>
        /// <returns>Documents list</returns>
        IResponseEnvelope<GetDocumentListResponse.Document> GetDocumentList(DateTime? dateTime, DateTime? dateFrom, DateTime? dateTimeTo, int page = 1, bool getFullList = false);

        /// <summary>
        /// Get client documents list from 'Nova Poshta' service. Represents method 'getDocumentList' of 'InternalDocument' model.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/556eef34a0fe4f02049c664e/operations/557eb417a0fe4f02fc455b2c
        /// </summary>
        /// <param name="getDocumentsListRequest">Get documents list request</param>
        /// <returns>Documents list</returns>
        IResponseEnvelope<GetDocumentListResponse.Document> GetDocumentList(GetDocumentsListRequest getDocumentsListRequest);
    }
}
