
using System.Collections.Generic;

namespace DAL.Models
{
	public class User: BaseEntity
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Password { get; set; }
		public string Email { get; set; }
		public int Phone { get; set; }
		public int PictureId { get; set; }
		public string Info { get; set; }
		public virtual ICollection<Comment> Comment { get; set; }
	}
}
