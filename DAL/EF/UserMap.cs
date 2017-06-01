using DAL.Models;
using System.Data.Entity.ModelConfiguration;


namespace DAL.EF
{
	public class UserMap : EntityTypeConfiguration<User>
	{
		public UserMap()
		{
			ToTable("User", "507SA").HasKey(t => t.Id);
			Property(t => t.Email).HasMaxLength(128).IsRequired();
			Property(t => t.Password).HasMaxLength(128).IsRequired();
			Property(t => t.Phone).IsRequired();
			Property(t => t.FirstName).HasMaxLength(64);
			Property(t => t.LastName).HasMaxLength(64);
			Property(t => t.Info).HasMaxLength(500);
			Property(t => t.PictureId);
			Property(t => t.IsAdmin);
		}
	}
}
