using DAL.Models;
using DAL.Repository.BaseRepository;
using DAL.UnitOfWork;

namespace DAL.Repository.NoweltyRepositoty
{
	public class NoweltyRepository : Repository<Nowelty>, INoweltyRepository{
		public NoweltyRepository(IUnitOfWork context) : base(context)
		{
		}
	}
}
