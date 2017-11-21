using System.Data.Entity;

namespace Data
{
	public class CommerceContext: DbContext
	{
		public DbSet<Product> Products { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<OrderDetail> OrderDetails { get; set; }
		public DbSet<Customer> Customer { get; set; }

		public CommerceContext() : base("Name=ECommerceEntities")
		{

		}
	}
}
