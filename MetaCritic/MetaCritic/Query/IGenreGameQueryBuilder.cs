
using MetaCritic.Model;

namespace MetaCritic.Query
{
    public interface IGenreGameQueryBuilder<T> where T : IGame
    {
        IPlatformGameQueryBuilder<T> PS5();

        IPlatformGameQueryBuilder<T> PS4();

        IPlatformGameQueryBuilder<T> XboxSeriesX();

        IPlatformGameQueryBuilder<T> XboxOne();

        IPlatformGameQueryBuilder<T> Switch();

        IPlatformGameQueryBuilder<T> PC();

        IPlatformGameQueryBuilder<T> Stadia();

        IGenreGameQueryBuilder<T> Action();

        IGenreGameQueryBuilder<T> Adventure();

        IGenreGameQueryBuilder<T> Fighting();

        IGenreGameQueryBuilder<T> FirstPersonShooter();

        IGenreGameQueryBuilder<T> Flight();

        IGenreGameQueryBuilder<T> Party();

        IGenreGameQueryBuilder<T> Platformer();

        IGenreGameQueryBuilder<T> Puzzle();

        IGenreGameQueryBuilder<T> Racing();

        IGenreGameQueryBuilder<T> RealTimeStrategy();

        IGenreGameQueryBuilder<T> RolePlaying();

        IGenreGameQueryBuilder<T> Simulation();

        IGenreGameQueryBuilder<T> Sports();

        IGenreGameQueryBuilder<T> Strategy();

        IGenreGameQueryBuilder<T> ThirdPersonShooter();

        IGenreGameQueryBuilder<T> TurnBasedStrategy();

        IGenreGameQueryBuilder<T> Wargames();

        IGenreGameQueryBuilder<T> Wrestling();
    }
}
