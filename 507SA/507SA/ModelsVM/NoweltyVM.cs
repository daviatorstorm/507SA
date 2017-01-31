using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _507SA.ModelsVM
{
	public class NoweltyVM
	{
		public int Id { get; set; }
		public DateTime Date { get; set; }
		public string Text { get; set; }
		public string Description { get; set; }
		public int UserId { get; set; }
		public virtual ICollection<Comment> Comment { get; set; }
	}
}