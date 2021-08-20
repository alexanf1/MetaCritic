
namespace MetaCritic.Query
{
    public class Platform : Filter
    {
        public static readonly Platform PS5 = new Platform("PS5", "ps5");
        public static readonly Platform PS4 = new Platform("PS4", "ps4");
        public static readonly Platform XboxSeriesX = new Platform("XboxSeriesX", "xbox-series-x");
        public static readonly Platform XboxOne = new Platform("XboxOne", "xboxone");
        public static readonly Platform Switch = new Platform("Switch", "switch");
        public static readonly Platform PC = new Platform("PC", "pc");
        public static readonly Platform Stadia = new Platform("Stadia", "stadia");

        private Platform(string name, string query) : base(name, query) { }
    }
}
