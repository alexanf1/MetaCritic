
namespace MetaCritic.Query
{
    using Model;

    public class GameQueryDefinition<T> : IGameQueryDefinition<IGame> 
    {
        public GameQueryDefinition()
        {
            Platform = Platform.PC;
            Category = Category.AllReleases;
            Sort = Sort.ByMetaScore;
        }

        public Platform Platform { get; set; }
        public Category Category { get; set; }
        public Sort Sort { get; set; }
    }
}
