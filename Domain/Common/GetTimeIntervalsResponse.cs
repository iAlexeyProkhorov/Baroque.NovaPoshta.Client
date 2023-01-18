using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Common
{
    /// <summary>
    /// Allow to get recipient city time intervals. Represents 'getTimeIntervals' method from 'Common' model.
    /// Documentation: https://developers.novaposhta.ua/view/model/a55b2c64-8512-11ec-8ced-005056b2dbe1/method/a56d5c1c-8512-11ec-8ced-005056b2dbe1
    /// </summary>
    [DataContract]
    public class GetTimeIntervalsResponse : BaseResponseEnvelope<GetTimeIntervalsResponse.TimeInterval>
    {
        /// <summary>
        /// Represents time interval
        /// </summary>
        [DataContract]
        public class TimeInterval
        {
            /// <summary>
            /// Gets or sets time interval response number
            /// </summary>
            [DataMember]
            public string Number { get; set; }

            /// <summary>
            /// Gets or sets time when interval are available
            /// </summary>
            [DataMember]
            public string Start { get; set; }

            /// <summary>
            /// Gets or sets time when interval begins aren't be available
            /// </summary>
            [DataMember]
            public string End { get; set; }
        }
    }
}
