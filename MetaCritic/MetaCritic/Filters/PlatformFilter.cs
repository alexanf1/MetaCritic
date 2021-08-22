
namespace MetaCritic.Query
{
    public class PlatformFilter : Filter
    {
        public static readonly PlatformFilter PS5 = new PlatformFilter("PS5", "ps5");
        public static readonly PlatformFilter PS4 = new PlatformFilter("PS4", "ps4");
        public static readonly PlatformFilter XboxSeriesX = new PlatformFilter("XboxSeriesX", "xbox-series-x");
        public static readonly PlatformFilter XboxOne = new PlatformFilter("XboxOne", "xboxone");
        public static readonly PlatformFilter Switch = new PlatformFilter("Switch", "switch");
        public static readonly PlatformFilter PC = new PlatformFilter("PC", "pc");
        public static readonly PlatformFilter Stadia = new PlatformFilter("Stadia", "stadia");

        private PlatformFilter(string name, string query) : base(name, query) { }
    }
}
