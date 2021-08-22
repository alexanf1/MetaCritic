
using MetaCritic.Filters;
using MetaCritic.Query;

namespace MetaCritic.Uri
{
    /// <summary>
    /// A set of extension methods for <see cref="UriGenerator"/>
    /// </summary>
    public static class IUriGeneratorExtensions
    {
        public static IUriGenerator ForCategory(this IUriGenerator uriGenerator, ReleaseFilter category)
        {
            uriGenerator.Release = category;

            return uriGenerator;
        }

        public static IUriGenerator SortBy(this IUriGenerator uriGenerator, SortFilter sort)
        {
            uriGenerator.Sort = sort;

            return uriGenerator;
        }

        public static IUriGenerator ForPlatform(this IUriGenerator uriGenerator, PlatformFilter platform)
        {
            uriGenerator.Platform = platform;

            return uriGenerator;
        }

        public static IUriGenerator ByTime(this IUriGenerator uriGenerator, TimeFilter time)
        {
            uriGenerator.Time= time;

            return uriGenerator;
        }

        public static IUriGenerator ByGenre(this IUriGenerator uriGenerator, GenreFilter genre)
        {
            uriGenerator.Genre = genre;

            return uriGenerator;
        }
    }
}

