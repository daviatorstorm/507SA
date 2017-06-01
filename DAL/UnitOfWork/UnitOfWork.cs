using DAL.EF;
using System;

namespace DAL.UnitOfWork
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly _507SAContext _dbContext;

		public UnitOfWork(_507SAContext dbcontext)
		{
			_dbContext = dbcontext;
		}
		public _507SAContext Context
		{
			get { return _dbContext; }
		}
		public void SaveChanges()
		{
			_dbContext.SaveChanges();
		}

		private bool disposedValue = false;

		protected virtual void Dispose(bool disposing)
		{
			if (!disposedValue)
			{
				if (disposing)
				{
					_dbContext.Dispose();
				}
				disposedValue = true;
			}
		}
		public void Dispose()
		{

			Dispose(true);
			GC.SuppressFinalize(this);
		}
	}
}
