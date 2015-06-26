using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace poe_website.Models.Account
{
	public class RegisterModel
	{
		[DisplayName("Name")]
		public String Name { get; set; }

		[DisplayName("E-mail address")]
		public String Email { get; set; }
	}
}