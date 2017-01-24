using DAL.Models;
using System.Data.Entity.ModelConfiguration;

namespace DAL.EF
{
	public class ImageMap : EntityTypeConfiguration<Image>
	{
		public ImageMap()
		{
			ToTable("Image", "507SA").HasKey(t => t.Id);
			Property(t => t.Name).HasMaxLength(128).IsRequired();
			Property(t => t.Path).HasMaxLength(128).IsRequired();
		}
	}
}
