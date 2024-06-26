﻿//Copyright 2020 Alexey Prokhorov

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
using Baroque.NovaPoshta.Client.Domain.Address;
using System;

namespace Baroque.NovaPoshta.Client.Services.Address
{
    /// <summary>
    /// Represents 'Address' model methods
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/556d7ccaa0fe4f08e8f7ce43/operations/58e5ebeceea27017bc851d67
    /// </summary>
    public class AddressService : IAddressService
    {
        #region Constants

        public const string MODEL = "Address";

        #endregion

        #region Fields

        private readonly INovaPoshtaGateway _novaPoshtaGateway;

        #endregion

        #region Constructor

        /// <summary>
        /// Address service. Represents methods for 'Address' model.
        /// </summary>
        /// <param name="gateway">Nova Poshta service gateway instance.</param>
        public AddressService(INovaPoshtaGateway gateway)
        {
            this._novaPoshtaGateway = gateway;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Search settlements by name.
        /// Create request to 'SearchSettlements' Nova Poshta service method.
        /// Documentation: https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a0eb83ab-8512-11ec-8ced-005056b2dbe1
        /// </summary>
        /// <param name="settlementName">Searched name</param>
        /// <param name="limit">Quantity</param>
        /// <returns>Settlements list</returns>
        public virtual IResponseEnvelope<SettlementsSearchResponse.ResponseItem> SearchSettlements(string settlementName, int limit = 100)
        {
            var request = new SettlementsSearchRequest()
            {
                SettlementName = settlementName,
                Limit = limit
            };

            return SearchSettlements(request);
        }

        /// <summary>
        /// Search settlements by name.
        /// Create request to 'SearchSettlements' Nova Poshta service method.
        /// Documentation: https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a0eb83ab-8512-11ec-8ced-005056b2dbe1
        /// </summary>
        /// <param name="request">Search settlement request method properties</param>
        /// <returns>Settlements list</returns>
        public virtual IResponseEnvelope<SettlementsSearchResponse.ResponseItem> SearchSettlements(SettlementsSearchRequest request)
        {
            var fullRequestBody = new RequestEnvelope<SettlementsSearchRequest>()
            {
                ApiKey = _novaPoshtaGateway.ApiKey,
                CalledMethod = "searchSettlements",
                ModelName = MODEL,
                MethodProperties = request
            };

            var response = _novaPoshtaGateway.CreateRequest<SettlementsSearchRequest, SettlementsSearchResponse>(fullRequestBody);

            return response;
        }

        /// <summary>
        /// Search street in settlement.
        /// Documentation: https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a1329635-8512-11ec-8ced-005056b2dbe1
        /// </summary>
        /// <param name="street">Street name</param>
        /// <param name="settlement">Settlement unique guid</param>
        /// <param name="limit">Response items quantity</param>
        /// <returns>Searched streets</returns>
        public virtual IResponseEnvelope<StreetSearchResponse.ResponseItem> SearchSettlementStreets(string street, Guid settlement, int limit = 100)
        {
            var request = new StreetSearchRequest()
            {
                SettlementReference = settlement,
                StreetName = street,
                Limit = limit
            };
            return SearchSettlementStreets(request);
        }

        /// <summary>
        /// Search settlement streets.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/556d7ccaa0fe4f08e8f7ce43/operations/58e5f369eea27017540b58ac
        /// </summary>
        /// <param name="request">Street searching request</param>
        /// <returns>List of searched streets</returns>
        public virtual IResponseEnvelope<StreetSearchResponse.ResponseItem> SearchSettlementStreets(StreetSearchRequest request)
        {
            var fullRequest = new RequestEnvelope<StreetSearchRequest>()
            {
                ApiKey = _novaPoshtaGateway.ApiKey,
                CalledMethod = "searchSettlementStreets",
                ModelName = MODEL,
                MethodProperties = request
            };

            var response = _novaPoshtaGateway.CreateRequest<StreetSearchRequest, StreetSearchResponse>(fullRequest);
            return response;
        }

        /// <summary>
        /// Create counterparty new address. Represents 'save' method of 'Address' model.
        /// Documentation: https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a155d0d9-8512-11ec-8ced-005056b2dbe1
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public virtual IResponseEnvelope<CreateCounterpartyAddressResponse.CounterpartyAddress> CreateCounterpartyAddress(CreateCounterpartyAddressRequest request)
        {
            var fullRequest = new RequestEnvelope<CreateCounterpartyAddressRequest>()
            {
                ApiKey = _novaPoshtaGateway.ApiKey,
                CalledMethod = "save",
                ModelName = MODEL,
                MethodProperties = request
            };

            var response = _novaPoshtaGateway.CreateRequest<CreateCounterpartyAddressRequest, CreateCounterpartyAddressResponse>(fullRequest);
            return response;
        }

        /// <summary>
        /// Update counterparty address. 
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/556d7ccaa0fe4f08e8f7ce43/operations/556d9db5a0fe4f08e8f7ce4b
        /// </summary>
        /// <param name="request">Update counterparty address request</param>
        /// <returns>Update result</returns>
        public virtual IResponseEnvelope<UpdateCounterpartyAddressResponse.CounterpartyAddress> UpdateCounterparyAddress(UpdateCounterpartyAddressRequest request)
        {
            var fullRequest = new RequestEnvelope<UpdateCounterpartyAddressRequest>
            {
                ApiKey = _novaPoshtaGateway.ApiKey,
                CalledMethod = "update",
                ModelName = MODEL,
                MethodProperties = request
            };

            var response = _novaPoshtaGateway.CreateRequest<UpdateCounterpartyAddressRequest, UpdateCounterpartyAddressResponse>(fullRequest);
            return response;
        }

        /// <summary>
        /// Delete counterparty address sender or recipient. Represents 'delete' method of 'Address' model.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/556d7ccaa0fe4f08e8f7ce43/operations/556da062a0fe4f08e8f7ce4c
        /// </summary>
        /// <param name="reference">Address reference key</param>
        /// <returns>Delete address response</returns>
        public virtual IResponseEnvelope<DeleteCounterpartyAddressResponse.CounterpartyAddress> DeleteCounterpartyAddress(Guid reference)
        {
            var request = new RequestEnvelope<DeleteCounterpartyAddressRequest>()
            {
                ApiKey = _novaPoshtaGateway.ApiKey,
                CalledMethod = "delete",
                ModelName = MODEL,
                MethodProperties = new DeleteCounterpartyAddressRequest()
                {
                    Reference = reference
                }
            };

            var response = _novaPoshtaGateway.CreateRequest<DeleteCounterpartyAddressRequest, DeleteCounterpartyAddressResponse>(request);
            return response;
        }

        /// <summary>
        /// Get Ukrainian areas list. Represents 'getAreas' method of 'Address' model.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/556d7ccaa0fe4f08e8f7ce43/operations/556d9130a0fe4f08e8f7ce48
        /// </summary>
        /// <returns>List of Ukrainian areas.</returns>
        public virtual IResponseEnvelope<AreasGetResponse.Area> GetAreas()
        {
            var request = new RequestEnvelope<AreasGetRequest>()
            {
                ApiKey = _novaPoshtaGateway.ApiKey,
                CalledMethod = "getAreas",
                ModelName = MODEL,
                MethodProperties = new AreasGetRequest()
            };

            var response = _novaPoshtaGateway.CreateRequest<AreasGetRequest, AreasGetResponse>(request);
            return response;
        }

        /// <summary>
        /// Get Ukrainian settlements. Represents 'getCities' method of 'Address' model.
        /// Documentation: https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a1e6f0a7-8512-11ec-8ced-005056b2dbe1
        /// </summary>
        /// <param name="ref">City unique guid key</param>
        /// <param name="name">City name</param>
        /// <returns>Ukrainian cities list</returns>
        public virtual IResponseEnvelope<CitiesGetResponse.City> GetCities(string name, Guid? @ref = null)
        {
            var request = new CitiesGetRequest()
            {
                FindByString = name,
                Ref = @ref
            };
            return GetCities(request);
        }

        /// <summary>
        /// Get Ukrainian settlements. Represents 'getCities' method of 'Address' model.
        /// Documentation: https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a1e6f0a7-8512-11ec-8ced-005056b2dbe1
        /// </summary>
        /// <param name="request">Cities search request</param>
        /// <returns>Ukrainian cities list</returns>
        public virtual IResponseEnvelope<CitiesGetResponse.City> GetCities(CitiesGetRequest request)
        {
            var fullRequest = new RequestEnvelope<CitiesGetRequest>(request)
            {
                ApiKey = _novaPoshtaGateway.ApiKey,
                CalledMethod = "getCities",
                ModelName = MODEL
            };

            var response = _novaPoshtaGateway.CreateRequest<CitiesGetRequest, CitiesGetResponse>(fullRequest);
            return response;
        }

        /// <summary>
        /// Get Ukrainian settlements list by sended request parameters.
        /// Represents 'getSettlements' method of 'AddressGeneral' model. Each response page contains only 150 settlements.
        /// Documentation: https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a1c42723-8512-11ec-8ced-005056b2dbe1
        /// </summary>
        /// <param name="name">Settlement name</param>
        /// <param name="address">Settlement address key, should be located inside settlement</param>
        /// <param name="region">Settlement region key</param>
        /// <param name="area">Settlement area key. Unfortunately this field don't use areas keys.</param>
        /// <param name="warehouse">Warehouses availability</param>
        /// <param name="page">Page number</param>
        /// <returns>Settlements collection</returns>
        public virtual IResponseEnvelope<SettlementsGetResponse.Settlement> GetSettlements(string name = "", Guid? address = null, Guid? region = null, Guid? area = null, bool warehouse = true, int page = 1)
        {
            var request = new SettlementsGetRequest()
            {
                AreaRef = area,
                Ref = address,
                RegionRef = region,
                Warehouse = warehouse ? 1 : 0,
                FindByString = name,
                Page = page
            };
            return GetSettlements(request);
        }

        /// <summary>
        /// Get Ukrainian settlements list by sended request parameters.
        /// Represents 'getSettlements' method of 'AddressGeneral' model. Each response page contains only 150 settlements.
        /// Documentation: https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a1c42723-8512-11ec-8ced-005056b2dbe1
        /// </summary>
        /// <param name="request">GEt settlements request</param>
        /// <returns>List of finded settlements</returns>
        public virtual IResponseEnvelope<SettlementsGetResponse.Settlement> GetSettlements(SettlementsGetRequest request)
        {
            var fullRequest = new RequestEnvelope<SettlementsGetRequest>(request)
            {
                ApiKey = _novaPoshtaGateway.ApiKey,
                CalledMethod = "getSettlements",
                ModelName = "AddressGeneral"
            };

            var response = _novaPoshtaGateway.CreateRequest<SettlementsGetRequest, SettlementsGetResponse>(fullRequest);
            return response;
        }

        /// <summary>
        /// Get warehouses list by needed parameters. Represents 'getWarehouses' method of 'Address' model.
        /// Documentation: https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a2322f38-8512-11ec-8ced-005056b2dbe1
        /// </summary>
        /// <param name="cityName">Name of the city where warehouse located</param>
        /// <param name="cityRef">Warehouse city reference</param>
        /// <param name="settlementRef">Warehouse settlement reference</param>
        /// <param name="warehouseType">Warehouse type reference</param>
        /// <param name="bicycleParking">Has warehouse bicycle parking. 'True' - has parking, 'False' - no parking.</param>
        /// <param name="postFinance">Warehouse post finance cashbox. 'True' - has post finance. 'False' - no post finance.</param>
        /// <param name="posTerminal">Warehouse has POS terminal. 'True' - has termina. 'False' - no terminal.</param>
        /// <param name="warehouseId">Warehouse number.</param>
        /// <param name="page">Response page number. One page contains 500 warehouses.</param>
        /// <param name="limit">Response items quantity per one page.</param>
        /// <returns>List of 'Nova Poshta' service warehouses</returns>
        public virtual IResponseEnvelope<WarehousesGetResponse.Warehouse> GetWarehouses(string cityName = "", Guid? cityRef = null, Guid? settlementRef = null, Guid? warehouseType = null,
            bool bicycleParking = false, bool postFinance = false, bool posTerminal = false, int? warehouseId = null, int page = 1, int limit = 500)
        {
            var request = new WarehousesGetRequest()
            {
                CityName = cityName,
                BicycleParking = bicycleParking ? 1 : 0,
                CityRef = cityRef,
                PostFinance = postFinance ? 1 : 0,
                SettlementRef = settlementRef,
                TypeOfWarehouseRef = warehouseType,
                WarehouseId = warehouseId,
                Page = page,
                Limit = limit
            };
            return GetWarehouses(request);
        }

        /// <summary>
        /// Get warehouses list by request parameters.Represents 'getWarehouses' method of 'Address' model.
        /// Documentation: https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a2322f38-8512-11ec-8ced-005056b2dbe1
        /// </summary>
        /// <param name="request">Warehouses get request instance</param>
        /// <returns>List of 'Nova Poshta' service warehouses</returns>
        public virtual IResponseEnvelope<WarehousesGetResponse.Warehouse> GetWarehouses(WarehousesGetRequest request)
        {
            var fullRequest = new RequestEnvelope<WarehousesGetRequest>(request)
            {
                ApiKey = _novaPoshtaGateway.ApiKey,
                CalledMethod = "getWarehouses",
                ModelName = MODEL
            };

            var response = _novaPoshtaGateway.CreateRequest<WarehousesGetRequest, WarehousesGetResponse>(fullRequest);
            return response;
        }

        /// <summary>
        /// Get warehouse types list. Represents 'getWarehouseTypes' method of 'Address' model.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/556d7ccaa0fe4f08e8f7ce43/operations/556d8211a0fe4f08e8f7ce45
        /// </summary>
        /// <returns>List of warehouses types</returns>
        public virtual IResponseEnvelope<WarehouseTypeResponse.WarehouseType> GetWarehouseTypes()
        {
            var request = new RequestEnvelope<EmptyRequest>(new EmptyRequest())
            {
                ApiKey = _novaPoshtaGateway.ApiKey,
                CalledMethod = "getWarehouseTypes",
                ModelName = MODEL
            };

            var response = _novaPoshtaGateway.CreateRequest<EmptyRequest, WarehouseTypeResponse>(request);
            return response;
        }

        /// <summary>
        /// Get list of city streets. 'Nova poshta' should have warehouses in this city.
        /// Represents 'getStreet' method of 'Address' model.
        /// Documentation: https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a27c20d7-8512-11ec-8ced-005056b2dbe1
        /// </summary>
        /// <param name="name">Street name</param>
        /// <param name="cityRef">City reference key</param>
        /// <returns>List of city streets</returns>
        public virtual IResponseEnvelope<StreetGetResponse.Street> GetStreet(Guid cityRef, string name = null, int page = 1)
        {
            var request = new StreetGetRequest()
            {
                FindByString = name,
                CityRef = cityRef,
                Page = page
            };
            return GetStreet(request);
        }

        /// <summary>
        /// Get list of city streets. 'Nova poshta' should have warehouses in this city.
        /// Represents 'getStreet' method of 'Address' model.
        /// Documentation: https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a27c20d7-8512-11ec-8ced-005056b2dbe1
        /// </summary>
        /// <param name="request">Get street request</param>
        /// <returns>List of city streets</returns>
        public virtual IResponseEnvelope<StreetGetResponse.Street> GetStreet(StreetGetRequest request)
        {
            var fullRequest = new RequestEnvelope<StreetGetRequest>(request)
            {
                ApiKey = _novaPoshtaGateway.ApiKey,
                CalledMethod = "getStreet",
                ModelName = MODEL
            };

            var response = _novaPoshtaGateway.CreateRequest<StreetGetRequest, StreetGetResponse>(fullRequest);
            return response;
        }

        /// <summary>
        /// Gets area regions by area unique reference key. 
        /// Documentation: https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a98072f9-2a78-11ee-a60f-48df37b921db
        /// </summary>
        /// <remarks>I'm not sure, but area references from 'getAreas' aren't work. Looks like area references you can get here: https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/c0bfb1a3-2a73-11ee-a60f-48df37b921db</remarks>
        /// <param name="areaReference">Area reference key</param>
        /// <returns>List of area regions</returns>
        public virtual IResponseEnvelope<AreaRegionGetResponse.Region> GetSettlementCountryRegion(Guid areaReference)
        {
            var request = new RequestEnvelope<AreaRegionGetRequest>()
            {
                ApiKey = _novaPoshtaGateway.ApiKey,
                CalledMethod = "getSettlementCountryRegion",
                ModelName = "Address",
                MethodProperties = new AreaRegionGetRequest()
                {
                    AreaReference = areaReference
                }
            };

            var response = _novaPoshtaGateway.CreateRequest<AreaRegionGetRequest, AreaRegionGetResponse>(request);
            return response;
        }

        /// <summary>
        /// Gets settlement areas list. Looks like 'getAreas' method, but returns another references. Usable for 'getSettlementCountryRegion' method.
        /// Documentation: https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/c0bfb1a3-2a73-11ee-a60f-48df37b921db
        /// </summary>
        /// <returns>List of settlement areas</returns>
        public virtual IResponseEnvelope<SettlementAreaGetResponse.Area> GetSettlementAreas()
        {
            var request = new RequestEnvelope<EmptyRequest>()
            {
                ApiKey = _novaPoshtaGateway.ApiKey,
                CalledMethod = "getSettlementAreas",
                ModelName = "Address"
            };

            var response = _novaPoshtaGateway.CreateRequest<EmptyRequest, SettlementAreaGetResponse>(request);
            return response;
        }


        #endregion
    }
}
