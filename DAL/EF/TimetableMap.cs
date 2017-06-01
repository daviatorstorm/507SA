using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
	class TimetableMap: EntityTypeConfiguration<Timetable>
	{
		public TimetableMap()
		{
			ToTable("Timetable", "507SA").HasKey(t => t.Id);
			Property(t => t.Teacher).HasMaxLength(128);
			Property(t => t.Week);
			Property(t => t.DayId);
			Property(t => t.Auditorium);
			Property(t => t.Number);
		}
	}
}
