using System.Runtime.Serialization;

namespace Baroque.NovaPoshta.Client.Domain.Documents
{
    /// <summary>
    /// Represents delete document changes query request.
    /// Documentation: https://devcenter.novaposhta.ua/docs/services/59eef733ff2c200ce4f6f904/operations/59eefc71eea2700b202b9c44
    /// </summary>
    [DataContract]
    public class DeleteDocumentChangesRequest: BaseRefItem
    {
    }
}
