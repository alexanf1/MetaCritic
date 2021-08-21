using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MetaCritic.Http;
using MetaCritic.Model;
using MetaCritic.Scraping;

namespace MetaCritic.Query
{
    public class GameQueryBuilder<T> : IGameQueryBuilder<T> where T : IGame
    {
        private readonly IGameQueryDefinition<IGame> m_queryDefinition;
        
        public GameQueryBuilder(IGameQueryDefinition<IGame> queryDefinition)
        {
            m_queryDefinition = queryDefinition;
        }

        public async Task<IEnumerable<IGame>> GetAsync()
        {
            // todo: move into a factory...
            HttpClientWrapper client = new HttpClientWrapper();
            GameResultScraper resultScraper = new GameResultScraper();
            GameScraper scraper = new GameScraper(resultScraper);
            var queryExecutor = new GameQueryExecutor(client, scraper);

            return await queryExecutor.ExecuteAsync(m_queryDefinition);
        }

        #region Availability
        public IGameQueryBuilder<T> AllReleases()
        {
            m_queryDefinition.Category = Category.AllReleases;

            return this;
        }
        public IGameQueryBuilder<T> ComingSoon()
        {
            m_queryDefinition.Category = Category.ComingSoon;

            return this;
        }

        public IGameQueryBuilder<T> NewReleases()
        {
            m_queryDefinition.Category = Category.NewReleases;

            return this;
        }
        #endregion

        #region Platform
        public IGameQueryBuilder<T> PS5()
        {
            m_queryDefinition.Platform = Platform.PS5;

            return this;
        }
        public IGameQueryBuilder<T> PS4()
        {
            m_queryDefinition.Platform = Platform.PS4;

            return this;
        }
        public IGameQueryBuilder<T> XboxSeriesX()
        {
            m_queryDefinition.Platform = Platform.XboxSeriesX;

            return this;
        }
        public IGameQueryBuilder<T> XboxOne()
        {
            m_queryDefinition.Platform = Platform.XboxOne;

            return this;
        }
        public IGameQueryBuilder<T> Switch()
        {
            m_queryDefinition.Platform = Platform.Switch;

            return this;
        }
        public IGameQueryBuilder<T> PC()
        {
            m_queryDefinition.Platform = Platform.PC;

            return this;
        }
        public IGameQueryBuilder<T> Stadia()
        {
            m_queryDefinition.Platform = Platform.Stadia;

            return this;
        }
        #endregion

        #region Sort
        public IGameQueryBuilder<T> ByDate()
        {
            m_queryDefinition.Sort = Sort.ByDate;

            return this;
        }
        public IGameQueryBuilder<T> ByMetaScore()
        {
            m_queryDefinition.Sort = Sort.ByMetaScore;

            return this;
        }
        public IGameQueryBuilder<T> ByName()
        {
            m_queryDefinition.Sort = Sort.ByName;

            return this;
        }
        #endregion
    }
}
