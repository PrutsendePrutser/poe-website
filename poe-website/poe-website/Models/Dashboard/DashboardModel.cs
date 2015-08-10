using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace poe_website.Models.Dashboard
{
	public class DashboardModel
	{
		public CharacterOverviewModel CharacterOverview { get; set; }
		public RedditFeedOverviewModel RedditOverView { get; set; }
	}
}