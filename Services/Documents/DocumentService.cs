using Baroque.NovaPoshta.Client.Domain;
using Baroque.NovaPoshta.Client.Domain.Documents;
using Baroque.NovaPoshta.Client.Extensions;
using System;

namespace Baroque.NovaPoshta.Client.Services.Documents
{
    /// <summary>
    /// Represents 'InternalDocument' model service methods.
    /// </summary>
    public class DocumentService : IDocumentService
    {
        private readonly INovaPoshtaGateway _novaPoshtaGateway;

        public const string MODEL = "InternetDocument";

        public DocumentService(INovaPoshtaGateway novaPoshtaGateway)
        {
            this._novaPoshtaGateway = novaPoshtaGateway;
        }

        /// <summary>
        /// Estimate document price. Represents 'getDocumentPrice' method of 'InternetDocument' model.
        /// </summary>
        /// <param name="getDocumentPriceRequest">Get document price request</param>
        /// <returns>Calculated document price</returns>
        public virtual IResponseEnvelope<GetDocumentPriceResponse.PriceCalculationInfo> GetDocumentPrice(GetDocumentPriceRequest getDocumentPriceRequest)
        {
            var request = new RequestEnvelope<GetDocumentPriceRequest>(getDocumentPriceRequest)
            {
                ApiKey = _novaPoshtaGateway.ApiKey,
                CalledMethod = "getDocumentPrice",
                ModelName = MODEL
            };

            var response = _novaPoshtaGateway.CreateRequest<GetDocumentPriceRequest, GetDocumentPriceResponse>(request);
            return response;
        }

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
        public virtual IResponseEnvelope<GetDocumentListResponse.Document> GetDocumentList(DateTime? dateTime, DateTime? dateFrom, DateTime? dateTimeTo, int page = 1, bool getFullList = false)
        {
            var request = new GetDocumentsListRequest()
            {
                DateTime = dateTime.ParseToString(),
                DateTimeFrom = dateFrom.ParseToString(),
                DateTimeTo = dateTimeTo.ParseToString(),
                Page = page,
                GetFullList = getFullList.PaseToInt()
            };

            return GetDocumentList(request);
        }

        /// <summary>
        /// Get client documents list from 'Nova Poshta' service. Represents method 'getDocumentList' of 'InternalDocument' model.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/556eef34a0fe4f02049c664e/operations/557eb417a0fe4f02fc455b2c
        /// </summary>
        /// <param name="getDocumentsListRequest">Get documents list request</param>
        /// <returns>Documents list</returns>
        public virtual IResponseEnvelope<GetDocumentListResponse.Document> GetDocumentList(GetDocumentsListRequest getDocumentsListRequest)
        {
            var request = new RequestEnvelope<GetDocumentsListRequest>(getDocumentsListRequest)
            {
                ApiKey = _novaPoshtaGateway.ApiKey,
                CalledMethod = "getDocumentList",
                ModelName = MODEL
            };

            var response = _novaPoshtaGateway.CreateRequest<GetDocumentsListRequest, GetDocumentListResponse>(request);
            return response;
        }
    }
}
