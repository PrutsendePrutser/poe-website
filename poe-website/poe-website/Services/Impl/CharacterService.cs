using poe_website.Models.Character;
using poe_website.Models.Dashboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace poe_website.Services.Impl
{
	public class CharacterService : ICharacterService
	{
		public CharacterOverviewModel GetCharactersForOverview(string accountName)
		{
			var model = new CharacterOverviewModel { AccountName = accountName };
			model.CharacterList.Add(new CharacterOverviewDisplayModel {CharacterName = "ProtsMjolnor", Class = "Templar", BuildDescription = "OP as fuck crit Mjolner"});
			model.CharacterList.Add(new CharacterOverviewDisplayModel { CharacterName = "PrutsBalls", Class = "Scion", BuildDescription = "CoC KB wander" });
			model.CharacterList.Add(new CharacterOverviewDisplayModel { CharacterName = "Feissa", Class = "Ranger", BuildDescription = "Shit crit bow" });
			return model;
		}
	}
}