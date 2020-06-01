using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.ScanSheet
{
    /// <summary>
    /// Represents 'getScanSheet' request for 'ScanSheet' model.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/55662bd3a0fe4f10086ec96e/operations/556c72d7a0fe4f08e8f7ce30
    /// </summary>
    [DataContract]
    public class GetScanSheetRequest : BaseRefItem
    {
    }
}
