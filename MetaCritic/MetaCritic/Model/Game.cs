
namespace MetaCritic.Model
{
    using System;

    public class Game : IGame
    {
        public Game(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name is required.", nameof(name));
            }

            Name = name;
        }

        public string Name { get; }

        public string Platform { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public int? Score { get; set; }

        public string Description { get; set; }
    }
}
