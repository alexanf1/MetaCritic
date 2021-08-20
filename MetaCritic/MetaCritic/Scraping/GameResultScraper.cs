
namespace MetaCritic.Scraping
{
    using HtmlAgilityPack;
    using Model;
    using System;

    /// <inheritdoc />
    public class GameResultScraper : IGameResultScraper<IGame>
    {
        /// <inheritdoc />
        public IGame Scrape(HtmlNode node)
        {
            var name = ReadName(node);
            var game = new Game(name)
            {
                ReleaseDate = ReadReleaseDate(node),
                Description = ReadDescription(node),
                Platform = ReadPlatform(node),
                Score = ReadScore(node)
            };

            return game;
        }

        private string ReadValue(HtmlNode node, string path)
        {
            if (node == null) 
                return null;

            var result = node.SelectSingleNode(path);

            return result == null ? null : HtmlEntity.DeEntitize(result.InnerText.Trim());
        }

        private string ReadName(HtmlNode node)
        {
            return ReadValue(node, "./td[@class=\"clamp-summary-wrap\"]/a/h3");
        }

        private string ReadDescription(HtmlNode node)
        {
            return ReadValue(node, "./td[@class=\"clamp-summary-wrap\"]/div[@class=\"summary\"]");
        }

        private string ReadPlatform(HtmlNode node)
        {
            return ReadValue(node, "./td[@class=\"clamp-summary-wrap\"]/div[@class=\"clamp-details\"]/div[@class=\"platform\"]/span[@class=\"data\"]");
        }

        private int ReadScore(HtmlNode node)
        {
            var score = ReadValue(node, "./td[@class=\"clamp-summary-wrap\"]/div[@class=\"clamp-score-wrap\"]/a[@class=\"metascore_anchor\"]/div");
            
            int.TryParse(score, out var result);
            
            return result;
        }

        private DateTime ReadReleaseDate(HtmlNode node)
        {
            var releaseDate = ReadValue(node, "./td[@class=\"clamp-summary-wrap\"]/div[@class=\"clamp-details\"]/span");

            // 'date' is set to DateTime.MinValue if 'releaseDate' cannot be parsed.
            DateTime.TryParse(releaseDate, out var date);

            return date;
        }
    }
}
