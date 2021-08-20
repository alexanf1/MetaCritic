
using MetaCritic.Exceptions;

namespace MetaCritic.Http
{
    using System.Threading.Tasks;
    using System;

    /// <summary>
    /// A wrapper around HttpClient which allows for sending HTTP requests and receiving HTTP responses from a resource identified by the Uri.
    /// </summary>
    public interface IHttpClientWrapper
    {
        /// <summary>
        /// Send an async GET request to a specific <see cref="Uri"/>.
        /// </summary>
        /// <param name="address">The specified <typeparamref name="Uri"/>.</param>
        /// <returns>A <see cref="Task{string}"/> representing the response body as a result in a async operation.</returns>
        /// <exception cref="MetaCriticGetContentFailedException">Thrown if retrieving content from the specified Uri fails.</exception>
        Task<string> GetContentAsync(Uri address);
    }
}
