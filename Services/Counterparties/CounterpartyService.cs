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
using Baroque.NovaPoshta.Client.Domain.Countrparty;
using System;

namespace Baroque.NovaPoshta.Client.Services.Counterparties
{
    /// <summary>
    /// Represents 'Counterparty' model methods.
    /// </summary>
    public class CounterpartyService : ICounterpartyService
    {
        private readonly INovaPoshtaGateway _novaPoshtaGateway;

        protected const string MODEL = "Counterparty";

        public CounterpartyService(INovaPoshtaGateway novaPoshtaGateway)
        {
            this._novaPoshtaGateway = novaPoshtaGateway;
        }

        /// <summary>
        /// Get counterparty addresses. Represents 'getCounterpartyAddresses' method of 'Counterparty' model.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/557eb8c8a0fe4f02fc455b2d/operations/557fdcb4a0fe4f105c087611
        /// </summary>
        /// <param name="reference">Counterparty reference key</param>
        /// <param name="counterpartyProperty">Couterparty type like Sender or Recipient</param>
        /// <returns>Array of counterparty addresses</returns>
        public virtual IResponseEnvelope<GetCounterpartyAddressesResponse.CounterpartyAddress> GetCounterpartyAddresses(Guid reference, string counterpartyProperty)
        {
            var request = new GetCounterpartyAddressesRequest()
            {
                Reference = reference,
                CounterpartyProperty = counterpartyProperty
            };

            return GetCounterpartyAddresses(request);
        }

        /// <summary>
        /// Get counterparty addresses. Represents 'getCounterpartyAddresses' method of 'Counterparty' model.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/557eb8c8a0fe4f02fc455b2d/operations/557fdcb4a0fe4f105c087611
        /// </summary>
        /// <param name="getCounterpartyAddressesRequest">Get counterparty addresses request</param>
        /// <returns>Array of counterparty addresses</returns>
        public virtual IResponseEnvelope<GetCounterpartyAddressesResponse.CounterpartyAddress> GetCounterpartyAddresses(GetCounterpartyAddressesRequest getCounterpartyAddressesRequest)
        {
            var request = new RequestEnvelope<GetCounterpartyAddressesRequest>(getCounterpartyAddressesRequest)
            {
                CalledMethod = "getCounterpartyAddresses",
                ModelName = MODEL
            };

            var response = _novaPoshtaGateway.CreateRequest<GetCounterpartyAddressesRequest, GetCounterpartyAddressesResponse>(request);
            return response;
        }

        /// <summary>
        /// Get counterparty options. Represents 'getCounterpartyOptions' method response of 'Counterparty' model.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/557eb8c8a0fe4f02fc455b2d/operations/55801976a0fe4f105c087614
        /// </summary>
        /// <param name="reference">Counterparty reference key</param>
        /// <returns>Counterparty options</returns>
        public virtual IResponseEnvelope<GetCounterpartyOptionsResponse.CounterpartyOptions> GetCounterpartyOptions(Guid reference)
        {
            var request = new GetCounterpartyOptionsRequest()
            {
                Reference = reference
            };

            return GetCounterpartyOptions(request);
        }

        /// <summary>
        /// Get counterparty options. Represents 'getCounterpartyOptions' method response of 'Counterparty' model.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/557eb8c8a0fe4f02fc455b2d/operations/55801976a0fe4f105c087614
        /// </summary>
        /// <param name="getCounterpartyOptionsRequest">Get counterparty options request</param>
        /// <returns>Counterparty options</returns>
        public virtual IResponseEnvelope<GetCounterpartyOptionsResponse.CounterpartyOptions> GetCounterpartyOptions(GetCounterpartyOptionsRequest getCounterpartyOptionsRequest)
        {
            var request = new RequestEnvelope<GetCounterpartyOptionsRequest>(getCounterpartyOptionsRequest)
            {
                CalledMethod = "getCounterpartyOptions",
                ModelName = MODEL
            };

            var response = _novaPoshtaGateway.CreateRequest<GetCounterpartyOptionsRequest, GetCounterpartyOptionsResponse>(request);
            return response;
        }

        /// <summary>
        /// Allow to get counterparty contact persons list. Represents 'getCounterpartyContactPerson' method request of 'Counterparty' model.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/557eb8c8a0fe4f02fc455b2d/operations/557fe424a0fe4f105c087612
        /// </summary>
        /// <param name="page">Page number. Each page contains 100 items.</param>
        /// <param name="reference">Counterparty reference key</param>
        /// <returns>Array of counterparty contact persons.</returns>
        public virtual IResponseEnvelope<GetContactPersonResponse.ContactPerson> GetCounterpartyContactPerson(Guid reference, int page = 1)
        {
            var request = new GetContactPersonRequest()
            {
                Reference = reference,
                Page = page
            };

            return GetCounterpartyContactPerson(request);
        }

        /// <summary>
        /// Allow to get counterparty contact persons list. Represents 'getCounterpartyContactPerson' method request of 'Counterparty' model.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/557eb8c8a0fe4f02fc455b2d/operations/557fe424a0fe4f105c087612
        /// </summary>
        /// <param name="getContactPersonRequest">Get contact person request</param>
        /// <returns>Array of counterparty contact persons.</returns>
        public virtual IResponseEnvelope<GetContactPersonResponse.ContactPerson> GetCounterpartyContactPerson(GetContactPersonRequest getContactPersonRequest)
        {
            var request = new RequestEnvelope<GetContactPersonRequest>(getContactPersonRequest)
            {
                CalledMethod = "getCounterpartyContactPersons",
                ModelName = MODEL
            };

            var response = _novaPoshtaGateway.CreateRequest<GetContactPersonRequest, GetContactPersonResponse>(request);
            return response;
        }

