using DAL.Models;
using System.Data.Entity.ModelConfiguration;

namespace DAL.EF
{
	public class NoweltyMap : EntityTypeConfiguration<Nowelty>
	{
		public NoweltyMap()
		{
			ToTable("Nowelty", "507SA").HasKey(t => t.Id);
			Property(t => t.UserId);
			Property(t => t.Text).HasMaxLength(500).IsRequired();
			Property(t => t.Description).HasMaxLength(128);
		}
	}
}