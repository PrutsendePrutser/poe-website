using Microsoft.Practices.Unity;
using poe_website.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace poe_website.Controllers
{
    public class DashboardController : Controller
    {

		[Dependency]
		public IDashboardService DashboardService { get; set; }

        //
        // GET: /Dashboard/
		[HttpGet]
        public ActionResult Index()
        {
			var model = DashboardService.GetDashboard();
            return View(model);
        }
	}
}