
using MetaCritic.Exceptions;

namespace MetaCritic.Http
{
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;

    /// <inheritdoc />
    public class HttpClientWrapper : IHttpClientWrapper
    {
        private static readonly HttpClient m_client = new HttpClient();

        /// <inheritdoc />
        public async Task<string> GetContentAsync(string address)
        {
            try
            {
                return await m_client.GetStringAsync(address);
            }
            catch (ArgumentNullException e)
            {
                throw new MetaCriticGetContentFailedException($"Invalid Uri provided: {nameof(address)}", e);
            }
            catch (HttpRequestException e)
            {
                throw new MetaCriticGetContentFailedException($"Failed retrieve content", e);
            }
        }
    }
}
