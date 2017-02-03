using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _507SA.Session
{
	public class UserContext
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public bool IsAdmin { get; set; }
	}
}