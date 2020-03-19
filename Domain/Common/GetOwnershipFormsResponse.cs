using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Common
{
    /// <summary>
    /// Allow to get supported ownership forms. Represents 'getOwnershipFormsList' method response of 'Common' model.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/55702570a0fe4f0cf4fc53ed/operations/55702571a0fe4f0b6483890b
    /// </summary>
    [DataContract]
    public class GetOwnershipFormsResponse : BaseResponseEnvelope<GetOwnershipFormsResponse.OwnershipForm>
    {
        /// <summary>
        /// Represents ownership form
        /// </summary>
        [DataContract]
        public class OwnershipForm : BaseRefItem
        {
            /// <summary>
            /// Gets or sets ownership form abbreviated description
            /// </summary>
            [DataMember]
            public string Description { get; set; }

            /// <summary>
            /// Gets or sets ownership form full name
            /// </summary>
            [DataMember]
            public string FullName { get; set; }

            /// <summary>
            /// Get full ownership form description
            /// </summary>
            /// <returns>String</returns>
            public override string ToString()
            {
                return $"{Description} - {FullName}";
            }
        }
    }
}
