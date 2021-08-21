
using MetaCritic.Model;

namespace MetaCritic.Query
{
    public interface IGameQueryBuilder<T> where T : IGame
    {
        ITimeGameQueryBuilder<T> ByYear(int year);

        ITimeGameQueryBuilder<T> AllTime();

        ITimeGameQueryBuilder<T> Last90Days();

        IReleaseGameQueryBuilder<T> AllReleases();
        
        IReleaseGameQueryBuilder<T> ComingSoon();

        IReleaseGameQueryBuilder<T> NewReleases();
    }
}
