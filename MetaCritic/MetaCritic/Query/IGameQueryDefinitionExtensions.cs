
namespace MetaCritic.Query
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Http;
    using Model;
    using Scraping;

    public static class IGameQueryDefinitionExtensions
    {
        public static async Task<IEnumerable<IGame>> ExecuteAsync(this IGameQueryDefinition<IGame> queryDefinition)
        {
            HttpClientWrapper client = new HttpClientWrapper();
            GameScraper scraper = new GameScraper();
            var queryExecutor = new GameQueryExecutor(client, scraper);

            return await queryExecutor.ExecuteAsync(queryDefinition);
        }
    }
}
