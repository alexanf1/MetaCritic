
using MetaCritic.Exceptions;

namespace MetaCritic.Model
{
    using System;

    /// <inheritdoc />
    public class Game : IGame
    {
        public Game(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new MetaCriticInvalidGameException($"{typeof(Game)} could not be created!",
                    new ArgumentException("Name is required.", nameof(name)));
            }

            Name = name;
        }

        /// <inheritdoc />
        public string Name { get; }

        /// <inheritdoc />
        public string Platform { get; set; }

        /// <inheritdoc />
        public DateTime? ReleaseDate { get; set; }

        /// <inheritdoc />
        public int? Score { get; set; }

        /// <inheritdoc />
        public string Description { get; set; }
    }
}
