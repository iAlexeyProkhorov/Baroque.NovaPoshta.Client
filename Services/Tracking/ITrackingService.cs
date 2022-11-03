using Baroque.NovaPoshta.Client.Domain;
using Baroque.NovaPoshta.Client.Domain.Tracking;
using System.Collections.Generic;

namespace Baroque.NovaPoshta.Client.Services.Tracking
{
    /// <summary>
    /// Represents interface for 'TrackingDocument' model methods service
    /// Documentation: https://developers.novaposhta.ua/view/model/a99d2f28-8512-11ec-8ced-005056b2dbe1/method/a9ae7bc9-8512-11ec-8ced-005056b2dbe1
    /// </summary>
    public interface ITrackingService
    {
        /// <summary>
        /// Gets document statuse by input document number.
        /// </summary>
        /// <param name="documentNumber">Document tracking number</param>
        /// <param name="recipientPhone">Recipient phone number</param>
        /// <returns>Document tracking status</returns>
        IResponseEnvelope<GetStatusDocumentResponse.TrackingDocument> GetStatusDocuments(string documentNumber, string recipientPhone = null);

        // <summary>
        /// Gets list of document statuses by input documents number list.
        /// </summary>
        /// <param name="documentNumbers">List of documents tracking number</param>
        /// <returns>List of document tracking statuses</returns>
        IResponseEnvelope<GetStatusDocumentResponse.TrackingDocument> GetStatusDocuments(IList<string> documentNumbers);

        /// <summary>
        /// Gets list of document statuses by input documents number list.
        /// </summary>
        /// <param name="getStatusDocumentRequest">Get status documents request properties</param>
        /// <returns>List of document tracking statuses</returns>
        IResponseEnvelope<GetStatusDocumentResponse.TrackingDocument> GetStatusDocuments(GetStatusDocumentRequest getStatusDocumentRequest);
    }
}