        /// <summary>
        /// Get account counterparties. Represents 'getCounterparties' method of 'Counterparty' model.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/557eb8c8a0fe4f02fc455b2d/operations/557fd789a0fe4f105c08760f
        /// </summary>
        /// <param name="counterpartyType">Counterparty type. To get available counterpary type use 'GetTypesOfCounterparties' method of common service.</param>
        /// <param name="findByString">Find counterparty by string</param>
        /// <param name="page">Page number. Each page contains 100 counterparties</param>
        /// <returns>Array of account counterparties</returns>
        public virtual IResponseEnvelope<GetCounterpartiesResponse.Counterparty> GetCounterparties(string counterpartyType, string findByString = null, int page = 1)
        {
            var request = new GetCounterpartiesRequest()
            {
                CounterpartyProperty = counterpartyType
            };

            return GetCounterparties(request);
        }

        /// <summary>
        /// Get account counterparties. Represents 'getCounterparties' method of 'Counterparty' model.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/557eb8c8a0fe4f02fc455b2d/operations/557fd789a0fe4f105c08760f
        /// </summary>
        /// <param name="getCounterpartiesRequest">Get counterpartie request</param>
        /// <returns>Array of account counterparties</returns>
        public virtual IResponseEnvelope<GetCounterpartiesResponse.Counterparty> GetCounterparties(GetCounterpartiesRequest getCounterpartiesRequest)
        {
            var request = new RequestEnvelope<GetCounterpartiesRequest>(getCounterpartiesRequest)
            {
                ApiKey = _novaPoshtaGateway.ApiKey,
                CalledMethod = "getCounterparties",
                ModelName = MODEL
            };

            var response = _novaPoshtaGateway.CreateRequest<GetCounterpartiesRequest, GetCounterpartiesResponse>(request);
            return response;
        }

        /// <summary>
        /// Create counterparty. Represent 'save' method of 'Counterparty' model.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/557eb8c8a0fe4f02fc455b2d/operations/557ebbd3a0fe4f02fc455b2e
        /// </summary>
        /// <param name="createCounterpartyRequest">Create counterparty request</param>
        /// <returns>Counterparty creation result</returns>
        public virtual IResponseEnvelope<CounterpartyCreateOrUpdate> CreateCounterparty(CreateCounterpartyRequest createCounterpartyRequest)
        {
            var request = new RequestEnvelope<CreateCounterpartyRequest>(createCounterpartyRequest)
            {
                CalledMethod = "save",
                ModelName = MODEL
            };

            var response = _novaPoshtaGateway.CreateRequest<CreateCounterpartyRequest, CreateCounterpartyResponse>(request);
            return response;
        }

        /// <summary>
        /// Update counterparty. Represents 'update' method of 'Counterparty' model.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/557eb8c8a0fe4f02fc455b2d/operations/557fbe62a0fe4f105c08760d
        /// </summary>
        /// <param name="updateCounterpartyRequest">Update counterparty request</param>
        /// <returns>Counterparty processing result</returns>
        public virtual IResponseEnvelope<CounterpartyCreateOrUpdate> UpdateCounterparty(UpdateCounterpartyRequest updateCounterpartyRequest)
        {
            var request = new RequestEnvelope<UpdateCounterpartyRequest>(updateCounterpartyRequest)
            {
                CalledMethod = "update",
                ModelName = MODEL
            };

            var response = _novaPoshtaGateway.CreateRequest<UpdateCounterpartyRequest, UpdateCounterpartyResponse>(request);
            return response;
        }

        /// <summary>
        /// Delete 'recipient' counterparty. Represents 'delete' method of 'Counterparty' model.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/557eb8c8a0fe4f02fc455b2d/operations/557fd35da0fe4f105c08760e
        /// </summary>
        /// <param name="reference">Counterparty reference key</param>
        /// <returns>Counterparty removing result</returns>
        public virtual IResponseEnvelope<DeleteCounterpartyResponse.DeletedCounterparty> DeleteCounterparty(Guid reference)
        {
            var request = new DeleteCounterpartyRequest()
            {
                Reference = reference
            };
            return DeleteCounterparty(request);
        }

        /// <summary>
        /// Delete 'recipient' counterparty. Represents 'delete' method of 'Counterparty' model.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/557eb8c8a0fe4f02fc455b2d/operations/557fd35da0fe4f105c08760e
        /// </summary>
        /// <param name="deleteCounterpartyRequest">Delete counterparty request</param>
        /// <returns>Counterparty removing result</returns>
        public virtual IResponseEnvelope<DeleteCounterpartyResponse.DeletedCounterparty> DeleteCounterparty(DeleteCounterpartyRequest deleteCounterpartyRequest)
        {
            var request = new RequestEnvelope<DeleteCounterpartyRequest>(deleteCounterpartyRequest)
            {
                CalledMethod = "delete",
                ModelName = MODEL
            };

            var response = _novaPoshtaGateway.CreateRequest<DeleteCounterpartyRequest, DeleteCounterpartyResponse>(request);
            return response;
        }
    }
}
