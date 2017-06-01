using DAL.Models;
using DAL.Repository.BaseRepository;
using System.Collections.Generic;

namespace DAL.Repository.UserRepository
{
	public interface IUserRepository : IRepository<User>
	{
		User GetByCredentials(string email, string password);
		User GetByEmail(string email);
	}
}
