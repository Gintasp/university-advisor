using System;
using System.Linq;
using System.Web.Mvc;
using Advisor.Models;

namespace Advisor.Controllers
{
    public class SearchController : Controller
    {
        [HttpPost]
        [Route("search/{searchString}", Name = "search_page")]
        public ActionResult Index(string searchString)
        {
            var unis = from u in DB.Instance.Universities
                       select u;

            if (!String.IsNullOrEmpty(searchString))
            {
                unis = unis.Where(s => s.Title.Contains(searchString));
            }

            ViewBag.Universities = unis.ToList();
            ViewBag.SearchPhrase = searchString;

            return View("/Views/Advisor/Search.cshtml");
        }

        public ActionResult SearchResult(string searchString)
        {
            return Index(searchString);
        }
    }
}