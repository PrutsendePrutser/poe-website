using Microsoft.Practices.Unity;
using poe_website.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace poe_website.Controllers
{
    public class PagefeedController : Controller
    {
		[Dependency]
		public IPageFeedService PageFeedService { get; set; }

        //
        // GET: /Pagefeed/
        public ActionResult Index()
        {
            return View();
        }

		public ActionResult RedditFeed()
		{
			var redditFeedModel = PageFeedService.GetRedditFeed();
			return PartialView(redditFeedModel);
		}
	}
}