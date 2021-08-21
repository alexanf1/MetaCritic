
using System;
using MetaCritic.Exceptions;

namespace MetaCritic.Scraping
{
    using System.Collections.Generic;
    using HtmlAgilityPack;
    using Model;
    using System.Linq;

    /// <inheritdoc />
    public class GameScraper : IGameScraper
    {
        private readonly IGameResultScraper<IGame> m_scraper;

        public GameScraper(IGameResultScraper<IGame> scraper)
        {
            m_scraper = scraper;
        }

        /// <inheritdoc />
        public IEnumerable<T> Scrape<T>(string content) where T : IGame
        {
            if (string.IsNullOrWhiteSpace(content))
                throw new MetaCriticInvalidDocument($"An invalid {nameof(content)} was provided");

            HtmlDocument document = new HtmlDocument();

            try
            {
                document.LoadHtml(content);
            }
            catch (Exception e)
            {
                throw new MetaCriticInvalidDocument($"{nameof(content)} failed to load", e);
            }

            var searchResults = document.DocumentNode.SelectNodes("//table[@class=\"clamp-list\"]/tr");
            var entities = ScrapeSearchResults(searchResults);

            return entities.OfType<T>();
        }

        private IEnumerable<IGame> ScrapeSearchResults(IEnumerable<HtmlNode> searchResults)
        {
            if (searchResults == null)
                yield break;

            foreach (var searchResult in searchResults)
            {
                var resultType = GetResultType(searchResult);
                if (string.IsNullOrWhiteSpace(resultType))
                    continue;

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
