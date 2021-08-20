
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
            // todo: move into a factory...
            HttpClientWrapper client = new HttpClientWrapper();
            GameResultScraper resultScraper = new GameResultScraper();
            GameScraper scraper = new GameScraper(resultScraper);
            var queryExecutor = new GameQueryExecutor(client, scraper);

            return await queryExecutor.ExecuteAsync(queryDefinition);
        }
    }
}
