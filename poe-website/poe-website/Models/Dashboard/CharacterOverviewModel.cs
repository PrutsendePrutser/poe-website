using poe_website.Models.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace poe_website.Models.Dashboard
{
	public class CharacterOverviewModel
	{
		public String AccountName { get; set; }
		public IList<CharacterOverviewDisplayModel> CharacterList { get; set; }

		public CharacterOverviewModel()
		{
			CharacterList = new List<CharacterOverviewDisplayModel>();
		}
	}
}