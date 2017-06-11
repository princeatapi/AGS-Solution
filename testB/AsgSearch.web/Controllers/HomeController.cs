using AsgSearch.web.Classes;
using System.Web.Mvc;
using StackExchange.StacMan;
using System.Collections;
using AsgSearch.DAL;
using System.Collections.Generic;
using System;
using System.Linq;

namespace AsgSearch.web.Controllers
{
    public class HomeController : Controller
    {
        IStackExchangeSearch search;
        QueryService qService;

        public HomeController()
        {
            search = new StackExchangeSearch();
            //qService = new QueryService(new DAL.DALContext());
            qService = null;
        }
        public ActionResult Index()
        {
            ViewBag.Title = "Home";

            return View();
        }
        public ActionResult Step1()
        {
            ViewBag.Title = "Step 1";

            return View();
        }
        public ActionResult Step2()
        {
            ViewBag.Title = "Step 2";

            return View();
        }
        public ActionResult Step3()
        {
            ViewBag.Title = "Step 3";

            return View();
        }

        //public ActionResult Search(string searchKey)
        //{
        //    var p = search.Search(searchKey);
        //    List<SearchResult> results = new List<SearchResult>();

        //    for (int i = 0; i < p.Data.Items.Length; i++)
        //    {
        //        results.Add(new SearchResult
        //        {
        //            Title = p.Data.Items[i].Title,
        //            Avatar = p.Data.Items[i].Owner.ProfileImage,
        //            OwnerName = p.Data.Items[i].Owner.DisplayName,
        //            Tags = p.Data.Items[i].Tags != null ? String.Join(",", p.Data.Items[i].Tags.Select(key => "'" + key + "'")).ToString() : string.Empty,
        //            AcceptedAnsId = p.Data.Items[i].AcceptedAnswerId,
        //            DateCreated = p.Data.Items[i].CreationDate

        //        });
        //    }
        //    qService.SaveQuery(searchKey, System.DateTime.Now, results);
        //    return View("_List", p.Data.Items);
        //}

        //public ActionResult ListQuery()
        //{
        //    var Quries = qService.GetQueries();
        //    return View("_QueryList", Quries);
        //}
    }
}
