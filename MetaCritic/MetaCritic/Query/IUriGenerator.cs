
namespace MetaCritic.Query
{
    public interface IUriGenerator
    {
        Platform Platform { get; set; }
        
        Category Category { get; set; }
        
        Sort Sort { get; set; }

        string Generate(string input);
    }
}
