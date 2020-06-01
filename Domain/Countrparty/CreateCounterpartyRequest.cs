using System;
using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Countrparty
{
    /// <summary>
    /// Represents 'save' method request of 'Counterparty' model.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/557eb8c8a0fe4f02fc455b2d/operations/557ebbd3a0fe4f02fc455b2e
    /// </summary>
    [DataContract]
    public class CreateCounterpartyRequest
    {
        /// <summary>
        /// Gets or sets first name
        /// </summary>
        [DataMember]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets last name
        /// </summary>
        [DataMember]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets middle name
        /// </summary>
        [DataMember]
        public string MiddleName { get; set; }

        /// <summary>
        /// Gets or sets counterparty phone number
        /// </summary>
        [DataMember]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets counterparty email
        /// </summary>
        [DataMember]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets counterparty type like 'PrivatePerson' and so on.
        /// To get list of available counterparty types use 'GetTypesOfCounterparties' method of CommonService.
        /// Method documentation: https://devcenter.novaposhta.ua/docs/services/55702570a0fe4f0cf4fc53ed/operations/55702571a0fe4f0b64838912
        /// </summary>
        [DataMember]
        public string CounterpartyType { get; set; } = "PrivatePerson";

        /// <summary>
        /// Gets or sets counterparty property like 'Recipient', 'Sender'.
        /// </summary>
        [DataMember]
        public string CounterpartyProperty { get; set; } = "Recipient";

        /// <summary>
        /// Gets or sets counterparty ownership form reference key. Can be empty for privat persons.
        /// Available ownership forms you can get via 'GetOwnershipFormsList' method of CommonService. Method documentation: https://devcenter.novaposhta.ua/docs/services/55702570a0fe4f0cf4fc53ed/operations/55702571a0fe4f0b6483890b
        /// </summary>
        [DataMember]
        public Guid? OwnershipForm { get; set; }

        /// <summary>
        /// Gets or sets counterparty city reference key. Should be empty for private persons.
        /// </summary>
        [DataMember]
        public Guid? CityRef { get; set; }
    }
}
