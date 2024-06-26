﻿using Baroque.NovaPoshta.Client.Domain;
using Baroque.NovaPoshta.Client.Domain.Address;
using System;

namespace Baroque.NovaPoshta.Client.Services.Address
{
    /// <summary>
    /// Represents 'Address' model interface
    /// </summary>
    public interface IAddressService
    {
        /// <summary>
        /// Search settlements by name.
        /// Create request to 'SearchSettlements' Nova Poshta service method.
        /// Documentation: https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a0eb83ab-8512-11ec-8ced-005056b2dbe1
        /// </summary>
        /// <param name="settlementName">Searched name</param>
        /// <param name="limit">Quantity</param>
        /// <returns>Settlements list</returns>
        IResponseEnvelope<SettlementsSearchResponse.ResponseItem> SearchSettlements(string settlementName, int limit = 100);

        /// <summary>
        /// Create request to 'SearchSettlements' Nova Poshta service method.
        /// Documentation: https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a0eb83ab-8512-11ec-8ced-005056b2dbe1
        /// </summary>
        /// <param name="request">Search settlement request method properties</param>
        /// <returns>Search settlements response</returns>
        IResponseEnvelope<SettlementsSearchResponse.ResponseItem> SearchSettlements(SettlementsSearchRequest request);

        /// <summary>
        /// Search street in settlement.
        /// Documentation: https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a1329635-8512-11ec-8ced-005056b2dbe1
        /// </summary>
        /// <param name="street">Street name</param>
        /// <param name="settlement">Settlement unique guid</param>
        /// <param name="limit">Response items quantity</param>
        /// <returns>Searched streets</returns>
        IResponseEnvelope<StreetSearchResponse.ResponseItem> SearchSettlementStreets(string street, Guid settlement, int limit = 100);

        /// <summary>
        /// Search settlement streets.
        /// Documentation: https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a1329635-8512-11ec-8ced-005056b2dbe1
        /// </summary>
        /// <param name="request">Street searching request</param>
        /// <returns>List of searched streets</returns>
        IResponseEnvelope<StreetSearchResponse.ResponseItem> SearchSettlementStreets(StreetSearchRequest request);

        /// <summary>
        /// Create counterparty new address. Represents 'save' method of 'Address' model.
        /// Documentation: https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a155d0d9-8512-11ec-8ced-005056b2dbe1
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        IResponseEnvelope<CreateCounterpartyAddressResponse.CounterpartyAddress> CreateCounterpartyAddress(CreateCounterpartyAddressRequest request);

        /// <summary>
        /// Update counterparty address. 
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/556d7ccaa0fe4f08e8f7ce43/operations/556d9db5a0fe4f08e8f7ce4b
        /// </summary>
        /// <param name="request">Update counterparty address request</param>
        /// <returns>Update result</returns>
        IResponseEnvelope<UpdateCounterpartyAddressResponse.CounterpartyAddress> UpdateCounterparyAddress(UpdateCounterpartyAddressRequest request);

        /// <summary>
        /// Delete counterparty address sender or recipient. Represents 'delete' method of 'Address' model.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/556d7ccaa0fe4f08e8f7ce43/operations/556da062a0fe4f08e8f7ce4c
        /// </summary>
        /// <param name="reference">Address reference key</param>
        /// <returns>Delete address response</returns>
        IResponseEnvelope<DeleteCounterpartyAddressResponse.CounterpartyAddress> DeleteCounterpartyAddress(Guid reference);

        /// <summary>
        /// Get Ukrainian areas list. Represents 'getAreas' method of 'Address' model.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/556d7ccaa0fe4f08e8f7ce43/operations/556d9130a0fe4f08e8f7ce48
        /// </summary>
        /// <returns>List of Ukrainian areas.</returns>
        IResponseEnvelope<AreasGetResponse.Area> GetAreas();

        /// <summary>
        /// Get Ukrainian settlements. Represents 'getCities' method of 'Address' model.
        /// Documentation: https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a1e6f0a7-8512-11ec-8ced-005056b2dbe1
        /// </summary>
        /// <param name="ref">City unique guid key</param>
        /// <param name="name">City name</param>
        /// <returns>Ukrainian cities list</returns>
        IResponseEnvelope<CitiesGetResponse.City> GetCities(string name, Guid? @ref = null);

