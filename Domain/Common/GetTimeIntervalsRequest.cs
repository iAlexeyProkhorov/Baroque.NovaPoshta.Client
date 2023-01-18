using System;
using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Common
{
    /// <summary>
    /// Allow to get recipient city time intervals. Represents 'getTimeIntervals' method from 'Common' model.
    /// Documentation: https://developers.novaposhta.ua/view/model/a55b2c64-8512-11ec-8ced-005056b2dbe1/method/a56d5c1c-8512-11ec-8ced-005056b2dbe1
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
