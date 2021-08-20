
namespace MetaCritic.Scraping
{
    using HtmlAgilityPack;

    public interface IGameResultScraper<out IGame>
    {
        IGame Scrape(HtmlNode node);
    }
}
