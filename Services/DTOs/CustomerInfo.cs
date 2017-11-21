using System.Collections.Generic;

namespace Services.DTOs
{
	public class CustomerInfo
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }

		public virtual IList<OrderInfo> Orders { get; set; }
	}
}
