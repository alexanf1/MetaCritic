
using MetaCritic.Filters;
using MetaCritic.Query;

namespace MetaCritic.Uri
{
    using System;

    /// <summary>
    /// Defines an object representing specific properties that will determine a generated a <see cref="Uri"/>
    /// </summary>
    public interface IUriGenerator
    {
        /// <summary>
        /// Represents the specified platform for the generated <see cref="Uri"/>
        /// </summary>
        PlatformFilter Platform { get; set; }

        /// <summary>
        /// Represents the specified release timing (e.g. AllReleases, NewReleases, etc) for the generated <see cref="Uri"/>
        /// </summary>
        ReleaseFilter Release { get; set; }

        /// <summary>
        /// Represents the specified sorting (e.g. by score, data, etc) for the generated <see cref="Uri"/>
        /// </summary>
        SortFilter Sort { get; set; }

        /// <summary>
        /// Represents the specified timing (e.g. by year, all time, etc) for the generated <see cref="Uri"/>
        /// </summary>
        TimeFilter Time { get; set; }

        /// <summary>
        /// Represents the selected genre (e.g. by action, adventure, shooter, etc) for the generated <see cref="Uri"/>
        /// </summary>
        GenreFilter Genre { get; set; }

        /// <summary>
        /// Generates a <see cref="Uri"/> based instance defined properties. 
        /// </summary>
        /// <returns>A generated <typeparamref name="Uri"/></returns>
        Uri Generate();
    }
}
