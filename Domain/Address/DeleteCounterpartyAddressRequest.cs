using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Address
{
    /// <summary>
    /// Delete counterparty address. Represents request for 'delete' method of 'Address' model.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/556d7ccaa0fe4f08e8f7ce43/operations/556da062a0fe4f08e8f7ce4c
    /// </summary>
    [DataContract]
    public class DeleteCounterpartyAddressRequest: BaseRefItem
    {
    }
}
