using System.Collections.Generic;
using DAL.Models;
using DAL.Repository.BaseRepository;

namespace DAL.Repository.SubjectRepository
{
	public interface ISubjectRepository : IRepository<Subject>
	{
		IEnumerable<Subject> GetIsExam();
	}
}
