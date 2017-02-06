

using System;

namespace DAL.Models
{
	public class Comment: BaseEntity
	{
		public int UserId { get; set; }
		public int NoweltyId { get; set; }
		public string Text { get; set; }
		public virtual User User { get; set; }
		public virtual Nowelty Nowelty { get; set; }
		public DateTime DateOfComment { get; set; }

	}
}
