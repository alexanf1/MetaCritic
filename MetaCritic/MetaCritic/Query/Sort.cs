
namespace MetaCritic.Query
{
    public class Sort : Filter
    {
        public static readonly Sort ByDate = new Sort("ByDate", "date");
        public static readonly Sort ByMetaScore = new Sort("ByMetaScore", "metascore");
        public static readonly Sort ByName = new Sort("ByName", "name");

        private Sort(string name, string query) : base(name, query) { }
    }
}
