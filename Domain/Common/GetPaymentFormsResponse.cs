using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Common
{
    /// <summary>
    /// Allow to get 'Nova Poshta' service payment forms. Represents 'getPaymentForms' method response of 'Common' model.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/55702570a0fe4f0cf4fc53ed/operations/55702571a0fe4f0b6483890d
    /// </summary>
    [DataContract]
    public class GetPaymentFormsResponse: BaseResponseEnvelope<GetPaymentFormsResponse.PaymentForm>
    {
        /// <summary>
        /// Represents payment form
        /// </summary>
        [DataContract]
        public class PaymentForm
        {
            /// <summary>
            /// Gets or sets payment form reference
            /// </summary>
            [DataMember]
            public string Ref { get; set; }

            /// <summary>
            /// Gets or sets payment form description on Ukrainian
            /// </summary>
            [DataMember]
            public string Description { get; set; }

            /// <summary>
            /// Get payment form description
            /// </summary>
            /// <returns>String</returns>
            public override string ToString()
            {
                return this.Description;
            }
        }
    }
}
