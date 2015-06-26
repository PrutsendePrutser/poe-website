using poe_website.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace poe_website.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/
        public ActionResult Login()
        {
            return View();
        }

		[HttpGet]
		public ActionResult Create()
		{
			var model = new RegisterModel();
			return PartialView(model);
		}
	}
}