using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AsgSearch.DAL;
using StackExchange.StacMan;

namespace AsgSearch.Services
{
    public class QueryService : IQueryService, IDisposable
    {
        private IDALContext context;

        public QueryService(IDALContext dal)
        {
            context = dal;
        }

        public List<Query> GetQueries()
        {
            return context.Queries.All().OrderByDescending(key=>key.Time).Take(5).ToList();
        }

        // HINT: For step 2 you'll need to add a new parameter so you can set a value for the
        // QueryResults collection in Query
        public Query SaveQuery(string queryText, DateTime time , ICollection<SearchResult> searchResults)
        {
            var q =
                new Query()
                    {
                        QueryText = queryText,
                        Time = time,
                        SearchResults = searchResults

                    };

            context.Queries.Create(q);
            context.SaveChanges();
            return q;
        }

        public void Dispose()
        {
            if (context != null)
                context.Dispose();
        }
    }
}