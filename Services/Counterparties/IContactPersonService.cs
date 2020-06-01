using Baroque.NovaPoshta.Client.Domain;
using Baroque.NovaPoshta.Client.Domain.ContactPerson;

namespace Baroque.NovaPoshta.Client.Services.Counterparties
{
    /// <summary>
    /// Represents 'ContactPerson' model methods.
    /// </summary>
    public interface IContactPersonService
    {
        /// <summary>
        /// Represents 'save' method of 'ContactPerson' model.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/557eb8c8a0fe4f02fc455b2d/operations/55828c4ca0fe4f0adc08ef27
        /// </summary>
        /// <param name="createContactPersonRequest">Create contact person request</param>
        /// <returns>Created contact person</returns>
        IResponseEnvelope<CounterpartyContactPerson> Create(CreateContactPersonRequest createContactPersonRequest);

        /// <summary>
        /// Represents 'update' method of 'ContactPerson' model.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/557eb8c8a0fe4f02fc455b2d/operations/558297aca0fe4f0adc08ef28
        /// </summary>
        /// <param name="updateContactPersonRequest">Update contact person request</param>
        /// <returns>Updated contact person</returns>
        IResponseEnvelope<CounterpartyContactPerson> Update(UpdateContactPersonRequest updateContactPersonRequest);

        /// <summary>
        /// Represents 'delete' method of 'ContactPerson' model.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/557eb8c8a0fe4f02fc455b2d/operations/55829aa2a0fe4f0adc08ef29
        /// </summary>
        /// <param name="deleteContactPersonRequest">Delete contact person request</param>
        /// <returns>Deleted contact person</returns>
        IResponseEnvelope<DeleteContactPersonResponse.DeletedItem> Delete(DeleteContactPersonRequest deleteContactPersonRequest);
    }
}
