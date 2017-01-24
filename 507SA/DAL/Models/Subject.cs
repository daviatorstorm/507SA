

using System.Collections.Generic;

namespace DAL.Models
{
	public class Subject:BaseEntity
	{
		public Subject()
		{
			File = new HashSet<File>();
		}
		public string Name { get; set; }
		public bool IsExam { get; set; }
		public int SubjectId { get; set; }
		public virtual ICollection<File> File { get; set; }
	}
}
