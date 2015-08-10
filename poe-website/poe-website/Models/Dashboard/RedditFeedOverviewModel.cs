using poe_website.Models.Pagefeed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace poe_website.Models.Dashboard
{
	public class RedditFeedOverviewModel
	{
		public String SearchDescription { get; set; }
		public IList<RedditFeedModel> RedditMessages { get; set; }

		public RedditFeedOverviewModel()
		{
			RedditMessages = new List<RedditFeedModel>();
		}
	}
}