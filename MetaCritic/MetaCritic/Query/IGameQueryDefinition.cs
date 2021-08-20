
namespace MetaCritic.Query
{
    using Model;

    public interface IGameQueryDefinition<out T> where T : IGame
    {
        public Platform Platform { get; set; }
        public Category Category { get; set; }
        public Sort Sort { get; set; }
    }
}
