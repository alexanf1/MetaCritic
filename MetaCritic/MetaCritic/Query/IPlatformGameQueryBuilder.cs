
using System.Collections.Generic;
using System.Threading.Tasks;
using MetaCritic.Model;

namespace MetaCritic.Query
{
    public interface IPlatformGameQueryBuilder<T> where T : IGame
    {
        Task<IEnumerable<IGame>> GetAsync();

        IPlatformGameQueryBuilder<T> PS5();

        IPlatformGameQueryBuilder<T> PS4();

        IPlatformGameQueryBuilder<T> XboxSeriesX();

        IPlatformGameQueryBuilder<T> XboxOne();

        IPlatformGameQueryBuilder<T> Switch();

        IPlatformGameQueryBuilder<T> PC();

        IPlatformGameQueryBuilder<T> Stadia();

        ISortGameQueryBuilder<T> ByDate();

        ISortGameQueryBuilder<T> ByMetaScore();

        ISortGameQueryBuilder<T> ByName();
    }
}
