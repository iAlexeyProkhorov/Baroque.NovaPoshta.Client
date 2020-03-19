using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Address
{
    /// <summary>
    /// Represents warehouse type response. Represents 'getWarehouseTypes' method of 'Address' model.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/556d7ccaa0fe4f08e8f7ce43/operations/556d8211a0fe4f08e8f7ce45
    /// </summary>
    [DataContract]
    public class WarehouseTypeResponse : BaseResponseEnvelope<WarehouseTypeResponse.WarehouseType>
    {
        /// <summary>
        /// Represents warehouse type
        /// </summary>
        [DataContract]
        public class WarehouseType : BaseRefItem
        {
            /// <summary>
            /// Gets or sets type description
            /// </summary>
            [DataMember]
            public string Description { get; set; }

            /// <summary>
            /// Returns warehouse type presentation
            /// </summary>
            /// <returns>String</returns>
            public override string ToString()
            {
                return Description;
            }
        }
    }
}
