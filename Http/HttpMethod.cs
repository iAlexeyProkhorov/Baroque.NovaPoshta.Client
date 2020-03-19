namespace Baroque.NovaPoshta.Client.Http
{
    /// <summary>
    /// Represents HTTP method names
    /// Descriptions was get from here: https://www.tutorialspoint.com/http/http_methods
    /// </summary>
    public enum HttpMethod
    {
        /// <summary>
        /// The GET method is used to retrieve information from the given server using a given URI. Requests using GET should only retrieve data and should have no other effect on the data.
        /// </summary>
        GET,
        /// <summary>
        /// Same as GET, but transfers the status line and header section only.
        /// </summary>
        HEAD,
        /// <summary>
        /// A POST request is used to send data to the server, for example, customer information, file upload, etc. using HTML forms.
        /// </summary>
        POST,
        /// <summary>
        /// Replaces all current representations of the target resource with the uploaded content.
        /// </summary>
        PUT,
        /// <summary>
        /// Removes all current representations of the target resource given by a URI.
        /// </summary>
        DELETE,
        /// <summary>
        /// Establishes a tunnel to the server identified by a given URI.
        /// </summary>
        CONNECT,
        /// <summary>
        /// Describes the communication options for the target resource.
        /// </summary>
        OPTIONS,
        /// <summary>
        /// Performs a message loop-back test along the path to the target resource.
        /// </summary>
        TRACE
    }
}
