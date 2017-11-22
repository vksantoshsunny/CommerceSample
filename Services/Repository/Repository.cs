using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Services.Repository
{
	public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
	{
		protected CommerceContext Context;

		public Repository(CommerceContext context)
		{
			Context = context;
		}

		public TEntity Add(TEntity entity)
		{
			Context.Set<TEntity>().Add(entity);
			Context.SaveChanges();
			return entity;
		}

		public TEntity Get(int id)
		{
			return Context.Set<TEntity>().Find(id);
		}

		public ICollection<TEntity> GetAll()
		{
			return Context.Set<TEntity>().ToList();
		}

		public void Remove(int id)
		{
			var entity = Context.Set<TEntity>().Find(id);
			Context.Set<TEntity>().Remove(entity);
			Context.SaveChanges();
		}

		public IEnumerable<TEntity> SqlQuery(string sql, params object[] parms)
		{
			return Context.Database.SqlQuery<TEntity>(sql, parms);
		}
	}
}
