
namespace DAL.Models
{
	public class Image : BaseEntity
	{
		public string Name { get; set; }
		public string Path { get; set; }
		public virtual User User { get; set; }
	}
}
