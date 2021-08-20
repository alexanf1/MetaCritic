
namespace MetaCritic.Http
{
    using System.Net.Http;
    using System.Threading.Tasks;

    public class HttpClientWrapper : IHttpClientWrapper
    {
        private static readonly HttpClient m_client;

        static HttpClientWrapper()
        {
            m_client = new HttpClient();
        }

        public async Task<string> GetContentAsync(string address)
        {
            return await m_client.GetStringAsync(address);
        }
    }
}
