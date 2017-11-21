using Data;
using Services.Interfaces;
using Services.Repository;

namespace Services.UOW
{
	public class UnitOfWork: IUnitOfWork
	{
        
        private readonly CommerceContext _context;

		public UnitOfWork()
		{
			_context = new CommerceContext();
			ProductRepository = new ProductRepository(_context);

		}

		public IProductRepository ProductRepository { get; private set; }

		public int Complete()
		{
			return _context.SaveChanges();
		}

		public void Dispose()
		{
			_context.Dispose();
		}
	}
}
