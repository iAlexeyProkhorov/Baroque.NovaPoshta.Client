using Baroque.NovaPoshta.Client.Domain;
using Baroque.NovaPoshta.Client.Domain.ScanSheet;
using System;
using System.Collections.Generic;

namespace Baroque.NovaPoshta.Client.Services.ScanSheets
{
    /// <summary>
    /// Represents scan sheet model methods
    /// </summary>
    public class ScanSheetService : IScanSheetService
    {
        #region Fields

        private readonly INovaPoshtaGateway _novaPoshtaGateway;

        #endregion

        #region Constants

        protected const string MODEL = "ScanSheet";

        #endregion

        #region Constructor

        public ScanSheetService(INovaPoshtaGateway novaPoshtaGateway)
        {
            this._novaPoshtaGateway = novaPoshtaGateway;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Get all account scan sheets.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/55662bd3a0fe4f10086ec96e/operations/556c7734a0fe4f08e8f7ce31
        /// </summary>
        /// <returns></returns>
        public virtual IResponseEnvelope<GetScanSheetListResponse.ScanSheet> GetScanSheets()
        {
            var request = new RequestEnvelope<EmptyRequest>()
            {
                ApiKey = _novaPoshtaGateway.ApiKey,
                CalledMethod = "getScanSheetList",
                ModelName = MODEL
            };

            var response = _novaPoshtaGateway.CreateRequest<EmptyRequest, GetScanSheetListResponse>(request);
            return response;
        }

        /// <summary>
        /// Get scan sheet data by guid
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/55662bd3a0fe4f10086ec96e/operations/556c72d7a0fe4f08e8f7ce30
        /// </summary>
        /// <param name="reference">Scan sheet reference key</param>
        /// <returns>Scan sheet</returns>
        public virtual IResponseEnvelope<GetScanSheetResponse.ScanSheet> GetScanSheet(Guid reference)
        {
            var request = new GetScanSheetRequest()
            {
                Reference = reference
            };

            return GetScanSheet(request);
        }

        /// <summary>
        /// Get scan sheet data
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/55662bd3a0fe4f10086ec96e/operations/556c72d7a0fe4f08e8f7ce30
        /// </summary>
        /// <param name="getScanSheetRequest">Get scan sheet request</param>
        /// <returns>Scan sheet</returns>
        public virtual IResponseEnvelope<GetScanSheetResponse.ScanSheet> GetScanSheet(GetScanSheetRequest getScanSheetRequest)
        {
            var request = new RequestEnvelope<GetScanSheetRequest>(getScanSheetRequest)
            {
                ApiKey = _novaPoshtaGateway.ApiKey,
                CalledMethod = "getScanSheet",
                ModelName = MODEL
            };

            var response = _novaPoshtaGateway.CreateRequest<GetScanSheetRequest, GetScanSheetResponse>(request);
            return response;
        }

        /// <summary>
        /// Insert documents into scansheet.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/55662bd3a0fe4f10086ec96e/operations/556c4786a0fe4f0634657b65
        /// </summary>
        /// <param name="documents">Document references</param>
        /// <param name="reference">Scansheet reference, if it's already existing</param>
        /// <returns>documents inserting result</returns>
        public virtual IResponseEnvelope<InsertDocumentsResponse.ScanSheet> InsertDocuments(IList<Guid> documents, Guid? reference = null)
        {
            var request = new InsertDocumentsRequest()
            {
                DocumentRefs = documents,
                Ref = reference
            };

            return InsertDocuments(request);
        }

        /// <summary>
        /// Insert documents into scansheet
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/55662bd3a0fe4f10086ec96e/operations/556c4786a0fe4f0634657b65
        /// </summary>
        /// <param name="insertDocumentsRequest">Insertd documents request</param>
        /// <returns>Documents inserting result</returns>
        public virtual IResponseEnvelope<InsertDocumentsResponse.ScanSheet> InsertDocuments(InsertDocumentsRequest insertDocumentsRequest)
        {
            var request = new RequestEnvelope<InsertDocumentsRequest>(insertDocumentsRequest)
            {
                CalledMethod = "insertDocuments",
                ModelName = MODEL
            };

            var response = _novaPoshtaGateway.CreateRequest<InsertDocumentsRequest, InsertDocumentsResponse>(request);
            return response;
        }

        /// <summary>
        /// Delete scan sheets by reference key
        /// https://developers.novaposhta.ua/view/model/a46fc4f4-8512-11ec-8ced-005056b2dbe1/method/a50e049b-8512-11ec-8ced-005056b2dbe1
        /// </summary>
        /// <param name="references">References collection</param>
        /// <returns>Removed references</returns>
        public virtual IBaseResponseEnvelope<DeleteScanSheetResponse.ScanSheetRefs> DeleteSchanSheet(IList<Guid> references)
        {
            var request = new DeleteScanSheetRequest()
            {
                ScanSheetRefs = references
            };

            return DeleteScanSheet(request);
        }

        /// <summary>
        /// Delete scan sheets by reference key
        /// https://developers.novaposhta.ua/view/model/a46fc4f4-8512-11ec-8ced-005056b2dbe1/method/a50e049b-8512-11ec-8ced-005056b2dbe1
        /// </summary>
        /// <param name="deleteScanSheetRequest">Delete scan sheet request</param>
        /// <returns>Removed references</returns>
        public virtual IBaseResponseEnvelope<DeleteScanSheetResponse.ScanSheetRefs> DeleteScanSheet(DeleteScanSheetRequest deleteScanSheetRequest)
        {
            var request = new RequestEnvelope<DeleteScanSheetRequest>(deleteScanSheetRequest)
            {
                ApiKey = _novaPoshtaGateway.ApiKey,
                CalledMethod = "deleteScanSheet",
                ModelName = MODEL
            };

            var response = _novaPoshtaGateway.CreateRequest<DeleteScanSheetRequest, DeleteScanSheetResponse>(request);
            return response;
        }

        #endregion
    }
}
