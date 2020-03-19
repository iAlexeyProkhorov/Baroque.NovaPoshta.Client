using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Baroque.NovaPoshta.Client.Domain.Common
{
    /// <summary>
    /// Allow to get possible cargo description. Represents response for 'getCargoDescriptionList' method of 'Common' model.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/55702570a0fe4f0cf4fc53ed/operations/55702571a0fe4f0b64838908
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
