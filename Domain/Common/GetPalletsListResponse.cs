using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Common
{
    /// <summary>
    /// Get list of available pallets. Represents 'getPalletsList' method of 'Common' model.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/55702570a0fe4f0cf4fc53ed/operations/5824774ba0fe4f0e60694eb0
    /// </summary>
    [DataContract]
    public class GetPalletsListResponse : BaseResponseEnvelope<GetPalletsListResponse.Pallet>
    {
        /// <summary>
        /// Represents pallet
        /// </summary>
        [DataContract]
        public class Pallet : BaseRefItem
        {
            /// <summary>
            /// Gets or sets pallet description on Ukrainian.
            /// </summary>
            [DataMember]
            public string Description { get; set; }

            /// <summary>
            /// Gets or sets pallet description on Russian.
            /// </summary>
            [DataMember]
            public string DescriptionRu { get; set; }

            /// <summary>
            /// Gets or sets pallet weight
            /// </summary>
            [DataMember]
            public decimal Weight { get; set; }

            public override string ToString()
            {
                return Description;
            }
        }
    }
}
