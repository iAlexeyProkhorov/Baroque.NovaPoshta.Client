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
using Baroque.NovaPoshta.Client.Domain.Common;
using Baroque.NovaPoshta.Client.Extensions;
using System;
using System.Threading.Tasks;

namespace Baroque.NovaPoshta.Client.Services.Common
{
    /// <summary>
    /// Represents methods collection for 'Common' model. Contains method to get 'Nova Poshta' service reference books.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/55702570a0fe4f0cf4fc53ed/operations/55702571a0fe4f0b6483890f
    /// </summary>
    public class CommonService : ICommonService
    {
        #region Constants

        protected const string MODEL = "Common";

        #endregion

        #region Fields

        private readonly INovaPoshtaGateway _novaPoshtaGateway;

        #endregion

        #region Constructor

        public CommonService(INovaPoshtaGateway novaPoshtaGateway)
        {
            this._novaPoshtaGateway = novaPoshtaGateway;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Get list of time intervals async. Represents method 'getTimeIntervals' from 'Common' model.
        /// Documentation: https://developers.novaposhta.ua/view/model/a55b2c64-8512-11ec-8ced-005056b2dbe1/method/a56d5c1c-8512-11ec-8ced-005056b2dbe1
        /// </summary>
        /// <param name="recipientCityRef">Recipient city reference.</param>
        /// <param name="dateTime">Time when time intervals will be actual.</param>
        /// <returns></returns>
        public virtual async Task<IResponseEnvelope<GetTimeIntervalsResponse.TimeInterval>> GetTimeIntervalsAsync(Guid recipientCityRef, DateTime? dateTime)
        {
            var request = new GetTimeIntervalsRequest()
            {
                RecipientCityRef = recipientCityRef,
                DateTime = dateTime.ParseToString("hh:mm")
            };

            return await GetTimeIntervalsAsync(request);
        }

        /// <summary>
        /// Get list of time intervals async. Represents method 'getTimeIntervals' from 'Common' model.
        /// Documentation: https://developers.novaposhta.ua/view/model/a55b2c64-8512-11ec-8ced-005056b2dbe1/method/a56d5c1c-8512-11ec-8ced-005056b2dbe1
        /// </summary>
        /// <param name="request">Get time intervals request</param>
        /// <returns>Time intervals response</returns>
        public virtual async Task<IResponseEnvelope<GetTimeIntervalsResponse.TimeInterval>> GetTimeIntervalsAsync(GetTimeIntervalsRequest request)
        {
            var fullRequest = new RequestEnvelope<GetTimeIntervalsRequest>(request)
            {
                ApiKey = _novaPoshtaGateway.ApiKey,
                CalledMethod = "getTimeIntervals",
                ModelName = MODEL,
            };

            var response = await _novaPoshtaGateway.CreateRequestAsync<GetTimeIntervalsRequest, GetTimeIntervalsResponse>(fullRequest);
            return response;
        }

        /// <summary>
        /// Get available cargo types async. Reprensents 'getCargoTypes' method of 'Common' model.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/55702570a0fe4f0cf4fc53ed/operations/55702571a0fe4f0b64838909
        /// </summary>
        /// <returns>List of cargo types</returns>
        public virtual async Task<IResponseEnvelope<GetCargoTypesResponse.CargoType>> GetCargoTypesAsync()
        {
            var request = new RequestEnvelope<EmptyRequest>()
            {
                ApiKey = _novaPoshtaGateway.ApiKey,
                CalledMethod = "getCargoTypes",
                ModelName = MODEL
            };

            var response = await _novaPoshtaGateway.CreateRequestAsync<EmptyRequest, GetCargoTypesResponse>(request);
            return response;
        }

        /// <summary>
        /// Get list of available backward delivery cargo types async. Represents 'getBackwardDeliveryCargoTypes' method response.
        /// Documentation: https://developers.novaposhta.ua/view/model/a55b2c64-8512-11ec-8ced-005056b2dbe1/method/a5b46873-8512-11ec-8ced-005056b2dbe1
        /// </summary>
        /// <returns>List of backward delivery cargo types</returns>
        public virtual async Task<IResponseEnvelope<GetBackwardDeliveryCargoTypesResponse.CargoType>> GetBackwardDeliveryCargoTypesAsync()
        {
            var request = new RequestEnvelope<EmptyRequest>()
            {
                ApiKey = _novaPoshtaGateway.ApiKey,
                CalledMethod = "getBackwardDeliveryCargoTypes",
                ModelName = MODEL
            };

            var response = await _novaPoshtaGateway.CreateRequestAsync<EmptyRequest, GetBackwardDeliveryCargoTypesResponse>(request);
            return response;
        }

        /// <summary>
        /// Gets list of available pallets async. Represents 'getPalletsList' method of 'Common' model.
        /// Documentation: https://developers.novaposhta.ua/view/model/a55b2c64-8512-11ec-8ced-005056b2dbe1/method/a5dd575e-8512-11ec-8ced-005056b2dbe1
        /// </summary>
        public virtual async Task<IResponseEnvelope<GetPalletsListResponse.Pallet>> GetPalletsListAsync()
        {
            var request = new RequestEnvelope<EmptyRequest>()
            {
                ApiKey = _novaPoshtaGateway.ApiKey,
                CalledMethod = "getPalletsList",
                ModelName = MODEL
            };

            var response = await _novaPoshtaGateway.CreateRequestAsync<EmptyRequest, GetPalletsListResponse>(request);
            return response;
        }

        /// <summary>
        /// Gets list of available payer types async. Represents 'getTypesOfPayers' method of 'Common' model.
        /// Documentation: https://developers.novaposhta.ua/view/model/a55b2c64-8512-11ec-8ced-005056b2dbe1/method/a6247f2f-8512-11ec-8ced-005056b2dbe1
        /// </summary>
        /// <returns>Array of payer types</returns>
        public virtual async Task<IResponseEnvelope<GetPayerTypesResponse.PayerType>> GetTypesOfPayersAsync()
        {
            var request = new RequestEnvelope<EmptyRequest>()
            {
                ApiKey = _novaPoshtaGateway.ApiKey,
                CalledMethod = "getTypesOfPayers",
                ModelName = MODEL
            };

            var response = await _novaPoshtaGateway.CreateRequestAsync<EmptyRequest, GetPayerTypesResponse>(request);
            return response;
        }

        /// <summary>
        /// Get list of redelivery payer types. Represents 'getTypesOfPayersForRedelivery' method of 'Common' model.
        /// Documentation: https://developers.novaposhta.ua/view/model/a55b2c64-8512-11ec-8ced-005056b2dbe1/method/a6247f2f-8512-11ec-8ced-005056b2dbe1
        /// </summary>
        public virtual async Task<IResponseEnvelope<GetRedeliveryPayerTypesResponse.PayerType>> GetTypesOfPayersForRedeliveryAsync()
        {
            var request = new RequestEnvelope<EmptyRequest>()
            {
                ApiKey = _novaPoshtaGateway.ApiKey,
                CalledMethod = "getTypesOfPayersForRedelivery",
                ModelName = MODEL
            };

            var response = await _novaPoshtaGateway.CreateRequestAsync<EmptyRequest, GetRedeliveryPayerTypesResponse>(request);
            return response;
        }

        /// <summary>
        /// Allow to get available package types. Represents 'getPackList' method of 'Common' model.
        /// Documentation: https://developers.novaposhta.ua/view/model/a55b2c64-8512-11ec-8ced-005056b2dbe1/method/a6492db4-8512-11ec-8ced-005056b2dbe1
        /// </summary>
        /// <param name="height">Searching package type height. In millimeters.</param>
        /// <param name="length">Searching package type length. In millimeters.</param>
        /// <param name="width">Searching package type width. In millimeters.</param>
        /// <returns>Array of available package types</returns>
        public virtual async Task<IResponseEnvelope<GetPackageTypesResponse.PackageType>> GetPackListAsync(decimal? length = null, decimal? height = null, decimal? width = null)
        {
            var request = new GetPackageTypesRequest()
            {
                Length = length,
                Height = height,
                Width = width
            };

            return await GetPackListAsync(request);
        }

        /// <summary>
        /// Allow to get available package types. Represents 'getPackList' method of 'Common' model.
        /// Documentation: https://developers.novaposhta.ua/view/model/a55b2c64-8512-11ec-8ced-005056b2dbe1/method/a6492db4-8512-11ec-8ced-005056b2dbe1
        /// </summary>
        /// <param name="getPackageTypesRequest">Get package types request</param>
        /// <returns>Array of available package types</returns>
        public virtual async Task<IResponseEnvelope<GetPackageTypesResponse.PackageType>> GetPackListAsync(GetPackageTypesRequest getPackageTypesRequest)
        {
            var request = new RequestEnvelope<GetPackageTypesRequest>(getPackageTypesRequest)
            {
                ApiKey = _novaPoshtaGateway.ApiKey,
                CalledMethod = "getPackList",
                ModelName = MODEL
            };

            var response = await _novaPoshtaGateway.CreateRequestAsync<GetPackageTypesRequest, GetPackageTypesResponse>(request);
            return response;
        }

        /// <summary>
        /// Allow to get available tyre wheel types. Represents 'getTiresWheelsList' of 'Common' model.
        /// Documentation: https://developers.novaposhta.ua/view/model/a55b2c64-8512-11ec-8ced-005056b2dbe1/method/a66fada0-8512-11ec-8ced-005056b2dbe1
        /// </summary>
        /// <returns>Array of available tyres & wheels types</returns>
        public virtual async Task<IResponseEnvelope<GetTyresWheelsResponse.TyreWheelType>> GetTiresWheelsListAsync()
        {
            var request = new RequestEnvelope<EmptyRequest>()
            {
                ApiKey = _novaPoshtaGateway.ApiKey,
                CalledMethod = "getTiresWheelsList",
                ModelName = MODEL
            };

            var response = await _novaPoshtaGateway.CreateRequestAsync<EmptyRequest, GetTyresWheelsResponse>(request);
            return response;
        }

        /// <summary>
        /// Allow to get possible cargo description. Represents 'getCargoDescriptionList' method of 'Common' model.
        /// Searched description must begin like searched description. Search aren't work like 'Contains' method.
        /// Documentation: https://developers.novaposhta.ua/view/model/a55b2c64-8512-11ec-8ced-005056b2dbe1/method/a697db47-8512-11ec-8ced-005056b2dbe1
        /// </summary>
        /// <param name="description">Searched cargo description</param>
        /// <param name="page">Response page number. Each page contains 500 items.</param>
        /// <returns>Array of cargo descriptions</returns>
        public virtual async Task<IResponseEnvelope<GetCargoDescriptionResponse.CargoDescription>> GetCargoDescriptionListAsync(string description = null, int page = 1)
        {
            var request = new GetCargoDescriptionRequest()
            {
                FindByString = description,
                Page = page
            };

            return await GetCargoDescriptionListAsync(request);
        }

        /// <summary>
        /// Allow to get possible cargo description. Represents 'getCargoDescriptionList' method of 'Common' model.
        /// Searched description must begin like searched description. Search aren't work like 'Contains' method.
        /// Documentation: https://developers.novaposhta.ua/view/model/a55b2c64-8512-11ec-8ced-005056b2dbe1/method/a697db47-8512-11ec-8ced-005056b2dbe1
        /// </summary>
        /// <param name="cargoDescriptionRequest">Cargo description request</param>
        /// <returns>Array of cargo descriptions</returns>
        public virtual async Task<IResponseEnvelope<GetCargoDescriptionResponse.CargoDescription>> GetCargoDescriptionListAsync(GetCargoDescriptionRequest cargoDescriptionRequest)
        {
            var request = new RequestEnvelope<GetCargoDescriptionRequest>(cargoDescriptionRequest)
            {
                ApiKey = _novaPoshtaGateway.ApiKey,
                CalledMethod = "getCargoDescriptionList",
                ModelName = MODEL
            };

            var response = await _novaPoshtaGateway.CreateRequestAsync<GetCargoDescriptionRequest, GetCargoDescriptionResponse>(request);
            return response;
        }

        /// <summary>
        /// Get existing error messages. Represents 'getMessageCodeText' method of 'Common' model.
        /// Documentation: https://developers.novaposhta.ua/view/model/a55b2c64-8512-11ec-8ced-005056b2dbe1/method/a6bce5a1-8512-11ec-8ced-005056b2dbe1
        /// </summary>
        /// <returns>Array of error messages.</returns>
        public virtual async Task<IResponseEnvelope<GetMessageCodeResponse.MessageCodeItem>> GetMessageCodeTextAsync()
        {
            var request = new RequestEnvelope<EmptyRequest>()
            {
                ApiKey = _novaPoshtaGateway.ApiKey,
                CalledMethod = "getMessageCodeText",
                ModelName = MODEL
            };

            var response = await _novaPoshtaGateway.CreateRequestAsync<EmptyRequest, GetMessageCodeResponse>(request);
            return response;
        }

        /// <summary>
        /// Allow to get possible delivery service types like door - door, warehouse - warehouse and so on. Represents 'getServiceTypes' method of 'Common' model.
        /// Documentation: https://developers.novaposhta.ua/view/model/a55b2c64-8512-11ec-8ced-005056b2dbe1/method/a6e189f7-8512-11ec-8ced-005056b2dbe1
        /// </summary>
        /// <returns>Array of supported delivery service types</returns>
        public virtual async Task<IResponseEnvelope<GetServiceTypeResponse.ServiceType>> GetServiceTypesAsync()
        {
            var request = new RequestEnvelope<EmptyRequest>()
            {
                ApiKey = _novaPoshtaGateway.ApiKey,
                CalledMethod = "getServiceTypes",
                ModelName = MODEL
            };

            var response = await _novaPoshtaGateway.CreateRequestAsync<EmptyRequest, GetServiceTypeResponse>(request);
            return response;
        }

        /// <summary>
        /// Allow to get supported ownership forms. Represents 'getOwnershipFormsList' method response of 'Common' model.
        /// Documentation: https://developers.novaposhta.ua/view/model/a55b2c64-8512-11ec-8ced-005056b2dbe1/method/a754ff0d-8512-11ec-8ced-005056b2dbe1
        /// </summary>
        /// <returns>Array of supported ownership forms</returns>
        public virtual async Task<IResponseEnvelope<GetOwnershipFormsResponse.OwnershipForm>> GetOwnershipFormsListAsync()
        {
            var request = new RequestEnvelope<EmptyRequest>()
            {
                ApiKey = _novaPoshtaGateway.ApiKey,
                CalledMethod = "getOwnershipFormsList",
                ModelName = MODEL
            };

            var response = await _novaPoshtaGateway.CreateRequestAsync<EmptyRequest, GetOwnershipFormsResponse>(request);
            return response;
        }

        #endregion

        #region Legacy

        /// <summary>
        /// Allow to get existing counterparty types. Represents 'getTypesOfCounterparties' method of 'Common' model.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/55702570a0fe4f0cf4fc53ed/operations/55702571a0fe4f0b64838912
        /// </summary>
        /// <returns>Array of counterparty types</returns>
        public virtual IResponseEnvelope<GetCounterpatyTypesResponse.CounterpartyType> GetTypesOfCounterparties()
        {
            var request = new RequestEnvelope<EmptyRequest>()
            {
                ApiKey = _novaPoshtaGateway.ApiKey,
                CalledMethod = "getTypesOfCounterparties",
                ModelName = "Common"
            };

            var response = _novaPoshtaGateway.CreateRequest<EmptyRequest, GetCounterpatyTypesResponse>(request);
            return response;
        }

        /// <summary>
        /// Allow to get 'Nova Poshta' service payment forms. Represents 'getPaymentForms' method of 'Common' model.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/55702570a0fe4f0cf4fc53ed/operations/55702571a0fe4f0b6483890d 
        /// </summary>
        /// <returns>Array of payment forms</returns>
        public virtual IResponseEnvelope<GetPaymentFormsResponse.PaymentForm> GetPaymentForms()
        {
            var request = new RequestEnvelope<EmptyRequest>()
            {
                ApiKey = _novaPoshtaGateway.ApiKey,
                CalledMethod = "getPaymentForms",
                ModelName = MODEL
            };

            var response = _novaPoshtaGateway.CreateRequest<EmptyRequest, GetPaymentFormsResponse>(request);
            return response;
        }

        #endregion
    }
}
