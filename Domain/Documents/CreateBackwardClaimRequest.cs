using System;
using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Documents
{
    /// <summary>
    /// Represents backward claim creation request.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/58ad7185eea27006cc36d649/operations/58b6d227ff2c200cd80adb94
    /// </summary>
    [DataContract]
    public class CreateBackwardClaimRequest
    {
        /// <summary>
        /// Gets or sets document tracking number. Required field.
        /// </summary>
        [DataMember]
        public string IntDocNumber { get; set; }

        /// <summary>
        /// Gets or sets payment method reference. Possible values: Cash, NonCash. Required field.
        /// </summary>
        [DataMember]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Gets or sets backward reason reference key. Required field.
        /// </summary>
        [DataMember]
        public Guid Reason { get; set; }

        /// <summary>
        /// Gets or sets backward subtype reason reference key. Required field.
        /// </summary>
        [DataMember]
        public Guid SubtypeReason { get; set; }

        /// <summary>
        /// Gets or sets order type. Constant value "orderCargoReturn". Required field.
        /// </summary>
        [DataMember]
        public string OrderType { get; set; } = "orderCargoReturn";

        /// <summary>
        /// Gets or sets reference of 'CheckPossibilityCreateReturn' block. Required field.
        /// </summary>
        [DataMember]
        public Guid ReturnAddressRef { get; set; }

        /// <summary>
        /// Gets or sets addtional notes.
        /// </summary>
        [DataMember]
        public string Note { get; set; }
    }
}
