using DAL.Models;
using DAL.Repository.BaseRepository;
using DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.TimetableRepositoty
{
	public class TimetableRepository : Repository<Timetable>, ITimetableRepository
	{
		public TimetableRepository(IUnitOfWork context) : base(context)
		{
		}
	}
}
