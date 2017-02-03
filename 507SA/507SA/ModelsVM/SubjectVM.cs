using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _507SA.ModelsVM
{
	public class SubjectVM
	{
		public SubjectVM()
		{
			File = new HashSet<File>();
		}
		public int Id { get; set; }
		public string Name { get; set; }
		public bool? IsExam { get; set; }
		public virtual ICollection<File> File { get; set; }
	}
}