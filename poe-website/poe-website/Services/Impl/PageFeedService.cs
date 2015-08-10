using poe_website.Models.Dashboard;
using poe_website.Models.Pagefeed;
using RedditSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace poe_website.Services.Impl
{
	public class PageFeedService : IPageFeedService
	{
		public RedditFeedOverviewModel GetRedditFeed()
		{
			var model = new RedditFeedOverviewModel { SearchDescription = "Top rated reddit messages"};
			model.RedditMessages = RedditMessages();
			return model;
		}

		private IList<RedditFeedModel> RedditMessages()
		{
			var messages = new List<RedditFeedModel>();
			var reddit = new Reddit();
			var poeReddit = reddit.GetSubreddit("/r/pathofexile");
			var feed = poeReddit.Hot.Take(25).OrderByDescending(x => x.Score);
			foreach (var item in feed)
			{
				messages.Add(new RedditFeedModel {Rating = item.Score, UserName = item.Author.Name, MessageContent = item.Title, PermaUrl = item.Permalink.IsAbsoluteUri ? item.Permalink.AbsoluteUri : "http://www.reddit.com" + item.Permalink.OriginalString });
			}
			return messages;
		}
	}
}