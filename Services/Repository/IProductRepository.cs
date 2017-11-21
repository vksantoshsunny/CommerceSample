using Data;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
	public interface IProductRepository : IRepository<Product>
	{
		List<Product> Search(string name);
	}
}
