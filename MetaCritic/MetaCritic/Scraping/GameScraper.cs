
namespace MetaCritic.Scraping
{
    using System.Collections.Generic;
    using HtmlAgilityPack;
    using Model;
    using System.Linq;

    public class GameScraper : IGameScraper
    {
        private static readonly IGameResultScraper<IGame> m_scraper = new GameResultScraper();

        public IEnumerable<T> Scrape<T>(string content) where T : IGame
        {
            if (string.IsNullOrWhiteSpace(content))
            {
                return Enumerable.Empty<T>();
            }

            HtmlDocument document = new HtmlDocument();
            document.LoadHtml(content);

            var searchResults = document.DocumentNode.SelectNodes("//table[@class=\"clamp-list\"]/tr");
            var entities = ScrapeSearchResults(searchResults);

            return entities.OfType<T>();
        }

        private IEnumerable<IGame> ScrapeSearchResults(IEnumerable<HtmlNode> searchResults)
        {
            if (searchResults == null)
            {
                yield break;
            }

            foreach (var searchResult in searchResults)
            {
                var resultType = GetResultType(searchResult);
                if (string.IsNullOrWhiteSpace(resultType))
                {
                    continue;
                }

                var game = m_scraper.Scrape(searchResult);

                yield return game;
            }
        }

        private string GetResultType(HtmlNode searchResult)
        {
            return searchResult?.InnerText;
        }
    }
}
