using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _507SA.ModelsVM
{
	public class UserCredentialsVM
	{
		public string Email { get; set; }
		public string Password { get; set; }
		public bool RememberMe { get; set; }
	}
}