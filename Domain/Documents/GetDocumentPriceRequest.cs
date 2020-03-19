using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Documents
{
    /// <summary>
    /// Represents document price calculation request for 'getDocumentPrice' method of 'InternetDocument' model.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/556eef34a0fe4f02049c664e/operations/55702ee2a0fe4f0cf4fc53ef
    /// </summary>
    [DataContract]
    public class GetDocumentPriceRequest
    {
        /// <summary>
        /// Gets or sets sender city reference key. To get reference key use needed searching method from address service.
        /// </summary>
        [DataMember]
        public Guid CitySender { get; set; }

        /// <summary>
        /// Gets or sets recipient city reference key. To get reference key use needed searching method from address service.
        /// </summary>
        [DataMember]
        public Guid CityRecipient { get; set; }

        /// <summary>
        /// Gets or sets total package weight.
        /// </summary>
        [DataMember]
        public decimal Weight { get; set; } = 0.1M;

        /// <summary>
        /// Gets or sets delivery service type reference.
        /// To get reference key use: https://devcenter.novaposhta.ua/docs/services/55702570a0fe4f0cf4fc53ed/operations/55702571a0fe4f0b6483890e. Method also presented in common service.
        /// </summary>
        [DataMember]
        public string ServiceType { get; set; }

        /// <summary>
        /// Gets or sets package cost.
        /// </summary>
        [DataMember]
        public decimal Cost { get; set; } = 200;

        /// <summary>
        /// Gets or sets cargo type reference. To get reference use: https://devcenter.novaposhta.ua/docs/services/55702570a0fe4f0cf4fc53ed/operations/55702571a0fe4f0b64838909. Method also presented in client common service.
        /// </summary>
        [DataMember]
        public string CargoType { get; set; }

        /// <summary>
        /// Gets or sets package seats amount.
        /// </summary>
        [DataMember]
        public int SeatsAmount { get; set; }

        /// <summary>
        /// Gets or sets redelivery calculate
        /// </summary>
        [DataMember]
        public BackDelivery RedeliveryCalculate { get; set; }

        /// <summary>
        /// Gets or sets packages count
        /// </summary>
        [DataMember]
        public int? PackCount { get; set; }

        /// <summary>
        /// Gets or sets package type reference
        /// </summary>
        [DataMember]
        public Guid? PackRef { get; set; }

        /// <summary>
        /// Gets or sets amount
        /// </summary>
        [DataMember]
        public int Amount { get; set; }

        /// <summary>
        /// Gets or sets cargo details. As I understand this stuff are using for tyres and wheels delivery.
        /// </summary>
        [DataMember]
        public List<CargoDetail> CargoDetails { get; set; } = new List<CargoDetail>();

        /// <summary>
        /// Represents back delivery information
        /// </summary>
        [DataContract]
        public class BackDelivery
        {
            /// <summary>
            /// Gets or sets back delivery cargo type. 
            /// To get cargo type reference use: https://devcenter.novaposhta.ua/docs/services/55702570a0fe4f0cf4fc53ed/operations/55702571a0fe4f0b64838907, which presented in common service.
            /// </summary>
            [DataMember]
            public string CargoType { get; set; }

            /// <summary>
            /// Gets or sets back delivery amount
            /// </summary>
            [DataMember]
            public decimal Amount { get; set; }
        }

        /// <summary>
        /// Represents package calculation information. Allow to calculate package price inclue packaging type price.
        /// </summary>
        [DataContract]
        public class PackCalculationInfo
        {
            /// <summary>
            /// Gets or sets package type reference key.
            /// To get reference key use online method: https://devcenter.novaposhta.ua/docs/services/55702570a0fe4f0cf4fc53ed/operations/582b1069a0fe4f0298618f06
            /// It's presented in client CommonService.
            /// </summary>
            [DataMember]
            public Guid PackRef { get; set; }

            /// <summary>
            /// Gets or sets packaging count
            /// </summary>
            [DataMember]
            public int PackCount { get; set; }
        }

        /// <summary>
        /// Represents cargo details list item
        /// </summary>
        [DataContract]
        public class CargoDetail
        {
            /// <summary>
            /// Gets or sets package content type reference key.
            /// To get reference use online method: https://devcenter.novaposhta.ua/docs/services/55702570a0fe4f0cf4fc53ed/operations/55702571a0fe4f0b64838910, which presented in client common service.
            /// </summary>
            [DataMember]
            public Guid CargoDescription { get; set; }

            /// <summary>
            /// Gets or sets items amount
            /// </summary>
            [DataMember]
            public int Amount { get; set; }
        }
    }
}
