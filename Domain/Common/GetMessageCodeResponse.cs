using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Common
{
    /// <summary>
    /// Allow to get error messages. Reprensents 'getMessageCodeText' method response of 'Common' model.
    /// Documentation: https://developers.novaposhta.ua/view/model/a55b2c64-8512-11ec-8ced-005056b2dbe1/method/a6bce5a1-8512-11ec-8ced-005056b2dbe1
    /// </summary>
    [DataContract]
    public class GetMessageCodeResponse : BaseResponseEnvelope<GetMessageCodeResponse.MessageCodeItem>
    {
        /// <summary>
        /// Represents message code item
        /// </summary>
        [DataContract]
        public class MessageCodeItem
        {
            /// <summary>
            /// Gets or sets message code
            /// </summary>
            [DataMember]
            public string MessageCode { get; set; }

            /// <summary>
            /// Gets or sets message text on English
            /// </summary>
            [DataMember]
            public string MessageText { get; set; }

            /// <summary>
            /// Gets or sets message text on Russian
            /// </summary>
            [DataMember]
            public string MessageDescriptionRU { get; set; }

            /// <summary>
            /// Gets or sets message text on Ukrainian
            /// </summary>
            [DataMember]
            public string MessageDescriptionUA { get; set; }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public override string ToString()
            {
                return $"{MessageCode} - {MessageText}";
            }
        }
    }
}
