using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Common
{
    /// <summary>
    /// Allow to get recipient city time intervals. Represents 'getTimeIntervals' method from 'Common' model.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/55702570a0fe4f0cf4fc53ed/operations/55702571a0fe4f0b6483890f
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
