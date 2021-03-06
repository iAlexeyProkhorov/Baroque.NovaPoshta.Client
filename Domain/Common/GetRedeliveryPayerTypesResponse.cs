﻿using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Common
{
    /// <summary>
    /// Get list of redelivery payer types. Represents 'getTypesOfPayersForRedelivery' method of 'Common' model.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/55702570a0fe4f0cf4fc53ed/operations/55702571a0fe4f0b64838914
    /// </summary>
    [DataContract]
    public class GetRedeliveryPayerTypesResponse : BaseResponseEnvelope<GetRedeliveryPayerTypesResponse.PayerType>
    {
        /// <summary>
        /// Represents payer type
        /// </summary>
        [DataContract]
        public class PayerType
        {
            /// <summary>
            /// Gets or sets payer type description on Ukrainian
            /// </summary>
            [DataMember]
            public string Description { get; set; }

            /// <summary>
            /// Gets or sets payer type reference name
            /// </summary>
            [DataMember]
            public string Ref { get; set; }

            public override string ToString()
            {
                return Description;
            }
        }
    }
}
