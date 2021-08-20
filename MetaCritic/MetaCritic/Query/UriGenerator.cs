
namespace MetaCritic.Query
{
    public class UriGenerator : IUriGenerator
    {
        public Platform Platform { get; set; }
        public Category Category { get; set; }
        public Sort Sort { get; set; }

        // Default selections
        public UriGenerator()
        {
            Platform = Platform.PC;
            Category = Category.AllReleases;
            Sort = Sort.ByMetaScore;
        }

        public static IUriGenerator Create()
        {
            return new UriGenerator();
        }

        public string Generate(string input)
        {
            return $"https://www.metacritic.com/browse/games/release-date/{Category.Query}/{Platform.Query}/{Sort.Query}?view=detailed&page=0";
        }
    }
}
