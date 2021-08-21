
namespace MetaCritic.Scraping
{
    using System.Collections.Generic;
    using Model;
    using HtmlAgilityPack;

    /// <summary>
    /// Defines a helper class responsible for scrapping game related data from a <see cref="HtmlDocument"/>
    /// </summary>
    public interface IGameScraper
    {
        /// <summary>
        /// Retrieves game related data from a string that conforms to <see cref="HtmlDocument"/>.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="content"></param>
        /// <returns>A <see cref="IEnumerable{T}"/> collection of type T objects</returns>
        IEnumerable<T> Scrape<T>(string content) where T : IGame;
    }
}
