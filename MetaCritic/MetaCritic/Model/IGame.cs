
namespace MetaCritic.Model
{
    using System;

    /// <summary>
    /// An object representing a video game.
    /// </summary>
    public interface IGame
    {
        /// <summary>
        /// The name of the game.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// The specified platform for the game.
        /// </summary>
        public string Platform { get; set; }

        /// <summary>
        /// The release date of the game.
        /// </summary>
        public DateTime ReleaseDate { get; set; }

        /// <summary>
        /// The aggregate reviewers score of the game.
        /// </summary>
        public int Score { get; set; }

        /// <summary>
        /// The general description of the game.
        /// </summary>
        public string Description { get; set; }
    }
}
