
using System.Collections.Generic;
using System.Threading.Tasks;
using MetaCritic.Model;

namespace MetaCritic.Query
{
    public interface IGameQueryBuilder<T> where T : IGame
    {
        Task<IEnumerable<IGame>> GetAsync();

        IGameQueryBuilder<T> AllReleases();

        IGameQueryBuilder<T> ComingSoon();

        IGameQueryBuilder<T> NewReleases();

        IGameQueryBuilder<T> PS5();

        IGameQueryBuilder<T> PS4();

        IGameQueryBuilder<T> XboxSeriesX();

        IGameQueryBuilder<T> XboxOne();

        IGameQueryBuilder<T> Switch();

        IGameQueryBuilder<T> PC();

        IGameQueryBuilder<T> Stadia();

        IGameQueryBuilder<T> ByDate();

        IGameQueryBuilder<T> ByMetaScore();

        IGameQueryBuilder<T> ByName();
    }
}
