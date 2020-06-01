using Baroque.NovaPoshta.Client.Domain.ContactPerson;
using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Countrparty
{
    /// <summary>
    /// Represents counterparty for create and update methods
    /// </summary>
    [DataContract]
    public class CounterpartyCreateOrUpdate : BaseRefItem
    {
        /// <summary>
        /// Gets or sets counterparty description
        /// </summary>
        [DataMember]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets counterparty first name
        /// </summary>
        [DataMember]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets counterparty middle name
        /// </summary>
        [DataMember]
        public string MiddleName { get; set; }

        /// <summary>
        /// Gets or sets counterparty last name
        /// </summary>
        [DataMember]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets ...
        /// </summary>
        [DataMember(Name = "Counterparty")]
        public string CounterpartyRef { get; set; }

        /// <summary>
        /// Gets or sets ownership form reference
        /// </summary>
        [DataMember]
        public string OwnershipForm { get; set; }

        /// <summary>
        /// Gets or sets ownership form description
        /// </summary>
        [DataMember]
        public string OwnershipFormDescription { get; set; }

        /// <summary>
        /// Gets or sets EDRPOU
        /// </summary>
        [DataMember]
        public string EDRPOU { get; set; }

        /// <summary>
        /// Gets or sets counterparty type reference
        /// </summary>
        [DataMember]
        public string CounterpartyType { get; set; }

        /// <summary>
        /// Gets or sets counterparty contact person
        /// </summary>
        [DataMember]
        public ResponseEnvelope<CounterpartyContactPerson> ContactPerson { get; set; } = new ResponseEnvelope<CounterpartyContactPerson>();

        public override string ToString()
        {
            return this.Description;
        }
    }
}