        /// <summary>
        /// Get Ukrainian settlements. Represents 'getCities' method of 'Address' model.
        /// Documentation: https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a1e6f0a7-8512-11ec-8ced-005056b2dbe1
        /// </summary>
        /// <param name="request">Cities search request</param>
        /// <returns>Ukrainian cities list</returns>
        IResponseEnvelope<CitiesGetResponse.City> GetCities(CitiesGetRequest request);

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
        IResponseEnvelope<SettlementsGetResponse.Settlement> GetSettlements(string name = "", Guid? address = null, Guid? region = null, Guid? area = null, bool warehouse = true, int page = 1);

        /// <summary>
        /// Get Ukrainian settlements list by sended request parameters.
        /// Represents 'getSettlements' method of 'AddressGeneral' model. Each response page contains only 150 settlements.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/556d7ccaa0fe4f08e8f7ce43/operations/56248fffa0fe4f0da0550ea8
        /// </summary>
        /// <param name="request">GEt settlements request</param>
        /// <returns>List of finded settlements</returns>
        IResponseEnvelope<SettlementsGetResponse.Settlement> GetSettlements(SettlementsGetRequest request);

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
        IResponseEnvelope<WarehousesGetResponse.Warehouse> GetWarehouses(string cityName = "", Guid? cityRef = null, Guid? settlementRef = null, Guid? warehouseType = null,
            bool bicycleParking = false, bool postFinance = false, bool posTerminal = false, int? warehouseId = null, int page = 1, int limit = 500);

        /// <summary>
        /// Get warehouses list by request parameters.Represents 'getWarehouses' method of 'Address' model.
        /// Documentation: https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a2322f38-8512-11ec-8ced-005056b2dbe1
        /// </summary>
        /// <param name="request">Warehouses get request instance</param>
        /// <returns>List of 'Nova Poshta' service warehouses</returns>
        IResponseEnvelope<WarehousesGetResponse.Warehouse> GetWarehouses(WarehousesGetRequest request);

        /// <summary>
        /// Get warehouse types list. Represents 'getWarehouseTypes' method of 'Address' model.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/556d7ccaa0fe4f08e8f7ce43/operations/556d8211a0fe4f08e8f7ce45
        /// </summary>
        /// <returns>List of warehouses types</returns>
        IResponseEnvelope<WarehouseTypeResponse.WarehouseType> GetWarehouseTypes();

        /// <summary>
        /// Get list of city streets. 'Nova poshta' should have warehouses in this city.
        /// Represents 'getStreet' method of 'Address' model.
        /// Documentation: https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a27c20d7-8512-11ec-8ced-005056b2dbe1
        /// </summary>
        /// <param name="name">Street name</param>
        /// <param name="cityRef">City reference key</param>
        /// <returns>List of city streets</returns>
        IResponseEnvelope<StreetGetResponse.Street> GetStreet(Guid cityRef, string name = null, int page = 1);

        /// <summary>
        /// Get list of city streets. 'Nova poshta' should have warehouses in this city.
        /// Represents 'getStreet' method of 'Address' model.
        /// Documentation: https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a27c20d7-8512-11ec-8ced-005056b2dbe1
        /// </summary>
        /// <param name="request">Get street request</param>
        /// <returns>List of city streets</returns>
        IResponseEnvelope<StreetGetResponse.Street> GetStreet(StreetGetRequest request);

        /// <summary>
        /// Gets area regions by area unique reference key. 
        /// Documentation: https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/a98072f9-2a78-11ee-a60f-48df37b921db
        /// </summary>
        /// <remarks>I'm not sure, but area references from 'getAreas' aren't work. Looks like area references you can get here: https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/c0bfb1a3-2a73-11ee-a60f-48df37b921db</remarks>
        /// <param name="areaReference">Area reference key</param>
        /// <returns>List of area regions</returns>
        IResponseEnvelope<AreaRegionGetResponse.Region> GetSettlementCountryRegion(Guid areaReference);

        /// <summary>
        /// Gets settlement areas list. Looks like 'getAreas' method, but returns another references. Usable for 'getSettlementCountryRegion' method.
        /// Documentation: https://developers.novaposhta.ua/view/model/a0cf0f5f-8512-11ec-8ced-005056b2dbe1/method/c0bfb1a3-2a73-11ee-a60f-48df37b921db
        /// </summary>
        /// <returns>List of settlement areas</returns>
        IResponseEnvelope<SettlementAreaGetResponse.Area> GetSettlementAreas();
    }
}
