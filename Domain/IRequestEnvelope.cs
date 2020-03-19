namespace Baroque.NovaPoshta.Client.Domain
{
    /// <summary>
    /// Represents base nova poshta request envelope interface
    /// </summary>
    public interface IRequestEnvelope<TRequestBody>
    {
        /// <summary>
        /// Gets or sets individual api key
        /// </summary>
        string ApiKey { get; set; }

        /// <summary>
        /// Gets or sets using model name
        /// </summary>
        string ModelName { get; set; }

        /// <summary>
        /// Gets or sets called method name
        /// </summary>
        string CalledMethod { get; set; }

        /// <summary>
        /// Gets or sets request method properties
        /// </summary>
        TRequestBody MethodProperties { get; set; }
    }
}
