
using MetaCritic.Model;

namespace MetaCritic.Scraping
{
    using HtmlAgilityPack;

    /// <summary>
    /// Defines a helper class responsible for scrapping game related data out of a <see cref="HtmlNode"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IGameResultScraper<out T> where T : IGame
    {
        /// <summary>
        /// Retrieves game related data from a <see cref="HtmlNode"/>.
        /// </summary>
        /// <param name="node">An Html Node</param>
        /// <returns>Returns an object of type <typeparamref name="T"/>.</returns>
        T Scrape(HtmlNode node);
    }
}
