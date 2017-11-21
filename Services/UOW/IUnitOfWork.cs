using Services.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
	public interface IUnitOfWork : IDisposable
	{
		IProductRepository ProductRepository { get; }
		int Complete();
	}
}
