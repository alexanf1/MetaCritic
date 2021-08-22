
using MetaCritic.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MetaCritic.Query
{
    public interface ISortGameQueryBuilder<T> where T : IGame
    {
        Task<IEnumerable<IGame>> GetAsync();

        ISortGameQueryBuilder<T> ByDate();

        ISortGameQueryBuilder<T> ByMetaScore();

        ISortGameQueryBuilder<T> ByName();
    }
}
