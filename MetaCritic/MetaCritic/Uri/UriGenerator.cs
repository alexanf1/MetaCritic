
using MetaCritic.Filters;
using MetaCritic.Query;

namespace MetaCritic.Uri
{
    /// <inheritdoc />
    public class UriGenerator : IUriGenerator
    {
        private const string BASE_ADDRESS = "https://www.metacritic.com/browse/games/";
        private const string TIME_BASED_ADDRESS = BASE_ADDRESS + "score/metascore";
        private const string RELEASE_BASED_ADDRESS = BASE_ADDRESS + "release-date";

        private const string DEFAULT_ADDRESS = "https://www.metacritic.com/browse/games/score/metascore/all/all/filtered";

        /// <inheritdoc />
        public PlatformFilter Platform { get; set; }

        /// <inheritdoc />
        public ReleaseFilter Release { get; set; }

        /// <inheritdoc />
        public SortFilter Sort { get; set; }

        /// <inheritdoc />
        public TimeFilter Time { get; set; }

        public static IUriGenerator Create()
        {
            return new UriGenerator();
        }

        /// <inheritdoc />
        public System.Uri Generate()
        {
            if(Time != null && Time.Value != 0)
                return new System.Uri($"{TIME_BASED_ADDRESS}/{Time.Query}/{Platform.Query}/filtered?year_selected={Time.Value}&distribution=&sort=desc&view=detailed&page=0");
            
            if(Time != null)
                return new System.Uri($"{TIME_BASED_ADDRESS}/{Time.Query}/{Platform.Query}/filtered?sort=desc&view=detailed&page=0");

            if(Release != null)
                return new System.Uri($"{RELEASE_BASED_ADDRESS}/{Release.Query}/{Platform.Query}/{Sort.Query}?view=detailed&page=0"); 

            return new System.Uri(DEFAULT_ADDRESS);
        }
    }
}
