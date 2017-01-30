using DAL.UnitOfWork;
using System;
using System.Collections.Generic;


namespace DAL.Repository.BaseRepository
{
	public interface IRepository<TEntity> where TEntity : class
	{
		IUnitOfWork UnitOfWork { get; }
		TEntity Get(int id);
		IEnumerable<TEntity> GetAll();
		void Add(TEntity entity);
		void AddRange(IEnumerable<TEntity> entities);
		void Remove(TEntity entity);
		void RemoveRange(IEnumerable<TEntity> entities);
	}
}
