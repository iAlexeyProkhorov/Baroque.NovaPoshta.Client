using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Common
{
    /// <summary>
    /// Allow to get possible delivery service types like door - door, warehouse - warehouse and so on. Represents 'getServiceTypes' method of 'Common' model.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/55702570a0fe4f0cf4fc53ed/operations/55702571a0fe4f0b6483890e
    /// </summary>
    [DataContract]
    public class GetServiceTypeResponse : BaseResponseEnvelope<GetServiceTypeResponse.ServiceType>
    {
        /// <summary>
        /// Represents delivery service type
        /// </summary>
        [DataContract]
        public class ServiceType
        {
            /// <summary>
            /// Gets or sets delivery service type reference 
            /// </summary>
            [DataMember]
            public string Ref { get; set; }

            /// <summary>
            /// Gets or sets delivery service type description on Ukrainian.
            /// </summary>
            [DataMember]
            public string Description { get; set; }

            /// <summary>
            /// Get service type desctiption
            /// </summary>
            /// <returns>String</returns>
            public override string ToString()
            {
                return this.Description;
            }
        }
    }
}
