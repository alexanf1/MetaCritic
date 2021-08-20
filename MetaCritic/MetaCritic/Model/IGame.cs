
namespace MetaCritic.Model
{
    using System;

    public interface IGame
    {
        string Name { get; }

        public string Platform { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public int? Score { get; set; }

        public string Description { get; set; }
    }
}
