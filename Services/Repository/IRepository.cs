﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
	public interface IRepository<TEntity> where TEntity : class
	{
		TEntity Get(int id);
		ICollection<TEntity> GetAll();
		TEntity Add(TEntity entity);
		void Remove(int id);
		IEnumerable<TEntity> SqlQuery(string sql, params object[] parms);
	}
}
