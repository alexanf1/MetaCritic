
namespace MetaCritic.Query
{
    public class Category : Filter
    {
        public static readonly Category AllReleases = new Category("AllReleases", "available");
        public static readonly Category NewReleases = new Category("NewReleases", "new-releases");
        public static readonly Category ComingSoon = new Category("ComingSoon", "coming-soon");

        private Category(string name, string query) : base(name, query) {}
    }
}
