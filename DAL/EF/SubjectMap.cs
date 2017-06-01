using DAL.Models;
using System.Data.Entity.ModelConfiguration;

namespace DAL.EF
{
	public class SubjectMap : EntityTypeConfiguration<Subject>
	{
		public SubjectMap()
		{
			ToTable("Subject", "507SA").HasKey(t => t.Id);
			Property(t => t.Name).HasMaxLength(128).IsRequired();
			Property(t => t.IsExam);
			HasMany(e =>e.File).WithRequired(e=> e.Subject).WillCascadeOnDelete(false);
		}
	}
}
