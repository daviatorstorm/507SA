using DAL.Models;
using DAL.Repository.BaseRepository;
using DAL.UnitOfWork;


namespace DAL.Repository.ImageRepository
{
	public class ImageRepository:Repository<Image>, IImageRepository
	{
		public ImageRepository(IUnitOfWork context) : base(context)
		{
		}
	}
}
