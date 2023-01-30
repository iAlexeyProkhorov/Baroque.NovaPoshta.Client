using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Common
{
    /// <summary>
    /// Get list of available pallets. Represents 'getPalletsList' method of 'Common' model.
    /// Documentation: https://developers.novaposhta.ua/view/model/a55b2c64-8512-11ec-8ced-005056b2dbe1/method/a5dd575e-8512-11ec-8ced-005056b2dbe1
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
