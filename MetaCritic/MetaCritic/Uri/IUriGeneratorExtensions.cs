﻿
using MetaCritic.Query;

namespace MetaCritic.Uri
{
    /// <summary>
    /// A set of extension methods for <see cref="UriGenerator"/>
    /// </summary>
    public static class IUriGeneratorExtensions
    {
        public static IUriGenerator ForCategory(this IUriGenerator uriGenerator, Category category)
        {
            uriGenerator.Category = category;

            return uriGenerator;
        }

        public static IUriGenerator SortBy(this IUriGenerator uriGenerator, Sort sort)
        {
            uriGenerator.Sort = sort;

            return uriGenerator;
        }

        public static IUriGenerator ForPlatform(this IUriGenerator uriGenerator, Platform platform)
        {
            uriGenerator.Platform = platform;

            return uriGenerator;
        }
    }
}