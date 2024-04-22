﻿using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Common
{
    /// <summary>
    /// Allow to get possible cargo types. Represents 'getCartoTypes' method 'Common' model response.
    /// Documentation: https://developers.novaposhta.ua/view/model/a55b2c64-8512-11ec-8ced-005056b2dbe1/method/a5912a1e-8512-11ec-8ced-005056b2dbe1
    /// </summary>
    [DataContract]
    public class GetCargoTypesResponse : BaseResponseEnvelope<GetCargoTypesResponse.CargoType>
    {
        /// <summary>
        /// Represents cargo type
        /// </summary>
        [DataContract]
        public class CargoType
        {
            /// <summary>
            /// Gets or sets cargo type name. On Ukrainian.
            /// </summary>
            [DataMember]
            public string Description { get; set; }

            /// <summary>
            /// Gets or sets cargo type reference name
            /// </summary>
            [DataMember]
            public string Ref { get; set; }

            public override string ToString()
            {
                return Description;
            }
        }
    }
}
