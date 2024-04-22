using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Common
{
    /// <summary>
    /// Allow to get possible cargo description. Represents response for 'getCargoDescriptionList' method of 'Common' model.
    /// Documentation: https://developers.novaposhta.ua/view/model/a55b2c64-8512-11ec-8ced-005056b2dbe1/method/a697db47-8512-11ec-8ced-005056b2dbe1
    /// </summary>
    [DataContract]
    public class GetCargoDescriptionResponse : BaseResponseEnvelope<GetCargoDescriptionResponse.CargoDescription>
    {
        /// <summary>
        /// Represents cargo description
        /// </summary>
        [DataContract]
        public class CargoDescription : BaseRefItem
        {
            /// <summary>
            /// Gets or sets cargo description
            /// </summary>
            [DataMember]
            public string Description { get; set; }

            /// <summary>
            /// Returns cargo description
            /// </summary>
            /// <returns>String</returns>
            public override string ToString()
            {
                return Description;
            }
        }
    }
}
