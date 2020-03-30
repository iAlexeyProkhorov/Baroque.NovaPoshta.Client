using Baroque.NovaPoshta.Client.Domain;
using Baroque.NovaPoshta.Client.Domain.Countrparty;
using System;

namespace Baroque.NovaPoshta.Client.Services.Counterparties
{
    /// <summary>
    /// Represents counterparty service interface
    /// </summary>
    public interface ICounterpartyService
    {
        /// <summary>
        /// Get counterparty addresses. Represents 'getCounterpartyAddresses' method of 'Counterparty' model.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/557eb8c8a0fe4f02fc455b2d/operations/557fdcb4a0fe4f105c087611
        /// </summary>
        /// <param name="reference">Counterparty reference key</param>
        /// <param name="counterpartyProperty">Couterparty type like Sender or Recipient</param>
        /// <returns>Array of counterparty addresses</returns>
        IResponseEnvelope<GetCounterpartyAddressesResponse.CounterpartyAddress> GetCounterpartyAddresses(Guid reference, string counterpartyProperty);

        /// <summary>
        /// Get counterparty addresses. Represents 'getCounterpartyAddresses' method of 'Counterparty' model.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/557eb8c8a0fe4f02fc455b2d/operations/557fdcb4a0fe4f105c087611
        /// </summary>
        /// <param name="getCounterpartyAddressesRequest">Get counterparty addresses request</param>
        /// <returns>Array of counterparty addresses</returns>
        IResponseEnvelope<GetCounterpartyAddressesResponse.CounterpartyAddress> GetCounterpartyAddresses(GetCounterpartyAddressesRequest getCounterpartyAddressesRequest);

        /// <summary>
        /// Get counterparty options. Represents 'getCounterpartyOptions' method response of 'Counterparty' model.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/557eb8c8a0fe4f02fc455b2d/operations/55801976a0fe4f105c087614
        /// </summary>
        /// <param name="reference">Counterparty reference key</param>
        /// <returns>Counterparty options</returns>
        IResponseEnvelope<GetCounterpartyOptionsResponse.CounterpartyOptions> GetCounterpartyOptions(Guid reference);

        /// <summary>
        /// Get counterparty options. Represents 'getCounterpartyOptions' method response of 'Counterparty' model.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/557eb8c8a0fe4f02fc455b2d/operations/55801976a0fe4f105c087614
        /// </summary>
        /// <param name="getCounterpartyOptionsRequest">Get counterparty options request</param>
        /// <returns>Counterparty options</returns>
        IResponseEnvelope<GetCounterpartyOptionsResponse.CounterpartyOptions> GetCounterpartyOptions(GetCounterpartyOptionsRequest getCounterpartyOptionsRequest);

        /// <summary>
        /// Allow to get counterparty contact persons list. Represents 'getCounterpartyContactPerson' method request of 'Counterparty' model.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/557eb8c8a0fe4f02fc455b2d/operations/557fe424a0fe4f105c087612
        /// </summary>
        /// <param name="page">Page number. Each page contains 100 items.</param>
        /// <param name="reference">Counterparty reference key</param>
        /// <returns>Array of counterparty contact persons.</returns>
        IResponseEnvelope<GetContactPersonResponse.ContactPerson> GetCounterpartyContactPerson(Guid reference, int page = 1);

        /// <summary>
        /// Allow to get counterparty contact persons list. Represents 'getCounterpartyContactPerson' method request of 'Counterparty' model.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/557eb8c8a0fe4f02fc455b2d/operations/557fe424a0fe4f105c087612
        /// </summary>
        /// <param name="getContactPersonRequest">Get contact person request</param>
        /// <returns>Array of counterparty contact persons.</returns>
        IResponseEnvelope<GetContactPersonResponse.ContactPerson> GetCounterpartyContactPerson(GetContactPersonRequest getContactPersonRequest);

        /// <summary>
        /// Get account counterparties. Represents 'getCounterparties' method of 'Counterparty' model.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/557eb8c8a0fe4f02fc455b2d/operations/557fd789a0fe4f105c08760f
        /// </summary>
        /// <param name="counterpartyType">Counterparty type. To get available counterpary type use 'GetTypesOfCounterparties' method of common service.</param>
        /// <param name="findByString">Find counterparty by string</param>
        /// <param name="page">Page number. Each page contains 100 counterparties</param>
        /// <returns>Array of account counterparties</returns>
        IResponseEnvelope<GetCounterpartiesResponse.Counterparty> GetCounterparties(string counterpartyType, string findByString = null, int page = 1);

        /// <summary>
        /// Get account counterparties. Represents 'getCounterparties' method of 'Counterparty' model.
        /// Documentation: https://devcenter.novaposhta.ua/docs/services/557eb8c8a0fe4f02fc455b2d/operations/557fd789a0fe4f105c08760f
        /// </summary>
        /// <param name="getCounterpartiesRequest">Get counterpartie request</param>
        /// <returns>Array of account counterparties</returns>
        IResponseEnvelope<GetCounterpartiesResponse.Counterparty> GetCounterparties(GetCounterpartiesRequest getCounterpartiesRequest);
    }
}
