using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MetaCritic.Model;

namespace MetaCritic.Test.ConsoleApplication
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var games = await MetaCritic.SearchFor().Games().PC().AllReleases().ByMetaScore().GetAsync();
            Output("GAMES", games.ToList());
        }

        private static void Output(string description, IEnumerable<IGame> entities)
        {
            var heading = string.Format("{0} ({1} entities returned)", description, entities.Count());
            Console.WriteLine(heading);
            Console.WriteLine(new string('=', heading.Length));

            foreach (var entity in entities)
            {
                Console.WriteLine("Name: {0}, Score: {1}", entity.Name, entity.Score);
            }

            Console.WriteLine();
        }
    }
}
