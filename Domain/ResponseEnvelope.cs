using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain
{
    /// <summary>
    /// Represents main gateway response envelope.
    /// Each gateway response contains this class fields.
    /// </summary>
    /// <typeparam name="TResponseBody">Response body</typeparam>
    [DataContract]
    public class ResponseEnvelope<TResponseBody>: BaseResponseEnvelope<TResponseBody> where TResponseBody : class, new()
    {
        
    }
}
