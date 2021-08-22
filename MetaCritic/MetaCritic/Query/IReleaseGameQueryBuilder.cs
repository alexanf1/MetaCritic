
using MetaCritic.Model;

namespace MetaCritic.Query
{
    public interface IReleaseGameQueryBuilder<T> where T : IGame
    {
        IReleaseGameQueryBuilder<T> AllReleases();

        IReleaseGameQueryBuilder<T> ComingSoon();

        IReleaseGameQueryBuilder<T> NewReleases();

        IPlatformGameQueryBuilder<T> PS5();

        IPlatformGameQueryBuilder<T> PS4();

        IPlatformGameQueryBuilder<T> XboxSeriesX();

        IPlatformGameQueryBuilder<T> XboxOne();

        IPlatformGameQueryBuilder<T> Switch();

        IPlatformGameQueryBuilder<T> PC();

        IPlatformGameQueryBuilder<T> Stadia();
    }
}
