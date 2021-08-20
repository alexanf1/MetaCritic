
namespace MetaCritic.Query
{
    using Http;
    using Scraping;
    using System;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using Model;

    public class GameQueryExecutor : IGameQueryExecutor<IGame>
    {
        private readonly IHttpClientWrapper m_httpClient;
        private readonly IGameScraper m_searchScraper;

        public GameQueryExecutor(IHttpClientWrapper httpClient, IGameScraper scraper)
        {
            m_httpClient = httpClient;
            m_searchScraper = scraper;
        }

        public async Task<IEnumerable<IGame>> ExecuteAsync(IGameQueryDefinition<IGame> queryDefinition)
        {
            var content = await GetSearchPageContent(queryDefinition);
            var entities = m_searchScraper.Scrape<IGame>(content);

            return entities;
        }

        private async Task<string> GetSearchPageContent(IGameQueryDefinition<IGame> queryDefinition)
        {
            var uri = GetSearchUri(queryDefinition);

            try
            {
                return await m_httpClient.GetContentAsync(uri);
            }
            catch (Exception ex)
            {
                throw new Exception("Unable to perform search.", ex);
            }
        }

        private string GetSearchUri(IGameQueryDefinition<IGame> queryDefinition)
        {
            return UriGenerator.Create()
                .ForCategory(queryDefinition.Category)
                .ForPlatform(queryDefinition.Platform)
                .SortBy(queryDefinition.Sort)
                .Generate("test");
        }
    }
}
