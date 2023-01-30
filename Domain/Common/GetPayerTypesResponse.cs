using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Common
{
    /// <summary>
    /// Get list of available payer types. Represents 'getTypesOfPayers' method of 'Common' model.
    /// Documentation: https://developers.novaposhta.ua/view/model/a55b2c64-8512-11ec-8ced-005056b2dbe1/method/a6247f2f-8512-11ec-8ced-005056b2dbe1
    /// </summary>
    [DataContract]
    public class GetPayerTypesResponse: BaseResponseEnvelope<GetPayerTypesResponse.PayerType>
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
