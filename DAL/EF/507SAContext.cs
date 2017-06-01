using DAL.Models;
using System.Data.Entity;

namespace DAL.EF
{
	public class _507SAContext : DbContext
	{
		public _507SAContext() : base("_507SAContext")
		{
            Database.SetInitializer(new _507SAInitializer());
		}

		public virtual DbSet<User> User { get; set; }
		public virtual DbSet<Image> Image { get; set; }
		public virtual DbSet<Comment> Comment { get; set; }
		public virtual DbSet<File> File { get; set; }
		public virtual DbSet<Nowelty> Nowelty { get; set; }
		public virtual DbSet<Subject> Subject { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Configurations.Add(new UserMap());
			modelBuilder.Configurations.Add(new ImageMap());
			modelBuilder.Configurations.Add(new SubjectMap());
			modelBuilder.Configurations.Add(new FileMap());
			modelBuilder.Configurations.Add(new CommentMap());
			modelBuilder.Configurations.Add(new NoweltyMap());
		}
	}
}
