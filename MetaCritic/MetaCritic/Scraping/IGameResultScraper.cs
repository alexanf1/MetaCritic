
namespace MetaCritic.Scraping
{
    using HtmlAgilityPack;

    /// <summary>
    /// A helper class for scraping game related data out of an <see cref="HtmlNode"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IGameResultScraper<out IGame>
    {
        /// <summary>
        /// Retrieves game related data from a <see cref="HtmlNode"/>.
        /// </summary>
        /// <param name="node">An Html Node</param>
        /// <returns>Returns game related data.</returns>
        IGame Scrape(HtmlNode node);
    }
}
