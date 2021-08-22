
using MetaCritic.Query;

namespace MetaCritic.Filters
{
    public class GenreFilter : Filter
    {
        public static readonly GenreFilter Action = new GenreFilter("Action", "action");
        public static readonly GenreFilter Adventure = new GenreFilter("Adventure", "adventure");
        public static readonly GenreFilter Fighting = new GenreFilter("Fighting", "fighting");
        public static readonly GenreFilter FirstPersonShooter = new GenreFilter("FirstPersonShooter", "first-person");
        public static readonly GenreFilter Flight = new GenreFilter("Flight", "flight");
        public static readonly GenreFilter Party = new GenreFilter("Party", "party");
        public static readonly GenreFilter Platformer = new GenreFilter("Platformer", "platformer");
        public static readonly GenreFilter Puzzle = new GenreFilter("Puzzle", "puzzle");
        public static readonly GenreFilter Racing = new GenreFilter("Racing", "racing");
        public static readonly GenreFilter RealTimeStrategy = new GenreFilter("RealTimeStrategy", "real-time");
        public static readonly GenreFilter RolePlaying = new GenreFilter("RolePlaying", "role-playing");
        public static readonly GenreFilter Simulation = new GenreFilter("Simulation", "simulation");
        public static readonly GenreFilter Sports = new GenreFilter("Sports", "sports");
        public static readonly GenreFilter Strategy = new GenreFilter("Strategy", "strategy");
        public static readonly GenreFilter ThirdPersonShooter = new GenreFilter("ThirdPersonShooter", "third-person");
        public static readonly GenreFilter TurnBasedStrategy = new GenreFilter("TurnBasedStrategy", "turn-based");
        public static readonly GenreFilter Wargames = new GenreFilter("Wargames", "wargame");
        public static readonly GenreFilter Wrestling = new GenreFilter("Wrestling", "wrestling");

        private GenreFilter(string name, string query) : base(name, query) { }
    }
}
