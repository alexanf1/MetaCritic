using System;
using System.Collections.Generic;
using System.Text;

namespace MetaCritic.Query
{
    public interface IFilter
    {
        public string Name { get; }
        public string Query { get; }
    }
}
