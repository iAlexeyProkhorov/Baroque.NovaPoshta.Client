using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Countrparty
{
    /// <summary>
    /// Represents 'getCounterpartyContactPerson' method response of 'Counterparty' model.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/557eb8c8a0fe4f02fc455b2d/operations/557fe424a0fe4f105c087612
    /// </summary>
    [DataContract]
    public class GetContactPersonResponse : BaseResponseEnvelope<GetContactPersonResponse.ContactPerson>
    {
        /// <summary>
        /// Represents contact person
        /// </summary>
        [DataContract]
        public class ContactPerson : BaseRefItem
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
}
