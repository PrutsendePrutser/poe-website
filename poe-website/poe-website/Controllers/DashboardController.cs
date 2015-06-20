using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace poe_website.Controllers
{
    public class DashboardController : Controller
    {
        //
        // GET: /Dashboard/
		[HttpGet]
        public ActionResult Index()
        {
            return View();
        }
	}
}