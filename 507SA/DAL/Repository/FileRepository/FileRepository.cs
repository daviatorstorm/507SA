using DAL.Models;
using DAL.Repository.BaseRepository;
using DAL.UnitOfWork;


namespace DAL.Repository.FileRepository
{
	public class FileRepository:Repository<File>, IFileRepository
	{
		public FileRepository(IUnitOfWork context) : base(context)
		{
		}
	}
}
