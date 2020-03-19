using System;
using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Common
{
    /// <summary>
    /// Allow to get recipient city time intervals. Represents 'getTimeIntervals' method from 'Common' model.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/55702570a0fe4f0cf4fc53ed/operations/55702571a0fe4f0b6483890f
    /// </summary>
    [DataContract]
    public class GetTimeIntervalsRequest
    {
        [DataMember]
        public Guid RecipientCityRef { get; set; }

        [DataMember]
        public string DateTime { get; set; }
    }
}
