using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Documents
{
    /// <summary>
    /// Represents 'getDocumentPrice' method response of 'InternetDocument' model.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/556eef34a0fe4f02049c664e/operations/55702ee2a0fe4f0cf4fc53ef
    /// </summary>
    [DataContract]
    public class GetDocumentPriceResponse : BaseResponseEnvelope<GetDocumentPriceResponse.PriceCalculationInfo>
    {
        /// <summary>
        /// Represents price calculation result
        /// </summary>
        public class PriceCalculationInfo
        {
            /// <summary>
            /// Gets or sets estimated cost
            /// </summary>
            [DataMember]
            public decimal AssessedCost { get; set; }

            /// <summary>
            /// Gets or sets document cost
            /// </summary>
            [DataMember]
            public decimal Cost { get; set; }

            /// <summary>
            /// Gets or sets redelivery cost
            /// </summary>
            [DataMember]
            public decimal CostRedelivery { get; set; }

            /// <summary>
            /// Gets or sets tariff zone information
            /// </summary>
            [DataMember]
            public TZoneInformation TZoneInfo { get; set; } = new TZoneInformation();

            /// <summary>
            /// Gets or sets cost pack
            /// </summary>
            [DataMember]
            public int CostPack { get; set; }
        }

        /// <summary>
        /// Represents the tariff zone information
        /// </summary>
        [DataContract]
        public class TZoneInformation
        {
            /// <summary>
            /// Gets or sets tariff zone id number
            /// </summary>
            [DataMember]
            public int TZoneId { get; set; }

            /// <summary>
            /// Gets or sets tariff zone name
            /// </summary>
            [DataMember]
            public string TzoneName { get; set; }
        }
    }
}
