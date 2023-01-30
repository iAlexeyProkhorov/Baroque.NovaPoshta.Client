using Baroque.NovaPoshta.Client.Domain;
using Baroque.NovaPoshta.Client.Domain.Common;
using System;
using System.Threading.Tasks;

namespace Baroque.NovaPoshta.Client.Services.Common
{
    /// <summary>
    /// Represents methods collection for 'Common' model.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/55702570a0fe4f0cf4fc53ed/operations/55702571a0fe4f0b6483890f
    /// </summary>
    public interface ICommonService
    {
        /// <summary>
        /// Get list of time intervals. Represents method 'getTimeIntervals' from 'Common' model.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/55702570a0fe4f0cf4fc53ed/operations/55702571a0fe4f0b6483890f
        /// </summary>
        /// <param name="recipientCityRef">Recipient city reference.</param>
        /// <param name="dateTime">Time when time intervals will be actual.</param>
        /// <returns></returns>
        IResponseEnvelope<GetTimeIntervalsResponse.TimeInterval> GetTimeIntervals(Guid recipientCityRef, DateTime? dateTime);

        /// <summary>
        /// Get list of time intervals async. Represents method 'getTimeIntervals' from 'Common' model.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/55702570a0fe4f0cf4fc53ed/operations/55702571a0fe4f0b6483890f
        /// </summary>
        /// <param name="recipientCityRef">Recipient city reference.</param>
        /// <param name="dateTime">Time when time intervals will be actual.</param>
        /// <returns></returns>
        Task<IResponseEnvelope<GetTimeIntervalsResponse.TimeInterval>> GetTimeIntervalsAsync(Guid recipientCityRef, DateTime? dateTime);

        /// <summary>
        /// Get list of time intervals. Represents method 'getTimeIntervals' from 'Common' model.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/55702570a0fe4f0cf4fc53ed/operations/55702571a0fe4f0b6483890f
        /// </summary>
        /// <param name="request">Get time intervals request</param>
        /// <returns>Time intervals response</returns>
        IResponseEnvelope<GetTimeIntervalsResponse.TimeInterval> GetTimeIntervals(GetTimeIntervalsRequest request);

        /// <summary>
        /// Get list of time intervals async. Represents method 'getTimeIntervals' from 'Common' model.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/55702570a0fe4f0cf4fc53ed/operations/55702571a0fe4f0b6483890f
        /// </summary>
        /// <param name="request">Get time intervals request</param>
        /// <returns>Time intervals response</returns>
        Task<IResponseEnvelope<GetTimeIntervalsResponse.TimeInterval>> GetTimeIntervalsAsync(GetTimeIntervalsRequest request);

        /// <summary>
        /// Get available cargo types. Reprensents 'getCargoTypes' method of 'Common' model.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/55702570a0fe4f0cf4fc53ed/operations/55702571a0fe4f0b64838909
        /// </summary>
        /// <returns>List of cargo types</returns>
        IResponseEnvelope<GetCargoTypesResponse.CargoType> GetCargoTypes();

        // <summary>
        /// Get available cargo types async. Reprensents 'getCargoTypes' method of 'Common' model.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/55702570a0fe4f0cf4fc53ed/operations/55702571a0fe4f0b64838909
        /// </summary>
        /// <returns>List of cargo types</returns>
        Task<IResponseEnvelope<GetCargoTypesResponse.CargoType>> GetCargoTypesAsync();

        /// <summary>
        /// Get list of available backward delivery cargo types. Represents 'getBackwardDeliveryCargoTypes' method response.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/55702570a0fe4f0cf4fc53ed/operations/55702571a0fe4f0b64838907
        /// </summary>
        /// <returns>List of backward delivery cargo types</returns>
        IResponseEnvelope<GetBackwardDeliveryCargoTypesResponse.CargoType> GetBackwardDeliveryCargoTypes();

        /// <summary>
        /// Get list of available backward delivery cargo types async. Represents 'getBackwardDeliveryCargoTypes' method response.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/55702570a0fe4f0cf4fc53ed/operations/55702571a0fe4f0b64838907
        /// </summary>
        /// <returns>List of backward delivery cargo types</returns>
        Task<IResponseEnvelope<GetBackwardDeliveryCargoTypesResponse.CargoType>> GetBackwardDeliveryCargoTypesAsync();

        /// <summary>
        /// Get list of available pallets. Represents 'getPalletsList' method of 'Common' model.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/55702570a0fe4f0cf4fc53ed/operations/5824774ba0fe4f0e60694eb0
        /// </summary>
        IResponseEnvelope<GetPalletsListResponse.Pallet> GetPalletsList();

        /// <summary>
        /// Gets list of available pallets async. Represents 'getPalletsList' method of 'Common' model.
        /// Documentation: https://developers.novaposhta.ua/view/model/a55b2c64-8512-11ec-8ced-005056b2dbe1/method/a5dd575e-8512-11ec-8ced-005056b2dbe1
        /// </summary>
        Task<IResponseEnvelope<GetPalletsListResponse.Pallet>> GetPalletsListAsync();

        /// <summary>
        /// Get list of available payer types. Represents 'getTypesOfPayers' method of 'Common' model.
        /// Documentation: https://developers.novaposhta.ua/view/model/a55b2c64-8512-11ec-8ced-005056b2dbe1/method/a6247f2f-8512-11ec-8ced-005056b2dbe1
        /// </summary>
        /// <returns>Array of payer types</returns>
        IResponseEnvelope<GetPayerTypesResponse.PayerType> GetTypesOfPayers();

