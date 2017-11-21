using System.Collections.Generic;

namespace Services.DTOs
{
	public class OrderInfo
	{
		
		public int Id { get; set; }
		public int CustomerId { get; set; }
		public string Description { get; set; }

		public CustomerInfo Customer { get; set; }
		public IList<OrderDetailInfo> OrderDetails { get; set; }
	}
}
