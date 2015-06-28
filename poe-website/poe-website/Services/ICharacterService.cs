using poe_website.Models.Dashboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace poe_website.Services
{
	public interface ICharacterService
	{
		CharacterOverviewModel GetCharactersForOverview(string accountName);
	}
}