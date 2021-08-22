
using MetaCritic.Filters;

namespace MetaCritic.Query
{
    using Model;

    public interface IGameQueryDefinition<out T> where T : IGame
    {
        public PlatformFilter Platform { get; set; }
        public ReleaseFilter Category { get; set; }
        public SortFilter Sort { get; set; }
        public TimeFilter Time { get; set; }
        public GenreFilter Genre { get; set; }
    }
}
