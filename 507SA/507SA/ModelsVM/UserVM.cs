using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _507SA.ModelsVM
{
	public class UserVM
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Password { get; set; }
		public string Email { get; set; }
		public int Phone { get; set; }
		public int PictureId { get; set; }
		public string Info { get; set; }
		public virtual ICollection<Comment> Comment { get; set; }
		public string Message { get; set; }
		public string ConfirmPassword{ get; set; }
		public bool IsAdmin { get; set; }
	}
}