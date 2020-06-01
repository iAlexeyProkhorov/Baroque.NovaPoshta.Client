using Baroque.NovaPoshta.Client.Domain;
using Baroque.NovaPoshta.Client.Domain.ScanSheet;
using System;
using System.Collections.Generic;

namespace Baroque.NovaPoshta.Client.Services.ScanSheets
{
    /// <summary>
    /// Represents scan sheet method interface
    /// </summary>
    public interface IScanSheetService
    {
        /// <summary>
        /// Get all account scan sheets.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/55662bd3a0fe4f10086ec96e/operations/556c7734a0fe4f08e8f7ce31
        /// </summary>
        /// <returns></returns>
        IResponseEnvelope<GetScanSheetListResponse.ScanSheet> GetScanSheets();

        /// <summary>
        /// Get scan sheet data by guid.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/55662bd3a0fe4f10086ec96e/operations/556c72d7a0fe4f08e8f7ce30
        /// </summary>
        /// <param name="reference">Scan sheet reference key</param>
        /// <returns>Scan sheet</returns>
        IResponseEnvelope<GetScanSheetResponse.ScanSheet> GetScanSheet(Guid reference);

        /// <summary>
        /// Get scan sheet data.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/55662bd3a0fe4f10086ec96e/operations/556c72d7a0fe4f08e8f7ce30
        /// </summary>
        /// <param name="getScanSheetRequest">Get scan sheet request</param>
        /// <returns>Scan sheet</returns>
        IResponseEnvelope<GetScanSheetResponse.ScanSheet> GetScanSheet(GetScanSheetRequest getScanSheetRequest);

        /// <summary>
        /// Insert documents into scansheet.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/55662bd3a0fe4f10086ec96e/operations/556c4786a0fe4f0634657b65
        /// </summary>
        /// <param name="documents">Document references</param>
        /// <param name="reference">Scansheet reference, if it's already existing</param>
        /// <returns>documents inserting result</returns>
        IResponseEnvelope<InsertDocumentsResponse.ScanSheet> InsertDocuments(IList<Guid> documents, Guid? reference = null);

        /// <summary>
        /// Insert documents into scansheet
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/55662bd3a0fe4f10086ec96e/operations/556c4786a0fe4f0634657b65
        /// </summary>
        /// <param name="insertDocumentsRequest">Insertd documents request</param>
        /// <returns>Documents inserting result</returns>
        IResponseEnvelope<InsertDocumentsResponse.ScanSheet> InsertDocuments(InsertDocumentsRequest insertDocumentsRequest);

        /// <summary>
        /// Delete scan sheets by reference key.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/55662bd3a0fe4f10086ec96e/operations/556c6a2da0fe4f08e8f7ce2f
        /// </summary>
        /// <param name="references">References collection</param>
        /// <returns>Removed references</returns>
        IBaseResponseEnvelope<DeleteScanSheetResponse.ScanSheetRefs> DeleteSchanSheet(IList<Guid> references);

        /// <summary>
        /// Delete scan sheets by reference key.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/55662bd3a0fe4f10086ec96e/operations/556c6a2da0fe4f08e8f7ce2f
        /// </summary>
        /// <param name="deleteScanSheetRequest">Delete scan sheet request</param>
        /// <returns>Removed references</returns>
        IBaseResponseEnvelope<DeleteScanSheetResponse.ScanSheetRefs> DeleteScanSheet(DeleteScanSheetRequest deleteScanSheetRequest);
    }
}
