using DAL.Models;
using DAL.Repository.BaseRepository;
using DAL.UnitOfWork;


namespace DAL.Repository.CommentRepositoty
{
	public class CommentRepository:Repository<Comment>, ICommentRepository
	{
		public CommentRepository(IUnitOfWork context) : base(context)
		{
		}
	}
}
