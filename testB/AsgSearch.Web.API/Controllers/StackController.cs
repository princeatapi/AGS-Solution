using AsgSearch.DAL;
using AsgSearch.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using StackExchange.StacMan;
using System.Web.Http.Cors;


namespace AsgSearch.Web.API.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")] // Enabled corss origin sharing just to test the functionality
    public class StackController : ApiController
    {

        IStackExchangeSearch search;
        IQueryService qService;

        public StackController()
        {
            search = new StackExchangeSearch();
            qService = new QueryService(new DAL.DALContext());
        }

        // GET api/stack
        public IEnumerable<Query> Get()
        {
            return qService.GetQueries(); ;
        }

        // GET api/stack/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/stack
        public void Post([FromBody]Query value)
        {
            qService.SaveQuery(value.QueryText, value.Time, value.SearchResults);
        }

        // PUT api/stack/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/stack/5
        public void Delete(int id)
        {
        }

        [HttpGet]
        public IEnumerable<SearchResult> Search(string searchKey)
        {

            var p = search.Search(searchKey);
            List<SearchResult> results = new List<SearchResult>();

            for (int i = 0; i < p.Data.Items.Length; i++)
            {
                results.Add(new SearchResult
                {
                    Title = p.Data.Items[i].Title,
                    Avatar = p.Data.Items[i].Owner.ProfileImage,
                    OwnerName = p.Data.Items[i].Owner.DisplayName,
                    Tags = p.Data.Items[i].Tags != null ? String.Join(",", p.Data.Items[i].Tags.Select(key => "'" + key + "'")).ToString() : string.Empty,
                    AcceptedAnsId = p.Data.Items[i].AcceptedAnswerId,
                    DateCreated = p.Data.Items[i].CreationDate

                });
            }
            qService.SaveQuery(searchKey, System.DateTime.Now, results);
            return results;
        }
    }
}
