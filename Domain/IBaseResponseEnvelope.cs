namespace Baroque.NovaPoshta.Client.Domain
{
    /// <summary>
    /// Represents base response envelope interface. This insterface was made specially for few sh..t methods:
    /// 1) https://devcenter.novaposhta.ua/docs/services/55662bd3a0fe4f10086ec96e/operations/556c6a2da0fe4f08e8f7ce2f
    /// 2) https://devcenter.novaposhta.ua/docs/services/55662bd3a0fe4f10086ec96e/operations/556c6474a0fe4f08e8f7ce2e
    /// Thank you 'Nova Poshta' for "excellent" standatization.
    /// </summary>
    /// <typeparam name="TResponse">Response data type</typeparam>
    public interface IBaseResponseEnvelope<TResponse> where TResponse: class
    {
        /// <summary>
        /// Gets or sets successfull response or not
        /// </summary>
        bool Success { get; set; }

        /// <summary>
        /// Gets or sets response body
        /// </summary>
        TResponse Data { get; set; }
    }
}
