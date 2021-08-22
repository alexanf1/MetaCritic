
namespace MetaCritic.Query
{
    public class ReleaseFilter : Filter
    {
        public static readonly ReleaseFilter AllReleases = new ReleaseFilter("AllReleases", "available");
        public static readonly ReleaseFilter NewReleases = new ReleaseFilter("NewReleases", "new-releases");
        public static readonly ReleaseFilter ComingSoon = new ReleaseFilter("ComingSoon", "coming-soon");

        private ReleaseFilter(string name, string query) : base(name, query) {}
    }
}
