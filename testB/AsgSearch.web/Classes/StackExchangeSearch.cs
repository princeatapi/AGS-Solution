using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StackExchange.StacMan;
using System.Configuration;

namespace AsgSearch.web.Classes
{
    public class StackExchangeSearch : IStackExchangeSearch
    {
        StacManClient _client;

        public StackExchangeSearch()
        {
            _client = new StacManClient(ConfigurationManager.AppSettings["APIKey"], ConfigurationManager.AppSettings["APIVersion"]);
        }
        public StacManResponse<Question> Search(string strText)
        {
            var results = _client.Search.GetMatches(ConfigurationManager.AppSettings["SearchSite"], intitle: strText, filter: "withbody").Result;

            return results;
        }
    }
}