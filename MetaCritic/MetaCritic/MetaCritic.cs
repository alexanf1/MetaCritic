
using MetaCritic.Search;

namespace MetaCritic
{
    public class MetaCritic
    {
        public static IMetaCriticSearch SearchFor()
        {
            return new MetaCriticSearch();
        }
    }
}
