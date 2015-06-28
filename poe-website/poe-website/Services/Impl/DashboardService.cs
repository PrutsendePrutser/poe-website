using Microsoft.Practices.Unity;
using poe_website.Models.Dashboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace poe_website.Services.Impl
{
	public class DashboardService : IDashboardService
	{
		[Dependency]
		public ICharacterService CharacterService { get; set; }

		public DashboardModel GetDashboard()
		{
			var model = new DashboardModel
			{
				CharacterOverview = CharacterService.GetCharactersForOverview("PrutsendePrutser")
			};
			return model;
		}
	}
}