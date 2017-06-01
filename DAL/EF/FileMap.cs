using DAL.Models;
using System.Data.Entity.ModelConfiguration;

namespace DAL.EF
{
	public class FileMap : EntityTypeConfiguration<File>
	{
		public FileMap()
		{
			ToTable("File", "507SA").HasKey(t => t.Id);
			Property(t => t.SubjectId);
			Property(t => t.Name).HasMaxLength(128);
			Property(t => t.Type).HasMaxLength(128);
			Property(t => t.Type).HasMaxLength(128);
		}
	}
}