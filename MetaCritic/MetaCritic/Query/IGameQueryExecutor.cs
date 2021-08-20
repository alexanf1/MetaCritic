
namespace MetaCritic.Query
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Model;

    public interface IGameQueryExecutor<T> where T : IGame
    {
        Task<IEnumerable<T>> ExecuteAsync(IGameQueryDefinition<T> queryDefinition);
    }
}
