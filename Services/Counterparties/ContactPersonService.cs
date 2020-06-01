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
using Baroque.NovaPoshta.Client.Domain.ContactPerson;

namespace Baroque.NovaPoshta.Client.Services.Counterparties
{
    /// <summary>
    /// Represents 'ContactPerson' model methods.
    /// </summary>
    public class ContactPersonService : IContactPersonService
    {
        protected readonly INovaPoshtaGateway _novaPoshtaGateway;

        protected const string MODEL = "ContactPerson";

        public ContactPersonService(INovaPoshtaGateway novaPoshtaGateway)
        {
            this._novaPoshtaGateway = novaPoshtaGateway;
        }

        /// <summary>
        /// Represents 'save' method of 'ContactPerson' model.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/557eb8c8a0fe4f02fc455b2d/operations/55828c4ca0fe4f0adc08ef27
        /// </summary>
        /// <param name="createContactPersonRequest">Create contact person request</param>
        /// <returns>Created contact person</returns>
        public virtual IResponseEnvelope<CounterpartyContactPerson> Create(CreateContactPersonRequest createContactPersonRequest)
        {
            var request = new RequestEnvelope<CreateContactPersonRequest>(createContactPersonRequest)
            {
                CalledMethod = "save",
                ModelName = MODEL
            };

            var response = _novaPoshtaGateway.CreateRequest<CreateContactPersonRequest, CreateContactPersonResponse>(request);
            return response;
        }

        /// <summary>
        /// Represents 'update' method of 'ContactPerson' model.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/557eb8c8a0fe4f02fc455b2d/operations/558297aca0fe4f0adc08ef28
        /// </summary>
        /// <param name="updateContactPersonRequest">Update contact person request</param>
        /// <returns>Updated contact person</returns>
        public virtual IResponseEnvelope<CounterpartyContactPerson> Update(UpdateContactPersonRequest updateContactPersonRequest)
        {
            var request = new RequestEnvelope<UpdateContactPersonRequest>(updateContactPersonRequest)
            {
                CalledMethod = "update",
                ModelName = MODEL
            };

            var response = _novaPoshtaGateway.CreateRequest<UpdateContactPersonRequest, UpdateContactPersonResponse>(request);
            return response;
        }

        /// <summary>
        /// Represents 'delete' method of 'ContactPerson' model.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/557eb8c8a0fe4f02fc455b2d/operations/55829aa2a0fe4f0adc08ef29
        /// </summary>
        /// <param name="deleteContactPersonRequest">Delete contact person request</param>
        /// <returns>Deleted contact person</returns>
        public virtual IResponseEnvelope<DeleteContactPersonResponse.DeletedItem> Delete(DeleteContactPersonRequest deleteContactPersonRequest)
        {
            var request = new RequestEnvelope<DeleteContactPersonRequest>(deleteContactPersonRequest)
            {
                CalledMethod = "delete",
                ModelName = MODEL
            };

            var response = _novaPoshtaGateway.CreateRequest<DeleteContactPersonRequest, DeleteContactPersonResponse>(request);
            return response;
        }
    }
}
