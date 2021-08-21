
using MetaCritic.Filters;

namespace MetaCritic.Query
{
    using Model;

    public class GameQueryDefinition<T> : IGameQueryDefinition<IGame> 
    {
        public PlatformFilter Platform { get; set; }
        public ReleaseFilter Category { get; set; }
        public SortFilter Sort { get; set; }
        public TimeFilter Time { get; set; }
    }
}
