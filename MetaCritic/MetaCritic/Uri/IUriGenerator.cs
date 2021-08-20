
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
        Platform Platform { get; set; }

        /// <summary>
        /// Represents the specified category (e.g. AllReleases, NewReleases, etc) for the generated <see cref="Uri"/>
        /// </summary>
        Category Category { get; set; }

        /// <summary>
        /// Represents the specified sorting (e.g. by score, data, etc) for the generated <see cref="Uri"/>
        /// </summary>
        Sort Sort { get; set; }

        /// <summary>
        /// Generates a <see cref="Uri"/> based instance defined properties. 
        /// </summary>
        /// <returns>A generated <typeparamref name="Uri"/></returns>
        Uri Generate();
    }
}
