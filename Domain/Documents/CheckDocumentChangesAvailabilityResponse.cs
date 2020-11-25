using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Documents
{
    /// <summary>
    /// Represents 'CheckPossibilityChangeEW' method response of 'AdditionalService' model
    /// </summary>
    [DataContract]
    public class CheckDocumentChangesAvailabilityResponse : BaseResponseEnvelope<CheckDocumentChangesAvailabilityResponse.ChangesAvailabilityItem>
    {
        /// <summary>
        /// Gets or sets request processing errors list
        /// </summary>
        [DataMember]
        public string[] Errors { get; set; } = new string[0];

        /// <summary>
        /// Represents changes availability response item
        /// </summary>
        [DataContract]
        public class ChangesAvailabilityItem
        {
            /// <summary>
            /// Gets or sets value, which indicates can sender change document parameters or not
            /// </summary>
            [DataMember]
            public bool CanChangeSender { get; set; }

            /// <summary>
            /// Gets or sets value, which indicates can recipient change document parameters or not
            /// </summary>
            [DataMember]
            public bool CanChangeRecipient { get; set; }

            /// <summary>
            /// Gets or sets value, which indicates payment method changes possibility
            /// </summary>
            [DataMember]
            public bool CanChangePayerTypeOrPaymentMethod { get; set; }

            /// <summary>
            /// Gets or sets a sender phone number
            /// </summary>
            [DataMember]
            public string SenderPhone { get; set; }

            /// <summary>
            /// Gets or sets sender contact person full name
            /// </summary>
            [DataMember]
            public string ContactPersonSender { get; set; }

            /// <summary>
            /// Gets or sets recipient phone number
            /// </summary>
            [DataMember]
            public string RecipientPhone { get; set; }

            /// <summary>
            /// Gets or sets recipient contact person
            /// </summary>
            [DataMember]
            public string ContactPersonRecipient { get; set; }

            /// <summary>
            /// Gets or sets payer type reference. (Sender, Recipient, ThirdPerson)
            /// </summary>
            [DataMember]
            public string PayerType { get; set; }

            /// <summary>
            /// Gets or sets payment method reference key. For example: Cash
            /// </summary>
            [DataMember]
            public string PaymentMethod { get; set; }

            /// <summary>
            /// Gets or sets sender counterpary
            /// </summary>
            [DataMember]
            public string SenderCounterparty { get; set; }

            /// <summary>
            /// Gets or sets recipient counterparty
            /// </summary>
            [DataMember]
            public string RecipientCounterparty { get; set; }
        }
    }
}
