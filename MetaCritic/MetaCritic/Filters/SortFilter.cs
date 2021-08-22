
namespace MetaCritic.Query
{
    public class SortFilter : Filter
    {
        public static readonly SortFilter ByDate = new SortFilter("ByDate", "date");
        public static readonly SortFilter ByMetaScore = new SortFilter("ByMetaScore", "metascore");
        public static readonly SortFilter ByName = new SortFilter("ByName", "name");

        private SortFilter(string name, string query) : base(name, query) { }
    }
}
