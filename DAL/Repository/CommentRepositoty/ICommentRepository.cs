using DAL.Models;
using DAL.Repository.BaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.CommentRepositoty
{
	public interface ICommentRepository: IRepository<Comment>
	{
	}
}
