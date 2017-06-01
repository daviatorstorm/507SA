
using System;
using System.Collections.Generic;

namespace DAL.Models
{
	public class Nowelty:BaseEntity
	{
		public string Text { get; set; }
		public string Description { get; set; }
		public int UserId { get; set; }
		public DateTime Date { get; set; }
		public virtual IList<Comment> Comment { get; set; }
	}
}
