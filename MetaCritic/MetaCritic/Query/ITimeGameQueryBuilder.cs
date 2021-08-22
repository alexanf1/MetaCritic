
using MetaCritic.Model;

namespace MetaCritic.Query
{
    public interface ITimeGameQueryBuilder<T> where T : IGame
    {
        ITimeGameQueryBuilder<T> ByYear(int year);

        ITimeGameQueryBuilder<T> AllTime();

        ITimeGameQueryBuilder<T> Last90Days();

        IPlatformGameQueryBuilder<T> PS5();

        IPlatformGameQueryBuilder<T> PS4();

        IPlatformGameQueryBuilder<T> XboxSeriesX();

        IPlatformGameQueryBuilder<T> XboxOne();

        IPlatformGameQueryBuilder<T> Switch();

        IPlatformGameQueryBuilder<T> PC();

        IPlatformGameQueryBuilder<T> Stadia();
    }
}
