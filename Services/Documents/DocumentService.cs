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


        /// <summary>
        /// Allow to get document approximately delivery date. Represents 'getDocumentDeliveryDate' method of 'InternetDocument' model.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/556eef34a0fe4f02049c664e/operations/558153cca0fe4f12149812a1
        /// </summary>
        /// <param name="cityRecipient">Recipient city reference key</param>
        /// <param name="citySender">Sender city recipient key</param>
        /// <param name="dateTime">Document creation date time</param>
        /// <param name="serviceType">Delivery service type. Like 'WarehouseWarehouse' and so on.</param>
        /// <returns>Estimated delivery date</returns>
        public virtual IResponseEnvelope<GetDocumentDeliveryDateResponse.ResponseItem> GetDocumentDeliveryDate(Guid citySender, Guid cityRecipient, string serviceType = "WarehouseWarehouse", DateTime? dateTime=null)
        {
            var request = new GetDocumentDeliveryDateRequest()
            {
                CitySender = citySender,
                CityRecipient = cityRecipient,
                ServiceType = serviceType,
                DateTime = dateTime.ParseToString()
            };

            return GetDocumentDeliveryDate(request);
        }


        /// <summary>
        /// Allow to get document approximately delivery date. Represents 'getDocumentDeliveryDate' method of 'InternetDocument' model.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/556eef34a0fe4f02049c664e/operations/558153cca0fe4f12149812a1
        /// </summary>
        /// <param name="getDocumentDeliveryDateRequest">Document delivery date request</param>
        /// <returns>Estimated delivery date</returns>
        public virtual IResponseEnvelope<GetDocumentDeliveryDateResponse.ResponseItem> GetDocumentDeliveryDate(GetDocumentDeliveryDateRequest getDocumentDeliveryDateRequest)
        {
            var request = new RequestEnvelope<GetDocumentDeliveryDateRequest>(getDocumentDeliveryDateRequest)
            {
                ApiKey = _novaPoshtaGateway.ApiKey,
                CalledMethod = "getDocumentDeliveryDate",
                ModelName = MODEL
            };

            var response = _novaPoshtaGateway.CreateRequest<GetDocumentDeliveryDateRequest, GetDocumentDeliveryDateResponse>(request);
            return response;
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
        /// Create internet document. represents 'save' method of 'InternetDocument' model.
        /// Documentation: https://developers.novaposhta.ua/view/model/a90d323c-8512-11ec-8ced-005056b2dbe1/method/a965630e-8512-11ec-8ced-005056b2dbe1
        /// </summary>
        /// <param name="createDocumentRequest">Create document request</param>
        /// <returns>Document creation result</returns>
        public virtual IResponseEnvelope<CreateDocumentResponse.CreationResult> CreateDocument(CreateDocumentRequest createDocumentRequest)
        {
            var request = new RequestEnvelope<CreateDocumentRequest>(createDocumentRequest)
            {
                ApiKey = _novaPoshtaGateway.ApiKey,
                CalledMethod = "save",
                ModelName = MODEL
            };

            var response = _novaPoshtaGateway.CreateRequest<CreateDocumentRequest, CreateDocumentResponse>(request);
            return response;
        }

        /// <summary>
        /// Updates internet document. Represents 'update' method of 'InternetDocument' model.
        /// Documentation: https://developers.novaposhta.ua/view/model/a90d323c-8512-11ec-8ced-005056b2dbe1/method/a98a4354-8512-11ec-8ced-005056b2dbe1
        /// </summary>
        /// <param name="updateDocumentRequest">Update document request</param>
        /// <returns>Document update result</returns>
        public virtual IResponseEnvelope<UpdateDocumentResponse.UpdateResult> UpdateDocument(UpdateDocumentRequest updateDocumentRequest)
        {
            var request = new RequestEnvelope<UpdateDocumentRequest>(updateDocumentRequest)
            {
                ApiKey = _novaPoshtaGateway.ApiKey,
                CalledMethod = "update",
                ModelName = MODEL
            };

            var response = _novaPoshtaGateway.CreateRequest<UpdateDocumentRequest, UpdateDocumentResponse>(request);
            return response;
        }

        /// <summary>
        /// Deletes internet document. Reprents 'delete' method of 'InternetDocument' model.
        /// Documentation: https://developers.novaposhta.ua/view/model/a90d323c-8512-11ec-8ced-005056b2dbe1/method/a9f43ff1-8512-11ec-8ced-005056b2dbe1
        /// </summary>
        /// <param name="reference">Deleting document unique reference key</param>
        /// <returns>Document deletion result</returns>
        public virtual IResponseEnvelope<DeleteDocumentResponse.DeletedDocument> DeleteDocument(Guid reference)
        {
            var request = new DeleteDocumentRequest()
            {
                DocumentRefs = reference
            };

            return DeleteDocument(request);
        }

        /// <summary>
        /// Deletes internet document. Reprents 'delete' method of 'InternetDocument' model.
        /// Documentation: https://developers.novaposhta.ua/view/model/a90d323c-8512-11ec-8ced-005056b2dbe1/method/a9f43ff1-8512-11ec-8ced-005056b2dbe1
        /// </summary>
        /// <param name="deleteDocumentRequest">Delete document request</param>
        /// <returns>Document deletion result</returns>
        public virtual IResponseEnvelope<DeleteDocumentResponse.DeletedDocument> DeleteDocument(DeleteDocumentRequest deleteDocumentRequest)
        {
            var request = new RequestEnvelope<DeleteDocumentRequest>(deleteDocumentRequest)
            {
                ApiKey = _novaPoshtaGateway.ApiKey,
                CalledMethod = "delete",
                ModelName = MODEL
            };

            var response = _novaPoshtaGateway.CreateRequest<DeleteDocumentRequest, DeleteDocumentResponse>(request);
            return response;
        }
    }
}
