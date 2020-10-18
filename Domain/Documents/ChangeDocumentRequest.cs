using System;
using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Documents
{
    /// <summary>
    /// Change document request.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/59eef733ff2c200ce4f6f904/operations/59eef989eea2700b202b9c43
    /// </summary>
    [DataContract]
    public class ChangeDocumentRequest
    {
        /// <summary>
        /// Gets or sets document tracking number
        /// </summary>
        [DataMember]
        public int IntDocNumber { get; set; }

        /// <summary>
        /// Gets or sets changing data type. "orderChangeEW" by default.
        /// </summary>
        [DataMember]
        public string OrderType { get; set; } = "orderChangeEW";

        /// <summary>
        /// Gets or sets sender contact lastname and firstname
        /// </summary>
        [DataMember]
        public string SenderContactName { get; set; }

        /// <summary>
        /// Gets or sets sender contact phone
        /// </summary>
        [DataMember]
        public string SenderPhone { get; set; }

        /// <summary>
        /// Gets or sets recipient reference key
        /// </summary>
        [DataMember]
        public Guid Recipient { get; set; }

        /// <summary>
        /// Gets or sets recipient contact firstname and lastname
        /// </summary>
        [DataMember]
        public string RecipientContactName { get; set; }

        /// <summary>
        /// Gets or sets recipient phone number
        /// </summary>
        [DataMember]
        public string RecipientPhone { get; set; }

        /// <summary>
        /// Gets or sets payer type: recipient / sender / third person
        /// </summary>
        [DataMember]
        public string PayerType { get; set; }

        /// <summary>
        /// Gets or sets payment method. "Cash" by default.
        /// </summary>
        [DataMember]
        public string PaymentMethod { get; set; } = "Cash";
    }
}
