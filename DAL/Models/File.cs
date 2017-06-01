
namespace DAL.Models
{
	public class File:BaseEntity
	{
		public virtual Subject Subject { get; set; }
		public string Name { get; set; }
		public string Type { get; set; }
		public int SubjectId { get; set; }
		public string Path { get; set; }
	}
}
