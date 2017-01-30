using DAL.EF;
using System;

namespace DAL.UnitOfWork
{
	public interface IUnitOfWork : IDisposable
	{
		_507SAContext Context { get; }
		void SaveChanges();
	}
}
