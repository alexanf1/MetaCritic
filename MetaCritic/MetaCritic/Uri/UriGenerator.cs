
using MetaCritic.Query;

namespace MetaCritic.Uri
{
    /// <inheritdoc />
    public class UriGenerator : IUriGenerator
    {
        private const string BASE_ADDRESS = "https://www.metacritic.com/browse/games/release-date";

        /// <inheritdoc />
        public Platform Platform { get; set; }

        /// <inheritdoc />
        public Category Category { get; set; }

        /// <inheritdoc />
        public Sort Sort { get; set; }

        /// <summary>
        /// Sets the properties to a default predefined state
        /// </summary>
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

        /// <inheritdoc />
        public System.Uri Generate()
        {
            return new System.Uri($"{BASE_ADDRESS}/{Category.Query}/{Platform.Query}/{Sort.Query}?view=detailed&page=0");
        }
    }
}
