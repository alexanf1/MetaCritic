using System;
using System.Collections.Generic;
using System.Text;

namespace MetaCritic.Query
{
    public abstract class Filter : IFilter
    {
        protected Filter(string name, string query)
        {
            Name = name;
            Query = query;
        }
        public string Name { get; }
        public string Query { get; }
    }
}
