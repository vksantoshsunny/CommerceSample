using System.Collections.Generic;

namespace Services.DTOs
{
	public class ProductInfo
	{

		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }

		
		public IList<OrderDetailInfo> OrderDetails { get; set; }
	}
}
