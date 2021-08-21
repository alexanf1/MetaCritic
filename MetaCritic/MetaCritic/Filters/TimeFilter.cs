
using MetaCritic.Query;

namespace MetaCritic.Filters
{
    public class TimeFilter : Filter
    {
        public static readonly TimeFilter Year = new TimeFilter("Year", "year");
        public static readonly TimeFilter AllTime = new TimeFilter("AllTime", "all");
        public static readonly TimeFilter Last90Days = new TimeFilter("Last90Days", "90day");

        private TimeFilter(string name, string query) : base(name, query) {}

        public int Value { get; set; }
    }
}
