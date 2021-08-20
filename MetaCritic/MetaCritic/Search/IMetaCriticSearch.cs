using MetaCritic.Model;
using MetaCritic.Query;

namespace MetaCritic.Search
{
    public interface IMetaCriticSearch
    {
        IGameQueryBuilder<IGame> Games();
    }
}
