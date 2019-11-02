using Advisor.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Advisor.Controllers
{
    public class ApiController : Controller
    {
        [HttpGet]
        [Route("api/items")]
        public string Index()
        {
            List<University> unis = DB.Instance.Universities.ToList();
            string json = JsonConvert.SerializeObject(unis, Formatting.Indented);

            return json;
        }
    }
}
