using System;
using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Countrparty
{
    /// <summary>
    /// Represents 'update' method of 'Counterparty' model.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/557eb8c8a0fe4f02fc455b2d/operations/557fbe62a0fe4f105c08760d
    /// </summary>
    [DataContract]
    public class UpdateCounterpartyRequest : BaseRefItem
    {
        /// <summary>
        /// Gets or sets counterparty city reference key
        /// </summary>
        [DataMember]
        public Guid CityRef { get; set; }

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
    }
}
