using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Documents
{
    /// <summary>
    /// Represents delete backward claim request. 
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/58ad7185eea27006cc36d649/operations/58b6cdf4ff2c200cd80adb93
    /// </summary>
    [DataContract]
    public class DeleteBackwardClaimRequest : BaseRefItem
    {
    }
}
