using DAL.Models;
using System.Data.Entity.ModelConfiguration;

namespace DAL.EF
{
	public class CommentMap : EntityTypeConfiguration<Comment>
	{
		public CommentMap()
		{
			ToTable("Comment", "507SA").HasKey(t => t.Id);
			Property(t => t.UserId);
			Property(t => t.NoweltyId);
			Property(t => t.Text).HasMaxLength(300);
		}
	}
}
