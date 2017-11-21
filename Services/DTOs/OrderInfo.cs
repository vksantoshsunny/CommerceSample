using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
