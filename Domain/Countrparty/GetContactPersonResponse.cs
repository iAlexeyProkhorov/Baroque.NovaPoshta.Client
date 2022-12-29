using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Countrparty
{
    /// <summary>
    /// Represents 'getCounterpartyContactPerson' method response of 'Counterparty' model.
    /// Documentation: https://developers.novaposhta.ua/view/model/a28f4b04-8512-11ec-8ced-005056b2dbe1/method/a3575a67-8512-11ec-8ced-005056b2dbe1
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
