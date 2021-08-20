using MetaCritic.Model;
using MetaCritic.Query;

namespace MetaCritic.Search
{
    public class MetaCriticSearch : IMetaCriticSearch
    {
        public IGameQueryBuilder<IGame> Games()
        {
            return CreateQueryBuilder<IGame>();
        }

        private IGameQueryBuilder<T> CreateQueryBuilder<T>() where T : IGame
        {
            var gameQueryDefinition = new GameQueryDefinition<T>();
            return new GameQueryBuilder<T>(gameQueryDefinition);
        }
    }
}
