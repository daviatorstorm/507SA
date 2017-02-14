using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
	public class Timetable:BaseEntity
	{
		public virtual Subject Subject { get; set; }
		public int SubjectId { get; set; }
		public int DayId { get; set; }
		public string Auditorium { get; set; }
		public int Number { get; set; }
		public string Teacher { get; set; }
		public bool Week { get; set; }
	}
}
