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

        /// <summary>
        /// Allow to get document approximately delivery date. Represents 'getDocumentDeliveryDate' method of 'InternetDocument' model.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/556eef34a0fe4f02049c664e/operations/558153cca0fe4f12149812a1
        /// </summary>
        /// <param name="cityRecipient">Recipient city reference key</param>
        /// <param name="citySender">Sender city recipient key</param>
        /// <param name="dateTime">Document creation date time</param>
        /// <param name="serviceType">Delivery service type. Like 'WarehouseWarehouse' and so on.</param>
        /// <returns>Estimated delivery date</returns>
        IResponseEnvelope<GetDocumentDeliveryDateResponse.ResponseItem> GetDocumentDeliveryDate(Guid citySender, Guid cityRecipient, string serviceType = "WarehouseWarehouse", DateTime? dateTime = null);

        /// <summary>
        /// Allow to get document approximately delivery date. Represents 'getDocumentDeliveryDate' method of 'InternetDocument' model.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/556eef34a0fe4f02049c664e/operations/558153cca0fe4f12149812a1
        /// </summary>
        /// <param name="getDocumentDeliveryDateRequest">Document delivery date request</param>
        /// <returns>Estimated delivery date</returns>
        IResponseEnvelope<GetDocumentDeliveryDateResponse.ResponseItem> GetDocumentDeliveryDate(GetDocumentDeliveryDateRequest getDocumentDeliveryDateRequest);

        /// <summary>
        /// Estimate document price. Represents 'getDocumentPrice' method of 'InternetDocument' model.
        /// </summary>
        /// <param name="getDocumentPriceRequest">Get document price request</param>
        /// <returns>Calculated document price</returns>
        IResponseEnvelope<GetDocumentPriceResponse.PriceCalculationInfo> GetDocumentPrice(GetDocumentPriceRequest getDocumentPriceRequest);

        /// <summary>
        /// Create internet document. represents 'save' method of 'InternetDocument' model.
        /// Documentation: https://developers.novaposhta.ua/view/model/a90d323c-8512-11ec-8ced-005056b2dbe1/method/a965630e-8512-11ec-8ced-005056b2dbe1
        /// </summary>
        /// <param name="createDocumentRequest">Create document request</param>
        /// <returns>Document creation result</returns>
        IResponseEnvelope<CreateDocumentResponse.CreationResult> CreateDocument(CreateDocumentRequest createDocumentRequest);
    }
}
