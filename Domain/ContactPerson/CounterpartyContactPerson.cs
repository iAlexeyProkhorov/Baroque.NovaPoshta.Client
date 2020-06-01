using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.ContactPerson
{
    /// <summary>
    /// Represents contact person
    /// </summary>
    [DataContract]
    public class CounterpartyContactPerson : BaseRefItem
    {
        /// <summary>
        /// Gets or sets contact person description
        /// </summary>
        [DataMember]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets phones
        /// </summary>
        [DataMember]
        public string Phones { get; set; }

        /// <summary>
        /// Gets or sets contact person email
        /// </summary>
        [DataMember]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets contact person first name
        /// </summary>
        [DataMember]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets contact person last name
        /// </summary>
        [DataMember]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets contact person middle name
        /// </summary>
        [DataMember]
        public string MiddleName { get; set; }

        public override string ToString()
        {
            return this.Description;
        }
    }
}
