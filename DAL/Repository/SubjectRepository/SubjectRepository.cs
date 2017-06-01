using DAL.Models;
using DAL.Repository.BaseRepository;
using DAL.UnitOfWork;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repository.SubjectRepository
{
	public class SubjectRepository : Repository<Subject>, ISubjectRepository
	{
		public SubjectRepository(IUnitOfWork context) : base(context)
		{
		}
		public IEnumerable<Subject> GetIsExam()
		{
			return _unitOfWork.Context.Subject
				.Where(e => e.IsExam == true)
				.ToList<Subject>();
		}
	}
}
