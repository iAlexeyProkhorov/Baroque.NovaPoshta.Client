using Baroque.NovaPoshta.Client.Domain.Tracking;
using Baroque.NovaPoshta.Client.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Baroque.NovaPoshta.Client.Services.Tracking
{
    /// <summary>
    /// Represents 'TrackingDocument' model methods.
    /// Documentation: https://developers.novaposhta.ua/view/model/a99d2f28-8512-11ec-8ced-005056b2dbe1/method/a9ae7bc9-8512-11ec-8ced-005056b2dbe1
    /// </summary>
    public class TrackingService : ITrackingService
    {
        #region Fields

        private readonly INovaPoshtaGateway _novaPoshtaGateway;

        #endregion

        #region Constants

        public const string MODEL = "TrackingDocument";

        #endregion

        #region Constructor

        public TrackingService(INovaPoshtaGateway novaPoshtaGateway)
        {
            _novaPoshtaGateway = novaPoshtaGateway;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets document statuse by input document number.
        /// </summary>
        /// <param name="documentNumber">Document tracking number</param>
        /// <returns>Document tracking status</returns>
        public virtual IResponseEnvelope<GetStatusDocumentResponse.TrackingDocument> GetStatusDocuments(string documentNumber, string recipientPhone = null)
        {
            var getStatusDocumentRequest = new GetStatusDocumentRequest();
            getStatusDocumentRequest.Documents.Add(
                new GetStatusDocumentRequest.Document()
                {
                    DocumentNumber = documentNumber,
                    Phone = recipientPhone
                });


            return GetStatusDocuments(getStatusDocumentRequest);
        }

        /// <summary>
        /// Gets list of document statuses by input documents number list.
        /// </summary>
        /// <param name="documentNumbers">List of documents tracking number</param>
        /// <returns>List of document tracking statuses</returns>
        public virtual IResponseEnvelope<GetStatusDocumentResponse.TrackingDocument> GetStatusDocuments(IList<string> documentNumbers)
        {
            var getStatusDocumentRequest = new GetStatusDocumentRequest()
            {
                Documents = documentNumbers.Select(documentNumber =>
                {
                    return new GetStatusDocumentRequest.Document()
                    {
                        DocumentNumber = documentNumber
                    };
                }).ToList()
            };

            return GetStatusDocuments(getStatusDocumentRequest);
        }

        /// <summary>
        /// Gets list of document statuses by input documents number list.
        /// </summary>
        /// <param name="getStatusDocumentRequest">Get status documents request properties</param>
        /// <returns>List of document tracking statuses</returns>
        public virtual IResponseEnvelope<GetStatusDocumentResponse.TrackingDocument> GetStatusDocuments(GetStatusDocumentRequest getStatusDocumentRequest)
        {
            var request = new RequestEnvelope<GetStatusDocumentRequest>()
            {
                CalledMethod = "getStatusDocuments",
                ModelName = MODEL,
                ApiKey = _novaPoshtaGateway.ApiKey,
                MethodProperties = getStatusDocumentRequest
            };

            var response = _novaPoshtaGateway.CreateRequest<GetStatusDocumentRequest, GetStatusDocumentResponse>(request);
            return response;
        }

        #endregion
    }
}
