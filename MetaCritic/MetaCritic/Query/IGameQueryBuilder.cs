
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
