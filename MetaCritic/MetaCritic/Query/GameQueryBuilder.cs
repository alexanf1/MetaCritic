using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MetaCritic.Filters;
using MetaCritic.Http;
using MetaCritic.Model;
using MetaCritic.Scraping;

namespace MetaCritic.Query
{
    public class GameQueryBuilder<T> : IGameQueryBuilder<T>, ITimeGameQueryBuilder<T>,
        IPlatformGameQueryBuilder<T>, ISortGameQueryBuilder<T>, IReleaseGameQueryBuilder<T> where T : IGame
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

        #region Time Based Filters
        public ITimeGameQueryBuilder<T> ByYear(int year)
        {
            m_queryDefinition.Time = TimeFilter.Year;
            m_queryDefinition.Time.Value = year;

            return this;
        }
        public ITimeGameQueryBuilder<T> AllTime()
        {
            m_queryDefinition.Time = TimeFilter.AllTime;

            return this;
        }

        public ITimeGameQueryBuilder<T> Last90Days()
        {
            m_queryDefinition.Time = TimeFilter.Last90Days;

            return this;
        }
        #endregion

        #region Release Based Filters
        public IReleaseGameQueryBuilder<T> AllReleases()
        {
            m_queryDefinition.Category = ReleaseFilter.AllReleases;

            return this;
        }
        public IReleaseGameQueryBuilder<T> ComingSoon()
        {
            m_queryDefinition.Category = ReleaseFilter.ComingSoon;

            return this;
        }

        public IReleaseGameQueryBuilder<T> NewReleases()
        {
            m_queryDefinition.Category = ReleaseFilter.NewReleases;

            return this;
        }
        #endregion

        #region Platform Based Filters
        public IPlatformGameQueryBuilder<T> PS5()
        {
            m_queryDefinition.Platform = PlatformFilter.PS5;

            return this;
        }
        public IPlatformGameQueryBuilder<T> PS4()
        {
            m_queryDefinition.Platform = PlatformFilter.PS4;

            return this;
        }
        public IPlatformGameQueryBuilder<T> XboxSeriesX()
        {
            m_queryDefinition.Platform = PlatformFilter.XboxSeriesX;

            return this;
        }
        public IPlatformGameQueryBuilder<T> XboxOne()
        {
            m_queryDefinition.Platform = PlatformFilter.XboxOne;

            return this;
        }
        public IPlatformGameQueryBuilder<T> Switch()
        {
            m_queryDefinition.Platform = PlatformFilter.Switch;

            return this;
        }
        public IPlatformGameQueryBuilder<T> PC()
        {
            m_queryDefinition.Platform = PlatformFilter.PC;

            return this;
        }
        public IPlatformGameQueryBuilder<T> Stadia()
        {
            m_queryDefinition.Platform = PlatformFilter.Stadia;

            return this;
        }
        #endregion

        #region Sort Based Filters
        public ISortGameQueryBuilder<T> ByDate()
        {
            m_queryDefinition.Sort = SortFilter.ByDate;

            return this;
        }
        public ISortGameQueryBuilder<T> ByMetaScore()
        {
            m_queryDefinition.Sort = SortFilter.ByMetaScore;

            return this;
        }
        public ISortGameQueryBuilder<T> ByName()
        {
            m_queryDefinition.Sort = SortFilter.ByName;

            return this;
        }
        #endregion
    }
}
