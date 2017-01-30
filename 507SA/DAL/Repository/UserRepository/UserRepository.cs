using DAL.Models;
using DAL.Repository.BaseRepository;
using DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;


namespace DAL.Repository.UserRepository
{
	public class UserRepository : Repository<User>, IUserRepository
	{
		public UserRepository(IUnitOfWork context) : base(context)
		{
		}
		public User GetByCredentials(string email, string password)
		{
			return _unitOfWork.Context.User
				.Where(e => e.Email == email && e.Password == password)
				.FirstOrDefault<User>();
		}
		public User GetByEmail(string email)
		{
			return _unitOfWork.Context.User
				.Where(e => e.Email == email)
				.FirstOrDefault<User>();
		}
	}
}
