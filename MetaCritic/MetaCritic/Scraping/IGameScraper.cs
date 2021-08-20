
namespace MetaCritic.Scraping
{
    using System.Collections.Generic;
    using Model;

    public interface IGameScraper
    {
        IEnumerable<T> Scrape<T>(string content) where T : IGame;
    }
}
