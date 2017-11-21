using Data;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
	public class ProductRepository : Repository<Product>, IProductRepository
	{

		public ProductRepository(CommerceContext context)
			: base(context)
		{

		}


		public List<Product> Search(string name)
		{
			throw new NotImplementedException();
		}
	}
}
