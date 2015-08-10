using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace poe_website.Models.Pagefeed
{
	public class RedditFeedModel
	{
		public int Rating { get; set; }
		public string UserName { get; set; }
		public string MessageContent { get; set; }
		public string PermaUrl { get; set; }
	}
}