        /// <summary>
        /// Gets list of available payer types async. Represents 'getTypesOfPayers' method of 'Common' model.
        /// Documentation: https://developers.novaposhta.ua/view/model/a55b2c64-8512-11ec-8ced-005056b2dbe1/method/a6247f2f-8512-11ec-8ced-005056b2dbe1
        /// </summary>
        /// <returns>Array of payer types</returns>
        Task<IResponseEnvelope<GetPayerTypesResponse.PayerType>> GetTypesOfPayersAsync();

        /// <summary>
        /// Get list of redelivery payer types. Represents 'getTypesOfPayersForRedelivery' method of 'Common' model.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/55702570a0fe4f0cf4fc53ed/operations/55702571a0fe4f0b64838914
        /// </summary>
        IResponseEnvelope<GetRedeliveryPayerTypesResponse.PayerType> GetTypesOfPayersForRedelivery();

        /// <summary>
        /// Allow to get available package types. Represents 'getPackList' method of 'Common' model.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/55702570a0fe4f0cf4fc53ed/operations/582b1069a0fe4f0298618f06
        /// </summary>
        /// <param name="height">Searching package type height</param>
        /// <param name="length">Searching package type length</param>
        /// <param name="width">Searching package type width</param>
        /// <returns>Array of available package types</returns>
        IResponseEnvelope<GetPackageTypesResponse.PackageType> GetPackList(decimal? length = null, decimal? height = null, decimal? width = null);

        /// <summary>
        /// Allow to get available package types. Represents 'getPackList' method of 'Common' model.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/55702570a0fe4f0cf4fc53ed/operations/582b1069a0fe4f0298618f06
        /// </summary>
        /// <param name="getPackageTypesRequest">Get package types request</param>
        /// <returns>Array of available package types</returns>
        IResponseEnvelope<GetPackageTypesResponse.PackageType> GetPackList(GetPackageTypesRequest getPackageTypesRequest);

        /// <summary>
        /// Allow to get available tyre wheel types. Represents 'getTiresWheelsList' of 'Common' model.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/55702570a0fe4f0cf4fc53ed/operations/55702571a0fe4f0b64838910
        /// </summary>
        /// <returns>Array of available tyres & wheels types</returns>
        IResponseEnvelope<GetTyresWheelsResponse.TyreWheelType> GetTiresWheelsList();

        /// <summary>
        /// Allow to get possible cargo description. Represents 'getCargoDescriptionList' method of 'Common' model.
        /// Searched description must begin like searched description. Search aren't work like 'Contains' method.
        /// </summary>
        /// <param name="description">Searched cargo description</param>
        /// <param name="page">Response page number. Each page contains 500 items.</param>
        /// <returns>Array of cargo descriptions</returns>
        IResponseEnvelope<GetCargoDescriptionResponse.CargoDescription> GetCargoDescriptionList(string description = null, int page = 1);

        /// <summary>
        /// Allow to get possible cargo description. Represents 'getCargoDescriptionList' method of 'Common' model.
        /// Searched description must begin like searched description. Search aren't work like 'Contains' method.
        /// </summary>
        /// <param name="cargoDescriptionRequest">Cargo description request</param>
        /// <returns>Array of cargo descriptions</returns>
        IResponseEnvelope<GetCargoDescriptionResponse.CargoDescription> GetCargoDescriptionList(GetCargoDescriptionRequest cargoDescriptionRequest);

        /// <summary>
        /// Get existing error messages. Represents 'getMessageCodeText' method of 'Common' model.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/55702570a0fe4f0cf4fc53ed/operations/58f0730deea270153c8be3cd
        /// </summary>
        /// <returns>Array of error messages.</returns>
        IResponseEnvelope<GetMessageCodeResponse.MessageCodeItem> GetMessageCodeText();

        /// <summary>
        /// Allow to get possible delivery service types like door - door, warehouse - warehouse and so on. Represents 'getServiceTypes' method of 'Common' model.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/55702570a0fe4f0cf4fc53ed/operations/55702571a0fe4f0b6483890e
        /// </summary>
        /// <returns>Array of supported delivery service types</returns>
        IResponseEnvelope<GetServiceTypeResponse.ServiceType> GetServiceTypes();

        /// <summary>
        /// Allow to get existing counterparty types. Represents 'getTypesOfCounterparties' method of 'Common' model.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/55702570a0fe4f0cf4fc53ed/operations/55702571a0fe4f0b64838912
        /// </summary>
        /// <returns>Array of counterparty types</returns>
        IResponseEnvelope<GetCounterpatyTypesResponse.CounterpartyType> GetTypesOfCounterparties();

        /// <summary>
        /// Allow to get 'Nova Poshta' service payment forms. Represents 'getPaymentForms' method of 'Common' model.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/55702570a0fe4f0cf4fc53ed/operations/55702571a0fe4f0b6483890d 
        /// </summary>
        /// <returns>Array of payment forms</returns>
        IResponseEnvelope<GetPaymentFormsResponse.PaymentForm> GetPaymentForms();

        /// <summary>
        /// Allow to get supported ownership forms. Represents 'getOwnershipFormsList' method response of 'Common' model.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/55702570a0fe4f0cf4fc53ed/operations/55702571a0fe4f0b6483890b
        /// </summary>
        /// <returns>Array of supported ownership forms</returns>
        IResponseEnvelope<GetOwnershipFormsResponse.OwnershipForm> GetOwnershipFormsList();
    }     
}
