
using MetaCritic.Exceptions;

namespace MetaCritic.Http
{
    using System.Threading.Tasks;

    /// <summary>
    /// A wrapper around HttpClient which allows for sending HTTP requests and receiving HTTP responses from a resource identified by the Uri.
    /// </summary>
    public interface IHttpClientWrapper
    {
        /// <summary>
        /// Send an async GET request to a specific Uri.
        /// </summary>
        /// <param name="address">The specified Uri.</param>
        /// <returns>A task representing the response body as a string in a async operation.</returns>
        /// <exception cref="MetaCriticGetContentFailedException">Thrown if retrieving content from the specified Uri fails.</exception>
        Task<string> GetContentAsync(string address);
    }
}
