
namespace MetaCritic.Http
{
    using System.Threading.Tasks;

    public interface IHttpClientWrapper
    {
        Task<string> GetContentAsync(string address);
    }
}
